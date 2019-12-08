using System;
using System.Linq;
using Parking.DBService.IBLL;
using Parking.Core;
using Parking.Core.Log4Net;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Common;
using Parking.Core.DataProcessing;

namespace Parking.WorkBench
{
    /// <summary>
    /// 计费-结账
    /// </summary>
    public class ChargingCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            if (!recordInfo.IsFree)
            {
                bool isCharge = false;
                //如¨?果?是o?贵¨?宾à?车|ì(或¨°月?卡?§车|ì)，ê?直?à接¨?放¤?行D
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP || (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH && !recordInfo.IsMonthToTemp))
                {
                    recordInfo.CheckPointResult = true;
                    return;
                }
                //临￠¨′时o?à授o¨2权¨?§车|ì
                if (recordInfo.authenticationType == enumAuthenticationType.TempAuthorization)
                {
                    if (recordInfo.temporaryBilling == enumTemporaryBilling.FREE)
                    {
                        var orderFree = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                        var OrdersFree = orderFree.GetOrders(recordInfo.INOUT_RECODE);
                        recordInfo.INOUT_RECODE.DUE_MONEY = 0;
                        recordInfo.ListOrder = OrdersFree;
                        recordInfo.CheckPointResult = true;
                        return;
                    }
                    //超?时o?à计?费¤?
                    if (recordInfo.temporaryBilling == enumTemporaryBilling.CHARGE)
                    {
                        if (!recordInfo.IsFree && recordInfo.TemporaryEndTime < System.DateTime.Now)
                        {
                            isCharge = true;
                        }
                        else
                        {
                            var orderFree = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                            var OrdersFree = orderFree.GetOrders(recordInfo.INOUT_RECODE);
                            recordInfo.INOUT_RECODE.DUE_MONEY = 0;
                            recordInfo.ListOrder = OrdersFree;
                            recordInfo.CheckPointResult = true;
                            return;
                        }
                    }
                }
                var orderBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
                var Orders = orderBll.GetOrders(recordInfo.INOUT_RECODE);
                //取¨?当ì?à前??区?域?¨°的ì?订?单ì￡¤号?
                string Leave = base.getCurrChannel(recordInfo) == null ? recordInfo.INOUT_RECODE.CURR_PARTITION_CODE : base.getCurrChannel(recordInfo).Leave;
                var Order = Orders.Where(x => x.PARTITION_CODE == Leave).FirstOrDefault();
                if (null != Order)
                {
                    Order.DUE_MONEY = 0;
                    Order.TOTAL_TIME = 0;
                    var OrderDetails = orderDetailsBll.GetDetailsByOrder(Order.ID);
                    foreach (var temp in OrderDetails)
                    {
                        if (null == Order.FREE_TIME || Order.FREE_TIME < DateTime.Now)
                        {
                            //如¨?果?是o?临￠¨′时o?à授o¨2权¨?§车|ì、?é超?时o?à收o?费¤?并?é且¨°临￠¨′时o?à授o¨2权¨?§结¨￠束o?时o?à间?小?于?¨2当ì?à前??时o?à间?，ê?则¨°按???临￠¨′时o?à授o¨2权¨?§结¨￠束o?时o?à间?开a始o?计?费¤?
                            if (isCharge)
                            {
                                temp.IN_TIME = recordInfo.TemporaryEndTime;
                            }
                            double timeLong = temp.OUT_TIME.Subtract(temp.IN_TIME).TotalSeconds;
                            Order.TOTAL_TIME += timeLong;
                            recordInfo.INOUT_RECODE.TOTAL_TIME += timeLong;
                            //获?取¨?收o?费¤?标à¨o准á?
                            var tempCharg = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.PARTITION_CODE).FirstOrDefault();
                            if (null != tempCharg)
                            {
                                var carType = tempCharg.ListChargMap.Where(x => x.carType == (int)recordInfo.CarType).FirstOrDefault();
                                if (null != carType)
                                {
                                    string ChargeNo = string.Empty;
                                    //启?用??日¨?历¤¨2
                                    if (tempCharg.calTypeFlag)
                                        ChargeNo = CommHelper.getWorkingDaysVal() ? carType.holiday : carType.working;
                                    else
                                        ChargeNo = carType.chargeNo;
                                    var chargeType = EngineContext.Current.Resolve<IPBA_CHARGE_INFO>();
                                    var model = chargeType.GetModel(ChargeNo);
                                    recordInfo.chargeStandardType = (enumChargeStandardType)(Enum.Parse(typeof(enumChargeStandardType), model.CHARGE_PARAM_CODE, false));
                                    var chargeStandard = EngineContext.Current.Resolve<IChargeStandard>(recordInfo.chargeStandardType.ToString());
                                    chargeStandard.InitChargeStandard(ChargeNo);
                                    decimal money = chargeStandard.Charge(temp);
                                    money = money < 0 ? 0 : money;
                                    temp.DUE_MONEY = money;
                                    orderDetailsBll.Update(temp);
                                    recordInfo.ChargeStandard = chargeStandard;
                                    recordInfo.OPERATER_TYPE = enumOperaterType.ShowChargeInfo;
                                    ThreadMessageTransact.Instance.triggerEvent(recordInfo, false);
                                    ////////////////更¨1新?订?单ì￡¤信?息?é//////////////
                                    Order.DUE_MONEY += money;
                                    recordInfo.CheckPointResult = true;
                                }
                                else
                                    recordInfo.CheckPointResult = false;
                            }
                            else
                            {
                                recordInfo.CheckPointResult = false;
                                LogHelper.Log.Error("工?è作á??站?【?" + tempCharg.ORGANIZATION_NAME + "】?没?有?D配?置?收o?费¤?标à¨o准á?");
                            }
                        }
                    }
                    decimal needPay = Order.DUE_MONEY - Order.ALREADY_PAID - Order.PER_MONEY;
                    recordInfo.CurrNeedPay = needPay;
                }
                ////////////////更¨1新?Orders///////////////
                decimal totalMoney = 0;
                foreach (var temp in Orders)
                {
                    totalMoney += temp.DUE_MONEY;
                    if (null == temp.FREE_TIME || temp.FREE_TIME < DateTime.Now)
                    {
                        orderBll.Update(temp);
                    }
                }
                recordInfo.INOUT_RECODE.DUE_MONEY = totalMoney;
                recordInfo.ListOrder = Orders;
            }
        }
    }
}