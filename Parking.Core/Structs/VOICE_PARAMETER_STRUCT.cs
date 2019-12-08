namespace Parking.Core.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct VOICE_PARAMETER_STRUCT
    {
        public int volume;
        public string content;
        public string ip;
        public int reserve1;
        public int reserve2;
        public string reserve3;
        public string reserve4;
        public string reserve5;
    }
}

