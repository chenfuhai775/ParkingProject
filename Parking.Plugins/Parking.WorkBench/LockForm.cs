using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Parking.Core;
using System.Windows.Forms;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Model;
using Parking.Core.Common;
using System.Configuration;

namespace Parking.WorkBench
{
    public partial class LockForm : BasePanel
    {
        LockFormPanel LockPanel;
        public LockForm(LockFormPanel panel)
        {
            InitializeComponent();
            LockPanel = panel;
        }

        private void LockForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\LockForm.png");
            this.picOK.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\bnt.png");
        }

        private void picOK_Click(object sender, EventArgs e)
        {
            string userName = this.tbUserName.Text.Trim();
            if (GlobalEnvironment.LocalUserInfo.USER_ACCOUNT.ToLower() == userName.ToLower())
            {
                if (CommHelper.Login(this.tbUserName.Text.Trim(), this.tbPwd.Text.Trim()))
                {
                    LockPanel.Close();
                    this.Close();    //关闭登录窗口
                }
                else
                {
                    new G5MessageBox("密码错误").ShowDialog();
                }
            }
            else
            {
                new G5MessageBox("用户名错误").ShowDialog();
            }


        }
        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.picOK_Click(sender, e);
            }
        }
    }
}