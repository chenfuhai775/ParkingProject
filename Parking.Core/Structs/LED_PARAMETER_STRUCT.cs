namespace Parking.Core.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LED_PARAMETER_STRUCT
    {
        public int rowIndex;
        public string[] Msg;
        public string ip;
        public int port;
        public string fontName;
        public int fontSize;
        public int fontColor;
        public int displayMode;
        public int speed;
        public int leftPos;
        public int topPos;
        public int width;
        public int height;
        public int reserve1;
        public int reserve2;
        public string reserve3;
        public string reserve4;
        public string reserve5;
    }
}

