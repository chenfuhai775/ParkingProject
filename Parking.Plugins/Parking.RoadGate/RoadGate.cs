using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Parking.Core;
using Parking.Core.Model;
using Parking.Core.Log4Net;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Interface;
using Parking.Core.ControlEventArgs;
using Parking.Core.Oragnization;
using Parking.Core.Infrastructure;
using Parking.Core.DataProcessing;
using Parking.Core.Common;

namespace Parking.RoadGate
{
    public partial class RoadGate : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public RoadGate(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }
        private void RoadGate_Load(object sender, EventArgs e)
        {
            this.lbGateName.Location = new Point(5, (this.Height - this.lbGateName.Height) / 2 + 50);
            this.lbGateName.Text = _Plugin.TITLE;
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            InitDeviceInfo();
        }

        #region ___初始化设备信息/设备状态改变___
        /// <summary>
        ///  设备上线
        /// </summary>
        /// <param name="device"></param>
        private void InitDeviceInfo()
        {
            var device = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.ORGANIZATION_CODE == _Plugin.DEVICE_ID).FirstOrDefault();
            if (null != device)
            {
                //查找主控板
                if (!string.IsNullOrEmpty(device.IP))
                {
                    //获取主控板驱动信息
                    var temp = EngineContext.Current.Resolve<IControlPanel>(device.deviceType.ToString());
                    if (null != temp)
                    {
                        //初始化设备
                        bool result = temp.Initialize(device.IP, device.Port, device.loginName, device.loginPsw);
                        temp.OnDeviceStateChanged += new EventHandler<DeviceStateChangedEventArgs>(temp_OnDeviceStateChanged);
                    }
                }
            }
            string filePath = GlobalEnvironment.BasePath + "Image\\RoadNogate.png";
            if (File.Exists(filePath))
                this.picGate.Image = new Bitmap(filePath);
        }
        /// <summary>
        /// 状态变化时显示状态动画
        /// </summary>
        private void temp_OnDeviceStateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            //查找主控板
            var temp = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.ORGANIZATION_CODE == _Plugin.DEVICE_ID).FirstOrDefault();
            if (e.IP == temp.IP)
            {
                try
                {
                    string filePath = e.State == 0 ? GlobalEnvironment.BasePath + "Image\\RoadNogate.png" : GlobalEnvironment.BasePath + "Image\\GateNormalClose.png";
                    if (File.Exists(filePath))
                        this.picGate.Image = new Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    LogHelper.Log.Error(ex.Message, ex.InnerException);
                }
            }
        }
        #endregion

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            ActiveMessage(msg, isWaitOne);
        }
        /// <summary>
        /// 响应广播消息
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo, bool isWaitOne)
        {
            if (recordInfo.OPERATER_TYPE == enumOperaterType.OpenGate)
            {
                var channel = CommHelper.GetOrgInfos(_Plugin.DEVICE_ID, false).Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                if (null != channel)
                {
                    if (channel.ORGANIZATION_CODE == recordInfo.CHN_CODE)
                    {
                        string filePath = GlobalEnvironment.BasePath + "Image\\GateNormalOpen.png";
                        if (File.Exists(filePath))
                            this.picGate.Image = new Bitmap(filePath);

                        BackgroundWorker BgWork = new BackgroundWorker();
                        BgWork.DoWork += new DoWorkEventHandler(BgWork_DoWork);
                        BgWork.RunWorkerAsync();
                    }
                }
            }
        }
        /// <summary>
        /// 等待设备状态图消失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgWork_DoWork(object sender, EventArgs e)
        {
            bool isBreak = true;
            DateTime currDate = System.DateTime.Now;
            while (isBreak)
            {
                DateTime dateNow = System.DateTime.Now;
                if (currDate.AddMilliseconds(2000) <= dateNow)
                    isBreak = false;
            }
            string filePath = GlobalEnvironment.BasePath + "Image\\GateNormalClose.png";
            if (File.Exists(filePath))
                this.picGate.Image = new Bitmap(filePath);
        }
        #endregion

        #region ___重绘界面___
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid);//底边
        }
        #endregion
    }
}