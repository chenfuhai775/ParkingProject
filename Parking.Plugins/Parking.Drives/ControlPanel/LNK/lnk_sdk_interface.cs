namespace Parking.Drives
{
    using Parking.Core.Enum;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class lnk_sdk_interface
    {
        public class LNX_SDK_Interface_X64
        {
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int close_application();
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int close_comm_interface(int handle, IntPtr errmsg);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int close_device(int handle, IntPtr errmsg);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int close_device_info_handle(int infohandle);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int close_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int create_comm_interface(int interface_type, string inerface_info, int port, IntPtr errmsg);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int create_device(int devid, enumDevType devtype, string ip, int port, IntPtr errmsg);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int create_device_info_handle();
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int init_device_info_handle(int infohandle, int infoid, IntPtr value, int valuetype);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int led_show(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int areaid, int color, int ledstyle, int staytime, int loopcnt, string ledtext, int lockflag);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int modify_device_info(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int infohandle);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int open_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int read_device_handle(int devhandle, int handleinfoid, IntPtr valuetype, IntPtr value, IntPtr valuelen);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int read_device_info(int nethandle, int devhandle, int timeout, int retrycnt, send_read_device_info_callback_def func, IntPtr errmsg);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern unsafe int read_gate_event(int nethandle, int devhandle, int gate_id, int event_handle, int eventid, int* valuetype, void* value, int* valuelen);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int set_comm_interface_status_callback(int handle, NetStatusCallBack netstatus_cb);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int set_device_alive_status_callback(int nethandle, int devhandle, int timeout, DeviceStatusCallBack devicestatus_cb);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int set_gate_event_callback(int nethandle, int devhandle, gate_event_callback gateevent_cb);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int start_application();
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int stop_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X64\lnk_api.dll")]
            public static extern int voice_cmd(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int volume, string voicetext, int lockflag);

            public delegate int default_send_callback_def(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg);

            [StructLayout(LayoutKind.Sequential)]
            public struct DeviceInfoStruct
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] hardname;
                public int hardtype;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] hardver;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] softver;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] uid;
                public int deviceid;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] macaddr;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] gateway;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] netmask;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] deviceip;
                public int deviceport;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] stationip;
                public int stationport;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x40)]
                public char[] devname;
            }

            public delegate void DeviceStatusCallBack(int nethandle, int devhandle, int alive_status, int status_handle);

            public delegate int gate_event_callback(int nethandle, int devhandle, int gate_id, IntPtr pevent, int event_cnt, int event_handle);

            public delegate void NetStatusCallBack(int nethandle, int status, IntPtr errmsg);

            public delegate int send_read_device_info_callback_def(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg, IntPtr devinfo);
        }

        public class LNX_SDK_Interface_X86
        {
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int close_application();
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int close_comm_interface(int handle, IntPtr errmsg);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int close_device(int handle, IntPtr errmsg);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int close_device_info_handle(int infohandle);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int close_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int create_comm_interface(int interface_type, string inerface_info, int port, IntPtr errmsg);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int create_device(int devid, enumDevType devtype, string ip, int port, IntPtr errmsg);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int create_device_info_handle();
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int init_device_info_handle(int infohandle, int infoid, IntPtr value, int valuetype);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int led_show(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int areaid, int color, int ledstyle, int staytime, int loopcnt, string ledtext, int lockflag);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int modify_device_info(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int infohandle);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int open_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int read_device_handle(int devhandle, int handleinfoid, IntPtr valuetype, IntPtr value, IntPtr valuelen);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int read_device_info(int nethandle, int devhandle, int timeout, int retrycnt, send_read_device_info_callback_def func, IntPtr errmsg);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern unsafe int read_gate_event(int nethandle, int devhandle, int gate_id, int event_handle, int eventid, int* valuetype, void* value, int* valuelen);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int set_comm_interface_status_callback(int handle, NetStatusCallBack netstatus_cb);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int set_device_alive_status_callback(int nethandle, int devhandle, int timeout, DeviceStatusCallBack devicestatus_cb);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int set_gate_event_callback(int nethandle, int devhandle, gate_event_callback gateevent_cb);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int start_application();
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int stop_gate(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int holdtime);
            [DllImport(@"..\..\..\X86\lnk_api.dll")]
            public static extern int voice_cmd(int nethandle, int devhandle, int timeout, int retrycnt, default_send_callback_def func, IntPtr errmsg, int volume, string voicetext, int lockflag);

            public delegate int default_send_callback_def(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg);

            [StructLayout(LayoutKind.Sequential)]
            public struct DeviceInfoStruct
            {
                public int has_hardname;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] hardname;
                public int has_hardtype;
                public int hardtype;
                public int has_hardver;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] hardver;
                public int has_softver;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] softver;
                public int has_uid;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
                public char[] uid;
                public int has_deviceid;
                public int deviceid;
                public int has_macaddr;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] macaddr;
                public int has_gateway;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] gateway;
                public int has_netmask;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] netmask;
                public int has_deviceip;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] deviceip;
                public int has_deviceport;
                public int deviceport;
                public int has_stationip;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x10)]
                public char[] stationip;
                public int has_stationport;
                public int stationport;
                public int has_devname;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x40)]
                public char[] devname;
            }

            public delegate void DeviceStatusCallBack(int nethandle, int devhandle, int alive_status, int status_handle);

            public delegate int gate_event_callback(int nethandle, int devhandle, int gate_id, IntPtr pevent, int event_cnt, int event_handle);

            public delegate void NetStatusCallBack(int nethandle, int status, IntPtr errmsg);

            public delegate int send_read_device_info_callback_def(int nethandle, int devhandle, int sendid, int sendstatus, IntPtr errmsg, IntPtr devinfo);
        }
    }
}

