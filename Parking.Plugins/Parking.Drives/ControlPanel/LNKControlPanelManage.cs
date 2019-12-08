namespace Parking.Drives
{
    using Parking.Core;
    using Parking.Core.ControlEventArgs;
    using Parking.Core.Interface;
    using Parking.Core.Log4Net;
    using Parking.Core.Oragnization;
    using Parking.Core.Structs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading;

    public class LNKControlPanelManage : IControlPanel, ILEDScreen
    {
        private List<string> ControlPanels = new List<string>();

        public event EventHandler<DeviceStateChangedEventArgs> OnDeviceStateChanged;

        public LNKControlPanelManage()
        {
            LNK_BARRIER_ISDK_X86.OnDeviceStateChangedEvent += new StateChangedEventHandler(this.lnbr_OnDeviceStateChangedEvent);
        }

        public bool Initialize(string IP, int Port, string userName = "", string Pwd = "")
        {
            bool flag = true;
            if (!this.ControlPanels.Contains(IP))
            {
                flag = (flag && LNK_BARRIER_ISDK_X86.Initialize(IP, 0x1388, userName, Pwd)) && LNK_BARRIER_ISDK_X86.Connect(IP);
                this.ControlPanels.Add(IP);
            }
            return flag;
        }

        private void lnbr_OnDeviceStateChangedEvent(object sender, DeviceStateChangedEventArgs e)
        {
            string message = string.Empty;
            if (e.State == 0)
            {
                message = "设备在线状态事件------设备在线状态:离线\r\n\r\n";
            }
            if (e.State == 1)
            {
                message = "设备在线状态事件------设备IP:" + e.IP + "   设备在线状态:在线\r\n\r\n";
            }
            LogHelper.Log.Info(message);
            (from x in GlobalEnvironment.ListOragnization
                where x.IP == e.IP
                select x).ToList<Equipment>().ForEach(x => x.Online = e.State == 1);
            if (null != this.OnDeviceStateChanged)
            {
                this.OnDeviceStateChanged(sender, e);
            }
        }

        public bool OpenGate(string IP, int Port, int[] gateNumber)
        {
            bool flag = true;
            try
            {
                flag = flag && LNK_BARRIER_ISDK_X86.Connect(IP);
                foreach (int num in gateNumber)
                {
                    flag = flag && LNK_BARRIER_ISDK_X86.SendCommand(IP, num);
                }
            }
            catch (Exception exception)
            {
                LogHelper.Log.Error(exception.Message);
            }
            return flag;
        }

        public bool ShowLedScreen(string IP, int Port, string[] msg, int displayMode = 0, int rowIndex = 1, int fontColor = 1)
        {
            bool flag = true;
            try
            {
                LED_PARAMETER_STRUCT param = new LED_PARAMETER_STRUCT {
                    fontColor = fontColor,
                    ip = IP,
                    port = Port,
                    displayMode = displayMode,
                    Msg = msg,
                    rowIndex = rowIndex
                };
                flag = flag && LNK_LED_ISDK_X86.Connect(IP);
                flag = flag && LNK_LED_ISDK_X86.SendCommand(param);
            }
            catch (Exception exception)
            {
                LogHelper.Log.Error(exception.Message);
            }
            return flag;
        }

        public bool Sound(string IP, int Port, string[] msg, int soundSize, int sex = 0, int displayMode = 0, int rowIndex = 1)
        {
            bool flag = true;
            try
            {
                VOICE_PARAMETER_STRUCT param = new VOICE_PARAMETER_STRUCT {
                    ip = IP,
                    volume = soundSize
                };
                foreach (string str in msg)
                {
                    param.content = param.content + str;
                }
                flag = flag && LNK_LED_ISDK_X86.Connect(IP);
                flag = flag && LNK_LED_ISDK_X86.VoviceSend(param);
            }
            catch (Exception exception)
            {
                LogHelper.Log.Error(exception.Message);
            }
            return flag;
        }
    }
}

