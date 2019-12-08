namespace Parking.Core.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ROADGATE_NETCONFIG_STRUCT
    {
        public string deviceName;
        public string srcip;
        public string desip;
        public int port;
        public string mac;
        public int reserver1;
        public int reserver2;
        public string reserver3;
        public string reserver4;
        public string reserver5;
    }
}

