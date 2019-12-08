using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core;
using Parking.Core.Interface;
using Parking.DBService.IBLL;
using Parking.Core.Record;
using Parking.Core.Common;
using Parking.Core.Enum;
using Parking.Core.Model;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    /// <summary>
    /// 出场生成订单
    /// </summary>
    public class GenerateOrderCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            recordInfo.CheckPointResult = true;
            if (recordInfo.CARD_TYPE != enumCardType.CAR_TYPE_MONTH || recordInfo.IsMonthToTemp)
            {
                var orderBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
                //如果是贵宾车，直接放行
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    return;
                /////////////////当前区域////////////////
                string Leave = recordInfo.INOUT_RECODE.CURR_PARTITION_CODE;
                string Enter = base.getCurrChannel(recordInfo) == null ? string.Empty : base.getCurrChannel(recordInfo).Enter;
                var Order = orderBll.GetCurrentPartitionOrder(recordInfo.INOUT_RECODE);
                ////////////////////////////大车场入小车场////////////////////////
                if (!string.IsNullOrEmpty(Leave))
                {
                    if (null != Order)
                    {
                        recordInfo.Order = Order;
                        ////////////////////已经中央缴费///////////////////
                        if (DateTime.Now < Order.FREE_TIME && Order.IS_PAY)
                        {
                            recordInfo.IsCenterPay = true;
                            recordInfo.CheckPointResult = true;
                            /////////////////////如果是中央缴费则播报中央已缴费语音//////////////////////////
                            if (recordInfo.CHANNEL_TYPE == enumChannelType.centerPayment)
                            {
                                var voiceBllTemp = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
                                List<string> strArr = new List<string>();
                                PBA_VOICE_TEMPLATE voiceModel = voiceBllTemp.GetModelByType((int)enumTemplateType.MODEL_TYPE_VOICE, (int)enumSpeechType.CenterPayed);
                                strArr.Add(CommHelper.VoiceContent(voiceModel.CUSTOM_MODEL, recordInfo));
                                CommHelper.Sound(recordInfo, strArr.ToArray());
                                recordInfo.CheckPointResult = false;
                                new G5MessageBox("您已经缴费,请在规定时间内出场").ShowDialog();
                            }
                            else if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                            {
                                var temp = EngineContext.Current.Resolve<ICR_PREFERENTIAL_RECORD>();
                                var discounts = temp.GetListByInOutRecordCode(recordInfo.INOUT_RECODE.ID);
                                decimal preMoney = 0;
                                decimal totalMoney = 0;
                                foreach (var discount in discounts)
                                {
                                    preMoney += discount.PREFERENTIAL_MONEY;
                                    totalMoney = discount.CHARGE_MONEY;
                                }
                                recordInfo.INOUT_RECODE.PRE_MONEY = preMoney;
                                recordInfo.INOUT_RECODE.DUE_MONEY = totalMoney;
                                recordInfo.INOUT_RECODE.CHARGE_MONEY = totalMoney - preMoney;
                            }
                        }
                        else
                        {
                            CR_ORDER_RECORD_DETAILS orderDetails = new CR_ORDER_RECORD_DETAILS();
                            var OrderDetails = orderDetailsBll.GetOrderDetailsInfo(recordInfo);
                            if (null != OrderDetails)
                            {
                                orderDetails = OrderDetails;
                                orderDetails.OUT_TIME = DateTime.Now;
                                orderDetails.OUT_CHANNEL_CODE = recordInfo.CHN_CODE;
                                recordInfo.INOUT_RECODE.IN_TIME = OrderDetails.IN_TIME;
                                recordInfo.INOUT_RECODE.OUT_TIME = OrderDetails.OUT_TIME;
                                recordInfo.CheckPointResult = recordInfo.CheckPointResult && orderDetailsBll.Update(orderDetails);
                            }
                            else
                            {
                                orderDetails.ID = Guid.NewGuid().ToString("N");
                                orderDetails.ORDER_CODE = Order.ID;
                                orderDetails.IN_CHANNEL_CODE = Order.IN_CHANNEL_CODE;
                                orderDetails.OUT_CHANNEL_CODE = recordInfo.CHN_CODE;
                                orderDetails.IN_TIME = recordInfo.INOUT_RECODE.IN_TIME;
                                orderDetails.OUT_TIME = DateTime.Now;
                                orderDetails.VEHICLE_NO = recordInfo.INOUT_RECODE.VEHICLE_NO;
                                recordInfo.CheckPointResult = recordInfo.CheckPointResult && orderDetailsBll.Add(orderDetails);
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(Enter))
                {
                    if (null == Order)
                    {
                        CR_ORDER_RECORD_INFO orderTemp = new CR_ORDER_RECORD_INFO();
                        orderTemp.ID = Guid.NewGuid().ToString("N");
                        orderTemp.INOUT_RECODE_ID = recordInfo.INOUT_RECODE.ID;
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
            }
        }
    }
}