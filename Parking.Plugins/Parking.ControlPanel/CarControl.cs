using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Parking.Core;

namespace Parking.ControlPanel
{
    public partial class CarControl : UserControl
    {
        private string Id;
        public CarControl(string ID)
        {
            Id = ID;
            InitializeComponent();
        }
        private string _id;
        public string ID { get { return _id; } set { _id = value; } }
        public string VEHICLE_NO { set { this.lb_CarNo.Text = value; } }
        public string IN_CHANNEL_CODE
        {
            set
            {
                var channel = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == value).FirstOrDefault();
                this.lb_ChannelName.Text = channel == null ? "" : channel.ORGANIZATION_NAME;
            }
        }
        public string IN_TIME { set { this.lb_InTime.Text = value; } }
        public string IMG_URL
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && File.Exists(value))
                {
                    this.picIn.Image = new Bitmap(value);
                }
                else
                    this.picIn.Image = new Bitmap(GlobalEnvironment.BasePath + @"image/car.jpg");
            }
            get { return ID; }
        }

        public delegate void BtnClickHandle(object sender, string e);
        //定义事件
        public event BtnClickHandle UserControlBtnClicked;

        private void picIn_Click(object sender, EventArgs e)
        {
            if (UserControlBtnClicked != null)
                UserControlBtnClicked(sender, Id);//把按钮自身作为参数传递
        }
    }
}