using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Model;
using Parking.Core.Record;
using Parking.Core.Log4Net;
using Parking.Core.Interface;
using Parking.Core.Oragnization;
using Parking.Core.Infrastructure;
using Parking.Core.DataProcessing;

namespace Parking.MonitorCenter
{
    public partial class WatchForm : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public WatchForm(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatchForm_Load(object sender, EventArgs e)
        {
            var temp = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.ORGANIZATION_CODE == _Plugin.DEVICE_ID).FirstOrDefault();
            if (null != temp)
                OpenVideo(temp);
        }
        /// <summary>
        /// 打开视频流
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="ip"></param>
        private void OpenVideo(Equipment device)
        {
            try
            {
                if (!string.IsNullOrEmpty(device.IP))
                {
                    var CameraSdk = EngineContext.Current.Resolve<ICamera>(device.deviceType.ToString());
                    if (null != CameraSdk)
                    {
                        var result = CameraSdk.StartRealTimeVideo(this.picMonitor, device.IP, device.Port, device.loginName, device.loginPsw);
                        device.Online = result;
                        CameraSdk.OnPlate += new EventHandler<DataUploadEventArgs>(MonitorControl_OnPlate);
                    }
                    else
                        LogHelper.Log.Info("设备【" + device.IP + "】不存在!");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message, ex.InnerException);
            }
        }
        /// <summary>
        /// 车牌识别回调 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MonitorControl_OnPlate(object sender, DataUploadEventArgs e)
        {
            ThreadMessageTransact.Instance.AddRecognitioMiddData(e);
        }
    }
}