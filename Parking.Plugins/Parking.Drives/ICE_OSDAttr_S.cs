namespace Parking.Drives
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ICE_OSDAttr_S
    {
        public uint u32OSDLocationVideo;
        public uint u32ColorVideo;
        public uint u32DateVideo;
        public uint u32License;
        public uint u32CustomVideo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string szCustomVideo;
        public uint u32OSDLocationJpeg;
        public uint u32ColorJpeg;
        public uint u32DateJpeg;
        public uint u32Algo;
        public uint u32DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string szDeviceID;
        public uint u32DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string szDeviceName;
        public uint u32CamreaLocation;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string szCamreaLocation;
        public uint u32SubLocation;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string szSubLocation;
        public uint u32ShowDirection;
        public uint u32CameraDirection;
        public uint u32CustomJpeg;
        public uint u32ItemDisplayMode;
        public uint u32DateMode;
        public uint u32BgColor;
        public uint u32FontSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x30)]
        public string szCustomJpeg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x180)]
        public string szCustomVideo6;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x180)]
        public string szCustomJpeg6;
    }
}

