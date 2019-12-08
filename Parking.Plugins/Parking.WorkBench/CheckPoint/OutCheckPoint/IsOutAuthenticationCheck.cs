using System;
using System.Linq;
using Parking.Core;
using Parking.Core.Oragnization;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Log4Net;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Model;

namespace Parking.WorkBench
{
    /// <summary>
    /// 出口鉴权检查
    /// </summary>
    public class IsOutAuthenticationCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            try
            {
                ///////////////////////////车|ì位?已°?锁?定?§///////////////////////////////
                if (1 == recordInfo.INOUT_RECODE.LOCK_FLAG)
                {
                    recordInfo.CheckPointResult = false;
                    recordInfo.SpeechType = enumSpeechType.CarLocked;
                    Sound(recordInfo);
                    return;
                }
                ///////////////////////////黑¨2名?单ì￡¤校?ê验¨|///////////////////////////////
                if (base.getCurrParkInfo().blacklist)
                {
                    //////////////////////获?取¨?当ì?à前??出?口¨2车|ì牌?的ì?鉴?权¨?§//////////////////////////
                    recordInfo.CheckPointResult = recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_BLACK ? false : true;
                    if (!recordInfo.CheckPointResult)
                    {
                        recordInfo.SpeechType = enumSpeechType.BlacklistCarOut;
                        Sound(recordInfo);
                        return;
                    }
                }
                //如¨?果?是o?贵¨?宾à?车|ì不?需¨¨鉴?权¨?§，ê?直?à接¨?放¤?行D
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                {
                    recordInfo.CheckPointResult = true;
                    return;
                }
                //////////////////////////////临￠¨′时o?à通a?§行D权¨?§限T///////////////////////////////
                var tempAccessRight = EngineContext.Current.Resolve<IPL_ACCESS_RIGHTS_MANAGERS>();
                var accessRight = tempAccessRight.GetModelByVEHICLE_NO(recordInfo.INOUT_RECODE.VEHICLE_NO);
                //判D断?是o?否¤?是o?临￠¨′时o?à授o¨2权¨?§车|ì并?é且¨°入¨?场?时o?à间?是o?否¤?在¨2临￠¨′时o?à授o¨2权¨?§时o?à间?内¨2
                if (null != accessRight && accessRight.BEGIN_TIME <= recordInfo.INOUT_RECODE.IN_TIME && recordInfo.INOUT_RECODE.IN_TIME <= accessRight.END_TIME)
                {
                    if (accessRight.ACCREDIT_TYPE == 1)
                    {
                        if (accessRight.ACCESS_CHANNEL_CODE.Contains(recordInfo.CHN_CODE))
                        {
                            recordInfo.authenticationType = enumAuthenticationType.TempAuthorization;
                            recordInfo.IsFree = accessRight.TIMEOUT_BILING == 0 ? true : false;
                            recordInfo.temporaryBilling = (enumTemporaryBilling)accessRight.TIMEOUT_BILING;
                            if (recordInfo.temporaryBilling == enumTemporaryBilling.CHARGE)
                            {
                                if (accessRight.END_TIME > System.DateTime.Now)
                                {
                                    recordInfo.IsFree = true;
                                }
                                else
                                {
                                    recordInfo.TemporaryEndTime = accessRight.END_TIME;
                                }
                            }
                            recordInfo.CheckPointResult = true;
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
                }
                var tempPermit = EngineContext.Current.Resolve<Parking.DBService.IBLL.ICR_TRAFFIC_PERMIT_INFO>();
                var permitList = tempPermit.GetIssueInfo(recordInfo.INOUT_RECODE.VEHICLE_NO).ToList();
                var firstSigle = permitList.OrderBy(x => x.END_TIME).FirstOrDefault();
                //月?卡?§停a?ê用??则¨°月?转áa临￠¨′处?|理¤¨a
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                {
                    if (null != permitList && permitList.Count > 0)
                    {
                        int count = permitList.Where(x => x.TRAFFIC_PERMIT_STATUS == 0).Count();
                        if (count > 0)
                        {
                            recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                            recordInfo.IsMonthToTemp = true;
                            recordInfo.SpeechType = enumSpeechType.MonthCarLocking;
                        }
                    }
                }
                ///////////////////////车|ì位?权¨?§限T，ê?查¨|询?￥入¨?场?时o?à是o?否¤?占?用??车|ì位?，ê?没?有?D占?用??车|ì位?当ì?à月?转áa临￠¨′处?|理¤¨a/////////////////////////
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH || recordInfo.IsMonthToTemp)
                {
                    var spaceBllTemp = EngineContext.Current.Resolve<IPBA_PARKING_SPACE_MANAGER>();
                    var model = spaceBllTemp.GetModelByINOUTID(recordInfo.INOUT_RECODE.ID);
                    //////////////////////无T场?内¨2记?录?//////////////////////////
                    if (null != model && DateTime.Now < model.END_TIME)
                    {
                        recordInfo.SPACE_CODE = model.SPACE_CODE;
                        TimeSpan sp = model.END_TIME.Subtract(DateTime.Now.AddDays(-1));
                        recordInfo.Validity = sp.Days;
                    }
                    else
                    {
                        //如¨?果?场?内¨2过y期¨2当ì?à临￠¨′时o?à车|ì处?|理¤¨a并?é产¨2生|¨2订?单ì￡¤
                        if ((null != model && DateTime.Now > model.END_TIME) || recordInfo.IsMonthToTemp)
                        {
                            recordInfo.IsMonthToTemp = true;
                            recordInfo.SpeechType = enumSpeechType.MonthCardOverdueOut;
                            if (GlobalEnvironment.MVMP && null != model)
                            {
                                recordInfo.SPACE_CODE = model.SPACE_CODE;
                                recordInfo.ChargingStartTime = model.END_TIME;
                            }
                            else
                            {
                                if (recordInfo.INOUT_RECODE.IN_TIME < firstSigle.END_TIME && firstSigle.END_TIME < DateTime.Now)
                                    recordInfo.ChargingStartTime = firstSigle.END_TIME;
                            }
                            var orderBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                            var recordBll = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                            var recordTemp = recordBll.GetInSideCarNo(recordInfo.INOUT_RECODE);
                            var OrderEnter = orderBll.GetCurrentPartitionOrder(recordInfo.PARTITION_CODE, recordInfo.INOUT_RECODE.ID);
                            if (null == OrderEnter)
                            {
                                CR_ORDER_RECORD_INFO orderTemp = new CR_ORDER_RECORD_INFO();
                                orderTemp.ID = Guid.NewGuid().ToString("N");
                                orderTemp.INOUT_RECODE_ID = recordTemp.ID;
                                orderTemp.PARTITION_CODE = recordInfo.PARTITION_CODE;
                                orderTemp.IN_CHANNEL_CODE = recordInfo.CHN_CODE;
                                orderTemp.TOTAL_TIME = 0;
                                orderTemp.VEHICLE_NO = recordInfo.INOUT_RECODE.VEHICLE_NO;
                                orderTemp.DUE_MONEY = 0;
                                orderTemp.PER_MONEY = 0;
                                orderTemp.PAY_PLATFORM = 0;
                                orderTemp.PAY_TYPE = 0;
                                orderTemp.IS_PAY = false;
                                orderTemp.CREATE_TIME = DateTime.Now;
                                recordInfo.CheckPointResult = recordInfo.CheckPointResult && orderBll.Add(orderTemp);
                            }
                        }
                        //if (GlobalEnvironment.MVMP)
                        //{
                        //    //没?有?D剩o?ê余?¨¤车|ì位?月?转áa临￠¨′
                        //    if (null == model && !spaceBllTemp.IsSurplus(recordInfo.VEHICLE_NO))
                        //    {
                        //        recordInfo.CARD_TYPE = enumCardType.CAR_TYPE_TEMP;
                        //        recordInfo.IsMonthToTemp = true;
                        //        recordInfo.SpeechType = enumSpeechType.ParkingOccupyOut;
                        //    }
                        //}
                    }
                }
                ///////////////////////////校?ê验¨|卡?§类¤¨¤通a?§行D权¨?§限T///////////////////////////////
                var strArea = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.CHN_CODE).FirstOrDefault() as Area;
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
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
                recordInfo.CheckPointResult = false;
            }
        }
    }
}