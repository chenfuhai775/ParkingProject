namespace Parking.Core.Interface
{
    using Parking.Core.Model;
    using System;

    public interface IChargeStandard
    {
        decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails,int freeTime = 0);
        void InitChargeStandard(string ChargeCode);
    }
}

