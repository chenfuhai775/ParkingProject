using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core;
using Parking.Core.Oragnization;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Log4Net;
using Parking.Core.Enum;
using Parking.Core.Common;
using Parking.Core.Record;

namespace Parking.WorkBench
{
    /// <summary>
    /// 入口鉴权检查
    /// </summary>
    public class IsInAuthenticationCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            try
            {
                var voiceBllTemp = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
                List<string> strArr = new List<string>();
                if (base.getCurrParkInfo().blacklist)
                {
                    var temp = EngineContext.Current.Resolve<IPL_BLACK_WHITE_MANAGER>();
                    /////////////////////////获?取¨?当ì?à前??入¨?口¨2车|ì牌?的ì?鉴?权¨?§/////////////////////////
                    int role = temp.GetVEHICLE_NOType(recordInfo.INOUT_RECODE.VEHICLE_NO.ToString());
                    enumAuthenticationType authentionType = (enumAuthenticationType)role;
                    ///////////////////////武?警?￥车|ì牌?默?认¨?VIP/////////////////////////////////
                    if (CommHelper.ArmedPoliceCard(recordInfo.INOUT_RECODE.VEHICLE_NO))
                        authentionType = enumAuthenticationType.SPECIAL_TYPE_VIP;
                    recordInfo.authenticationType = authentionType;
                    CommHelper.getSoundByauthentionType(recordInfo);
                    recordInfo.CheckPointResult = authentionType == enumAuthenticationType.SPECIAL_TYPE_BLACK ? false : true;
                    if (!recordInfo.CheckPointResult)
                    {
                        Sound(recordInfo);
                        return;
                    }
                }
                //如¨?果?是o?贵¨?宾à?车|ì不?需¨¨鉴?权¨?§，ê?直?à接¨?放¤?行D
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                {
                    recordInfo.CheckPointResult = true;
                    base.ShowLED(recordInfo);
                    return;
                }
                //////////////////////////////临￠¨′时o?à通a?§行D权¨?§限T///////////////////////////////
                var tempAccessRight = EngineContext.Current.Resolve<IPL_ACCESS_RIGHTS_MANAGERS>();
                var accessRight = tempAccessRight.GetModelByVEHICLE_NO(recordInfo.INOUT_RECODE.VEHICLE_NO);
                if (null != accessRight)
                {
                    if (accessRight.ACCREDIT_TYPE == 1)
                    {
                        if (accessRight.ACCESS_CHANNEL_CODE.Contains(recordInfo.CHN_CODE) && accessRight.BEGIN_TIME <= DateTime.Now && DateTime.Now <= accessRight.END_TIME)
                        {
                            var tempInOutRecordArchive = EngineContext.Current.Resolve<ICR_INOUT_RECODE_ARCHIVE>();
                            int InCount = tempInOutRecordArchive.GetInOutCount(accessRight);
                            if (InCount < accessRight.ACCREDIT_NUMBER)
                            {
                                //临￠¨′时o?à授o¨2权¨?§车|ì入¨?场?
                                recordInfo.authenticationType = enumAuthenticationType.TempAuthorization;
                                recordInfo.CheckPointResult = true;
                                recordInfo.IsFree = accessRight.TIMEOUT_BILING == 0 ? true : false;
                                recordInfo.temporaryBilling = (enumTemporaryBilling)accessRight.TIMEOUT_BILING;
                                return;
                            }
                            else
                            {
                                recordInfo.CheckPointResult = false;
                                recordInfo.SpeechType = enumSpeechType.NoPermissions;
                                Sound(recordInfo);
                                return;
                            }
                        }
                        else
                        {
                            recordInfo.CheckPointResult = false;
                            recordInfo.SpeechType = enumSpeechType.NoPermissions;
                            Sound(recordInfo);
                            return;
                        }
                    }
                    else
                    {
                        if (accessRight.ACCESS_CHANNEL_CODE.Contains(recordInfo.CHN_CODE) && accessRight.BEGIN_TIME <= DateTime.Now && DateTime.Now <= accessRight.END_TIME)
                        {
                            recordInfo.CheckPointResult = false;
                            recordInfo.SpeechType = enumSpeechType.NoPermissions;
                            Sound(recordInfo);
                            return;
                        }
                    }
                }
                ///////////////////////月?卡?§暂Y停a?ê，ê?转áa临￠¨′时o?à卡?§/////////////////////////
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                {
                    var tempPermit = EngineContext.Current.Resolve<Parking.DBService.IBLL.ICR_TRAFFIC_PERMIT_INFO>();
                    var permitList = tempPermit.GetIssueInfo(recordInfo.INOUT_RECODE.VEHICLE_NO).ToList();
                    var permitSigle = permitList.Where(x => x.CARDTYPE == enumCardType.CAR_TYPE_MONTH && x.BEGAIN_TIME <= DateTime.Now && x.END_TIME >= DateTime.Now).FirstOrDefault();
                    if (null != permitSigle)
                    {
                        if (permitSigle.TRAFFIC_PERMIT_STATUS == 0)
                        {
                            /////////////////凭?证?è停a?ê用??则¨°月?转áa临￠¨′处?|理¤¨a/////////////
                            if (GlobalEnvironment.MonthToTemp)
                            {
                                recordInfo.SpeechType = enumSpeechType.MonthCarLocking;
                                recordInfo.IsMonthToTemp = true;
                                recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                                recordInfo.CheckPointResult = true;
                            }
                            else
                            {
                                recordInfo.CheckPointResult = false;
                                recordInfo.SpeechType = enumSpeechType.MonthCarLocking;
                                Sound(recordInfo);
                                return;
                            }
                        }
                    }
                    else
                    {
                        recordInfo.CheckPointResult = false;
                        recordInfo.SpeechType = enumSpeechType.MonthCarLocking;
                        Sound(recordInfo);
                        return;
                    }
                    /////////////////////重?新?选?择?车|ì位?//////////////////
                    if (GlobalEnvironment.MVMP)
                    {
                        if (string.IsNullOrEmpty(recordInfo.SPACE_CODE))
                        {
                            var permit = permitList.Where(x => x.CARDTYPE == enumCardType.CAR_TYPE_MONTH && x.BEGAIN_TIME <= DateTime.Now && x.END_TIME >= DateTime.Now && x.SPACE_STATUS == 0 && x.TRAFFIC_PERMIT_STATUS == 1 && string.IsNullOrEmpty(x.INOUT_RECORD_ID)).FirstOrDefault();
                            if (null != permit)
                            {
                                TimeSpan sp = permit.END_TIME.Subtract(DateTime.Now.AddDays(-1));
                                recordInfo.SPACE_CODE = permit.SPACE_CODE;
                                recordInfo.Validity = sp.Days;
                            }
                            else
                            {
                                string InOutRecords = string.Empty;
                                var ls = permitList.Where(x => x.CARDTYPE == enumCardType.CAR_TYPE_MONTH && x.BEGAIN_TIME <= DateTime.Now && x.END_TIME >= DateTime.Now && x.SPACE_STATUS == 1 && x.TRAFFIC_PERMIT_STATUS == 1).GroupBy(x => new { x.INOUT_RECORD_ID }).Select(g => new { INOUT_RECORD_ID = g.Key.INOUT_RECORD_ID });
                                foreach (var t in ls)
                                    InOutRecords += t.INOUT_RECORD_ID + ",";

                                if (!string.IsNullOrEmpty(InOutRecords))
                                    recordInfo.INOUT_RECODE.OccupyIds = InOutRecords.TrimEnd(',');

                                if (GlobalEnvironment.MonthToTemp)
                                {
                                    recordInfo.IsMonthToTemp = true;
                                    recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                                    recordInfo.SpeechType = enumSpeechType.ParkingOccupyTempIn;
                                }
                                else
                                {
                                    recordInfo.CheckPointResult = false;
                                    recordInfo.SpeechType = enumSpeechType.ParkingOccupy;
                                    Sound(recordInfo);
                                    return;

                                }
                            }
                        }
                    }
                }
                ///////////////////////////校?ê验¨|卡?§类¤¨¤通a?§行D权¨?§限T///////////////////////////////
                var strArea = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.CHN_CODE).FirstOrDefault() as Area;
                if (strArea.ckIE.Contains(((int)recordInfo.CARD_TYPE).ToString()))
                {
                    recordInfo.CheckPointResult = true;
                    //////////////////月?卡?§权¨?§限T组á¨|通a?§行D权¨?§限T//////////////////////
                    if (!base.HasPermit(recordInfo) && recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                        ////////////////////////月?卡?§无T通a?§行D权¨?§限T，ê?月?转áa临￠¨′///////////////////////
                        recordInfo.IsMonthToTemp = true;
                }
                else
                {
                    recordInfo.CheckPointResult = false;
                    recordInfo.SpeechType = enumSpeechType.NoPermissions;
                    Sound(recordInfo);
                    return;
                }
                base.ShowLED(recordInfo);
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
                recordInfo.CheckPointResult = false;
            }
        }
        /// <summary>
        /// 判断是否有剩余车位
        /// </summary>
        /// <param name="parNum"></param>
        /// <returns></returns>
        public bool GetIsSurplus(string parNum, ProcessRecord recordInfo)
        {
            int num = 0;
            var par = Parking.Core.GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == parNum).FirstOrDefault();
            if (null != par)
            {
                var tempRecode = EngineContext.Current.Resolve<Parking.DBService.IBLL.ICR_INOUT_RECODE>();
                var cartype = par.ListCardType;
                var query = from c in cartype
                            where c.carType == (int)recordInfo.CARD_TYPE
                            select c;

                var temp = query.FirstOrDefault();
                if (null != temp)
                {
                    if (temp.remainderFlag == 1)
                        num = temp.parkingNumber - temp.tempParking - tempRecode.GetPartitionCount(parNum, (int)recordInfo.CARD_TYPE);
                }
            }
            return num > 0 ? true : false;
        }
    }
}