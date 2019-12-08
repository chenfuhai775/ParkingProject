using System;
using System.Linq;
using Parking.DBService.IBLL;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.DataProcessing;
namespace Parking.WorkBench
{
    public class OutStockCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            recordInfo.CheckPointResult = true;
            try
            {
                var chargesLogBll = EngineContext.Current.Resolve<ICR_CHARGES_LOG>();
                var temp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                var tempImg = EngineContext.Current.Resolve<ICR_INOUT_RECODE_IMG>();
                string Enter = base.getCurrChannel(recordInfo).Enter;
                if (string.IsNullOrEmpty(Enter))
                {
                    if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    {
                        //贵¨?宾à?卡?§，ê?直?à接¨?写??一°?条??完a¨o整?记?录?
                        recordInfo.INOUT_RECODE.ID = Guid.NewGuid().ToString("N");
                        recordInfo.INOUT_RECODE.RECODE_STATUS = 1;
                        recordInfo.INOUT_RECODE.IN_TIME = recordInfo.REPORTIMG_TIME;
                        recordInfo.INOUT_RECODE.IN_FIELD_CODE = recordInfo.FIELD_CODE;
                        recordInfo.INOUT_RECODE.IN_PARTITION_CODE = recordInfo.PARTITION_CODE;
                        recordInfo.INOUT_RECODE.IN_CHANNEL_CODE = recordInfo.CHN_CODE;
                        recordInfo.INOUT_RECODE.IN_DEV_ID = recordInfo.DEV_CODE;
                        recordInfo.INOUT_RECODE.IN_OPERATOR_ID = recordInfo.OPERATOR_ID;
                        recordInfo.INOUT_RECODE.IN_PARK_TYPE = recordInfo.PARK_TYPE;
                        recordInfo.INOUT_RECODE.OUT_TIME = recordInfo.REPORTIMG_TIME;
                        recordInfo.INOUT_RECODE.OUT_FIELD_CODE = recordInfo.FIELD_CODE;
                        recordInfo.INOUT_RECODE.OUT_PARTITION_CODE = recordInfo.PARTITION_CODE;
                        recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE = recordInfo.CHN_CODE;
                        recordInfo.INOUT_RECODE.OUT_DEV_ID = recordInfo.DEV_CODE;
                        recordInfo.INOUT_RECODE.OUT_OPERATOR_ID = recordInfo.OPERATOR_ID;
                        recordInfo.INOUT_RECODE.OUT_PARK_TYPE = recordInfo.PARK_TYPE;
                    }
                    else
                    {
                        //////////////////保à?ê存??订?单ì￡¤信?息?é//////////////////
                        {
                            decimal dueMoney = 0;
                            decimal chargeMoney = 0;
                            decimal preMoney = 0;
                            foreach (var order in recordInfo.ListOrder)
                            {
                                dueMoney += order.DUE_MONEY;
                                chargeMoney += order.CHARGE_MONEY;
                                preMoney += order.PER_MONEY;
                                recordInfo.INOUT_RECODE.PAY_PLATFORM = order.PAY_PLATFORM;
                            }
                            recordInfo.INOUT_RECODE.DUE_MONEY = dueMoney;
                            recordInfo.INOUT_RECODE.CHARGE_MONEY = chargeMoney;
                            recordInfo.INOUT_RECODE.PRE_MONEY = preMoney;
                            temp.Update(recordInfo.INOUT_RECODE);
                        }
                        if (recordInfo.INOUT_RECODE.DUE_MONEY > 0)
                        {
                            var charges = chargesLogBll.GetListByInTime(recordInfo.INOUT_RECODE.VEHICLE_NO, recordInfo.INOUT_RECODE.IN_TIME);
                            decimal totalDueMoney = recordInfo.INOUT_RECODE.DUE_MONEY;
                            decimal totalChargeMoney = charges.Select(x => x.CHARGE_MONEY).Sum();
                            decimal totalPreMoney = charges.Select(x => x.PRE_MONEY).Sum();
                            decimal totalAlreayPay = totalChargeMoney + totalPreMoney;
                            if (totalDueMoney > totalAlreayPay)
                            {
                                //////////////////////保à?ê存??收o?费¤?流￠??水?///////////////////
                                CR_CHARGES_LOG chargesLog = new CR_CHARGES_LOG();
                                chargesLog.ID = recordInfo.chargeFlowing;
                                chargesLog.BEGIN_TIME = recordInfo.INOUT_RECODE.IN_TIME;
                                chargesLog.CHARGE_USERID = recordInfo.INOUT_RECODE.OUT_OPERATOR_ID;
                                chargesLog.CHARGES_EQ_ID = recordInfo.INOUT_RECODE.IN_EQ_ID;
                                chargesLog.END_TIME = recordInfo.INOUT_RECODE.OUT_TIME;
                                chargesLog.IN_CHANNEL_CODE = recordInfo.INOUT_RECODE.IN_CHANNEL_CODE;
                                chargesLog.IN_FIELD_CODE = recordInfo.INOUT_RECODE.IN_FIELD_CODE;
                                chargesLog.IN_PARTITION_CODE = recordInfo.INOUT_RECODE.IN_PARTITION_CODE;
                                chargesLog.OUT_CHANNEL_CODE = recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE;
                                chargesLog.OUT_FIELD_CODE = recordInfo.INOUT_RECODE.OUT_FIELD_CODE;
                                chargesLog.OUT_PARTITION_CODE = recordInfo.INOUT_RECODE.OUT_PARTITION_CODE;
                                chargesLog.CHARGE_TIME = System.DateTime.Now;
                                chargesLog.PAY_TYPE = totalAlreayPay > 0 ? 1 : 2;
                                chargesLog.PAY_PLATFORM = 1;
                                chargesLog.OWNER_CODE = recordInfo.OWNER_CODE;
                                chargesLog.SPACE_CODE = recordInfo.SPACE_CODE;
                                chargesLog.REMARK = "车位被占，当临时车处理";
                                TimeSpan tsTotal = recordInfo.INOUT_RECODE.OUT_TIME.Subtract(recordInfo.INOUT_RECODE.IN_TIME);
                                chargesLog.STOP_TIME = (int)Math.Round(tsTotal.TotalMinutes, 0);
                                chargesLog.UNIQUE_IDENTIFIER = recordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER;
                                chargesLog.TRAFFIC_PERMIT_TYPE_IDENTITY = recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_TEMP ? "0" : recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH ? "1" : "2";
                                chargesLog.VEHICLE_NO = recordInfo.INOUT_RECODE.VEHICLE_NO;
                                chargesLog.PRE_MONEY = recordInfo.INOUT_RECODE.PRE_MONEY;
                                chargesLog.CHARGE_MONEY = recordInfo.CurrNeedPay;
                                chargesLog.DUE_MONEY = recordInfo.INOUT_RECODE.PRE_MONEY + recordInfo.CurrNeedPay;
                                chargesLog.CHARGE_METHOD = (int)recordInfo.PayMethod;
                                chargesLogBll.Add(chargesLog);
                            }
                            foreach (var charge in charges)
                            {
                                charge.OUT_CHANNEL_CODE = recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE;
                                charge.OUT_FIELD_CODE = recordInfo.INOUT_RECODE.OUT_FIELD_CODE;
                                charge.OUT_PARTITION_CODE = recordInfo.INOUT_RECODE.OUT_PARTITION_CODE;
                                charge.OWNER_CODE = string.IsNullOrEmpty(charge.OWNER_CODE) ? null : charge.OWNER_CODE;
                                chargesLogBll.Update(charge);
                            }
                        }
                    }
                    /////////////////转áa移°?出?场?数oy据Y/////////////////
                    if (AddRecodeArchive(recordInfo))
                    { temp.Delete(recordInfo.INOUT_RECODE.ID); }
                    ///////////////触?￡¤发¤?é出?场?事o?件t//////////////////
                    recordInfo.OPERATER_TYPE = enumOperaterType.OutSuccessed;
                    ThreadMessageTransact.Instance.triggerEvent(recordInfo, false);
                }
                //保à?ê存??出?场?图a?片?
                CR_INOUT_RECODE_IMG modelOutImg = new CR_INOUT_RECODE_IMG();
                modelOutImg.ID = Guid.NewGuid().ToString("N");
                modelOutImg.IMG_TYPE = 0;
                modelOutImg.CHANNEL_CODE = recordInfo.CHN_CODE;
                modelOutImg.IMG_URL = recordInfo.PicFullName;
                modelOutImg.RECODE_ID = recordInfo.INOUT_RECODE.ID;
                modelOutImg.DEV_ID = recordInfo.DEV_CODE;
                modelOutImg.CHANNEL_TYPE = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? "I" : "E";
                modelOutImg.CREATE_TIME = DateTime.Now;
                modelOutImg.ISSEND = 0;
                tempImg.Add(modelOutImg);
                /////////////////////////////////显?示o?屏¨￠信?息?é///////////////////////////////
                if (recordInfo.CHANNEL_TYPE != enumChannelType.chn_in)
                    base.ShowLED(recordInfo);
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
                recordInfo.CheckPointResult = false;
            }
        }
    }
}