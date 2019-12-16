using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Parking.Core;
using System.Windows.Forms;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Common;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Oragnization;

namespace Parking.WorkBench
{
    public partial class UnlicensedCarsEnter : BasePanel
    {
        private DataUploadRecord dataUploadRecord;
        public UnlicensedCarsEnter(DataUploadRecord record)
        {
            InitializeComponent();
            dataUploadRecord = record;
        }
        private void UnlicensedCarsEnter_Load(object sender, EventArgs e)
        {

            if (null == dataUploadRecord.REPORTIMG_TIME)
                lbInOutTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            else
                lbInOutTime.Text = dataUploadRecord.REPORTIMG_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            lbInOut.Text = dataUploadRecord.CHANNEL_TYPE == enumChannelType.chn_in ? "入场时间 :" : "出场时间 :";

            List<OragnizationBase> orgBase = new List<OragnizationBase>();
            string Ip = CommHelper.GetRealIP();
            GlobalEnvironment.ListOragnization.Where(x => x.channelType == enumChannelType.wsn).ToList().ForEach(delegate(Equipment o)
            {
                if (o.Attributes.ContainsKey("IP"))
                {
                    if (Ip == o.Attributes["IP"])
                    {
                        GetChannel(ref orgBase, o.ORGANIZATION_CODE);
                    }
                }
            });
            this.cbChannelCode.DataSource = orgBase.Where(X => X.channelType == dataUploadRecord.CHANNEL_TYPE).ToList();
            this.cbChannelCode.DisplayMember = "ORGANIZATION_NAME";
            this.cbChannelCode.ValueMember = "ORGANIZATION_CODE";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查找通道
        /// </summary>
        private void GetChannel(ref List<OragnizationBase> orgBase, string PID)
        {
            var temp = GlobalEnvironment.ListOragnization.Where(x => x.PARENT_CODE == PID);
            foreach (var args in temp)
            {
                if (args.channelType == enumChannelType.chn_in || args.channelType == enumChannelType.chn_out)
                {
                    orgBase.Add(args);
                }
                else
                { GetChannel(ref orgBase, args.ORGANIZATION_CODE); }
            }
        }
        /// <summary>
        /// 判断无牌号是否存在
        /// </summary>
        /// <returns></returns>
        public bool IsInputOK()
        {
            if (txtPhone.Text.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                var temp = EngineContext.Current.Resolve<IRecordConvert>();
                return false;
            }
        }
    }
}