namespace Parking.Drives
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ICE_UART_PARAM
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=2, ArraySubType=UnmanagedType.Struct)]
        public ice_uart[] uart_param;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=10, ArraySubType=UnmanagedType.I4)]
        public int[] as32Reserved;
    }
}

