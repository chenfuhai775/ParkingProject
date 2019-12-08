namespace Parking.ChargeStandard
{
    using Parking.Core.ChargeStandard;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CHARGE_TYPE_TOTAL_LENGTH : BaseCharge, IChargeStandard
    {
        public override decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int time = 0)
        {
            Dictionary<DateTime, DateTime> dictionary = new Dictionary<DateTime, DateTime>();
            TimeSpan span = (TimeSpan) (OrderDetails.OUT_TIME - OrderDetails.IN_TIME);
            int num = Convert.ToDateTime(OrderDetails.OUT_TIME.ToShortDateString()).Subtract(Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString())).Days + 1;
            decimal num2 = 0M;
            for (int i = 0; i < num; i++)
            {
                DateTime key = (i == 0) ? OrderDetails.IN_TIME : Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) i);
                DateTime time2 = Convert.ToDateTime(OrderDetails.IN_TIME.ToShortDateString()).AddDays((double) (i + 1)).AddSeconds(-1.0);
                time2 = (time2 > OrderDetails.OUT_TIME) ? OrderDetails.OUT_TIME : time2;
                dictionary.Add(key, time2);
            }
            foreach (KeyValuePair<DateTime, DateTime> pair in dictionary)
            {
                TimeSpan span2 = pair.Value - pair.Key;
                num2 += this.GetMoney(0.0, span2.TotalMinutes);
            }
            return num2;
        }

        private decimal GetMoney(double startTime, double endTime)
        {
            Func<SubsectionTotalLength, bool> predicate = null;
            double dtTemp = startTime;
            decimal num = 0M;
            while (dtTemp < endTime)
            {
                if (predicate == null)
                {
                    predicate = x => (x.beginTime <= dtTemp) && (x.endTime >= dtTemp);
                }
                SubsectionTotalLength length = this.Subsections.Where<SubsectionTotalLength>(predicate).FirstOrDefault<SubsectionTotalLength>();
                if (null == length)
                {
                    return num;
                }
                num += length.payMoney;
                dtTemp = length.endTime + 1;
            }
            return num;
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

