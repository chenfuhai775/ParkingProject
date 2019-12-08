using System;
using System.Collections.Generic;
using System.Linq;
using Parking.Core;
using Parking.Core.Log4Net;
using Parking.Core.Model;
using Parking.DBService.IBLL;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Record;
using Parking.Core.Enum;

namespace Parking.WorkBench
{
    /// <summary>
    /// 出场弹收费框
    /// </summary>
    public class ShowChargeCheck : CheckPointBase, ICheck
    {

        private static Dictionary<string, DateTime> dicChargeInfo = new Dictionary<string, DateTime>();
        public override void Process(ProcessRecord recordInfo)
        {
            try
            {
                recordInfo.CheckPointResult = true;

                bool AutoGate = false;
                var currChannel = base.getCurrChannel(recordInfo);
                if (null != currChannel)
                    AutoGate = currChannel.autoGate;

                //自á?动?￥开a闸?é
                if (AutoGate)
                {
                    recordInfo.AutoOpenGate = true;
                }
                else
                {
                    //如¨?果?是o?贵¨?宾à?车|ì，ê?直?à接¨?放¤?行D
                    if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    {
                        return;
                    }
                    //先¨¨查¨|找¨°订?单ì￡¤
                    ICR_ORDER_RECORD_INFO orderRecord = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                    string Leave = base.getCurrChannel(recordInfo) == null ? recordInfo.INOUT_RECODE.CURR_PARTITION_CODE : base.getCurrChannel(recordInfo).Leave;
                    var order = orderRecord.GetOrders(recordInfo.INOUT_RECODE).Where(x => x.PARTITION_CODE == Leave).FirstOrDefault();
                    //////////////////////////余?¨¤额?不?足á?转áa临￠¨′时o?à卡?§///////////////////////////
                    if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_STORED)
                    {
                        if (null == recordInfo.OwnerInfo || recordInfo.OwnerInfo.balance < recordInfo.CurrNeedPay)
                        {
                            recordInfo.IsMonthToTemp = true;
                        }
                        else
                        {
                            order.ALREADY_PAID = order.DUE_MONEY;
                            order.IS_PAY = true;
                            recordInfo.PayMethod = enumPayMethod.STORED_PAY;
                            recordInfo.INOUT_RECODE.CHARGE_MONEY = recordInfo.INOUT_RECODE.DUE_MONEY;
                        }
                    }
                    if (recordInfo.CHANNEL_TYPE != enumChannelType.centerPayment && (null == order || order.DUE_MONEY == order.ALREADY_PAID || 0 == recordInfo.INOUT_RECODE.DUE_MONEY || recordInfo.IsFree))
                    { }
                    else
                    {
                        base.TriggerEvent(enumOperaterType.ShowCharge, recordInfo, true);
                        base.WaitOne(recordInfo);
                    }
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