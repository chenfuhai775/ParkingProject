using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Log4Net;
using Parking.DBService.IBLL;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    public class ManualDiscount : IDiscount
    {
        public decimal Discount(ProcessRecord recordInfo, CRPreferentialDetails details)
        {
            return details.PREFERENTIAL_CONTENT;
        }
    }
}