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
    public partial class PagingControl : UserControl
    {
        public event Action OnFirst;
        public event Action OnPrevious;
        public event Action OnNext;
        public event Action OnLast;

        public PagingControl()
        {
            InitializeComponent();
        }

        public string PageSize { set { this.lbPageSize.Text = value; } }
        public string PageCount { set { this.lbPageCount.Text = value; } }
        public string CurrPage { set { this.lbCurrPage.Text = value; } }
        public string RecordCount { set { this.lbRecordCount.Text = value; } }
        public Color BgColor { set { this.BackColor = value; } }

        #region ___分页___
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (null != OnFirst)
                OnFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (null != OnPrevious)
                OnPrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (null != OnNext)
                OnNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (null != OnLast)
                OnLast();
        }
        #endregion

    }
}