using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Interface;
using Parking.Core.Common;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;

namespace Parking.WorkBench
{
    public class RecordConvertBase
    {
        public void InitBaseInfo(ProcessRecord recordInfo)
        {
            var temp = EngineContext.Current.Resolve<ICR_TRAFFIC_PERMIT_INFO>();
            var tempInOutRecord = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
            var inRecord = tempInOutRecord.GetInSideCarNo(recordInfo.INOUT_RECODE);
            if (null != inRecord)
                recordInfo.INOUT_RECODE.VEHICLE_NO = inRecord.VEHICLE_NO;

            var issueInfos = temp.GetIssueInfo(recordInfo.INOUT_RECODE.VEHICLE_NO);
            if (issueInfos.Count > 0)
            {
                var first = issueInfos.FirstOrDefault();
                recordInfo.CARD_TYPE = first.CARDTYPE;
                recordInfo.CarType = first.CAR_TYPE;
                recordInfo.OWNER_CODE = first.OWNER_CODE;
                if (null != first.ACCESS_CHANNEL_CODE)
                    recordInfo.ACCESS_CHANNEL_CODE = first.ACCESS_CHANNEL_CODE;
                CommHelper.getSoundByCardType(recordInfo);
                ////////////////////////如¨?果?是o?月?卡?§//////////////////////////////
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                {
                    if (null != inRecord && recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                        recordInfo.CARD_TYPE = (enumCardType)Enum.Parse(typeof(enumCardType), inRecord.CREDENTIALS_TYPE.ToString());
                    Core.Model.IssueInfo issueInfo = null;
                    var record = tempInOutRecord.GetModelByVehicleNo(recordInfo.INOUT_RECODE.VEHICLE_NO);
                    if (null != record)
                        issueInfo = issueInfos.Where(x => x.INOUT_RECORD_ID == record.ID).FirstOrDefault();
                    if (null == issueInfo)
                        issueInfo = issueInfos.Where(x => x.CARDTYPE == enumCardType.CAR_TYPE_MONTH && x.SPACE_STATUS == 0 && x.BEGAIN_TIME <= System.DateTime.Now && x.END_TIME >= System.DateTime.Now).FirstOrDefault();
                    if (null == issueInfo || issueInfo.END_TIME < DateTime.Now)
                    {
                        if (GlobalEnvironment.MonthToTemp)
                        {
                            recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                            recordInfo.IsMonthToTemp = true;
                            var Occupy = issueInfos.Where(x => x.BEGAIN_TIME <= System.DateTime.Now && x.END_TIME >= System.DateTime.Now);
                            recordInfo.SpeechType = Occupy.Count() > 0 ? enumSpeechType.ParkingOccupyTempIn : enumSpeechType.MonthCardOverdueIn;
                            //string InOutRecords = string.Empty;
                            //var ls = issueInfos.Where(x => x.CARDTYPE == enumCardType.CAR_TYPE_MONTH && x.BEGAIN_TIME <= DateTime.Now && x.END_TIME >= DateTime.Now && x.SPACE_STATUS == 1 && x.TRAFFIC_PERMIT_STATUS == 1).GroupBy(x => new { x.INOUT_RECORD_ID }).Select(g => new { INOUT_RECORD_ID = g.Key.INOUT_RECORD_ID });
                            //foreach (var t in ls)
                            //    InOutRecords += t.INOUT_RECORD_ID + ",";
                            //if (!string.IsNullOrEmpty(InOutRecords))
                            //    recordInfo.INOUT_RECODE.OccupyIds = InOutRecords.TrimEnd(',');
                        }
                    }
                    else
                    {
                        if (GlobalEnvironment.MVMP)
                            recordInfo.SPACE_CODE = issueInfo.SPACE_CODE;
                        TimeSpan sp = issueInfo.END_TIME.Subtract(DateTime.Now.AddDays(-1));
                        recordInfo.Validity = sp.Days;
                        //recordInfo.INOUT_RECODE.OccupyIds = string.Empty;
                    }
                }
                //////////////////////////储??é值|ì卡?§信?息?é///////////////////////////
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_STORED)
                {
                    var ownerInfoBll = EngineContext.Current.Resolve<IPBA_OWNER_INFO>();
                    var ownerInfo = ownerInfoBll.GetModel(recordInfo.OWNER_CODE);
                    if (null != ownerInfo)
                        recordInfo.OwnerInfo = ownerInfo;
                }
            }
            else
            {
                recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                CommHelper.getSoundByCardType(recordInfo);
            }
            /////////////////////////////凭?证?è类¤¨¤型¨a//////////////////////////////
            recordInfo.INOUT_RECODE.CREDENTIALS_TYPE = (int)recordInfo.CARD_TYPE;
            /////////////////////////////卡?§类¤¨¤型¨a//////////////////////////////
            var tempBlackManager = EngineContext.Current.Resolve<IPL_BLACK_WHITE_MANAGER>();
            int role = tempBlackManager.GetVEHICLE_NOType(recordInfo.INOUT_RECODE.VEHICLE_NO.ToString());
            recordInfo.authenticationType = (enumAuthenticationType)role;
            /////////////////////////////车|ì牌?识o?别àe出?错?¨a的ì?情¨|况?/////////////////////////////////
            var tempOrg = GlobalEnvironment.ListlicenseCorrect.Where(x => x.BeforeChange_VehNo.Equals(recordInfo.INOUT_RECODE.VEHICLE_NO)).OrderBy(x => x.Count).LastOrDefault();
            if (null != tempOrg)
                recordInfo.INOUT_RECODE.VEHICLE_NO = tempOrg.AfterChange_VehNo;
        }
    }
}