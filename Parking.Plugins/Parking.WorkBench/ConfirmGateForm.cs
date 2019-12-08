using System;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Record;

namespace Parking.WorkBench
{
    public partial class ConfirmGateForm : BasePanel
    {
        private ProcessRecord recordInfo;
        public ConfirmGateForm(ProcessRecord record)
        {
            InitializeComponent();
            recordInfo = record;
            base.Title = "入口确认开闸";
            this.lbCarNo.Text = recordInfo.INOUT_RECODE.VEHICLE_NO;
            this.lbInOutTime.Text = recordInfo.REPORTIMG_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            this.lbChannelName.Text = recordInfo.CHN_NAME;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            recordInfo.CheckPointResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            recordInfo.CheckPointResult = false;
            this.Close();
        }
        private void ConfirmGateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChannelEngine.ProcessSet(recordInfo);
        }
    }
}