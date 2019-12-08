namespace Parking.Drives
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ice_uart
    {
        public int uartEn;
        public int uartWorkMode;
        public int baudRate;
        public int dataBits;
        public int parity;
        public int stopBits;
        public int flowControl;
        public int LEDControlCardType;
        public int LEDBusinessType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=3, ArraySubType=UnmanagedType.I4)]
        public int[] as32Reserved;
    }
}

