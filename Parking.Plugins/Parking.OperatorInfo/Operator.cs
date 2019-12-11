using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Parking.Core.Record;
using Parking.Core.Interface;
using Parking.Core.DataProcessing;
using Parking.Core.Infrastructure;
using System.Reflection;
using Parking.Core;
using Parking.Core.Model;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.DBService.IBLL;
using Parking.Core.Oragnization;

namespace Parking.OperatorInfo
{
    public partial class Operator : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public Operator(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }
        private void Operator_Load(object sender, EventArgs e)
        {
            this.picOper.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\person.png");
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            InitPanelInfo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];
            this.lbTimer.Text = " " + week + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
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
            if (recordInfo.OPERATER_TYPE == enumOperaterType.OutSuccessed || recordInfo.OPERATER_TYPE == enumOperaterType.CentralPaySuccess)
            {
                if (recordInfo.OPERATER_TYPE == enumOperaterType.CentralPaySuccess || ((recordInfo.CHANNEL_TYPE == enumChannelType.chn_out) && !recordInfo.AutoOpenGate))
                {
                    //////////贵宾车不生成订单信息//////////////
                    if (null != recordInfo && !recordInfo.IsCenterPay&&recordInfo.PayMethod == enumPayMethod.Cash)
                    {
                        this.lbChargeAmount.Text = (Convert.ToDecimal(this.lbChargeAmount.Text) + recordInfo.INOUT_RECODE.CHARGE_MONEY).ToString("#0.00");
                        this.lbDiscountAmount.Text = (Convert.ToDecimal(this.lbDiscountAmount.Text) + recordInfo.INOUT_RECODE.PRE_MONEY).ToString("#0.00");
                        GlobalEnvironment.LocalUserInfo.DUE_MONEY = decimal.Parse(this.lbChargeAmount.Text);
                        GlobalEnvironment.LocalUserInfo.PER_MONEY = decimal.Parse(this.lbDiscountAmount.Text);
                        ICR_PARK_EXCHANGE bllRecord = EngineContext.Current.Resolve<ICR_PARK_EXCHANGE>();
                        var model = bllRecord.GetModelByAccount(GlobalEnvironment.LocalUserInfo.USER_ACCOUNT, GlobalEnvironment.LocalUserInfo.WORKSTATION_NO);
                        if (null != model)
                        {
                            model.WORK_STATUS = 0;
                            model.DUE_MONEY = GlobalEnvironment.LocalUserInfo.DUE_MONEY;
                            model.PER_MONEY = GlobalEnvironment.LocalUserInfo.PER_MONEY;
                            bllRecord.Update(model);
                        }
                    }
                }
            }
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ChangeRole)
            {
                InitPanelInfo();
            }
        }
        /// <summary>
        /// 初始化界面
        /// </summary>
        public void InitPanelInfo()
        {
            ICR_PARK_EXCHANGE bllRecord = EngineContext.Current.Resolve<ICR_PARK_EXCHANGE>();
            var model = bllRecord.GetModelByAccount(GlobalEnvironment.LocalUserInfo.USER_ACCOUNT, GlobalEnvironment.LocalUserInfo.WORKSTATION_NO);
            this.lbLocalUser.Text = GlobalEnvironment.LocalUserInfo.USER_NAME;
            this.lbLoginTime.Text = Convert.ToDateTime(GlobalEnvironment.LocalUserInfo.LOGIN_TIME).ToString("yyyy-MM-dd HH:mm:ss");
            this.lbChargeAmount.Text = "0";
            this.lbDiscountAmount.Text = "0";
            if (null != model)
            {
                this.lbChargeAmount.Text = Convert.ToDecimal(model.DUE_MONEY).ToString("#0.00");
                this.lbDiscountAmount.Text = Convert.ToDecimal(model.PER_MONEY).ToString("#0.00");
                GlobalEnvironment.LocalUserInfo.DUE_MONEY = model.DUE_MONEY;
                GlobalEnvironment.LocalUserInfo.PER_MONEY = model.PER_MONEY;
            }
        }
        #endregion
    }
}