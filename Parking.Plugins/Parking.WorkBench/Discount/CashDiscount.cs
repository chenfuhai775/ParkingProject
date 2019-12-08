using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Interface;

namespace Parking.WorkBench
{
    public class CashDiscount : IDiscount
    {
        /// <summary>
        /// 现金减免
        /// </summary>
        /// <param name="recordInfo"></param>
        public decimal Discount(ProcessRecord recordInfo, CRPreferentialDetails details)
        {
            decimal disMoney = 0;
            decimal.TryParse(details.PREFERENTIAL_CONTENT.ToString(), out disMoney);
            return disMoney;
        }
    }
}