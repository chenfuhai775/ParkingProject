namespace Parking.ChargeStandard
{
    using Parking.Core.Infrastructure;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Parking.DBService.IBLL;
    using System;
    using System.Collections.Generic;

    public class CHARGE_TYPE_DAY_NIGHT : BaseCharge, IChargeStandard
    {
        private void CaculateIntervalBilling(double totalMinDay, ref decimal totalMoney, int intervalTime, decimal intervalCharge)
        {
            double num = totalMinDay / ((double) intervalTime);
            double num2 = totalMinDay % ((double) intervalTime);
            if (num2 > 0.0)
            {
                totalMoney += (((int) num) + 1) * intervalCharge;
            }
            else
            {
                totalMoney += ((int) num) * intervalCharge;
            }
        }

        public override decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int time = 0)
        {
            Dictionary<DateTime, DateTime> dictionary = new Dictionary<DateTime, DateTime>();
            if (OrderDetails.OUT_TIME.Subtract(OrderDetails.IN_TIME).TotalMinutes <= this.freeTime)
            {
                return 0M;
            }
            int num2 = Convert.ToDateTime(OrderDetails.OUT_TIME.ToShortDateString()).Subtract(Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString())).Days + 1;
            for (int i = 0; i < num2; i++)
            {
                DateTime key = (i == 0) ? OrderDetails.IN_TIME : Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) i);
                DateTime time2 = Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) (i + 1)).AddSeconds(-1.0);
                time2 = (time2 > OrderDetails.OUT_TIME) ? OrderDetails.OUT_TIME : time2;
                dictionary.Add(key, time2);
            }
            decimal totalMoney = 0M;
            foreach (KeyValuePair<DateTime, DateTime> pair in dictionary)
            {
                TimeSpan span2 = pair.Value - pair.Key;
                double totalMinutes = span2.TotalMinutes;
                if (this.dailyCapTime > 0)
                {
                    totalMinutes = (totalMinutes > this.dailyCapTime) ? ((double) this.dailyCapTime) : totalMinutes;
                }
                DateTime time3 = pair.Key.Date.AddHours((double) this.dayStartTime.Hour).AddMinutes((double) this.dayStartTime.Minute).AddSeconds((double) this.dayStartTime.Second);
                DateTime time4 = pair.Key.Date.AddHours((double) this.nightStartTime.Hour).AddMinutes((double) this.nightStartTime.Minute).AddSeconds((double) this.nightStartTime.Second);
                if ((pair.Key >= time3) && (pair.Key < time4))
                {
                    totalMinutes -= this.dayFirstBillingTime;
                    totalMoney += this.dayFirstChargeMoney;
                    if (totalMinutes > 0.0)
                    {
                        if (pair.Value <= time4)
                        {
                            this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                        }
                        else if (this.nightChargeType == 1)
                        {
                            double num6 = time4.Subtract(pair.Key).TotalMinutes;
                            this.CaculateIntervalBilling(num6 - this.dayFirstBillingTime, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                            totalMinutes -= num6 - this.dayFirstBillingTime;
                            totalMinutes -= this.nightFirstBillingTine;
                            totalMoney += this.nightFirstCharge;
                            if (totalMinutes > 0.0)
                            {
                                this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                            }
                        }
                        else
                        {
                            totalMoney += this.nightChargePerTime;
                        }
                    }
                }
                else if (pair.Key < time3)
                {
                    TimeSpan span3;
                    if (this.nightChargeType == 1)
                    {
                        totalMoney += this.nightFirstCharge;
                        totalMinutes -= this.nightFirstBillingTine;
                        if (totalMinutes > 0.0)
                        {
                            if (pair.Value < time4)
                            {
                                if (pair.Value <= time3)
                                {
                                    this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                                }
                                else
                                {
                                    span3 = time3.Subtract(pair.Key);
                                    this.CaculateIntervalBilling(span3.TotalMinutes - this.nightFirstBillingTine, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                                    totalMinutes -= span3.TotalMinutes - this.nightFirstBillingTine;
                                    totalMinutes -= this.dayFirstBillingTime;
                                    totalMoney += this.dayFirstChargeMoney;
                                    if (totalMinutes > 0.0)
                                    {
                                        this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                                    }
                                }
                            }
                            else
                            {
                                span3 = time3.Subtract(pair.Key);
                                this.CaculateIntervalBilling(span3.TotalMinutes - this.nightFirstBillingTine, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                                totalMinutes -= span3.TotalMinutes - this.nightFirstBillingTine;
                                totalMinutes -= this.dayFirstBillingTime;
                                totalMoney += this.dayFirstChargeMoney;
                                span3 = time4.Subtract(time3);
                                this.CaculateIntervalBilling(span3.TotalMinutes - this.dayFirstBillingTime, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                                totalMinutes -= span3.TotalMinutes - this.dayFirstBillingTime;
                                this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                            }
                        }
                    }
                    else
                    {
                        totalMoney += this.nightChargePerTime;
                        if (totalMinutes > 0.0)
                        {
                            if (pair.Value < time4)
                            {
                                if (pair.Value > time3)
                                {
                                    span3 = time3.Subtract(pair.Key);
                                    if (span3.TotalMinutes > 0.0)
                                    {
                                        totalMinutes -= span3.TotalMinutes;
                                        totalMinutes -= this.dayFirstBillingTime;
                                        totalMoney += this.dayFirstChargeMoney;
                                        if (totalMinutes > 0.0)
                                        {
                                            this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                                        }
                                    }
                                }
                            }
                            else if (pair.Value > time3)
                            {
                                totalMoney += this.dayFirstChargeMoney;
                                TimeSpan span4 = time4.Subtract(time3);
                                this.CaculateIntervalBilling(span4.TotalMinutes - this.dayFirstBillingTime, ref totalMoney, this.dayIntervalBillingTime, this.dayIntervalCharge);
                                totalMoney += this.nightChargePerTime;
                            }
                        }
                    }
                }
                else if (this.nightChargeType == 1)
                {
                    totalMinutes -= this.nightFirstBillingTine;
                    totalMoney += this.nightFirstCharge;
                    if (totalMinutes > 0.0)
                    {
                        this.CaculateIntervalBilling(totalMinutes, ref totalMoney, this.nightIntervalBillingTime, this.nightIntervalCharge);
                    }
                }
                else
                {
                    totalMoney += this.nightChargePerTime;
                }
                if (this.dailyCapMoney > 0)
                {
                    totalMoney = (totalMoney > this.dailyCapMoney) ? this.dailyCapMoney : totalMoney;
                    decimal oneDayTotalMoney = this.GetOneDayTotalMoney(OrderDetails);
                    if ((oneDayTotalMoney + totalMoney) > this.dailyCapMoney)
                    {
                        totalMoney = this.dailyCapMoney - oneDayTotalMoney;
                    }
                }
            }
            return totalMoney;
        }

        public decimal GetOneDayTotalMoney(CR_ORDER_RECORD_DETAILS record)
        {
            return EngineContext.Current.Resolve<ICR_INOUT_RECODE>().GetOneDayTotalMoney(record);
        }

        public int dailyCapMoney
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("allDay_dailyCapMoney") || string.IsNullOrEmpty(base.Attributes["allDay_dailyCapMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["allDay_dailyCapMoney"].ToString());
                }
                return 0;
            }
        }

        public int dailyCapTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("allDay_dailyCapTime") || string.IsNullOrEmpty(base.Attributes["allDay_dailyCapTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["allDay_dailyCapTime"].ToString());
                }
                return 0;
            }
        }

        public int dayFirstBillingTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("day_firstTime") || string.IsNullOrEmpty(base.Attributes["day_firstTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["day_firstTime"].ToString());
                }
                return 0;
            }
        }

        public int dayFirstChargeMoney
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("day_firstChargeMoney") || string.IsNullOrEmpty(base.Attributes["day_firstChargeMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["day_firstChargeMoney"].ToString());
                }
                return 0;
            }
        }

        public int dayIntervalBillingTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("day_intervalChargingTime") || string.IsNullOrEmpty(base.Attributes["day_intervalChargingTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["day_intervalChargingTime"].ToString());
                }
                return 0;
            }
        }

        public decimal dayIntervalCharge
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("day_intervalChargingMoney") || string.IsNullOrEmpty(base.Attributes["day_intervalChargingMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["day_intervalChargingMoney"].ToString());
                }
                return 0M;
            }
        }

        public DateTime dayStartTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("day_beginTime") || string.IsNullOrEmpty(base.Attributes["day_beginTime"].ToString())))
                {
                    return Convert.ToDateTime(base.Attributes["day_beginTime"].ToString());
                }
                return DateTime.MinValue;
            }
        }

        public int freeTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("allDay_freeTime") || string.IsNullOrEmpty(base.Attributes["allDay_freeTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["allDay_freeTime"].ToString());
                }
                return 0;
            }
        }

        public decimal nightChargePerTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_payMoney") || string.IsNullOrEmpty(base.Attributes["night_payMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_payMoney"].ToString());
                }
                return 0M;
            }
        }

        public int nightChargeType
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_payMethod") || string.IsNullOrEmpty(base.Attributes["night_payMethod"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_payMethod"].ToString());
                }
                return 0;
            }
        }

        public int nightFirstBillingTine
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_firstTime") || string.IsNullOrEmpty(base.Attributes["night_firstTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_firstTime"].ToString());
                }
                return 0;
            }
        }

        public int nightFirstCharge
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_firstChargeMoney") || string.IsNullOrEmpty(base.Attributes["night_firstChargeMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_firstChargeMoney"].ToString());
                }
                return 0;
            }
        }

        public int nightIntervalBillingTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_intervalChargingTime") || string.IsNullOrEmpty(base.Attributes["night_intervalChargingTime"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_intervalChargingTime"].ToString());
                }
                return 0;
            }
        }

        public int nightIntervalCharge
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_intervalChargingMoney") || string.IsNullOrEmpty(base.Attributes["night_intervalChargingMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["night_intervalChargingMoney"].ToString());
                }
                return 0;
            }
        }

        public DateTime nightStartTime
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("night_beginTime") || string.IsNullOrEmpty(base.Attributes["night_beginTime"].ToString())))
                {
                    return Convert.ToDateTime(base.Attributes["night_beginTime"].ToString());
                }
                return DateTime.MinValue;
            }
        }
    }
}

