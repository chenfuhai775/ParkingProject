using System;
using System.Linq;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.Core.Common;
using Parking.Core.Caching;
using Parking.Core.DataProcessing;

namespace Parking.DataUpload
{
    public partial class DataUploadRecord : UserControl
    {
        #region ___构造函数___
        public DataUploadRecord()
        {
            InitializeComponent();
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
        }
        #endregion

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ActiveMessage(msg, isWaitOne); }));
                return;
            }
            ActiveMessage(msg, isWaitOne);
        }
        /// <summary>
        /// 响应广播消息
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo, bool isWaitOne)
        {
            var cache = EngineContext.Current.Resolve<ICacheManager>();
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ShowRecord)
            {
                string VEHICLE_NO = cache.Get<string>(recordInfo.CHANNEL_TYPE.ToString());
                if (string.IsNullOrEmpty(VEHICLE_NO) || VEHICLE_NO != recordInfo.INOUT_RECODE.VEHICLE_NO)
                {
                    string cardType = CommHelper.getCarType(recordInfo);
                    if (dgDataUploadRecord.Rows.Count > 50)
                        dgDataUploadRecord.Rows.Clear();
                    dgDataUploadRecord.Rows.Insert(0, new DataGridViewRow());
                    if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_in)
                        dgDataUploadRecord.Rows[0].SetValues(new object[] { recordInfo.PicFullName, recordInfo.INOUT_RECODE.VEHICLE_NO, cardType, recordInfo.PARTITION_NAME, recordInfo.CHN_NAME, recordInfo.REPORTIMG_TIME.ToString("yyyy-MM-dd HH:mm:ss"), recordInfo.INOUT_RECODE.IN_PARK_TYPE, GlobalEnvironment.LocalUserInfo.USER_NAME });
                    else if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                    {
                        string inPartition = string.Empty;
                        string inChn = string.Empty;
                        if (null != GlobalEnvironment.ListOragnization)
                        {
                            var tempPartition = GlobalEnvironment.ListOragnization.Where(x => x.OrganizationInfo.ORGANIZATION_CODE == recordInfo.INOUT_RECODE.IN_PARTITION_CODE).FirstOrDefault();
                            inPartition = null == tempPartition ? "" : tempPartition.OrganizationInfo.ORGANIZATION_NAME;
                            var tempCHN = GlobalEnvironment.ListOragnization.Where(x => x.OrganizationInfo.ORGANIZATION_CODE == recordInfo.INOUT_RECODE.IN_CHANNEL_CODE).FirstOrDefault();
                            inChn = null == tempCHN ? "" : tempCHN.OrganizationInfo.ORGANIZATION_NAME;
                        }
                        dgDataUploadRecord.Rows[0].SetValues(new object[] { recordInfo.PicFullName, recordInfo.INOUT_RECODE.VEHICLE_NO, cardType, inPartition, inChn, recordInfo.INOUT_RECODE.IN_TIME.ToString("yyyy-MM-dd HH:mm:ss"), recordInfo.INOUT_RECODE.IN_PARK_TYPE, GlobalEnvironment.LocalUserInfo.USER_NAME, recordInfo.PARTITION_NAME, recordInfo.CHN_NAME, recordInfo.REPORTIMG_TIME.ToString("yyyy-MM-dd HH:mm:ss"), recordInfo.INOUT_RECODE.OUT_PARK_TYPE, recordInfo.INOUT_RECODE.CHARGE_MONEY.ToString("#0.00"), recordInfo.INOUT_RECODE.PRE_MONEY.ToString("#0.00") });
                    }
                    dgDataUploadRecord.Rows[0].Selected = true;
                    cache.Set(recordInfo.CHANNEL_TYPE.ToString(), recordInfo.INOUT_RECODE.VEHICLE_NO, 10);
                }
            }
        }
        #endregion

        #region ___切换收费信息___
        private void dgDataUploadRecord_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgDataUploadRecord_SelectionChanged(object sender, EventArgs e)
        {
            int rowCount = dgDataUploadRecord.Rows.Count;
            if (rowCount > 1)
            {
                /////////////////////////触发添加数据事件////////////////////
                var dgSelectedRow = dgDataUploadRecord.SelectedRows[0];
                if (null != dgSelectedRow && dgSelectedRow.Index != (rowCount - 1))
                {
                    string FullPic = dgSelectedRow.Cells[0].Value == null ? string.Empty : dgSelectedRow.Cells[0].Value.ToString();
                    string VEHICLE_NO = dgSelectedRow.Cells[1].Value == null ? string.Empty : dgSelectedRow.Cells[1].Value.ToString();
                    if (!string.IsNullOrEmpty(FullPic) && !string.IsNullOrEmpty(VEHICLE_NO))
                    {
                        var p = new ProcessRecord { PicFullName = FullPic, VEHICLE_NO = VEHICLE_NO, OPERATER_TYPE = enumOperaterType.SwitchdataGrid };
                        ThreadMessageTransact.Instance.triggerEvent(p, false);
                    }
                }
            }
        }
        #endregion
    }
}