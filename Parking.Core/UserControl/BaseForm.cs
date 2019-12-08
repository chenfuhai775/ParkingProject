using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Parking.Core.Infrastructure;
using System.Text;
using System.Windows.Forms;

namespace Parking.Core
{
    public partial class BaseForm : Form
    {
        private bool showClose = true;
        public bool ShowClose
        {
            get { return showClose; }
            set { showClose = value; }
        }
        public BaseForm()
        {
            InitializeComponent();
        }
        public virtual string Title
        {
            get { return this.lbTitle.Text; }
            set { this.lbTitle.Text = value; }
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (ShowClose)
                this.picClose.Location = new Point(this.Width - 50, 15);
            this.picClose.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\close.png");
            this.picLogo.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\title.png");
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)   //拖动窗体
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 274, 61440 + 9, 0);
                return;
            }
        }
        /// <summary>
        /// 界面重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid);//底边
        }
    }
}