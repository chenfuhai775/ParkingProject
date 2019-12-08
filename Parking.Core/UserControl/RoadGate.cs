using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking.Controls
{
    public partial class RoadGate : UserControl
    {
        public RoadGate()
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
                {
                    this.picGate.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.picGate.Image = new System.Drawing.Bitmap(_picImage);
                }
            }
        }
        private string _gateName = string.Empty;
        public string GateName
        {
            set
            {
                _gateName = value;
                this.lbGateName.Text = _gateName;
            }
        }

        private void RoadGate_Load(object sender, EventArgs e)
        {
            this.lbGateName.Location = new Point(5, (this.Height - this.lbGateName.Height) / 2 + 50);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(153, 153, 153), 1, ButtonBorderStyle.Solid);//底边
        }
    }
}