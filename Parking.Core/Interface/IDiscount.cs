namespace Parking.Core.Interface
{
    using Parking.Core.Model;
    using Parking.Core.Record;
    using System;

    public interface IDiscount
    {
        decimal Discount(ProcessRecord recordInfo, CRPreferentialDetails details);
    }
}

