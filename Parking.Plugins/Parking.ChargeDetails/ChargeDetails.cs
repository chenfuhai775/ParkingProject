using System;
using System.Windows.Forms;
using Parking.Core.Model;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.DataProcessing;
using Parking.ChargeStandard;
namespace Parking.CarInformation
{
    public partial class ChargeDetails : UserControl
    {
        private FN_LAYOUT_SUBJECT _Plugin;
        public ChargeDetails(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
        }

        private void DetailsOfEntryAndExit_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注á?é册¨￠消?息?é总á¨1线?事o?件t///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
            dgMessage.Rows[0].Selected = false;
        }
        #region ___注á?é册¨￠消?息?é总á¨1线?事o?件t___
        private void Instance_OnMessageBroadcast(ProcessRecord recordInfo, bool isWaitOne)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ActiveMessage(recordInfo); }));
                return;
            }
            ActiveMessage(recordInfo);
        }
        /// <summary>
        /// 响¨?应?|广?播￡¤消?息?é
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo)
        {
            if (recordInfo.OPERATER_TYPE == enumOperaterType.ShowChargeInfo)
            {
                if (null != recordInfo.ChargeStandard)
                {
                    dgMessage.Rows.Clear();
                    var chargeStandard = recordInfo.ChargeStandard as ChargeStandard.BaseCharge;
                    this.lbChargeName.Text = chargeStandard.ChargeName;
                    this.lbChargeCode.Text = chargeStandard.ChargeCode;
                    this.lbCumulativeWay.Text = chargeStandard.Attributes["A_cumulativeWay"] == "A" ? "跨凌晨累计" : "24小时累计";
                    this.lbfreeOvertimeBiling.Text = chargeStandard.Attributes["A_freeOvertimeBiling"] == "1" ? "是" : "否";
                    this.lbfreeTime.Text = chargeStandard.Attributes["A_freeTime"].ToString() + "分钟";
                    this.lbfreePreferentialWay.Text = chargeStandard.Attributes["A_freePreferentialWay"] == "1" ? "天" : "次";
                    foreach (var temp in chargeStandard.ListChargeInfo)
                    {
                        this.dgMessage.Rows.Add(new object[] { temp });
                    }
                }
            }
        }
        #endregion
    }
}