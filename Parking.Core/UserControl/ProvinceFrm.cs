using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parking.Controls
{
    public partial class ProvinceFrm : Form
    {
        readonly string[] BigProvices = { "京", "津", "冀", "沪", "粤", "浙" };
        readonly string[] Provinces = { "晋", "蒙", "辽", "吉", "黑", "苏", "皖", "闽", "赣", "鲁", "豫", "鄂", "湘", "桂", "琼", "渝", "川", "贵", "云", "藏", "陕", "甘", "青", "宁", "新", "台", "港", "澳", "警", "挂", "学" };
        Point StartPoint = new Point(0, 0);

        private CarNo _CarNo = null;
        public ProvinceFrm(CarNo carNo)
        {
            _CarNo = carNo;
            InitializeComponent();
        }

        private void ProvinceFrm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X + 30, this.Owner.Location.Y + 158);
            int i = 0;
            this.panel1.Controls.Clear();
            this.panel2.Controls.Clear();
            int j = 0;
            foreach (string s in BigProvices)
            {
                Button btn = new Button();
                btn.Name = s;
                btn.Text = s;
                btn.Width = 70;
                btn.Height = 42;
                btn.FlatStyle = FlatStyle.Flat;
                btn.TabStop = false;
                btn.Font = new Font("微软雅黑", 16, FontStyle.Regular);
                btn.ForeColor = Color.Gray;
                btn.Location = getBigLocation(j, 70, 37);
                btn.Click += new EventHandler(btn_Click);
                this.panel2.Controls.Add(btn);
                j++;
            }
            foreach (string s in Provinces)
            {
                Button btn = new Button();
                btn.Name = s;
                btn.Text = s;
                btn.Width = 45;
                btn.Height = 31;
                btn.FlatStyle = FlatStyle.Flat;
                btn.TabStop = false;
                btn.Font = new Font("微软雅黑", 12, FontStyle.Regular);
                btn.ForeColor = Color.Gray;
                btn.Location = getLocation(i, 45, 31);
                btn.Click += new EventHandler(btn_Click);
                this.panel1.Controls.Add(btn);
                i++;
            }
            Button btnDelete = new Button();
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "取消";
            btnDelete.Width = 95;
            btnDelete.Height = 31;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.TabStop = false;
            btnDelete.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            btnDelete.ForeColor = Color.Gray;
            btnDelete.Location = new Point(205, 108);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            this.panel1.Controls.Add(btnDelete);
        }
        private void btn_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            _CarNo.CarNO += btn.Text;
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs args)
        {
            this.Close();
        }
        /// <summary>
        /// 获?取¨?空?间?位?置?
        /// </summary>
        /// <param name="Num"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public Point getLocation(int Num, int Width, int Height)
        {
            int W = this.panel1.Width;
            int horizontal = W / (Width + 5);
            int v = Num == 0 ? 0 : Num / horizontal;
            int m = Num == 0 ? 0 : Num % horizontal;
            int vertical = m > 0 ? (m + 1) : v;

            int x = m == 0 ? (StartPoint.X + 5) : m * (Width + 5) + 5;
            int y = v == 0 ? StartPoint.Y : v * (Height + 5);
            return new Point(x, y);
        }
        /// <summary>
        /// 获?取¨?空?间?位?置?
        /// </summary>
        /// <param name="Num"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public Point getBigLocation(int Num, int Width, int Height)
        {
            int W = this.panel2.Width;
            int horizontal = W / (Width + 5);
            int v = Num == 0 ? 0 : Num / horizontal;
            int m = Num == 0 ? 0 : Num % horizontal;
            int vertical = m > 0 ? (m + 1) : v;

            int x = m == 0 ? (StartPoint.X + 5) : m * (Width + 5) + 5;
            int y = v == 0 ? StartPoint.Y : v * (Height + 5);
            return new Point(x, y);
        }
        private void ProvinceFrm_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            //Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //左á¨?边à?
            //Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //上|?边à?
            //Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid, //右?¨°边à?
            //Color.FromArgb(0, 156, 230), 1, ButtonBorderStyle.Solid);//底ì?á边à?
        }
    }
}