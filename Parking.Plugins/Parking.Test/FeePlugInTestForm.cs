using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Model;
using Parking.Core;
using Parking.ChargeStandard;
using Parking.Core.Interface;

namespace Parking.Test
{
    public partial class FeePlugInTestFrm : BasePanel
    {

        DataTable dtCharge = new DataTable();

        public FeePlugInTestFrm()
        {
            InitializeComponent();
        }

        private void FeePlugInTestFrm_Load(object sender, EventArgs e)
        {
            var temp = EngineContext.Current.Resolve<IPBA_CHARGE_INFO>();
            dtCharge = temp.getChargeList();
            if (dtCharge != null && dtCharge.Rows.Count > 0)
            {
                cmbCharge.DataSource = dtCharge;
                cmbCharge.ValueMember = dtCharge.Columns[0].ColumnName;
                cmbCharge.DisplayMember = dtCharge.Columns[1].ColumnName;

                cmbCharge.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            CR_ORDER_RECORD_DETAILS record = new CR_ORDER_RECORD_DETAILS();
            record.IN_TIME = DateTime.Parse(dtInTime.Text.Trim());
            record.OUT_TIME = DateTime.Parse(dtOutTime.Text.Trim());
            var code = cmbCharge.SelectedValue.ToString();
            var temp = EngineContext.Current.Resolve<IPBA_CHARGE_INFO>();
            var model = temp.GetModel(code);
            var voiceTemp = EngineContext.Current.Resolve<IChargeStandard>(model.CHARGE_PARAM_CODE);
            voiceTemp.InitChargeStandard(code);
            lblMoney.Text = voiceTemp.Charge(record).ToString();
        }
    }
}