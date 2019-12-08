namespace Parking.Core.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ROADGATE_INFO_STRUCT
    {
        public string ip;
        public bool isManual;
        public int Counter;
        public int reserve1;
        public int reserve2;
        public string reserve3;
        public string reserve4;
        public string reserve5;
    }
}

