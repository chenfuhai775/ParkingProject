using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking.Core
{
    public partial class G5MessageBox : Form
    {
        private bool showClose = true;
        public bool ShowClose
        {
            get { return showClose; }
            set { showClose = value; }
        }
        public G5MessageBox(string msg)
        {
            InitializeComponent();
            this.lbMsg.Text = msg;
        }
        /// <summary>
        /// 画线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageBox_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid);//底边
        }
        /// <summary>
        /// 窗口移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 274, 61440 + 9, 0);
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void G5MessageBox_Load(object sender, EventArgs e)
        {
            if (ShowClose)
                this.picClose.Location = new Point(this.Width - 30, 10);
            this.picClose.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\close.png");
            this.picPrompt.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\Prompt.png");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}