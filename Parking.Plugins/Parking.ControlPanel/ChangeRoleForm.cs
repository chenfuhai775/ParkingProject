using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Model;
using Parking.Core.Record;
using Parking.Core.DataProcessing;
using Parking.DBService.IBLL;
using System.Windows.Forms;
using Parking.Core.Infrastructure;
using Parking.Core.Common;

namespace Parking.ControlPanel
{
    public partial class ChangeRoleForm : BasePanel
    {
        public ChangeRoleForm()
        {
            InitializeComponent();
            this.Title = "换班";
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeRoleForm_Load(object sender, EventArgs e)
        {
            this.lbPayMoney.Text = Convert.ToDecimal(GlobalEnvironment.LocalUserInfo.DUE_MONEY).ToString("#0.00");
            this.lbPerMoney.Text = Convert.ToDecimal(GlobalEnvironment.LocalUserInfo.PER_MONEY).ToString("#0.00");
            this.lbLoginTime.Text = Convert.ToDateTime(GlobalEnvironment.LocalUserInfo.LOGIN_TIME).ToString("yyyy-MM-dd HH:mm:ss");
            this.lbLocalUser.Text = GlobalEnvironment.LocalUserInfo.USER_NAME;
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan tsTemp = new TimeSpan(GlobalEnvironment.LocalUserInfo.LOGIN_TIME.Ticks);
            TimeSpan ts = tsNow.Subtract(tsTemp).Duration(); //时间差的绝对值  
            this.lbTotalTime.Text = ts.Days + " 日 " + ts.Hours + " 时 " + ts.Minutes + " 分 " + ts.Seconds + " 秒 ";
        }
        /// <summary>
        /// 保存换班记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string workUserName = GlobalEnvironment.LocalUserInfo.USER_ACCOUNT;
            string userName = this.tbChangeRole.Text.Trim();
            //保存之前操作员信息
            ICR_PARK_EXCHANGE bllRecord = EngineContext.Current.Resolve<ICR_PARK_EXCHANGE>();
            var model = bllRecord.GetModelByAccount(workUserName, GlobalEnvironment.LocalUserInfo.WORKSTATION_NO);
            if (null != model)
            {
                model.WORK_STATUS = 1;
                model.DUE_MONEY = GlobalEnvironment.LocalUserInfo.DUE_MONEY;
                model.PER_MONEY = GlobalEnvironment.LocalUserInfo.PER_MONEY;
                model.EIXT_TIME = DateTime.Now;
                bllRecord.Update(model);
            }
            if (userName != GlobalEnvironment.LocalUserInfo.USER_ACCOUNT)
            {
                //更新新的操作员对象信息
                string pwd = this.tbPwd.Text.Trim();
                if (CommHelper.Login(userName, pwd))
                {
                    GlobalEnvironment.LocalUserInfo.WORKSTATION_NO = GlobalEnvironment.WorkStationInfo.WORKSTATION_ID;
                    GlobalEnvironment.LocalUserInfo.DUE_MONEY = 0;
                    GlobalEnvironment.LocalUserInfo.PER_MONEY = 0;
                    var exchange = bllRecord.GetModelByAccount(userName, GlobalEnvironment.LocalUserInfo.WORKSTATION_NO);
                    if (null == exchange)
                    {
                        bllRecord.Add(GlobalEnvironment.LocalUserInfo);
                    }
                    this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                    ThreadMessageTransact.Instance.triggerEvent(new ProcessRecord() { OPERATER_TYPE = enumOperaterType.ChangeRole }, false);
                    this.Close();   //关闭登录窗口
                }
                else
                {
                    new G5MessageBox("用户名或密码错误").ShowDialog();
                }
            }
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOK_Click(sender, e);
            }
        }
    }
}