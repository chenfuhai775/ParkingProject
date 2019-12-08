using System;
using System.Drawing;
using System.Windows.Forms;
using Parking.Core;
namespace Parking.Controls
{
    public partial class CarNo : UserControl
    {
        public CarNo()
        {
            InitializeComponent();
        }
        public string CarNO
        {
            get { return this.tbCarNo.Text.ToUpper(); }
            set { this.tbCarNo.Text = value; }
        }
        private void picChangePro_Click(object sender, EventArgs e)
        {
            ProvinceFrm frm = new ProvinceFrm(this);
            frm.ShowDialog(this);
        }

        private void picChangePro_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid, //左á¨?边à?
            Color.FromArgb(171, 173, 179), 1, ButtonBorderStyle.Solid, //上|?边à?
            Color.FromArgb(171, 173, 179), 1, ButtonBorderStyle.Solid, //右?¨°边à?
            Color.FromArgb(255, 255, 255), 1, ButtonBorderStyle.Solid);//底ì?á边à?
        }

        private void CarNo_Load(object sender, EventArgs e)
        {
            this.picChangePro.Image = new System.Drawing.Bitmap(GlobalEnvironment.BasePath + @"\image\Provice.png");
        }
    }
}