namespace Parking.Drives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    public class CVzClientSDK
    {
        public const int VZ_LPRC_PROVINCE_STR_LEN = 0x80;
        public const int VZ_LPRC_VIRTUAL_LOOP_MAX_NUM = 8;
        public const int VZ_LPRC_VIRTUAL_LOOP_NAME_LEN = 0x20;
        public const int VZ_LPRC_VIRTUAL_LOOP_VERTEX_NUM = 4;

        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_Cleanup();
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_Close(int handle);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_CloseByIP(string pStrIP);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_ForceTrigger(int handle);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_GetSnapShootToJpeg2(int nPlayHandle, string pFullPathName, int nQuality);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_GetSupportedProvinces(int handle, ref VZ_LPRC_PROVINCE_INFO pProvInfo);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_GetVirtualLoop(int handle, ref VZ_LPRC_VIRTUAL_LOOPS pVirtualLoops);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_ImageSaveToJpeg(IntPtr pImgInfo, string pFullPathName, int nQuality);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_IsConnected(int handle, IntPtr pStatus);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_Open(string pStrIP, ushort wPort, string pStrUserName, string pStrPassword);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_PresetProvinceIndex(int handle, int nIndex);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SerialSend(int nSerialHandle, byte[] pData, uint uSizeData);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SerialStart(int nSerialHandle, int nSerialPort, VZDEV_SERIAL_RECV_DATA_CALLBACK func, IntPtr pUserData);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VZLPRClient_SetCommonNotifyCallBack(VZLPRC_COMMON_NOTIFY_CALLBACK func, IntPtr pUserData);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SetDateTime(int nSerialHandle, ref VZ_DATE_TIME_INFO pDTInfo);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SetIOOutput(int handle, uint uChnId, int nOutput);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SetIOOutputAuto(int handle, uint uChnId, int duration);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SetPlateInfoCallBack(int handle, VZLPRC_PLATE_INFO_CALLBACK func, IntPtr pUserData, int bEnableImage);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_Setup();
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_SetVirtualLoop(int handle, ref VZ_LPRC_VIRTUAL_LOOPS pVirtualLoops);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_StartRealPlay(int handle, IntPtr hWnd);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRClient_StopRealPlay(IntPtr hWnd);
        [DllImport("VzLPRSDK.dll")]
        public static extern int VzLPRSetIsSavePlateImage(int Handle, bool bSave, string saveDir);

        [Serializable, StructLayout(LayoutKind.Sequential)]
        public struct TH_PlateResult
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10, ArraySubType=UnmanagedType.I1)]
            public char[] license;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=8, ArraySubType=UnmanagedType.I1)]
            public char[] color;
            public int nColor;
            public int nType;
            public int nConfidence;
            public int nBright;
            public int nDirection;
            public CVzClientSDK.TH_RECT rcLocation;
            public int nTime;
            public byte nCarBright;
            public byte nCarColor;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x66, ArraySubType=UnmanagedType.I1)]
            public char[] reserved;
        }

        [Serializable, StructLayout(LayoutKind.Sequential)]
        public struct TH_RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_DATE_TIME_INFO
        {
            public uint uYear;
            public uint uMonth;
            public uint uMDay;
            public uint uHour;
            public uint uMin;
            public uint uSec;
        }

        public enum VZ_LPRC_CALLBACK_TYPE : uint
        {
            VZ_LPRC_CALLBACK_CLIP_IMAGE = 3,
            VZ_LPRC_CALLBACK_COMMON_NOTIFY = 0,
            VZ_LPRC_CALLBACK_PLATE_RESULT = 4,
            VZ_LPRC_CALLBACK_PLATE_RESULT_STABLE = 5,
            VZ_LPRC_CALLBACK_PLATE_RESULT_TRIGGER = 6,
            VZ_LPRC_CALLBACK_PLATE_STR = 1,
            VZ_LPRC_CALLBACK_VIDEO = 7,
            VZ_LRPC_CALLBACK_FULL_IMAGE = 2
        }

        public enum VZ_LPRC_COMMON_NOTIFY : uint
        {
            VZ_LPRC_ACCESS_DENIED = 1,
            VZ_LPRC_IO_INPUT = 100,
            VZ_LPRC_NETWORK_ERR = 2,
            VZ_LPRC_NO_ERR = 0,
            VZ_LPRC_OFFLINE = 4,
            VZ_LPRC_ONLINE = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_LPRC_IMAGE_INFO
        {
            public uint uWidth;
            public uint uHeight;
            public uint uPitch;
            public uint uPixFmt;
            public IntPtr pBuffer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_LPRC_PROVINCE_INFO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x80, ArraySubType=UnmanagedType.I1)]
            public char[] strProvinces;
            private int nCurrIndex;
        }

        [Serializable]
        public enum VZ_LPRC_RESULT_TYPE : uint
        {
            VZ_LPRC_RESULT_FORCE_TRIGGER = 2,
            VZ_LPRC_RESULT_IO_TRIGGER = 3,
            VZ_LPRC_RESULT_REALTIME = 0,
            VZ_LPRC_RESULT_STABLE = 1,
            VZ_LPRC_RESULT_VLOOP_TRIGGER = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_LPRC_VERTEX
        {
            private uint X_1000;
            private uint Y_1000;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_LPRC_VIRTUAL_LOOP
        {
            public byte byID;
            public byte byEnable;
            public byte byDraw;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=1, ArraySubType=UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20, ArraySubType=UnmanagedType.I1)]
            public char[] strName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
            public CVzClientSDK.VZ_LPRC_VERTEX[] struVertex;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VZ_LPRC_VIRTUAL_LOOPS
        {
            public uint uNumVirtualLoop;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
            public CVzClientSDK.VZ_LPRC_VIRTUAL_LOOP[] struLoop;
        }

        public delegate int VZDEV_SERIAL_RECV_DATA_CALLBACK(int handle, StringBuilder pRecvDataBuffer, uint uRecvSize, IntPtr pUserData);

        public delegate void VZLPRC_COMMON_NOTIFY_CALLBACK(int handle, IntPtr pUserData, CVzClientSDK.VZ_LPRC_COMMON_NOTIFY eNotify, string pStrDetail);

        public delegate int VZLPRC_PLATE_INFO_CALLBACK(int handle, IntPtr pUserData, IntPtr pResult, uint uNumPlates, CVzClientSDK.VZ_LPRC_RESULT_TYPE eResultType, IntPtr pImgFull, IntPtr pImgPlateClip);

        public delegate int VZLPRC_VIDEO_CALLBACK(int handle, IntPtr pUserData, ushort wVideoID, ref CVzClientSDK.VzYUV420P pFrame);

        [StructLayout(LayoutKind.Sequential)]
        public struct VzYUV420P
        {
            public IntPtr pY;
            public IntPtr pU;
            public IntPtr pV;
            private int widthStepY;
            private int widthStepU;
            private int widthStepV;
            private int width;
            private int height;
        }
    }
}

