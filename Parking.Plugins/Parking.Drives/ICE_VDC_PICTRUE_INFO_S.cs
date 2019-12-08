namespace Parking.Drives
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ICE_VDC_PICTRUE_INFO_S
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x80)]
        public string cFileName;
        public IntPtr pstVbrResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x194)]
        public string data;
    }
}

