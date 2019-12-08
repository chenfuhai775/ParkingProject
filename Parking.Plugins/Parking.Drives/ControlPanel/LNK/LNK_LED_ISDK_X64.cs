namespace Parking.Drives
{
    using Parking.Core.ControlEventArgs;
    using Parking.Core.Structs;
    using System;
    using System.Threading;

    public static class LNK_LED_ISDK_X64
    {
        private static string ip = string.Empty;
        private static int port = 0;

        public static  event StateChangedEventHandler OnDeviceStateChangedEvent;

        public static bool Connect(string m_ip)
        {
            bool flag = false;
            if (DevInstanceMgr.DevSetConCnt(m_ip, 1))
            {
                return true;
            }
            int devhandle = LNX_SDK_Operation_X64.CreateDev(m_ip, DevInstanceMgr.DevFindDevPort(m_ip));
            if ((devhandle >= 0) && DevInstanceMgr.DevSetConState(true, devhandle, m_ip))
            {
                flag = true;
            }
            return flag;
        }

        public static bool DisConnect(string ip)
        {
            bool flag = false;
            if (DevInstanceMgr.DevSetConCnt(ip, 2))
            {
                return true;
            }
            flag = LNX_SDK_Operation_X64.CloseDev(ip);
            if (flag && DevInstanceMgr.DevSetConState(false, -1, ip))
            {
                flag = true;
            }
            return flag;
        }

        public static void ExuteDelegate(int eventtype, object obj)
        {
            int num = eventtype;
            if ((num == 1) && (OnDeviceStateChangedEvent != null))
            {
                OnDeviceStateChangedEvent(new object(), (DeviceStateChangedEventArgs) obj);
            }
        }

        public static string[] GetDeviceInfo(string ip)
        {
            string[] strArray = null;
            if (DevInstanceMgr.dicIPDevInfo.ContainsKey(ip) && !DevInstanceMgr.dicIPDevInfo[ip].conState)
            {
                return strArray;
            }
            return LNX_SDK_Operation_X64.ReadDeviceInfo(DevInstanceMgr.DevFindDevHandle(ip));
        }

        public static bool Initialize(string ip, int m_port, string userName, string passWord)
        {
            bool flag = false;
            if (DevInstanceMgr.DevSetDevCnt(ip, 1))
            {
                return true;
            }
            flag = LNX_SDK_Operation_X64.Initialize();
            if (flag)
            {
                DevInstanceMgr.DevAdd(2, ip, m_port);
            }
            return flag;
        }

        public static bool SendCommand(LED_PARAMETER_STRUCT param)
        {
            bool flag = false;
            if (param.Msg == null)
            {
                return flag;
            }
            if (DevInstanceMgr.dicIPDevInfo.ContainsKey(param.ip))
            {
                if (!DevInstanceMgr.dicIPDevInfo[param.ip].conState)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return LNX_SDK_Operation_X64.LEDSend(DevInstanceMgr.DevFindDevHandle(param.ip), param);
        }

        public static bool SetDeviceInfo(LED_NETCONFIG_STRUCT param)
        {
            return LNX_SDK_Operation_X64.ModifyDeviceInfo(DevInstanceMgr.DevFindDevHandle(param.srcip), param.deviceName, param.desip, param.port, param.mac);
        }

        public static bool SetDeviceInfoEX(LED_BASICCONFIG_STRUCT param)
        {
            return LNX_SDK_Operation_X64.SetDeviceVolume(param);
        }

        public static bool UnInitialize(string ip)
        {
            if (DevInstanceMgr.DevSetDevCnt(ip, 2))
            {
                return true;
            }
            DevInstanceMgr.DevRemoveByDevIP(ip);
            return LNX_SDK_Operation_X64.UnInitialize();
        }

        public static bool VoviceSend(VOICE_PARAMETER_STRUCT param)
        {
            return LNX_SDK_Operation_X64.VoiceSend(DevInstanceMgr.DevFindDevHandle(param.ip), param);
        }
    }
}

