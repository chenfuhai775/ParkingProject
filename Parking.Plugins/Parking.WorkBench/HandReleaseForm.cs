using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.DataProcessing;
using Parking.Core.Record;
using Parking.Core.Common;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Oragnization;

namespace Parking.WorkBench
{
    public partial class HandReleaseForm : BasePanel
    {
        private DataUploadRecord dataUploadRecord;
        Parking.DBService.IBLL.IBAS_SYSTEM_DATA_DICT bllDataDict = EngineContext.Current.Resolve<Parking.DBService.IBLL.IBAS_SYSTEM_DATA_DICT>();
        public HandReleaseForm(DataUploadRecord record)
        {
            InitializeComponent();
            dataUploadRecord = record;
            this.cmbCarType.SelectedValue = (int)record.CarType;
            this.tbCarNo.CarNO = record.plateNum;
        }
        public override string Title
        { set { base.Title = value; } }
        /// <summary>
        /// 放行出场
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommHelper.ValidateCarNum(this.tbCarNo.CarNO) || CommHelper.ValidateUnlicensedCar(this.tbCarNo.CarNO))
                {
                    dataUploadRecord.plateNum = this.tbCarNo.CarNO;
                    dataUploadRecord.CHN_CODE = this.cbChannelCode.SelectedValue.ToString();
                    dataUploadRecord.CHN_NAME = this.cbChannelCode.Text;
                    dataUploadRecord.REPORTIMG_TIME = Convert.ToDateTime(this.lbInOutTime.Text);
                    dataUploadRecord.carType = Convert.ToInt32(this.cmbCarType.SelectedValue.ToString());
                    dataUploadRecord.CarType = (enumCarType)System.Enum.Parse(typeof(enumCarType), this.cmbCarType.SelectedValue.ToString());
                    var converter = EngineContext.Current.Resolve<IRecordConvert>(enumReleaseType.HandRelease.ToString());
                    DataUploadEventArgs args = new DataUploadEventArgs() { TempRecordInfo = dataUploadRecord };
                    var recordInfo = converter.ConvertRecord(args);
                    ThreadMessageTransact.Instance.AcceptFormalData(recordInfo);
                    this.Close();
                }
                else
                {
                    new G5MessageBox("请输入正确的车牌号码!").ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
        /// <summary>
        /// 取消放行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandReleaseForm_Load(object sender, EventArgs e)
        {
            tbCarNo.Text = dataUploadRecord.plateNum;
            if (null == dataUploadRecord.REPORTIMG_TIME)
                lbInOutTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            else
                lbInOutTime.Text = dataUploadRecord.REPORTIMG_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            lbInOut.Text = dataUploadRecord.CHANNEL_TYPE == enumChannelType.chn_in ? "入场时间 :" : "出场时间 :";

            List<Equipment> orgBase = new List<Equipment>();
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
            List<Parking.Core.Model.BAS_SYSTEM_DATA_DICT> dataList = bllDataDict.GetListByParentModelKey("VEHICLE_TYPE");
            this.cmbCarType.DataSource = dataList;
            this.cmbCarType.DisplayMember = "MODEL_NAME";
            this.cmbCarType.ValueMember = "MODEL_VALUE";
        }
        /// <summary>
        /// 查找通道
        /// </summary>
        private void GetChannel(ref List<Equipment> orgBase, string PID)
        {
            var temp = GlobalEnvironment.ListOragnization.Where(x => x.PARENT_CODE == PID);

            foreach (var args in temp)
            {
                if (args.channelType == enumChannelType.chn_in || args.channelType == enumChannelType.chn_out)
                {
                    orgBase.Add(args);
                }
                else
                    GetChannel(ref orgBase, args.ORGANIZATION_CODE);
            }
        }
    }
}