namespace Parking.Drives
{
    using Parking.Core.Structs;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    internal class DevInstanceMgr
    {
        public static Dictionary<string, DevInfo> dicIPDevInfo = new Dictionary<string, DevInfo>();
        private static List<DataArrivedDeleteInfo> lsDataArrivedDeleteInfo = new List<DataArrivedDeleteInfo>();
        private static List<DevStateChangeDeleteInfo> lsDevStateChangeDeleteInfo = new List<DevStateChangeDeleteInfo>();
        public static List<IP_HandleInfo> lsHandleIP = new List<IP_HandleInfo>();
        private static List<SEQInfo> lsSeq = new List<SEQInfo>();

        private static void DataArrivedDeleteAdd(int devhandle, string ip, DataArrivedEventHandler onDataArrivedEvent)
        {
            DataArrivedDeleteInfo item = new DataArrivedDeleteInfo {
                devHandle = devhandle,
                ip = ip,
                OnDataArrivedEvent = onDataArrivedEvent
            };
            lsDataArrivedDeleteInfo.Add(item);
        }

        private static DataArrivedEventHandler DataArrivedDeleteFind(int devhandle)
        {
            DataArrivedDeleteInfo info = null;
            info = lsDataArrivedDeleteInfo.Find(m_DataArrivedDeleteInfo => m_DataArrivedDeleteInfo.devHandle == devhandle);
            if (info == null)
            {
                return null;
            }
            return info.OnDataArrivedEvent;
        }

        private static DataArrivedEventHandler DataArrivedDeleteFindByIP(string ip)
        {
            DataArrivedDeleteInfo info = null;
            info = lsDataArrivedDeleteInfo.Find(m_DataArrivedDeleteInfo => m_DataArrivedDeleteInfo.ip == ip);
            if (info == null)
            {
                return null;
            }
            return info.OnDataArrivedEvent;
        }

        private static void DataArrivedDeleteRemove(int devhandle)
        {
            lsDataArrivedDeleteInfo.RemoveAll(m_DataArrivedDeleteInfo => m_DataArrivedDeleteInfo.devHandle == devhandle);
        }

        private static void DataArrivedDeleteRemoveByIP(string ip)
        {
            lsDataArrivedDeleteInfo.RemoveAll(m_DataArrivedDeleteInfo => m_DataArrivedDeleteInfo.ip == ip);
        }

        public static void DevAdd(int type, string ip, int port)
        {
            DevInfo info = new DevInfo();
            if (!dicIPDevInfo.ContainsKey(ip))
            {
                info.type = type;
                info.devIP = ip;
                info.devPort = port;
                info.devHandle = -1;
                info.devCnt = 1;
                info.led_BASICCONFIG_STRUCT.volume = 3;
                dicIPDevInfo.Add(ip, info);
            }
        }

        private static bool DevConCntDecrementing(string ip)
        {
            return false;
        }

        private static bool DevConCntIncrement(string ip)
        {
            return false;
        }

        private static bool DevConCntIsZero(string ip)
        {
            return false;
        }

        public static int DevFindDevHandle(string ip)
        {
            int devHandle = -1;
            if (dicIPDevInfo.ContainsKey(ip))
            {
                devHandle = dicIPDevInfo[ip].devHandle;
            }
            return devHandle;
        }

        public static DeviceMonitorEventArgs DevFindDeviceMonitorEventArgs(string ip)
        {
            DeviceMonitorEventArgs deviceMonitorEventArgs = null;
            DevInfo info = null;
            if (dicIPDevInfo.ContainsKey(ip))
            {
                info = dicIPDevInfo[ip];
                deviceMonitorEventArgs = info.deviceMonitorEventArgs;
            }
            return deviceMonitorEventArgs;
        }

        public static string DevFindDevIP(int devHandle)
        {
            return HandleIPFindIP(devHandle);
        }

        public static int DevFindDevPort(string ip)
        {
            int devPort = 0x1388;
            if (dicIPDevInfo.ContainsKey(ip))
            {
                devPort = dicIPDevInfo[ip].devPort;
            }
            return devPort;
        }

        public static int DevFindDevVolumeByHandle(int handle)
        {
            int volume = 3;
            string key = string.Empty;
            key = HandleIPFindIP(handle);
            if (dicIPDevInfo.ContainsKey(key))
            {
                volume = dicIPDevInfo[key].led_BASICCONFIG_STRUCT.volume;
            }
            return volume;
        }

        public static int DevFindDevVolumeByIP(string ip)
        {
            int volume = 3;
            if (dicIPDevInfo.ContainsKey(ip))
            {
                volume = dicIPDevInfo[ip].led_BASICCONFIG_STRUCT.volume;
            }
            return volume;
        }

        private static bool DevFindIsCon_DZ(string ip)
        {
            return false;
        }

        private static bool DevFindIsCon_LED(string ip)
        {
            return false;
        }

        public static void DevRemoveByDevhandle(int devhandle)
        {
            int num = -1;
            num = lsHandleIP.FindIndex(m_IP_HandleInfo => m_IP_HandleInfo.handle == devhandle);
            if ((num != -1) && dicIPDevInfo.ContainsKey(lsHandleIP[num].ip))
            {
                dicIPDevInfo.Remove(lsHandleIP[num].ip);
            }
            lsHandleIP.RemoveAll(m_IP_HandleInfo => m_IP_HandleInfo.handle == devhandle);
        }

        public static void DevRemoveByDevIP(string ip)
        {
            if (dicIPDevInfo.ContainsKey(ip))
            {
                dicIPDevInfo.Remove(ip);
            }
            lsHandleIP.RemoveAll(m_IP_HandleInfo => m_IP_HandleInfo.ip == ip);
        }

        private static void DevReSetConFlag(int devType, string ip)
        {
        }

        public static bool DevSetConCnt(string ip, int conflag)
        {
            bool flag = false;
            if (dicIPDevInfo.ContainsKey(ip))
            {
                if (!dicIPDevInfo[ip].conState)
                {
                    return flag;
                }
                if (conflag == 1)
                {
                    DevInfo local1 = dicIPDevInfo[ip];
                    local1.conCnt++;
                    flag = true;
                }
                if ((conflag == 2) && (dicIPDevInfo[ip].conCnt > 1))
                {
                    DevInfo local2 = dicIPDevInfo[ip];
                    local2.conCnt--;
                    DevInfo local3 = dicIPDevInfo[ip];
                    local3.conDecreaseCnt++;
                    flag = true;
                }
            }
            return flag;
        }

        private static void DevSetConFlag(int devType, string ip)
        {
        }

        public static bool DevSetConState(bool conState, int devhandle, string ip)
        {
            int num;
            bool flag = false;
            if (!dicIPDevInfo.ContainsKey(ip))
            {
                return flag;
            }
            if (conState)
            {
                dicIPDevInfo[ip].conState = true;
                dicIPDevInfo[ip].devHandle = devhandle;
                dicIPDevInfo[ip].conCnt = 1;
                if (HandleIPIsHaveIP(ip))
                {
                    num = HandleIPFindIndexByIP(ip);
                    if (num != -1)
                    {
                        lsHandleIP[num].handle = devhandle;
                    }
                }
                else
                {
                    IP_HandleInfo item = new IP_HandleInfo {
                        handle = devhandle,
                        ip = ip
                    };
                    lsHandleIP.Add(item);
                }
            }
            else
            {
                dicIPDevInfo[ip].conState = false;
                dicIPDevInfo[ip].devHandle = -1;
                if (HandleIPIsHaveIP(ip))
                {
                    num = HandleIPFindIndexByIP(ip);
                    if (num != -1)
                    {
                        lsHandleIP[num].handle = -1;
                    }
                }
            }
            return true;
        }

        public static bool DevSetDevCnt(string ip, int devflag)
        {
            bool flag = false;
            if (!dicIPDevInfo.ContainsKey(ip))
            {
                return flag;
            }
            if (devflag == 1)
            {
                DevInfo local1 = dicIPDevInfo[ip];
                local1.devCnt++;
                flag = true;
            }
            if ((devflag != 2) || (dicIPDevInfo[ip].devCnt <= 1))
            {
                return flag;
            }
            DevInfo local2 = dicIPDevInfo[ip];
            local2.devCnt--;
            if (dicIPDevInfo[ip].conCnt > 1)
            {
                if (dicIPDevInfo[ip].conDecreaseCnt <= 0)
                {
                    DevInfo local3 = dicIPDevInfo[ip];
                    local3.conCnt--;
                }
                else
                {
                    DevInfo local4 = dicIPDevInfo[ip];
                    local4.conDecreaseCnt--;
                }
            }
            return true;
        }

        public static int HandleIPFindHandle(string ip)
        {
            int handle = -1;
            IP_HandleInfo info = lsHandleIP.Find(m_IP_HandleInfo => m_IP_HandleInfo.ip == ip);
            if (info != null)
            {
                handle = info.handle;
            }
            return handle;
        }

        public static int HandleIPFindIndexByHandle(int handle)
        {
            return lsHandleIP.FindIndex(m_IP_HandleInfo => m_IP_HandleInfo.handle == handle);
        }

        public static int HandleIPFindIndexByIP(string ip)
        {
            return lsHandleIP.FindIndex(m_IP_HandleInfo => m_IP_HandleInfo.ip == ip);
        }

        public static string HandleIPFindIP(int handle)
        {
            string ip = string.Empty;
            IP_HandleInfo info = lsHandleIP.Find(m_IP_HandleInfo => m_IP_HandleInfo.handle == handle);
            if (info != null)
            {
                ip = info.ip;
            }
            return ip;
        }

        public static bool HandleIPIsHaveHandle(int handle)
        {
            bool flag = false;
            if (lsHandleIP.Find(m_IP_HandleInfo => m_IP_HandleInfo.handle == handle) != null)
            {
                flag = true;
            }
            return flag;
        }

        public static bool HandleIPIsHaveIP(string ip)
        {
            bool flag = false;
            if (lsHandleIP.Find(m_IP_HandleInfo => m_IP_HandleInfo.ip == ip) != null)
            {
                flag = true;
            }
            return flag;
        }

        public static bool lsDevInfoIsNULL()
        {
            bool flag = false;
            if (dicIPDevInfo.Count > 0)
            {
                flag = true;
            }
            return flag;
        }

        public static void RemoveOutTimeSeqPro()
        {
            while (true)
            {
                SEQRemove();
                Thread.Sleep(200);
            }
        }

        public static void SEQAdd(SEQInfo SEQInfo)
        {
            DevInstanceMgr.SEQInfo item = new DevInstanceMgr.SEQInfo {
                SEQ = SEQInfo.SEQ,
                TimeStamp = DateTime.Now,
                Data = SEQInfo.Data
            };
            lsSeq.Add(item);
        }

        public static SEQInfo SEQFindInfo(int seq)
        {
            return lsSeq.Find(_SEQInfo => _SEQInfo.SEQ == seq);
        }

        public static bool SEQIsFind(int seq)
        {
            bool flag = false;
            SEQInfo info = lsSeq.Find(m_SEQInfo => m_SEQInfo.SEQ == seq);
            if (info == null)
            {
                return flag;
            }
            return (info.SEQ == seq);
        }

        public static void SEQRemove()
        {
            for (int i = 0; i < lsSeq.Count; i++)
            {
                TimeSpan span = (TimeSpan) (DateTime.Now - lsSeq[i].TimeStamp);
                if (span.TotalMilliseconds > 3000.0)
                {
                    lsSeq.Remove(lsSeq[i]);
                }
            }
        }

        private static void StateChangeDeleteAdd(int devhandle, string ip, StateChangedEventHandler onDeviceStateChangedEvent)
        {
            DevStateChangeDeleteInfo item = new DevStateChangeDeleteInfo {
                devHandle = devhandle,
                ip = ip,
                OnDeviceStateChangedEvent = onDeviceStateChangedEvent
            };
            lsDevStateChangeDeleteInfo.Add(item);
        }

        private static StateChangedEventHandler StateChangeDeleteFindDevOnDeviceStateChangedEvent(int devhandle)
        {
            DevStateChangeDeleteInfo info = null;
            info = lsDevStateChangeDeleteInfo.Find(m_DevStateChangeDeleteInfo => m_DevStateChangeDeleteInfo.devHandle == devhandle);
            if (info == null)
            {
                return null;
            }
            return info.OnDeviceStateChangedEvent;
        }

        private static StateChangedEventHandler StateChangeDeleteFindDevOnDeviceStateChangedEventByIP(string ip)
        {
            DevStateChangeDeleteInfo info = null;
            info = lsDevStateChangeDeleteInfo.Find(m_DevStateChangeDeleteInfo => m_DevStateChangeDeleteInfo.ip == ip);
            if (info == null)
            {
                return null;
            }
            return info.OnDeviceStateChangedEvent;
        }

        private static void StateChangeDeleteRemove(int devhandle)
        {
            lsDevStateChangeDeleteInfo.RemoveAll(m_DevStateChangeDeleteInfo => m_DevStateChangeDeleteInfo.devHandle == devhandle);
        }

        public class DataArrivedDeleteInfo
        {
            public int devHandle = 0;
            public string ip;
            public DataArrivedEventHandler OnDataArrivedEvent;
        }

        public class DevInfo
        {
            public int conCnt;
            public int conDecreaseCnt;
            public bool conState;
            public int devCnt;
            public int devHandle;
            public DeviceMonitorEventArgs deviceMonitorEventArgs = new DeviceMonitorEventArgs();
            public int devID = -1;
            public string devIP;
            public int devPort;
            public LED_BASICCONFIG_STRUCT led_BASICCONFIG_STRUCT = new LED_BASICCONFIG_STRUCT();
            public int type;
        }

        public class DevStateChangeDeleteInfo
        {
            public int devHandle = 0;
            public string ip;
            public StateChangedEventHandler OnDeviceStateChangedEvent;
        }

        public class IP_HandleInfo
        {
            public int handle;
            public string ip;
        }

        public class SEQInfo
        {
            public object Data = new object();
            public int SEQ;
            public DateTime TimeStamp = DateTime.Now;
            public int Type;
        }
    }
}

