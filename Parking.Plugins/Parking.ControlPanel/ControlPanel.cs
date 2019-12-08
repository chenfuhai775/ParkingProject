using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.OSGI;
using Parking.Core.Model;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.DataProcessing;
using Parking.Core.Common;
using Parking.Core.Extension;
using Parking.Controls;
using log4net;

namespace Parking.ControlPanel
{
    public partial class ControlPanel : UserControl
    {
        #region ___构造函数___
        private FN_LAYOUT_SUBJECT _Plugin;
        public ControlPanel(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);

            ExtensionContainer.Instance.OnExtensionChanged += new ExtensionContainer.OnExtensionChangedEventHandler(Instance_OnExtensionChanged);
            ExtensionContainer.Instance.onExtensionChanged();
        }
        #endregion

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord recordInfo, bool isWaitOne)
        {
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ShowInSideForm)
            {
                CarInSideForm form = new CarInSideForm(recordInfo.INOUT_RECODE.VEHICLE_NO);
                form.ShowDialog();
            }
            if (recordInfo.OPERATER_TYPE == enumOperaterType.CentralPayment)
            {
                CentralPaymentForm form = new CentralPaymentForm();
                form.ShowDialog();
            }
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ShowChangeRoleForm)
            {
                ChangeRoleForm form = new ChangeRoleForm();
                if (isWaitOne)
                    form.ShowDialog();
                else
                    form.Show();
            }
        }
        #endregion

        #region __数据库连接状态__
        private void timerDBTesting_Tick(object sender, EventArgs e)
        {
            var dbHelper = EngineContext.Current.Resolve<ISystem_DbHelper>();
            if (dbHelper.IsConnection())
            {
                PictureBox picDbStatus = this.Controls.Find("DBStatus", false)[0] as PictureBox;
                picDbStatus.Image = new Bitmap(GlobalEnvironment.BasePath + @"\image\Signal.png");
            }
            else
            {
                PictureBox picDbStatus = this.Controls.Find("DBStatus", false)[0] as PictureBox;
                picDbStatus.Image = new Bitmap(GlobalEnvironment.BasePath + @"\image\NoSignal.png");
            }
            dbHelper.SynchronizationLocationTime();
        }
        #endregion

        #region __界面控件__
        /// <summary>
        /// 添加控件
        /// </summary>
        /// <param name="extensions"></param>
        public void Instance_OnExtensionChanged(object sender, ExtensionArgs args)
        {
            InitExtensionControl(args);
        }
        public void InitExtensionControl(ExtensionArgs args)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { InitExtensionControl(args); }));
                    return;
                }
                this.Controls.Clear();
                int i = 0;
                int startIndex = (SystemInformation.PrimaryMonitorSize.Width - args.extensions.Count * 120) / 2;
                foreach (var app in args.extensions)
                {
                    ControlButton btn = new ControlButton();
                    if (!string.IsNullOrEmpty(app.Icon))
                        btn.PicImage = app.Icon;
                    btn.TitleName = app.ExtensText;
                    btn.Size = new System.Drawing.Size(120, 80);
                    btn.Location = new Point(startIndex + 119 * i, 0);
                    i++;
                    PictureBox pb = btn.Controls.Find("picLogo", false)[0] as PictureBox;
                    pb.Tag = app;
                    pb.Click += new EventHandler(btn_Click);
                    this.Controls.Add(btn);
                }
                ///////////////////////////加载数据库状态图标/////////////////////////////////////
                PictureBox picDbStatus = new PictureBox();
                picDbStatus.Size = new System.Drawing.Size(30, 30);
                picDbStatus.Name = "DBStatus";
                picDbStatus.Image = new Bitmap(GlobalEnvironment.BasePath + @"\image\Signal.png");
                picDbStatus.Location = new Point(SystemInformation.PrimaryMonitorSize.Width - 100, 30);
                this.Controls.Add(picDbStatus);

                //数据库连接状态
                this.timerDBTesting.Stop();
                this.timerDBTesting.Interval = 3000;
                this.timerDBTesting.Tick += new EventHandler(timerDBTesting_Tick);
                timerDBTesting.Start();
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            try
            {
                WinShellApplication app = ((PictureBox)sender).Tag as WinShellApplication;
                ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = app.OperaterType }, false);
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
        #endregion
    }
}