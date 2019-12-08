using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Interface;

namespace Parking.WorkBench
{
    public class PercentageDiscount : IDiscount
    {
        /// <summary>
        /// 折扣
        /// </summary>
        /// <param name="recordInfo"></param>
        public decimal Discount(ProcessRecord recordInfo, CRPreferentialDetails details)
        {
            decimal disMoney = 1;
            decimal.TryParse(details.PREFERENTIAL_CONTENT.ToString(), out disMoney);
            return recordInfo.INOUT_RECODE.CHARGE_MONEY * (1 - disMoney);
        }
    }
}