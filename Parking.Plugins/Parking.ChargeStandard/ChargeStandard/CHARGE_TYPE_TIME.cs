namespace Parking.ChargeStandard
{
    using Parking.Core.ChargeStandard;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CHARGE_TYPE_TIME : BaseCharge, IChargeStandard
    {
        public override decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int time = 0)
        {
            Dictionary<DateTime, DateTime> dictionary = new Dictionary<DateTime, DateTime>();
            if (OrderDetails.OUT_TIME.Subtract(OrderDetails.IN_TIME).TotalMinutes <= this.freeTime)
            {
                return 0M;
            }
            int num2 = Convert.ToDateTime(OrderDetails.OUT_TIME.ToShortDateString()).Subtract(Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString())).Days + 1;
            decimal num3 = 0M;
            for (int i = 0; i < num2; i++)
            {
                DateTime key = (i == 0) ? OrderDetails.IN_TIME : Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) i);
                DateTime time2 = Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) (i + 1)).AddSeconds(-1.0);
                time2 = (time2 > OrderDetails.OUT_TIME) ? OrderDetails.OUT_TIME : time2;
                dictionary.Add(key, time2);
            }
            foreach (KeyValuePair<DateTime, DateTime> pair in dictionary)
            {
                TimeSpan span2 = pair.Value - pair.Key;
                num3 += this.GetMoney(span2.TotalMinutes);
            }
            return num3;
        }

        private decimal GetMoney(double totalMinutes)
        {
            double dtTemp = totalMinutes;
            decimal payMoney = 0M;
            SubsectionTotalLength length = (from x in this.Subsections
                where (x.beginTime <= dtTemp) && (x.endTime >= dtTemp)
                select x).FirstOrDefault<SubsectionTotalLength>();
            if (null != length)
            {
                payMoney = length.payMoney;
            }
            else
            {
                payMoney = this.dailyCapMoney;
            }
            if (payMoney > this.dailyCapMoney)
            {
                payMoney = this.dailyCapMoney;
            }
            return payMoney;
        }

        public int dailyCapMoney
        {
            get
            {
                if (!(!base.Attributes.ContainsKey("A_dailyCapMoney") || string.IsNullOrEmpty(base.Attributes["A_dailyCapMoney"].ToString())))
                {
                    return Convert.ToInt32(base.Attributes["A_dailyCapMoney"].ToString());
                }
                return 20;
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

        public List<SubsectionTotalLength> Subsections
        {
            get
            {
                List<SubsectionTotalLength> list = new List<SubsectionTotalLength>();
                foreach (string str in base.Attributes.Keys)
                {
                    if (str.Contains("array"))
                    {
                        SubsectionTotalLength item = new SubsectionTotalLength();
                        item = JsonConvert.DeserializeObject<SubsectionTotalLength>(base.Attributes[str]);
                        list.Add(item);
                    }
                }
                return list;
            }
        }
    }
}

