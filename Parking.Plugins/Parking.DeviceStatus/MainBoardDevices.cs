using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Common;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.ControlEventArgs;
using Parking.Core.DataProcessing;
using Parking.Core.Record;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using System.Reflection;
using Parking.Controls;
using System.IO;
using System.Threading;


namespace Parking.DeviceStatus
{
    public partial class MainBoardDevices : UserControl
    {
        private RoadGate findPic;
        public MainBoardDevices()
        {
            InitializeComponent();
        }
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
            if ((recordInfo.CHANNEL_TYPE == enumChannelType.chn_in && recordInfo.OPERATER_TYPE == enumOperaterType.OpenGate) || recordInfo.OPERATER_TYPE == enumOperaterType.OutSuccessed)
            {
                findPic = (RoadGate)this.Controls.Find(recordInfo.CHN_NAME, true)[0];
                if (null != findPic)
                {
                    string filePath = GlobalEnvironment.BasePath + "Image\\GateNormalOpen.png";
                    if (File.Exists(filePath))
                        findPic.PicImage = filePath;

                    BackgroundWorker BgWork = new BackgroundWorker();
                    BgWork.DoWork += new DoWorkEventHandler(BgWork_DoWork);
                    BgWork.RunWorkerAsync();
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
                findPic.PicImage = filePath;
        }
        #endregion

        /// <summary>
        /// 道闸状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBoardDevices_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);

            var oragniZations = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out);
            var queryArr = oragniZations.ToArray();
            for (int k = 0; k < queryArr.Count(); k++)
            {
                RoadGate pic = new RoadGate();
                string organizationName = string.Empty;
                if (k < oragniZations.Count())
                {
                    organizationName = queryArr[k].OrganizationInfo.ORGANIZATION_NAME;
                    //查找主控板
                    var controlDevice = GlobalEnvironment.ListOragnization.Where(x => x.PARENT_CODE == queryArr[k].OrganizationInfo.ORGANIZATION_CODE && x.deviceType == enumDeviceType.LonixControlPanelI).FirstOrDefault();
                    if (null != controlDevice)
                    {
                        //获取主控板驱动信息
                        var temp = EngineContext.Current.Resolve<IControlPanel>(controlDevice.deviceType.ToString());
                        if (null != temp)
                        {
                            //初始化设备
                            bool result = temp.Initialize(controlDevice.IP, controlDevice.Port, controlDevice.loginName, controlDevice.loginPsw);
                            temp.OnDeviceStateChanged += new EventHandler<DeviceStateChangedEventArgs>(temp_OnDeviceStateChanged);
                        }
                        string filePath = GlobalEnvironment.BasePath + "Image\\RoadNogate.png";
                        if (File.Exists(filePath))
                            pic.PicImage = filePath;
                    }
                    else
                    {
                        string filePath = GlobalEnvironment.BasePath + "Image\\RoadNogate.png";
                        if (File.Exists(filePath))
                            pic.PicImage = filePath;
                    }
                }
                pic.Name = organizationName;
                pic.GateName = organizationName;
                Point p = new Point(k % 2, k / 2);
                pic.Location = new Point(p.X * (pic.Width + 20) + 30, p.Y * (pic.Height + 20) + 70);
                this.Controls.Add(pic);
            }
        }
        /// <summary>
        /// 状态变化时显示状态动画
        /// </summary>
        private void temp_OnDeviceStateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            //查找主控板
            var controlDevice = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.IP == e.IP);
            foreach (var board in controlDevice)
            {
                try
                {
                    var channelDevice = CommHelper.GetOrgInfos(board.ORGANIZATION_CODE, false).Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                    if (null != channelDevice)
                    {
                        findPic = (RoadGate)this.Controls.Find(channelDevice.ORGANIZATION_NAME, true)[0];
                        if (null != findPic)
                        {
                            string filePath = e.State == 0 ? GlobalEnvironment.BasePath + "Image\\RoadNogate.png" : GlobalEnvironment.BasePath + "Image\\GateNormalClose.png";
                            if (File.Exists(filePath))
                                findPic.PicImage = filePath;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Log.Error(ex.Message, ex.InnerException);
                }
            }
        }
    }
}