namespace Parking.Core.Interface
{
    using System;
    using System.Runtime.InteropServices;

    public interface IPayMethod
    {
        bool Pay(decimal money, string QRCode = "");
    }
}

