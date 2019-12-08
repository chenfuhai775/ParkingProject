using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.Log4Net;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Model;
using Parking.Core.DataProcessing;

namespace Parking.OwnerInfo
{
    public partial class OwnerInfo : BasePanel
    {
        #region __类内变量__
        IPBA_OWNER_INFO bllRecord = EngineContext.Current.Resolve<IPBA_OWNER_INFO>();
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
        public OwnerInfo()
        {
            InitializeComponent();
        }
        #endregion

        #region __类内方法__
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
                strSB.Append(" AND OWNER_NAME LIKE '%" + cardNum + "%' ");
            string dtInTime = Convert.ToDateTime(this.dtInTime.Text).ToString("yyyy-MM-dd");
            string dtOutTime = Convert.ToDateTime(this.dtOutTime.Text).ToString("yyyy-MM-dd");
            strSB.Append(" AND CONVERT(varchar(100), CREATE_TIME, 23) >= '" + dtInTime + "' and CONVERT(varchar(100), CREATE_TIME, 23) <='" + dtOutTime + "'");
            var carInfoList = bllRecord.GetOwnerInfo(strSB.ToString(), currPage, pageSize, out sizeCount, out pageCount);

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
                    OwnerControl control = new OwnerControl(temp.OWNER_CODE);
                    control.Tag = temp.OWNER_CODE;
                    control.OwnerName = temp.OWNER_NAME;
                    control.Address = temp.OWNER_ADDRESS;
                    control.Phone = temp.OWNER_PHONE;
                    control.CarNo = temp.VEHICLE_NO;
                    control.IMG_URL = temp.OWNER_PICTURE;
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
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