using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core;

namespace Parking.WorkBench
{
    public partial class OccupyRecordInfo : BasePanel
    {
        private ProcessRecord _recordInfo = null;

        public OccupyRecordInfo(ProcessRecord recordInfo)
        {
            InitializeComponent();
            _recordInfo = recordInfo;
            this.grdInOutsInfo.AutoGenerateColumns = false;
            base.Title = "车位信息列表";
        }

        private void OccupyRecordInfo_Load(object sender, EventArgs e)
        {
            if (null != _recordInfo)
            {
                var inOutRecord = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                List<Parking.Core.Model.CR_INOUT_RECODE> list = inOutRecord.GetInOccupyRecordList(_recordInfo);
                this.grdInOutsInfo.DataSource = list;
                grdInOutsInfo.ClearSelection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}