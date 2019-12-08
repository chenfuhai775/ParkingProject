using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core;
using Parking.Core.Log4Net;
using Parking.Core.Enum;
using Parking.Core.Extension;
using Parking.Core.Common;
using Parking.Core.DataProcessing;
using Parking.Core.Oragnization;
using System.Threading;

namespace Parking.WorkBench
{
    public partial class WorkBench : BaseForm
    {
        #region __触发事件__
        int topTitleHeight = 80;
        int bottomTitleHeight = 80;
        int WorkBenchHeight = 0;
        Thread GetCurImages;//图片上传线程
        Thread SendCurImages;//图片上传线程
        Thread UpLoadFile;//更新文件
        delegate void sendImgDelegate(DataRow row, Equipment channel);//图片上委托
        Queue<DataSet> imageData = new Queue<DataSet>();
        static object imageDataLock = new object();
        #endregion

        #region __构造函数__
        public WorkBench()
        {
            InitializeComponent();
        }
        #endregion

        #region __页面加载__
        private void Workbench_Load(object sender, EventArgs e)
        {
            Initialzation();
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            ThreadMessageTransact.Instance.Start();
            ThreadNetworkInterface.Instance.Start();
            ///////////////////////////////////////////////插件变更事件//////////////////////////////////////////////
            ExtensionContainer.Instance.OnExtensionChanged += new ExtensionContainer.OnExtensionChangedEventHandler(Instance_OnExtensionChanged);
            ExtensionContainer.Instance.onExtensionChanged();
            ThreadHelper.StartBgThread(ref SendCurImages, new ParameterizedThreadStart(SendCurWorkStationImages), null, true);
            ThreadHelper.StartBgThread(ref GetCurImages, new ParameterizedThreadStart(GetCurWorkstationNotSendImages), null, true);
            ThreadHelper.StartBgThread(ref UpLoadFile, new ParameterizedThreadStart(UpLoadPluginFile), null, true);

        }
        #endregion

        #region __初始化界面__
        public void Initialzation()
        {
            try
            {
                if (null != GlobalEnvironment.WorkStationInfo)
                {
                    var tempPark = EngineContext.Current.Resolve<IPBA_PARKING_ORGANIZATION_INFO>();
                    List<OragnizationBase> list = new List<OragnizationBase>();
                    GlobalEnvironment.ListOragnization = tempPark.GetOragnizationInfo();
                    GlobalEnvironment.CurrWorkStationOragnization = CommHelper.GetCurrentWorkStationOrgs(GlobalEnvironment.WorkStationInfo.WORKSTATION_ID);
                    var tempOwner = EngineContext.Current.Resolve<IPBA_OWNER_ORGANIZATION>();
                    GlobalEnvironment.OwnerList = tempOwner.GetModelList(string.Empty);
                    //加载车牌识别率统计
                    var tempCorrect = EngineContext.Current.Resolve<ICR_LICENSE_CORRECT_RECORD>();
                    tempCorrect.InitRecognitioInfo();
                }
                else
                    new G5MessageBox("请先配置工作站IP地址").ShowDialog();
            }
            catch (Exception ex) { LogHelper.Log.Error(ex.Message); }
        }
        #endregion

        #region __添加子控件__
        /// //<summary>
        /// 添加控件
        /// </summary>
        /// <param name="extensions"></param>
        public void Instance_OnExtensionChanged(object sender, ExtensionArgs args)
        {
            InitExtensionControl(args);
        }
        public void InitExtensionControl(ExtensionArgs args)
        {
            if (null == GlobalEnvironment.WorkStationInfo)
                return;

            WorkBenchHeight = this.Height - topTitleHeight - bottomTitleHeight;
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { InitExtensionControl(args); }));
                return;
            }
            var pluginBLL = EngineContext.Current.Resolve<IFN_LAYOUT_SUBJECT>();
            var plugins = pluginBLL.GetPlugins(GlobalEnvironment.WorkStationInfo.ID);
       
            //this.Controls.Clear();
            foreach (var pluginInfo in plugins)
            {
                var app = args.extensions.Where(x => x.ExtensName == pluginInfo.CLIENT_TYPE).FirstOrDefault();
                if (null != app)
                {
                    UserControl tempForm = System.Activator.CreateInstance(app.Bundle.LoadClass(app.ExtensType), new object[] { pluginInfo }) as UserControl;

                    tempForm.Width = (int)(pluginInfo.WIDTH * this.Width / 100);
                    tempForm.Height = (int)(pluginInfo.HEIGHT * this.Height / 100);

                    int left = (int)(pluginInfo.LEEF_X * this.Width / 100);
                    int top = (int)(pluginInfo.LEEF_Y * this.Height / 100) + topTitleHeight;

                    top = top + topTitleHeight > this.Height ? (this.Height - tempForm.Height) : top;
                    tempForm.Location = new Point(left, top);
                    this.Controls.Add(tempForm);
                }
            }
        }
        #endregion __添加子控件__

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ActiveMessage(msg, isWaitOne); }));
                return;
            }
            ActiveMessage(msg, isWaitOne);
        }
        /// <summary>
        /// 响应广播消息
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo, bool isWaitOne)
        {
            /// <summary>
            /// 显示收费框
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ShowCharge)
            {
                var MonitorWidth = SystemInformation.PrimaryMonitorSize.Width;
                var MonitorHeight = SystemInformation.PrimaryMonitorSize.Height;
                ChargeForm chargeForm = new ChargeForm(recordInfo);

                //chargeForm.Width = MonitorWidth / 3;
                //chargeForm.Height = chargeForm.Width / 4 * 3 - 40;

                Point point = new Point();
                point.X = MonitorWidth - chargeForm.Width;
                point.Y = MonitorHeight - chargeForm.Height - bottomTitleHeight;
                chargeForm.Location = point;
                //if (isWaitOne)
                //    chargeForm.ShowDialog();
                //else
                    chargeForm.Show();
            }
            /// <summary>
            /// 车牌矫正框
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.PlateCorrection)
            {
                var MonitorWidth = SystemInformation.PrimaryMonitorSize.Width;
                var MonitorHeight = SystemInformation.PrimaryMonitorSize.Height;
                PlateCorrectionForm plateCorrectionForm = new PlateCorrectionForm(recordInfo);

                //plateCorrectionForm.Width = MonitorWidth / 7 * 2;
                //plateCorrectionForm.Height = plateCorrectionForm.Width / 5 * 3 - 40;

                Point point = new Point();
                point.X = MonitorWidth - plateCorrectionForm.Width;
                point.Y = MonitorHeight - plateCorrectionForm.Height - bottomTitleHeight;
                plateCorrectionForm.Location = point;
                //if (isWaitOne)
                //    plateCorrectionForm.ShowDialog();
                //else
                    plateCorrectionForm.Show();
            }
            /// <summary>
            /// 确认开闸框
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.OpenInConfirmGate)
            {
                var MonitorWidth = SystemInformation.PrimaryMonitorSize.Width;
                var MonitorHeight = SystemInformation.PrimaryMonitorSize.Height;
                ConfirmGateForm confirmGateForm = new ConfirmGateForm(recordInfo);

                //confirmGateForm.Width = MonitorWidth / 7 * 2;
                //confirmGateForm.Height = confirmGateForm.Width / 5 * 3 - 40;

                Point point = new Point();
                point.X = MonitorWidth - confirmGateForm.Width;
                point.Y = MonitorHeight - confirmGateForm.Height - bottomTitleHeight;
                confirmGateForm.Location = point;
                //if (isWaitOne)
                //    confirmGateForm.ShowDialog();
                //else
                    confirmGateForm.Show();
            }
            /// <summary>
            /// 锁屏幕
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.LockForm)
            {
                LockFormPanel form = new LockFormPanel();
                form.ShowDialog();
            }
            /// <summary>
            /// 手工放行入场
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.HandReleaseIn)
            {
                DataUploadRecord dataUploadRecord = new DataUploadRecord();
                dataUploadRecord.REPORTIMG_TIME = DateTime.Now;
                dataUploadRecord.CHANNEL_TYPE = enumChannelType.chn_in;
                HandReleaseForm handReleaseForm = new HandReleaseForm(dataUploadRecord);
                handReleaseForm.Title = "手工放行入场";
                handReleaseForm.ShowDialog();
            }
            /// <summary>
            /// 手工放行出场
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.HandReleaseOut)
            {
                DataUploadRecord dataUploadRecord = new DataUploadRecord();
                dataUploadRecord.plateNum = recordInfo.INOUT_RECODE.VEHICLE_NO;
                dataUploadRecord.CarType = recordInfo.CarType;
                dataUploadRecord.REPORTIMG_TIME = DateTime.Now;
                dataUploadRecord.CHANNEL_TYPE = enumChannelType.chn_out;
                HandReleaseForm handReleaseForm = new HandReleaseForm(dataUploadRecord);
                handReleaseForm.Title = "手工放行出场";
                handReleaseForm.ShowDialog();
            }
            /// <summary>
            /// 无牌车放行入场
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.UnlicensedIn)
            {
                DataUploadRecord dataUploadRecord = new DataUploadRecord();
                dataUploadRecord.REPORTIMG_TIME = DateTime.Now;
                dataUploadRecord.CHANNEL_TYPE = enumChannelType.chn_in;
                UnlicensedCarsEnter unlicensedCarsEnterForm = new UnlicensedCarsEnter(dataUploadRecord);
                unlicensedCarsEnterForm.Title = "无牌车放行入场";
                unlicensedCarsEnterForm.ShowDialog();
            }
            /// <summary>
            /// 退出系统
            /// </summary>
            if (recordInfo.OPERATER_TYPE == enumOperaterType.Quit)
            {
                G5MessageBox msgBox = new G5MessageBox("确定要退出吗?");
                DialogResult result = msgBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                    this.Close();
                }
            }
        }
        #endregion

        #region __界面重布局__
        private void WorkBench_Resize(object sender, EventArgs e)
        {
            //ExtensionContainer.Instance.onExtensionChanged();
        }
        #endregion

        #region __快捷键___
        private void WorkBench_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.HandReleaseIn }, false);
                    break;
                case Keys.F2:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.HandReleaseOut }, false);
                    break;
                case Keys.F3:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.UnlicensedIn }, false);
                    break;
                case Keys.F4:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.UnlicensedOut }, false);
                    break;
                case Keys.F5:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.ShowInSideForm }, false);
                    break;
                case Keys.F6:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.CentralPayment }, false);
                    break;
                case Keys.F7:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.ShowChangeRoleForm }, false);
                    break;
                case Keys.F8:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.LockForm }, false);
                    break;
                case Keys.F9:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.Quit }, false);
                    break;
                case Keys.F10:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.QueryUserIfno }, false);
                    break;
                case Keys.F11:
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord { OPERATER_TYPE = enumOperaterType.FeePlugInTest }, false);
                    break;
            }
        }

        #endregion

        #region ___图片上传___
        /// <summary>
        /// 图片上传
        /// </summary>
        private void GetCurWorkstationNotSendImages(object status)
        {
            while (true)
            {
                if (null != GlobalEnvironment.CurrWorkStationOragnization)
                {
                    var tempImg = EngineContext.Current.Resolve<ICR_INOUT_RECODE_IMG>();
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("ISSEND = 0 ");
                    var tempChannels = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).ToList();
                    if (tempChannels.Count > 0)
                    {
                        strSql.Append(" AND ( ");
                        foreach (var temp in tempChannels)
                            strSql.Append(" CHANNEL_CODE = '" + temp.ORGANIZATION_CODE + "' OR ");
                        strSql.Append(" 1<> 1) ");
                        strSql.Append(" AND IMG_URL <> '' ");
                        strSql.Append(" order by CREATE_TIME DESC");
                        try
                        {
                            DataSet ds = tempImg.GetList(strSql.ToString());
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                lock (imageDataLock)
                                    imageData.Enqueue(ds);
                            }
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Log.Error(ex.ToString());
                        }
                    }
                }
                Thread.Sleep(80000);
            }
        }
        private void SendCurWorkStationImages(object status)
        {
            try
            {
                while (true)
                {
                    DataSet ds = null;
                    if (imageData.Count > 0)
                    {
                        lock (imageData)
                            ds = imageData.Dequeue();
                        if (null != ds && ds.Tables[0].Rows.Count > 0)
                        {
                            var tempImg = EngineContext.Current.Resolve<ICR_INOUT_RECODE_IMG>();
                            var recordTemp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                //bool isSendImg = CommHelper.SendImg(row["IMG_URL"].ToString(), row["CHANNEL_TYPE"].ToString(), row["VEHICLE_NO"].ToString());
                                bool isSendImg = true;//CommHelper.SendImg(row["IMG_URL"].ToString(), row["CHANNEL_TYPE"].ToString());
                                if (isSendImg)
                                {
                                    Parking.Core.Model.CR_INOUT_RECODE_IMG model = new CR_INOUT_RECODE_IMG();
                                    model.ID = row["ID"].ToString();
                                    model.DEV_ID = row["DEV_ID"].ToString();
                                    model.CHANNEL_TYPE = row["CHANNEL_TYPE"].ToString();
                                    model.CHANNEL_CODE = row["CHANNEL_CODE"].ToString();
                                    model.CREATE_TIME = DateTime.Parse(row["CREATE_TIME"].ToString());
                                    model.IMG_TYPE = int.Parse(row["IMG_TYPE"].ToString());
                                    model.IMG_URL = row["IMG_URL"].ToString();
                                    model.ISSEND = 1;
                                    model.RECODE_ID = row["RECODE_ID"].ToString();
                                    tempImg.Update(model);
                                }
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.ToString());
            }
        }
        #endregion

        #region ___更新文件___
        private void UpLoadPluginFile(object status)
        {
            while (true)
            {
                IFN_MONITOR_UPDATE_INFO tempMonitor = EngineContext.Current.Resolve<IFN_MONITOR_UPDATE_INFO>();
                var model = tempMonitor.GetByWorkStationCode(GlobalEnvironment.WorkStationInfo.WORKSTATION_ID);
                if (null != model)
                {
                    IFN_MONITOR_VERSION_INFO tempVersions = EngineContext.Current.Resolve<IFN_MONITOR_VERSION_INFO>();
                    var version = tempVersions.GetByVersion(model.UPDATE_VERSION);
                    var fileName = FileHandler.DownloadFile(version.DOWNLOAD_URL, version.VERSION_NUMBER);
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        ////////////更新下载信息/////////
                        model.UPDATE_TIME = DateTime.Now;
                        tempMonitor.Update(model);
                        ///////////更新岗亭版本信息//////
                        IPBA_PARKING_PARAM_SETTINGS setting = EngineContext.Current.Resolve<IPBA_PARKING_PARAM_SETTINGS>();
                        var versionInfo = setting.GetVersionInfo(GlobalEnvironment.WorkStationInfo.WORKSTATION_ID);
                        if (null != versionInfo)
                        {
                            versionInfo.DISPLAY_VALUE = version.VERSION_NUMBER;
                            setting.Update(versionInfo);
                        }
                    }
                }
                Thread.Sleep(50000);
            }
        }
        #endregion

    }
}
