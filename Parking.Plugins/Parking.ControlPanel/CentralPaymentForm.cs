using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Common;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Enum;
using Parking.Core.DataProcessing;
using Parking.Core.Model;

namespace Parking.ControlPanel
{
    public partial class CentralPaymentForm : BasePanel
    {
        #region __类内变量__
        ICR_INOUT_RECODE bllRecord = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
        /// <summary>
        ///  自定义容器的起始坐标点
        /// </summary>
        Point StartPoint = new Point(0, 10);
        int pageSize = 5;
        int currPage = 0;
        int sizeCount = 0;
        int pageCount = 0;
        #endregion

        #region __构造函数__
        public CentralPaymentForm()
        {
            InitializeComponent();
            base.Title = "中央定点缴费";
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
            if (recordInfo.OPERATER_TYPE == enumOperaterType.OutSuccessed)
            {
                Query();
            }
        }
        #endregion

        #region __类内方法__
        private void CarInSideForm_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            this.pagingControl.OnFirst += new Action(pagingControl_OnFirst);
            this.pagingControl.OnLast += new Action(pagingControl_OnLast);
            this.pagingControl.OnNext += new Action(pagingControl_OnNext);
            this.pagingControl.OnPrevious += new Action(pagingControl_OnPrevious);
            this.dtInTime.Text = DateTime.Now.AddDays(1 - DateTime.Now.Day).ToString();
            this.dtOutTime.Text = DateTime.Now.AddDays(1 - DateTime.Now.Day).AddMonths(1).AddDays(-1).ToString();
            Query();
        }
        #region ___关闭窗口___
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
        }
        private void CentralPaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //必须把事件给注销掉
            ThreadMessageTransact.Instance.OnMessageBroadcast -= new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            StringBuilder strSB = new StringBuilder();
            strSB.Append(" 1=1 ");
            string carNo = this.tbCarNo.Text.Trim();
            if (!string.IsNullOrEmpty(carNo))
                strSB.Append(" AND VEHICLE_NO LIKE '%" + carNo + "%' ");
            string cardNum = this.tbCardNum.Text.Trim();
            if (!string.IsNullOrEmpty(cardNum))
                strSB.Append(" AND CAR_EC_NO LIKE '%" + cardNum + "%' ");
            string dtInTime = Convert.ToDateTime(this.dtInTime.Text).ToString("yyyy-MM-dd");
            string dtOutTime = Convert.ToDateTime(this.dtOutTime.Text).ToString("yyyy-MM-dd");
            strSB.Append(" AND CONVERT(varchar(100), IN_TIME, 23) >= '" + dtInTime + "' and CONVERT(varchar(100), IN_TIME, 23) <='" + dtOutTime + "'");
            var carInfoList = bllRecord.GetInSideList(strSB.ToString(), currPage, pageSize, out sizeCount, out pageCount);

            this.pagingControl.PageSize = pageSize.ToString();
            this.pagingControl.PageCount = pageCount.ToString();
            this.pagingControl.RecordCount = sizeCount.ToString();
            this.pagingControl.CurrPage = (currPage + 1).ToString();

            BeginInvoke((Action)delegate()
            {
                GC.Collect();
                this.pCarPic.Controls.Clear();
                int i = 0;
                foreach (var temp in carInfoList)
                {
                    CarControl control = new CarControl(temp.ID);
                    control.UserControlBtnClicked += new CarControl.BtnClickHandle(control_UserControlBtnClicked);
                    control.Tag = temp.ID;
                    control.VEHICLE_NO = temp.VEHICLE_NO;
                    control.IN_CHANNEL_CODE = temp.IN_CHANNEL_CODE;
                    control.IMG_URL = temp.IMG_URL;
                    control.IN_TIME = temp.IN_TIME.ToString("yyyy-MM-dd HH:mm:ss");
                    control.Location = getLocation(i, control.Width, control.Height);
                    this.pCarPic.Controls.Add(control);
                    i++;
                }
            });
        }
        /// <summary>
        /// 获取空间位置
        /// </summary>
        /// <param name="Num"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public Point getLocation(int Num, int Width, int Height)
        {
            int W = this.pCarPic.Width;
            int horizontal = W / (Width + 10);
            int v = Num == 0 ? 0 : Num / horizontal;
            int m = Num == 0 ? 0 : Num % horizontal;
            int vertical = m > 0 ? (m + 1) : v;

            int x = m == 0 ? (StartPoint.X + 10) : m * (Width + 10) + 10;
            int y = v == 0 ? StartPoint.Y : v * (Height + 5);
            return new Point(x, y);
        }
        #endregion

        #region __放行事件__
        public void control_UserControlBtnClicked(object sender, string ID)
        {
            DataUploadRecord dataUploadRecord = new DataUploadRecord();
            CR_INOUT_RECODE inOutRecord = bllRecord.GetModel(ID);
            if (null != inOutRecord)
            {
                dataUploadRecord.plateNum = inOutRecord.VEHICLE_NO;
                dataUploadRecord.REPORTIMG_TIME = inOutRecord.IN_TIME;
                dataUploadRecord.PARTITION_CODE = inOutRecord.IN_PARTITION_CODE;
                var partitionChildren = CommHelper.GetOrgInfos(dataUploadRecord.PARTITION_CODE);
                //查找中央缴费定点
                if (null != partitionChildren && partitionChildren.Count > 0)
                {
                    var centralPaymentChannel = partitionChildren.Where(x => x.channelType == enumChannelType.centerPayment).FirstOrDefault();
                    if (null != centralPaymentChannel)
                        dataUploadRecord.CHN_CODE = centralPaymentChannel.ORGANIZATION_CODE;
                }
                dataUploadRecord.CHANNEL_TYPE = enumChannelType.centerPayment;
                dataUploadRecord.INOUT_RECODE = inOutRecord;
                DataUploadEventArgs args = new DataUploadEventArgs() { TempRecordInfo = dataUploadRecord };
                ThreadMessageTransact.Instance.AcceptFormalData(dataUploadRecord);
            }
        }
        #endregion

        #region ____分页____
        private void pagingControl_OnFirst()
        {
            if (currPage != 0)
            {
                currPage = 0;
                Query();
            }
        }

        private void pagingControl_OnLast()
        {
            if (currPage != (pageCount - 1))
            {
                currPage = pageCount - 1;
                Query();
            }
        }

        private void pagingControl_OnPrevious()
        {
            if (currPage > 0)
            {
                currPage -= 1;
                Query();
            }
        }

        private void pagingControl_OnNext()
        {
            if (currPage < (pageCount - 1))
            {
                currPage += 1;
                Query();
            }
        }
        #endregion


    }
}