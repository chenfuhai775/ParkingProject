namespace Parking.Drives
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ICE_CameraInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x80)]
        public string szAppVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)]
        public string szAlgoVersion;
        public int szIsEnc;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x10)]
        public string szAppTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x400)]
        public string szReserved;
    }
}

