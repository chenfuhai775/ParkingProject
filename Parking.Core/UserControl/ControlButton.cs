using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;

namespace Parking.Controls
{
    public partial class ControlButton : UserControl
    {
        public ControlButton()
        {
            InitializeComponent();
        }
        private string _picImage = string.Empty;
        public string PicImage
        {
            set
            {
                _picImage = value;
                if (!string.IsNullOrEmpty(_picImage))
                    this.picLogo.BackgroundImage = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + "Image\\" + _picImage);
            }
        }
        private string _gateName = string.Empty;
        public string TitleName
        {
            set
            {
                _gateName = value;
                this.lbTitle.Text = _gateName;
            }
        }

        private void ControlButton_Load(object sender, EventArgs e)
        {
            this.picLogo.Location = new Point((120 - this.picLogo.Width) / 2, 10);
            this.lbTitle.Location = new Point((120 - this.lbTitle.Width) / 2, 58);
        }

        private void ControlButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(98, 188, 238), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(98, 188, 238), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(62, 171, 230), 1, ButtonBorderStyle.Solid);//底边
        }

        private void ControlButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 129, 205);
        }

        private void ControlButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 171, 230);
        }

        private void picLogo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 171, 230);
        }

        private void picLogo_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 129, 205);
        }

        private void lbTitle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 171, 230);
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 129, 205);
        }
    }
}