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
    public partial class MonitorWindow : UserControl
    {
        public MonitorWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 监视控件
        /// </summary>
        public PictureBox PicMonitor
        {
            get { return this.picMonitor; }
        }
    }
}