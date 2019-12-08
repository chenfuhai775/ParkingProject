namespace Parking.Drives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    public class ipcsdk
    {
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_BeginTalk(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_Broadcast(IntPtr hSDK, ushort nIndex);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_BroadcastGroup(IntPtr hSDK, [In, MarshalAs(UnmanagedType.LPStr)] string pcIndex);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_Capture(IntPtr hSDK, byte[] pcPicData, uint u32PicSize, ref uint pu32PicLen);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_Close(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_ControlAlarmOut(IntPtr hSDK, uint u32Index);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_EndTalk(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_Fini();
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetAlarmOutConfig(IntPtr hSDK, uint u32Index, ref uint pu32IdleState, ref uint pu32DelayTime, ref uint pu32Reserve);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetCameraInfo(IntPtr hSDK, ref ICE_CameraInfo pstCameraInfo);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetDevID(IntPtr hSDK, StringBuilder szDevID);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetIPAddr(IntPtr hSDK, ref uint pu32IP, ref uint pu32Mask, ref uint pu32Gateway);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetLoop(IntPtr hSDK, ref uint nLeft, ref uint nBottom, ref uint nRight, ref uint nTop, uint nWidth, uint nHeight);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetStatus(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetTriggerMode(IntPtr hSDK, ref uint pu32TriggerMode);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_GetUARTCfg(IntPtr hSDK, ref ICE_UART_PARAM pstUARTCfg);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_Init();
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_LogConfig(int openLog, string logPath);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_Open([In, MarshalAs(UnmanagedType.LPStr)] string pcIP, byte u8OverTCP, ushort u16RTSPPort, ushort u16ICEPort, ushort u16OnvifPort, byte u8MainStream, uint pfOnStream, IntPtr pvStreamParam, uint pfOnFrame, IntPtr pvFrameParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_Open_Passwd([In, MarshalAs(UnmanagedType.LPStr)] string pcIP, [In, MarshalAs(UnmanagedType.LPStr)] string pcPasswd, byte u8OverTCP, ushort u16RTSPPort, ushort u16ICEPort, ushort u16OnvifPort, byte u8MainStream, uint pfOnStream, IntPtr pvStreamParam, uint pfOnFrame, IntPtr pvFrameParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_OpenDevice([In, MarshalAs(UnmanagedType.LPStr)] string pcIP);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_OpenDevice_Passwd([In, MarshalAs(UnmanagedType.LPStr)] string pcIP, [In, MarshalAs(UnmanagedType.LPStr)] string pcPasswd);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_OpenGate(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_OpenPreview([In, MarshalAs(UnmanagedType.LPStr)] string pcIP, byte u8OverTCP, byte u8MainStream, uint hWnd, ICE_IPCSDK_OnPlate pfOnPlate, IntPtr pvPlateParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ICE_IPCSDK_OpenPreview_Passwd([In, MarshalAs(UnmanagedType.LPStr)] string pcIP, [MarshalAs(UnmanagedType.LPStr)] string pcPasswd, byte u8OverTCP, byte u8MainStream, uint hWnd, ICE_IPCSDK_OnPlate pfOnPlate, IntPtr pvPlateParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_ReadUserData(IntPtr hSDK, byte[] pcData, int nSize);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_ReadUserData_Binary(IntPtr hSDK, byte[] pcData, uint nSize, uint nOffset, uint nLen);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_Reboot(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SearchDev(StringBuilder szDevs);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetAlarmOutConfig(IntPtr hSDK, uint u32Index, uint u32IdleState, uint u32DelayTime, uint u32Reserve);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetCity(IntPtr hSDK, uint u32Index);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetDeviceEventCallBack(IntPtr hSDK, ICE_IPCSDK_OnDeviceEvent pfOnDeviceEvent, IntPtr pvDeviceEventParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetFrameCallback(IntPtr hSDK, ICE_IPCSDK_OnFrame_Planar pfOnFrame, IntPtr pvParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetIPAddr(IntPtr hSDK, uint u32IP, uint u32Mask, uint u32Gateway);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetLoop(IntPtr hSDK, uint nLeft, uint nBottom, uint nRight, uint nTop, uint nWidth, uint nHeight);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetOSDCfg(IntPtr hSDK, ref ICE_OSDAttr_S pstOSDAttr);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetPastPlateCallBack(IntPtr hSDK, ICE_IPCSDK_OnPastPlate pfOnPastPlate, IntPtr pvPastPlateParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetPlateCallback(IntPtr hSDK, ICE_IPCSDK_OnPlate pfOnPlate, IntPtr pvParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetSerialPortCallBack(IntPtr hSDK, ICE_IPCSDK_OnSerialPort pfOnSerialPort, IntPtr pvSerialPortParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_SetSerialPortCallBack_RS232(IntPtr hSDK, ICE_IPCSDK_OnSerialPort_RS232 pfOnSerialPort, IntPtr pvSerialPortParam);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetTriggerMode(IntPtr hSDK, uint u32TriggerMode);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SetUARTCfg(IntPtr hSDK, ref ICE_UART_PARAM pstUARTCfg);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_StartRecord(IntPtr hSDK, [In, MarshalAs(UnmanagedType.LPStr)] string pcFileName);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_StartStream(IntPtr hSDK, byte u8MainStream, uint hWnd);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_StopRecord(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void ICE_IPCSDK_StopStream(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_SyncTime(IntPtr hSDK, ushort u16Year, byte u8Month, byte u8Day, byte u8Hour, byte u8Min, byte u8Sec);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_TransSerialPort(IntPtr hSDK, string pcData, uint u32Len);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_TransSerialPort_RS232(IntPtr hSDK, string pcData, uint u32Len);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_Trigger(IntPtr hSDK, StringBuilder pcNumber, StringBuilder pcColor, byte[] pcPicData, uint u32PicSize, ref uint pu32PicLen);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_TriggerExt(IntPtr hSDK);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern float ICE_IPCSDK_VBR_CompareFeat(float[] _pfResFeat1, uint _iFeat1Len, float[] _pfReaFeat2, uint _iFeat2Len);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_WriteUserData(IntPtr hSDK, [In, MarshalAs(UnmanagedType.LPStr)] string pcData);
        [DllImport("ice_ipcsdk.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ICE_IPCSDK_WriteUserData_Binary(IntPtr hSDK, [In, MarshalAs(UnmanagedType.LPStr)] string pcData, uint nOffset, uint nLen);

        public delegate void ICE_IPCSDK_OnDeviceEvent(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, uint u32EventType, uint u32EventData1, uint u32EventData2, uint u32EventData3, uint u32EventData4);

        public delegate void ICE_IPCSDK_OnFrame_Planar(IntPtr pvParam, uint u32Timestamp, IntPtr pu8DataY, IntPtr pu8DataU, IntPtr pu8DataV, int s32LinesizeY, int s32LinesizeU, int s32LinesizeV, int s32Width, int s32Height);

        public delegate void ICE_IPCSDK_OnPastPlate(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, uint u32CapTime, [In, MarshalAs(UnmanagedType.LPStr)] string pcNumber, [In, MarshalAs(UnmanagedType.LPStr)] string pcColor, IntPtr pcPicData, uint u32PicLen, IntPtr pcCloseUpPicData, uint u32CloseUpPicLen, short s16PlatePosLeft, short s16PlatePosTop, short s16PlatePosRight, short s16PlatePosBottom, float fPlateConfidence, uint u32VehicleColor, uint u32PlateType, uint u32VehicleDir, uint u32AlarmType, uint u32Reserved1, uint u32Reserved2, uint u32Reserved3, uint u32Reserved4);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ICE_IPCSDK_OnPlate(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, [In, MarshalAs(UnmanagedType.LPStr)] string pcNumber, [In, MarshalAs(UnmanagedType.LPStr)] string pcColor, IntPtr pcPicData, uint u32PicLen, IntPtr pcCloseUpPicData, uint u32CloseUpPicLen, short nSpeed, short nVehicleType, short nReserved1, short nReserved2, float fPlateConfidence, uint u32VehicleColor, uint u32PlateType, uint u32VehicleDir, uint u32AlarmType, uint u32SerialNum, uint uCapTime, uint u32ResultHigh, uint u32ResultLow);

        public delegate void ICE_IPCSDK_OnSerialPort(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, IntPtr pcData, uint u32Len);

        public delegate void ICE_IPCSDK_OnSerialPort_RS232(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, IntPtr pcData, uint u32Len);
    }
}

