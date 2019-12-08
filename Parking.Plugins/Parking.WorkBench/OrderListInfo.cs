using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Model;
using Parking.Core;
namespace Parking.WorkBench
{
    public partial class OrderListInfo : BasePanel
    {
        List<CR_ORDER_RECORD_INFO> orderList;
        DataTable table = new DataTable();
        public OrderListInfo(List<CR_ORDER_RECORD_INFO> order)
        {
            orderList = order;
            InitializeComponent();
            base.Title = "订单信息列表";
        }
        private void OrderListInfo_Load(object sender, EventArgs e)
        {

            table.Columns.Add("No", typeof(int));
            table.Columns.Add("VEHICLE_NO", typeof(string));
            table.Columns.Add("TOTAL_COST", typeof(string));
            table.Columns.Add("ALREADY_PAID", typeof(string));
            table.Columns.Add("PER_MONEY", typeof(string));
            table.Columns.Add("IN_PARTITION_CODE", typeof(string));
            table.Columns.Add("OUT_PARTITION_CODE", typeof(string));
            table.Columns.Add("IS_PAY", typeof(string));
            table.Columns.Add("Total_time", typeof(string));
            bindGrd();
            grdOrderInfo.ClearSelection();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void bindGrd()
        {
            table.Clear();
            int count = 0;
            if (null != orderList && orderList.Count > 0)
            {
                var temp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                foreach (CR_ORDER_RECORD_INFO order in orderList)
                {
                    count++;
                    var r = table.NewRow();
                    r["No"] = count;
                    r["VEHICLE_NO"] = order.VEHICLE_NO;
                    r["PER_MONEY"] = order.PER_MONEY.ToString();
                    r["TOTAL_COST"] = order.DUE_MONEY.ToString();
                    r["ALREADY_PAID"] = order.ALREADY_PAID.ToString();
                    r["PER_MONEY"] = order.PER_MONEY.ToString();
                    TimeSpan tsTotal = new TimeSpan(0, 0, 0, (int)order.TOTAL_TIME);
                    //停车时长
                    string parkingTime = tsTotal.Days + "天" + tsTotal.Hours + "小时" + tsTotal.Minutes + "分" + tsTotal.Seconds + "秒";
                    r["Total_time"] = parkingTime;
                    var recode = temp.GetModel(order.INOUT_RECODE_ID);
                    if (null != recode)
                    {
                        var parIn = Parking.Core.GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recode.IN_PARTITION_CODE).FirstOrDefault();
                        if (null != parIn)
                        {
                            r["IN_PARTITION_CODE"] = parIn.ORGANIZATION_NAME;
                        }
                        var parOut = Parking.Core.GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recode.OUT_PARTITION_CODE).FirstOrDefault();
                        if (null != parOut)
                        {
                            r["OUT_PARTITION_CODE"] = parOut.ORGANIZATION_NAME;
                        }
                        else { r["OUT_PARTITION_CODE"] = "未出场"; }
                    }
                    r["IS_PAY"] = order.IS_PAY == false ? "未支付" : "已支付";
                    table.Rows.Add(r);
                }
            }
            grdOrderInfo.DataSource = table;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}