using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.DBService.IBLL;
using Parking.Core.Model;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    public class SaveDiscountsCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out || recordInfo.CHANNEL_TYPE == enumChannelType.centerPayment)
            {
                if (null != recordInfo.ListDiscount && recordInfo.ListDiscount.Count > 0)
                {
                    ///////////////////////////插入计费汇总跟优惠记录////////////////////////////////////
                    var tempLog = EngineContext.Current.Resolve<ICR_CHARGES_LOG>();
                    var temRecor = EngineContext.Current.Resolve<ICR_PREFERENTIAL_RECORD>();
                    decimal totalperMoney = 0;

                    foreach (var temp in recordInfo.ListDiscount.OrderBy(x => x.CR_LEVEL))
                    {
                        var discount = EngineContext.Current.Resolve<IDiscount>(temp.PREFERENTIAL_TYPE.ToString());
                        totalperMoney += discount.Discount(recordInfo, temp);
                    }
                    recordInfo.INOUT_RECODE.PRE_MONEY = totalperMoney;
                    recordInfo.INOUT_RECODE.CHARGE_MONEY = recordInfo.INOUT_RECODE.DUE_MONEY - totalperMoney;
                    /////////////////修改优惠劵状态/////////////////
                    if (null != recordInfo.ListDiscount)
                    {
                        var physicalTemp = EngineContext.Current.Resolve<ICR_PREFERENTIAL_PHYSICAL>();
                        foreach (CRPreferentialDetails detail in recordInfo.ListDiscount)
                        {
                            CR_PREFERENTIAL_RECORD model = new CR_PREFERENTIAL_RECORD();
                            model.ID = Guid.NewGuid().ToString("N");
                            model.INOUT_RECORD_CODE = recordInfo.INOUT_RECODE.ID;
                            model.PREFERENTIAL_CONTENT = detail.PREFERENTIAL_CONTENT.ToString();
                            model.PREFERENTIAL_MONEY = detail.PREFERENTIAL_MONEY;
                            model.CHARGE_MONEY = recordInfo.INOUT_RECODE.DUE_MONEY;
                            model.PREFERENTIAL_TYPE = Convert.ToInt32(detail.PREFERENTIAL_TYPE);
                            model.CHARGE_ID = recordInfo.chargeFlowing;
                            model.PREFERENTIA_IDENT = detail.PREFERENTIA_IDENT;
                            model.PREFERENTIAL_NAME = detail.PREFERENTIAL_NAME;
                            temRecor.Add(model);
                            /////////////////修改优惠劵状态/////////////////
                            physicalTemp.update(detail.PREFERENTIA_IDENT, 1);
                        }
                    }
                }
            }
            recordInfo.CheckPointResult = true;
        }
    }
}