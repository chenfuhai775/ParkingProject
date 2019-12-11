using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Parking.Core.Common;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Enum;
using Parking.DBService.IBLL;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Oragnization;
using Parking.Core.Infrastructure;


namespace Parking.WorkBench
{
    public partial class PlateCorrectionForm : BaseForm
    {
        private ProcessRecord recordInfo;
        public PlateCorrectionForm(ProcessRecord record)
        {
            InitializeComponent();
            recordInfo = record;
            Initialize();
            this.carNo.Focus();
            base.Title = "车牌校正框";
        }
        private void Initialize()
        {
            this.lbCarNo.Text = recordInfo.INOUT_RECODE.VEHICLE_NO;
            var temp = GlobalEnvironment.ListOragnization.Where(x => x.IP == CommHelper.GetRealIP() && x.channelType == enumChannelType.wsn).FirstOrDefault();
            this.lbChannelName.Text = recordInfo.CHN_NAME;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlateCorrectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChannelEngine.ProcessSet(recordInfo);
        }
    }
}