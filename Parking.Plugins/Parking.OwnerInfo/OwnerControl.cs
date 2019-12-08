using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using System.IO;

namespace Parking.OwnerInfo
{
    public partial class OwnerControl : UserControl
    {
        private string Id;
        public OwnerControl(string ID)
        {
            Id = ID;
            InitializeComponent();
        }
        private string _id;
        public string ID { get { return _id; } set { _id = value; } }
        public string OwnerName { set { this.lb_Name.Text = value; } }
        public string Phone { set { this.lb_Phone.Text = value; } }
        public string CarNo { set { this.lbCarNo.Text = value; } }
        public string Address { set { this.lb_Address.Text = value; } }
        public string IMG_URL
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && File.Exists(value))
                {
                    this.picIn.Image = new Bitmap(value);
                }
                else
                    this.picIn.Image = new Bitmap(GlobalEnvironment.BasePath + @"image/person.png");
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