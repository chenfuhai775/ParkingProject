namespace Parking.Drives
{
    using Parking.Core.ControlEventArgs;
    using Parking.Core.Enum;
    using Parking.Core.Structs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;

    public class LNX_SDK_Operation_X64
    {
        private static bool InitializeFlag = false;
        private static bool InitializeSucceFlag = false;
        private static lnk_sdk_interface.LNX_SDK_Interface_X64.default_send_callback_def m_default_send_callback_def;
        private static lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceStatusCallBack m_DeviceStatusCallBack;
        private static lnk_sdk_interface.LNX_SDK_Interface_X64.gate_event_callback m_gate_event_callback;
        private static lnk_sdk_interface.LNX_SDK_Interface_X64.NetStatusCallBack m_NetStatusCallBack;
        private static lnk_sdk_interface.LNX_SDK_Interface_X64.send_read_device_info_callback_def m_send_read_device_info_callback_def;
        private static int nethandle;
        private static bool SeqProThreadStartFlag = false;
        private static bool UnInitializeFlag = false;
        private static bool UnInitializeSucceFlag = false;

        public static bool BarrierSend(int devhandle, int command)
        {
            IntPtr errmsg = new IntPtr();
            bool flag = true;
            int seq = -1;
            if (command == 2)
            {
                seq = lnk_sdk_interface.LNX_SDK_Interface_X64.stop_gate(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, 500);
                if (seq == -1)
                {
                    return false;
                }
            }
            if (command == 1)
            {
                seq = lnk_sdk_interface.LNX_SDK_Interface_X64.open_gate(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, 500);
                if (seq == -1)
                {
                    return false;
                }
            }
            if (command == 0)
            {
                seq = lnk_sdk_interface.LNX_SDK_Interface_X64.close_gate(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, 500);
                if (seq == -1)
                {
                    return false;
                }
            }
            int num2 = 10;
            while (num2-- > 0)
            {
                if (DevInstanceMgr.SEQIsFind(seq))
                {
                    return true;
                }
                Thread.Sleep(100);
                flag = false;
            }
            return flag;
        }

        public static bool CloseDev(string ip)
        {
            int handle = DevInstanceMgr.DevFindDevHandle(ip);
            IntPtr errmsg = new IntPtr();
            if (lnk_sdk_interface.LNX_SDK_Interface_X64.close_device(handle, errmsg) < 0)
            {
                return false;
            }
            return true;
        }

        public static int CloseDeviceInfo(int infohandle)
        {
            return lnk_sdk_interface.LNX_SDK_Interface_X64.close_device_info_handle(infohandle);
        }

        public static int CreateDev(string ip, int port)
        {
            IntPtr errmsg = new IntPtr();
            int devhandle = lnk_sdk_interface.LNX_SDK_Interface_X64.create_device(-1, enumDevType.LX_PCUFZ01, ip, port, errmsg);
            int num2 = lnk_sdk_interface.LNX_SDK_Interface_X64.set_device_alive_status_callback(nethandle, devhandle, 0x1388, m_DeviceStatusCallBack);
            int num3 = lnk_sdk_interface.LNX_SDK_Interface_X64.set_gate_event_callback(nethandle, devhandle, m_gate_event_callback);
            return devhandle;
        }

        public static int CreateDeviceInfo()
        {
            return lnk_sdk_interface.LNX_SDK_Interface_X64.create_device_info_handle();
        }

        private static int default_send_callback_defPro(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg)
        {
            string str = Marshal.PtrToStringAnsi(errmsg);
            if (sendstatus != -10)
            {
                DevInstanceMgr.SEQInfo sEQInfo = new DevInstanceMgr.SEQInfo {
                    SEQ = sendid
                };
                DevInstanceMgr.SEQAdd(sEQInfo);
            }
            return 0;
        }

        private static void DeviceStatusCallBackPro(int nethandle, int devhandle, int alive_status, int status_handle)
        {
            string ip = string.Empty;
            ip = DevInstanceMgr.DevFindDevIP(devhandle);
            DeviceStateChangedEventArgs args = new DeviceStateChangedEventArgs(alive_status, ip);
            if (DevInstanceMgr.dicIPDevInfo.ContainsKey(ip))
            {
                if (DevInstanceMgr.dicIPDevInfo[ip].type == 1)
                {
                    LNK_BARRIER_ISDK_X64.ExuteDelegate(1, args);
                }
                if (DevInstanceMgr.dicIPDevInfo[ip].type == 2)
                {
                    LNK_LED_ISDK_X64.ExuteDelegate(1, args);
                }
            }
        }

        private static unsafe int gate_event_callbackPro(int nethandle, int devhandle, int gate_id, IntPtr pevent, int event_cnt, int event_handle)
        {
            int num;
            DataArrivedEventArgs args;
            ROADGATE_INFO_STRUCT roadgate_info_struct = new ROADGATE_INFO_STRUCT();
            if (devhandle >= 0)
            {
                byte[] source = new byte[] { 0, 4, 0, 0 };
                IntPtr ptr = Marshal.AllocHGlobal(0x400);
                IntPtr valuetype = Marshal.AllocHGlobal(4);
                IntPtr destination = Marshal.AllocHGlobal(4);
                Marshal.Copy(source, 0, destination, 4);
                lnk_sdk_interface.LNX_SDK_Interface_X64.read_device_handle(devhandle, 3, valuetype, ptr, destination);
                num = Marshal.ReadInt32(destination);
                byte[] buffer2 = new byte[num];
                Marshal.Copy(ptr, buffer2, 0, num);
                roadgate_info_struct.ip = Encoding.Default.GetString(buffer2).Trim();
                Marshal.FreeHGlobal(ptr);
                Marshal.FreeHGlobal(valuetype);
                Marshal.FreeHGlobal(destination);
            }
            if (event_cnt > 0)
            {
                int[] numArray = new int[event_cnt];
                Marshal.Copy(pevent, numArray, 0, event_cnt);
                for (int i = 0; i < event_cnt; i++)
                {
                    DeviceMonitorEventArgs args2;
                    if ((numArray[i] == 4) || (numArray[i] == 5))
                    {
                        roadgate_info_struct.isManual = true;
                        args = new DataArrivedEventArgs(roadgate_info_struct);
                        LNK_BARRIER_ISDK_X64.ExuteDelegate(3, args);
                    }
                    if (numArray[i] == 14)
                    {
                        args2 = DevInstanceMgr.DevFindDeviceMonitorEventArgs(roadgate_info_struct.ip);
                        args2.IP = roadgate_info_struct.ip;
                        args2.IsPressed = true;
                        LNK_BARRIER_ISDK_X64.ExuteDelegate(2, args2);
                    }
                    if (numArray[i] == 15)
                    {
                        args2 = DevInstanceMgr.DevFindDeviceMonitorEventArgs(roadgate_info_struct.ip);
                        args2.IP = roadgate_info_struct.ip;
                        args2.IsPressed = false;
                        LNK_BARRIER_ISDK_X64.ExuteDelegate(2, args2);
                    }
                    if (numArray[i] == 0x18)
                    {
                        args2 = DevInstanceMgr.DevFindDeviceMonitorEventArgs(roadgate_info_struct.ip);
                        args2.IP = roadgate_info_struct.ip;
                        args2.State = 0;
                        LNK_BARRIER_ISDK_X64.ExuteDelegate(2, args2);
                    }
                    if (numArray[i] == 0x1c)
                    {
                        args2 = DevInstanceMgr.DevFindDeviceMonitorEventArgs(roadgate_info_struct.ip);
                        args2.IP = roadgate_info_struct.ip;
                        args2.State = 1;
                        LNK_BARRIER_ISDK_X64.ExuteDelegate(2, args2);
                    }
                }
            }
            if (event_handle >= 0)
            {
                int num4;
                int num3 = 0;
                num = 4;
                if ((lnk_sdk_interface.LNX_SDK_Interface_X64.read_gate_event(nethandle, devhandle, gate_id, event_handle, 11, &num3, (void*) &num4, &num) == 0) && ((num3 == 1) && (num == 4)))
                {
                    roadgate_info_struct.Counter = num4;
                    args = new DataArrivedEventArgs(roadgate_info_struct);
                    LNK_BARRIER_ISDK_X64.ExuteDelegate(3, args);
                }
            }
            return 0;
        }

        public static string GetRealIP()
        {
            string str = string.Empty;
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface interface2 in allNetworkInterfaces)
            {
                if (interface2.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    UnicastIPAddressInformationCollection unicastAddresses = interface2.GetIPProperties().UnicastAddresses;
                    foreach (UnicastIPAddressInformation information in unicastAddresses)
                    {
                        if (information.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return information.Address.ToString();
                        }
                    }
                }
            }
            return str;
        }

        public static int InitDeviceInfo(int infohandle, int infoid, IntPtr value, int valuetype)
        {
            return lnk_sdk_interface.LNX_SDK_Interface_X64.init_device_info_handle(infohandle, infoid, value, valuetype);
        }

        public static bool Initialize()
        {
            IntPtr errmsg = new IntPtr();
            if (!SeqProThreadStartFlag)
            {
                SeqProThreadStartFlag = true;
                ThreadPool.QueueUserWorkItem(new WaitCallback(LNX_SDK_Operation_X64.SEQOutTimeRemovePro));
            }
            if (InitializeFlag)
            {
                return InitializeSucceFlag;
            }
            m_NetStatusCallBack = new lnk_sdk_interface.LNX_SDK_Interface_X64.NetStatusCallBack(LNX_SDK_Operation_X64.NetStatusCallBackPro);
            m_gate_event_callback = new lnk_sdk_interface.LNX_SDK_Interface_X64.gate_event_callback(LNX_SDK_Operation_X64.gate_event_callbackPro);
            m_DeviceStatusCallBack = new lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceStatusCallBack(LNX_SDK_Operation_X64.DeviceStatusCallBackPro);
            m_default_send_callback_def = new lnk_sdk_interface.LNX_SDK_Interface_X64.default_send_callback_def(LNX_SDK_Operation_X64.default_send_callback_defPro);
            m_send_read_device_info_callback_def = new lnk_sdk_interface.LNX_SDK_Interface_X64.send_read_device_info_callback_def(LNX_SDK_Operation_X64.send_read_device_info_callback_defPro);
            bool flag = true;
            if (lnk_sdk_interface.LNX_SDK_Interface_X64.start_application() != 0)
            {
                flag = false;
                InitializeSucceFlag = false;
                return flag;
            }
            nethandle = lnk_sdk_interface.LNX_SDK_Interface_X64.create_comm_interface(1, GetRealIP(), 0x1388, errmsg);
            if (nethandle < 0)
            {
                flag = false;
                InitializeSucceFlag = false;
                return flag;
            }
            InitializeFlag = true;
            InitializeSucceFlag = true;
            UnInitializeFlag = false;
            UnInitializeSucceFlag = false;
            return flag;
        }

        public static bool LEDSend(int devhandle, LED_PARAMETER_STRUCT param)
        {
            IntPtr errmsg = new IntPtr();
            bool flag = true;
            string ledtext = string.Empty;
            int staytime = -1;
            int loopcnt = -1;
            int seq = -1;
            if (param.Msg != null)
            {
                int num7;
                if ((param.Msg.Length + param.rowIndex) > 5)
                {
                    staytime = ((4 - param.rowIndex) + 1) * 0x5dc;
                    loopcnt = -1;
                    param.displayMode = 12;
                    ledtext = string.Empty;
                    foreach (string str2 in param.Msg)
                    {
                        char[] chArray = str2.ToArray<char>();
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < chArray.Length; i++)
                        {
                            string str4;
                            int length;
                            int num6;
                            builder.Append(chArray[i]);
                            if (Encoding.Default.GetBytes(builder.ToString()).Length == 8)
                            {
                                str4 = builder.ToString();
                                ledtext = ledtext + str4;
                                builder.Clear();
                            }
                            if (Encoding.Default.GetBytes(builder.ToString()).Length > 8)
                            {
                                builder.Remove(builder.Length - 1, 1);
                                str4 = builder.ToString();
                                length = Encoding.Default.GetBytes(str4).Length;
                                num6 = 8 - length;
                                str4 = str4.PadRight(num6 + str4.Length, ' ');
                                ledtext = ledtext + str4;
                                builder.Clear();
                                builder.Append(chArray[i]);
                            }
                            if (i == (chArray.Length - 1))
                            {
                                str4 = builder.ToString();
                                if (str4 != "")
                                {
                                    length = Encoding.Default.GetBytes(str4).Length;
                                    num6 = 8 - length;
                                    str4 = str4.PadRight(num6 + str4.Length, ' ');
                                    ledtext = ledtext + str4;
                                    builder.Clear();
                                }
                            }
                        }
                    }
                    seq = lnk_sdk_interface.LNX_SDK_Interface_X64.led_show(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, param.rowIndex, param.fontColor, param.displayMode, staytime, loopcnt, ledtext, 0);
                    if (seq == -1)
                    {
                        return false;
                    }
                    num7 = 10;
                    while (num7-- > 0)
                    {
                        if (DevInstanceMgr.SEQIsFind(seq))
                        {
                            return true;
                        }
                        Thread.Sleep(100);
                        flag = false;
                    }
                    return flag;
                }
                foreach (string str2 in param.Msg)
                {
                    ledtext = str2;
                    seq = lnk_sdk_interface.LNX_SDK_Interface_X64.led_show(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, param.rowIndex++, param.fontColor, param.displayMode, staytime, loopcnt, ledtext, 0);
                    if (seq == -1)
                    {
                        return false;
                    }
                    num7 = 10;
                    while (num7-- > 0)
                    {
                        if (DevInstanceMgr.SEQIsFind(seq))
                        {
                            flag = true;
                            break;
                        }
                        Thread.Sleep(100);
                        flag = false;
                    }
                }
            }
            return flag;
        }

        public static bool ModifyDeviceInfo(int devhandle, string deviceName, string ip, int port, string mac)
        {
            string s = ReadDeviceUID(devhandle);
            bool flag = false;
            bool flag2 = false;
            if (s != null)
            {
                IntPtr errmsg = new IntPtr();
                IntPtr destination = new IntPtr();
                IntPtr ptr3 = new IntPtr();
                IntPtr ptr4 = new IntPtr();
                IntPtr ptr5 = new IntPtr();
                IntPtr ptr6 = new IntPtr();
                int infohandle = -1;
                if (s != null)
                {
                    infohandle = CreateDeviceInfo();
                    if (infohandle == -1)
                    {
                        flag = false;
                    }
                    byte[] bytes = Encoding.Default.GetBytes(s);
                    destination = Marshal.AllocHGlobal(bytes.Length);
                    Marshal.Copy(bytes, 0, destination, bytes.Length);
                    InitDeviceInfo(infohandle, 5, destination, 2);
                }
                else
                {
                    flag = false;
                }
                if (deviceName != null)
                {
                    byte[] source = Encoding.Default.GetBytes(deviceName + "\0");
                    ptr3 = Marshal.AllocHGlobal(source.Length);
                    Marshal.Copy(source, 0, ptr3, source.Length);
                    InitDeviceInfo(infohandle, 14, ptr3, 2);
                    flag2 = true;
                }
                if (ip != null)
                {
                    byte[] buffer3 = Encoding.Default.GetBytes(ip + "\0");
                    ptr4 = Marshal.AllocHGlobal(buffer3.Length);
                    Marshal.Copy(buffer3, 0, ptr4, buffer3.Length);
                    InitDeviceInfo(infohandle, 10, ptr4, 2);
                    flag2 = true;
                }
                if (port != -1)
                {
                    byte[] buffer4 = BitConverter.GetBytes(port);
                    ptr5 = Marshal.AllocHGlobal(4);
                    Marshal.Copy(buffer4, 0, ptr5, 4);
                    InitDeviceInfo(infohandle, 11, ptr5, 1);
                    flag2 = true;
                }
                if (mac != null)
                {
                    byte[] buffer5 = Encoding.Default.GetBytes(mac + "\0");
                    ptr6 = Marshal.AllocHGlobal(buffer5.Length);
                    Marshal.Copy(buffer5, 0, ptr6, buffer5.Length);
                    InitDeviceInfo(infohandle, 7, ptr6, 2);
                    flag2 = true;
                }
                if (flag2 && (lnk_sdk_interface.LNX_SDK_Interface_X64.modify_device_info(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, infohandle) == -1))
                {
                    flag = false;
                }
                Thread.Sleep(0x3e8);
                CloseDeviceInfo(infohandle);
                Marshal.FreeHGlobal(destination);
                Marshal.FreeHGlobal(ptr3);
                Marshal.FreeHGlobal(ptr4);
                Marshal.FreeHGlobal(ptr5);
                Marshal.FreeHGlobal(ptr6);
            }
            return flag;
        }

        private static void NetStatusCallBackPro(int nethandle, int status, IntPtr errmsg)
        {
            string str = Marshal.PtrToStringAnsi(errmsg);
        }

        private static string read_device_handle(int devhandle)
        {
            string str = string.Empty;
            IntPtr valuetype = new IntPtr();
            valuetype = Marshal.AllocHGlobal(4);
            IntPtr ptr2 = new IntPtr();
            ptr2 = Marshal.AllocHGlobal(0x400);
            IntPtr valuelen = new IntPtr();
            valuelen = Marshal.AllocHGlobal(4);
            for (int i = 1; i <= 4; i++)
            {
                int num2 = lnk_sdk_interface.LNX_SDK_Interface_X64.read_device_handle(devhandle, i, valuetype, ptr2, valuelen);
                int num3 = Marshal.ReadInt32(valuetype);
                if ((num2 == 0) && (num3 != 0))
                {
                    switch (i)
                    {
                        case 3:
                        {
                            byte[] bytes = new byte[Marshal.ReadInt32(valuelen)];
                            bytes = (byte[]) Marshal.PtrToStructure(ptr2, typeof(byte[]));
                            str = Encoding.Default.GetString(bytes).Trim();
                            break;
                        }
                    }
                }
            }
            return str;
        }

        public static string[] ReadDeviceInfo(int devhandle)
        {
            IntPtr errmsg = new IntPtr();
            errmsg = Marshal.AllocHGlobal(0x400);
            List<string> list = new List<string>();
            string[] strArray = null;
            lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct data = new lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct();
            DevInstanceMgr.SEQInfo info = new DevInstanceMgr.SEQInfo();
            int seq = lnk_sdk_interface.LNX_SDK_Interface_X64.read_device_info(nethandle, devhandle, 300, 3, m_send_read_device_info_callback_def, errmsg);
            string str = Marshal.PtrToStringAnsi(errmsg);
            Marshal.FreeHGlobal(errmsg);
            if (seq == -1)
            {
                return strArray;
            }
            int num2 = 10;
            while (num2-- > 0)
            {
                info = DevInstanceMgr.SEQFindInfo(seq);
                if (info != null)
                {
                    data = (lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct) info.Data;
                    break;
                }
                Thread.Sleep(100);
            }
            list.Add(new string(data.hardname));
            list.Add(new string(data.softver));
            list.Add(new string(data.macaddr));
            return list.ToArray();
        }

        public static string ReadDeviceUID(int devhandle)
        {
            IntPtr errmsg = new IntPtr();
            errmsg = Marshal.AllocHGlobal(0x400);
            string str = null;
            lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct data = new lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct();
            DevInstanceMgr.SEQInfo info = new DevInstanceMgr.SEQInfo();
            int seq = lnk_sdk_interface.LNX_SDK_Interface_X64.read_device_info(nethandle, devhandle, 300, 3, m_send_read_device_info_callback_def, errmsg);
            string str2 = Marshal.PtrToStringAnsi(errmsg);
            Marshal.FreeHGlobal(errmsg);
            if (seq == -1)
            {
                return str;
            }
            int num2 = 10;
            while (num2-- > 0)
            {
                info = DevInstanceMgr.SEQFindInfo(seq);
                if (info != null)
                {
                    data = (lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct) info.Data;
                    break;
                }
                Thread.Sleep(100);
            }
            return new string(data.uid);
        }

        private static int send_read_device_info_callback_defPro(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg, IntPtr devinfo)
        {
            string str = Marshal.PtrToStringAnsi(errmsg);
            if (sendstatus != -10)
            {
                lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct struct2 = (lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct) Marshal.PtrToStructure(devinfo, typeof(lnk_sdk_interface.LNX_SDK_Interface_X64.DeviceInfoStruct));
                DevInstanceMgr.SEQInfo sEQInfo = new DevInstanceMgr.SEQInfo {
                    SEQ = sendid,
                    Data = struct2
                };
                DevInstanceMgr.SEQAdd(sEQInfo);
            }
            return 0;
        }

        public static void SEQOutTimeRemovePro(object obj)
        {
            DevInstanceMgr.RemoveOutTimeSeqPro();
        }

        public static bool SetDeviceVolume(LED_BASICCONFIG_STRUCT param)
        {
            bool flag = false;
            if (DevInstanceMgr.dicIPDevInfo.ContainsKey(param.ip))
            {
                DevInstanceMgr.dicIPDevInfo[param.ip].led_BASICCONFIG_STRUCT.volume = param.volume / 10;
                flag = true;
            }
            return flag;
        }

        public static bool UnInitialize()
        {
            IntPtr errmsg = new IntPtr();
            if (DevInstanceMgr.lsDevInfoIsNULL())
            {
                return true;
            }
            bool flag = true;
            if (UnInitializeFlag)
            {
                return UnInitializeSucceFlag;
            }
            if (lnk_sdk_interface.LNX_SDK_Interface_X64.close_comm_interface(nethandle, errmsg) < 0)
            {
                flag = false;
                UnInitializeSucceFlag = false;
                return flag;
            }
            if (lnk_sdk_interface.LNX_SDK_Interface_X64.start_application() != 0)
            {
                flag = false;
                UnInitializeSucceFlag = false;
                return flag;
            }
            UnInitializeFlag = true;
            UnInitializeSucceFlag = true;
            InitializeFlag = false;
            InitializeSucceFlag = false;
            return flag;
        }

        public static bool VoiceSend(int devhandle, VOICE_PARAMETER_STRUCT param)
        {
            bool flag = true;
            IntPtr errmsg = new IntPtr();
            int seq = lnk_sdk_interface.LNX_SDK_Interface_X64.voice_cmd(nethandle, devhandle, 300, 3, m_default_send_callback_def, errmsg, param.volume, param.content, 1);
            if (seq == -1)
            {
                return false;
            }
            int num2 = 10;
            while (num2-- > 0)
            {
                if (DevInstanceMgr.SEQIsFind(seq))
                {
                    return true;
                }
                Thread.Sleep(100);
                flag = false;
            }
            return flag;
        }
    }
}

