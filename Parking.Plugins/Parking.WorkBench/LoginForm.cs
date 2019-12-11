using System;
using Parking.Core;
using System.Windows.Forms;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Common;
using System.Drawing;

namespace Parking.WorkBench
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbUserName.AutoSize = false;
            tbUserName.Height = 35;
            tbPwd.AutoSize = false;
            tbPwd.Height = 35;

            this.picOK.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\bnt.png");
            this.panel1.BackgroundImage = Image.FromFile(GlobalEnvironment.BasePath + @"\image\login.jpg");
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picOK_Click(object sender, EventArgs e)
        {
            if (CommHelper.Login(this.tbUserName.Text.Trim(), this.tbPwd.Text.Trim()))
            {
                string strIP = CommHelper.GetRealIP();
                var temp = EngineContext.Current.Resolve<IFN_LAYOUT_MAIN>();
                Parking.Core.Model.FN_LAYOUT_MAIN workModel = temp.GetLayOutByIP(strIP);
                if (null == workModel)
                {
                    workModel = temp.GetLayOutByWORKSTATION(strIP);

                }
                if (null != workModel)
                {
                    GlobalEnvironment.WorkStationInfo = workModel;
                    GlobalEnvironment.LocalUserInfo.WORKSTATION_NO = GlobalEnvironment.WorkStationInfo.WORKSTATION_ID;
                }
                ICR_PARK_EXCHANGE bllRecord = EngineContext.Current.Resolve<ICR_PARK_EXCHANGE>();
                var model = bllRecord.GetModelByAccount(this.tbUserName.Text.Trim(), GlobalEnvironment.LocalUserInfo.WORKSTATION_NO);
                if (null == model)
                {
                    bllRecord.Add(GlobalEnvironment.LocalUserInfo);
                }
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this.Close();   //关闭登录窗口
            }
            else
            {
                new G5MessageBox("用户名或密码错误").ShowDialog();
            }
        }
        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.picOK_Click(sender, e);
            }
        }
    }
}