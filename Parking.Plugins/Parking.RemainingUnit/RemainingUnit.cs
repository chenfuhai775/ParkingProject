using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Parking.Core.Record;
using System.Windows.Forms;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.DataProcessing;
using Parking.DBService.IBLL;
using Parking.Core.Infrastructure;
using Parking.Core;
using Parking.Core.Model;
using Parking.Core.Common;
using Parking.Core.Oragnization;

namespace Parking.RemainingUnit
{
    public partial class RemainingUnit : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public RemainingUnit(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
            this.dgParkingStatistics.AutoGenerateColumns = false;
            dgParkingStatistics.CurrentCell = null;
        }
        private void RemainingUnit_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            try
            {
                BindGrd();
                this.timer1.Interval = 2000;
                this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
                this.timer1.Start();
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
        /// <summary>
        ///  绑定数据
        /// </summary>
        private void BindGrd(ProcessRecord recordInfo = null)
        {
            try
            {
                List<CarTypeMap> listCar = new List<CarTypeMap>();
                List<ParkingSpaceStatistics> listParkSpaceStatistics = new List<ParkingSpaceStatistics>();
                ICR_INOUT_RECODE bllRecord = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                int recordCount = 0;
                int pageCount = 0;
                var temp = bllRecord.GetInSideList(string.Empty, 0, int.MaxValue, out recordCount, out pageCount);
                var ListPar = Parking.Core.GlobalEnvironment.ListOragnization.Where(x => x.channelType == enumChannelType.par).ToList();

                foreach (var p in ListPar)
                {
                    foreach (var tempCarType in p.ListCardType)
                    {
                        tempCarType.AreaName = p.ORGANIZATION_NAME;
                        tempCarType.AreaCode = p.ORGANIZATION_CODE;
                        tempCarType.parkingNumber = tempCarType.parkingNumber - tempCarType.tempParking;
                        listCar.Add(tempCarType);
                    }
                }
                foreach (var t in temp)
                {
                    var par = listCar.Where(x => x.AreaCode == t.CurrPartitionCode && x.carType == t.Credentials_Type).FirstOrDefault();
                    if (null != par)
                        par.parkingNumber = par.parkingNumber > 0 ? par.parkingNumber - 1 : 0;
                }
                foreach (var tempCar in listCar)
                {
                    var objectPar = listParkSpaceStatistics.Where(x => x.AreaName.Contains(tempCar.AreaName)).FirstOrDefault();
                    if (null == objectPar)
                    {
                        ParkingSpaceStatistics t = new ParkingSpaceStatistics();
                        t.AreaName = tempCar.AreaName;
                        if ((int)enumCardType.CAR_TYPE_TEMP == tempCar.carType)
                            t.CAR_TYPE_TEMP_COUNT = tempCar.parkingNumber;
                        if ((int)enumCardType.CAR_TYPE_MONTH == tempCar.carType)
                            t.CAR_TYPE_MONTH_COUNT = tempCar.parkingNumber;
                        listParkSpaceStatistics.Add(t);
                    }
                    else
                    {
                        if ((int)enumCardType.CAR_TYPE_TEMP == tempCar.carType)
                            objectPar.CAR_TYPE_TEMP_COUNT = tempCar.parkingNumber;
                        if ((int)enumCardType.CAR_TYPE_MONTH == tempCar.carType)
                            objectPar.CAR_TYPE_MONTH_COUNT = tempCar.parkingNumber;
                    }
                }
                GlobalEnvironment.ListCarTypeMap = listCar;
                this.dgParkingStatistics.DataSource = listParkSpaceStatistics;
                dgParkingStatistics.CurrentCell = null;
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
        /// <summary>
        /// 实时更新剩余车位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            BindGrd();
        }

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
            if (recordInfo.OPERATER_TYPE == enumOperaterType.OpenGate || recordInfo.OPERATER_TYPE == enumOperaterType.OutSuccessed)
            {
                BindGrd(recordInfo);
            }
        }
        #endregion
    }
    /// <summary>
    /// 车位数量类
    /// </summary>
    public class ParkingSpaceStatistics
    {
        public string AreaName { get; set; }
        public int CAR_TYPE_TEMP_COUNT { get; set; }
        public int CAR_TYPE_MONTH_COUNT { get; set; }
        public int Total { get { return (CAR_TYPE_TEMP_COUNT + CAR_TYPE_MONTH_COUNT); } }
    }
}