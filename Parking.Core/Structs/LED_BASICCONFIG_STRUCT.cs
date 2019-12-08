namespace Parking.Core.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LED_BASICCONFIG_STRUCT
    {
        public string ip;
        public int volume;
        public int brightness;
        public int contrast;
    }
}

