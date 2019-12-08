namespace Parking.ChargeStandard
{
    using Parking.Core.Infrastructure;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Parking.DBService.IBLL;
    using System;

    public class CHARGE_TYPE_CHARGE_NUMBER : BaseCharge, IChargeStandard
    {
        public override decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int time = 0)
        {
            try
            {
                switch (this.cumulativeWay)
                {
                    case "A":
                        return this.GetChargeA(OrderDetails);

                    case "B":
                        return this.GetChargeB(OrderDetails);

                    case "C":
                        return this.GetChargeC(OrderDetails);
                }
                return 0M;
            }
            catch
            {
                return 0M;
            }
        }

        public decimal GetChargeA(CR_ORDER_RECORD_DETAILS OrderDetails)
        {
            decimal payMoney = 0M;
            TimeSpan span = (TimeSpan) (OrderDetails.OUT_TIME - OrderDetails.IN_TIME);
            int days = Convert.ToDateTime(OrderDetails.OUT_TIME.ToShortDateString()).Subtract(Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString())).Days;
            if (span.TotalMinutes <= this.freeTime)
            {
                return 0M;
            }
            decimal oneDayTotalMoney = 0M;
            if (this.GetMultipleMoney(OrderDetails) > 0M)
            {
                oneDayTotalMoney = this.GetOneDayTotalMoney(OrderDetails) + this.payMoney;
            }
            else
            {
                oneDayTotalMoney = this.GetOneDayTotalMoney(OrderDetails);
            }
            if (oneDayTotalMoney >= this.dailyCapMoney)
            {
                payMoney = 0M;
            }
            else if ((this.dailyCapMoney - oneDayTotalMoney) >= this.payMoney)
            {
                payMoney = this.payMoney;
            }
            else
            {
                payMoney = this.dailyCapMoney - oneDayTotalMoney;
            }
            return (payMoney + (this.payMoney * days));
        }

        public decimal GetChargeB(CR_ORDER_RECORD_DETAILS OrderDetails)
        {
            decimal payMoney = 0M;
            TimeSpan span = (TimeSpan) (OrderDetails.OUT_TIME - OrderDetails.IN_TIME);
            if (span.TotalMinutes <= this.freeTime)
            {
                OrderDetails.DUE_MONEY = 0M;
                return payMoney;
            }
            decimal oneDayTotalMoney = 0M;
            if (this.GetExceed24HourMoney(OrderDetails) > 0M)
            {
                oneDayTotalMoney = this.GetOneDayTotalMoney(OrderDetails) + this.payMoney;
            }
            else
            {
                oneDayTotalMoney = this.GetOneDayTotalMoney(OrderDetails);
            }
            if (oneDayTotalMoney >= this.dailyCapMoney)
            {
                payMoney = 0M;
            }
            else if ((this.dailyCapMoney - oneDayTotalMoney) >= this.payMoney)
            {
                payMoney = this.payMoney;
            }
            else
            {
                payMoney = this.dailyCapMoney - oneDayTotalMoney;
            }
            return (payMoney + (this.payMoney * span.Days));
        }

        public decimal GetChargeC(CR_ORDER_RECORD_DETAILS OrderDetails)
        {
            decimal num = 0M;
            TimeSpan span = (TimeSpan) (OrderDetails.OUT_TIME - OrderDetails.IN_TIME);
            if (span.TotalMinutes <= this.freeTime)
            {
                OrderDetails.DUE_MONEY = 0M;
                return num;
            }
            decimal nowDayTotalMoney = EngineContext.Current.Resolve<ICR_INOUT_RECODE>().GetNowDayTotalMoney(OrderDetails);
            if (nowDayTotalMoney >= this.dailyCapMoney)
            {
                OrderDetails.DUE_MONEY = 0M;
                return num;
            }
            if ((this.dailyCapMoney - nowDayTotalMoney) >= this.payMoney)
            {
                return this.payMoney;
            }
            return (this.dailyCapMoney - nowDayTotalMoney);
        }

        public decimal GetExceed24HourMoney(CR_ORDER_RECORD_DETAILS record)
        {
            return EngineContext.Current.Resolve<ICR_INOUT_RECODE>().GetExceed24HourMoney(record);
        }

        public decimal GetMultipleMoney(CR_ORDER_RECORD_DETAILS record)
        {
            return EngineContext.Current.Resolve<ICR_INOUT_RECODE>().GetMultipleMoney(record);
        }

        public decimal GetOneDayTotalMoney(CR_ORDER_RECORD_DETAILS record)
        {
            return EngineContext.Current.Resolve<ICR_INOUT_RECODE>().GetOneDayTotalMoney(record);
        }

        public string cumulativeWay
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("A_cumulativeWay") || string.IsNullOrEmpty(base.Attributes["A_cumulativeWay"].ToString())))
                {
                    return base.Attributes["A_cumulativeWay"].ToString();
                }
                return "";
            }
        }

        public decimal dailyCapMoney
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("A_dailyCapMoney") || string.IsNullOrEmpty(base.Attributes["A_dailyCapMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["A_dailyCapMoney"].ToString());
                }
                return 0M;
            }
        }

        public int freeTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("A_freeTime") || string.IsNullOrEmpty(base.Attributes["A_freeTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["A_freeTime"].ToString());
                }
                return 0;
            }
        }

        public decimal payMoney
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("A_payMoney") || string.IsNullOrEmpty(base.Attributes["A_payMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["A_payMoney"].ToString());
                }
                return 0M;
            }
        }
    }
}

