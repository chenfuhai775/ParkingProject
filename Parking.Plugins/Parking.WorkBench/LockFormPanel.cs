using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking.WorkBench
{
    public partial class LockFormPanel : Form
    {
        public LockFormPanel()
        {
            InitializeComponent();
        }

        private void LockFormPanel_Load(object sender, EventArgs e)
        {
            LockForm form = new LockForm(this);
            form.ShowDialog();
        }
    }
}