using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Interface;

namespace Parking.WorkBench
{
    public class BasePayMethod : IPayMethod
    {
        public virtual bool Pay(decimal money, string QRCode = "")
        {
            return false;
        }
    }
}