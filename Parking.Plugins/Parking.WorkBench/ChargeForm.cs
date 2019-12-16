using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Parking.Core.Record;
using System.IO;
using System.Threading;
using Parking.Core.Enum;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;
using Parking.Core.Interface;
using Parking.Core.Model;
using Parking.Core.WeiXin;
using Parking.Core.Common;

namespace Parking.WorkBench
{
    using Parking.Core;

    public partial class ChargeForm : BasePanel
    {
        #region __类内变量__
        private ProcessRecord recordInfo;
        ICR_ORDER_RECORD_INFO orderRecord;
        List<CR_ORDER_RECORD_INFO> order;
        decimal totalMoney = 0;
        decimal chargeMoney = 0;
        decimal alReadyPaid = 0;
        List<CRPreferentialDetails> ListDiscount = new List<CRPreferentialDetails>();
        decimal PreMoney = 0;
        #endregion

        #region __构造函数__
        public ChargeForm(ProcessRecord record)
        {
            InitializeComponent();
            recordInfo = record;
            base.WindowsClosed = false;
            CheckForIllegalCrossThreadCalls = false;
            orderRecord = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
            order = recordInfo.ListOrder;//orderRecord.GetOrders(recordInfo.INOUT_RECODE.ID, );
            base.Title = record.CHANNEL_TYPE == enumChannelType.centerPayment ? "中央缴费框" : "出口收费框";
            Initialize();
        }
        #endregion

        #region __页面初始化__
        /// <summary>
        /// 初始化界面信息
        /// </summary>
        private void Initialize()
        {
            chargingOrder();
            this.lbDueMoney.Text = totalMoney.ToString();
            this.lbPreMoney.Text = PreMoney.ToString();
            this.lbChargeMoney.Text = chargeMoney.ToString();
            this.lbAlreadyPaid.Text = alReadyPaid.ToString();
            this.lbOperator.Text = GlobalEnvironment.LocalUserInfo.USER_NAME;
            this.lbInTime.Text = recordInfo.INOUT_RECODE.IN_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            this.lbOutTime.Text = recordInfo.INOUT_RECODE.OUT_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            this.lbCarNo.Text = recordInfo.INOUT_RECODE.VEHICLE_NO;
            this.lblOrderNum.Text = order.Count.ToString();
            TimeSpan tsIn = new TimeSpan(recordInfo.INOUT_RECODE.IN_TIME.Ticks);
            TimeSpan tsOut = new TimeSpan(recordInfo.INOUT_RECODE.OUT_TIME.Ticks);
            TimeSpan tsTotal = tsOut.Subtract(tsIn).Duration();
            //停车时长
            string parkingTime = tsTotal.Days + " 天 " + tsTotal.Hours + " 小时 " + tsTotal.Minutes + " 分 " + tsTotal.Seconds + " 秒";
            this.lbTotalTime.Text = parkingTime;
            //var physicalTemp = EngineContext.Current.Resolve<ICR_PREFERENTIAL_PHYSICAL>();
            //var preDetails = physicalTemp.GetPhysicalByVehicleNo(recordInfo.INOUT_RECODE.VEHICLE_NO).FirstOrDefault();
            //if (null != preDetails)
            //{
            //    var discount = EngineContext.Current.Resolve<IDiscount>(preDetails.PREFERENTIAL_TYPE.ToString());
            //    var first = ListDiscount.FirstOrDefault();
            //    if (null == first)
            //    {   /////////////////如¨?果?是o?第ì¨2一°?个?优??惠Y项?目?直?à接¨?添?¨a加¨?进?去¨￡¤///////////
            //        preDetails.PREFERENTIAL_MONEY = preDetails.PREFERENTIAL_CONTENT;
            //        ListDiscount.Add(preDetails);
            //        ReDiscount();
            //    }
            //}
        }
        /// <summary>
        /// 打开页面立刻报语音 CHARGE_METHOD  VEHICLE_TYPE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChargeForm_Load(object sender, EventArgs e)
        {
            var temp = EngineContext.Current.Resolve<IBAS_SYSTEM_DATA_DICT>();
            var ListPayType = temp.GetListByParentModelKey("CHARGE_METHOD");
            cbPayType.ValueMember = "MODEL_VALUE";
            cbPayType.DisplayMember = "MODEL_NAME";
            cbPayType.DataSource = ListPayType;
            var ListCarType = temp.GetListByParentModelKey("VEHICLE_TYPE");
            cbCarType.DataSource = ListCarType;
            cbCarType.ValueMember = "MODEL_VALUE";
            cbCarType.DisplayMember = "MODEL_NAME";
            this.cbCarType.SelectedValue = ((int)recordInfo.CarType).ToString();
            Sound();
            this.tbQRcode.Focus();
        }
        #endregion

        #region __按钮事件__
        public void chargingOrder()
        {
            foreach (var o in order)
            {
                totalMoney += o.DUE_MONEY;
                chargeMoney += (o.DUE_MONEY - o.ALREADY_PAID - o.PER_MONEY);
                alReadyPaid += o.ALREADY_PAID;
                PreMoney += string.IsNullOrEmpty(o.PER_MONEY.ToString()) ? 0 : o.PER_MONEY;
            }
            recordInfo.INOUT_RECODE.DUE_MONEY = totalMoney;
            recordInfo.INOUT_RECODE.CHARGE_MONEY = chargeMoney;
            recordInfo.INOUT_RECODE.PRE_MONEY = PreMoney;
        }
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            OpenGate();
        }
        /// <summary>
        /// 开闸
        /// </summary>
        private void OpenGate()
        {
            recordInfo.CheckPointResult = true;
            recordInfo.INOUT_RECODE.PAY_METHOD = Int32.Parse(this.cbPayType.SelectedValue.ToString());
            recordInfo.INOUT_RECODE.PAY_PLATFORM = 0;
            this.Close();
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            recordInfo.CheckPointResult = false;
            var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
            if (null != recordInfo.currPartitionOrderDetails)
                orderDetailsBll.Delete(recordInfo.currPartitionOrderDetails.ID);
            this.Close();
        }
        /// <summary>
        /// 播语音
        /// </summary>
        private void Sound()
        {
            var voiceTemp = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
            var voiceModel = voiceTemp.GetModelByType((int)enumTemplateType.MODEL_TYPE_VOICE, (int)enumSpeechType.PayOut);
            List<string> strArr = new List<string>();
            recordInfo.INOUT_RECODE.IN_TIME = DateTime.Parse(this.lbInTime.Text);
            recordInfo.INOUT_RECODE.OUT_TIME = DateTime.Parse(this.lbOutTime.Text);
            if (null != voiceModel)
            {
                if (recordInfo.CHANNEL_TYPE == enumChannelType.centerPayment)
                {
                    string soundStr = CommHelper.VoiceContent(voiceModel.CUSTOM_MODEL, recordInfo, true);
                    CommHelper.WindowsSound(soundStr);
                }
                else
                {
                    strArr.Add(CommHelper.VoiceContent(voiceModel.CUSTOM_MODEL, recordInfo));
                    Parking.Core.Common.CommHelper.Sound(recordInfo, strArr.ToArray());
                }
            }
            ///////////////////////////////////显示屏信息///////////////////////////////
            var checkPointBase = EngineContext.Current.Resolve<CheckPointBase>();
            checkPointBase.ShowLED(recordInfo);
        }
        /// <summary>
        /// 重报语音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReSound_Click(object sender, EventArgs e)
        {
            Sound();
        }
        /// <summary>
        /// 免费放行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFree_Click(object sender, EventArgs e)
        {
            recordInfo.IsFree = true;
            recordInfo.CheckPointResult = true;
            recordInfo.PayMethod = (enumPayMethod)Enum.Parse(typeof(enumPayMethod), this.cbPayType.SelectedValue.ToString());
            recordInfo.INOUT_RECODE.PAY_METHOD = Convert.ToInt32(this.cbPayType.SelectedValue);
            ReDiscount();
            this.Close();
        }
        #endregion

        #region __扫码支付__
        /// <summary>
        /// 手工优惠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPreMoney_KeyUp(object sender, KeyEventArgs e)
        {
            //重新计算优惠值
            ReDiscount();
        }
        /// <summary>
        /// 扫描二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbQRcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.lbMessage.Text = string.Empty;
                if (!string.IsNullOrEmpty(tbQRcode.Text))
                {
                    //优惠打折
                    if ("0" == this.cbPayType.SelectedValue.ToString())
                    {
                        var physicalTemp = EngineContext.Current.Resolve<ICR_PREFERENTIAL_PHYSICAL>();
                        var preDetails = physicalTemp.GetPhysicalByCodeNo(tbQRcode.Text).FirstOrDefault();
                        if (null != preDetails)
                        {
                            var discount = EngineContext.Current.Resolve<IDiscount>(preDetails.PREFERENTIAL_TYPE.ToString());
                            var first = ListDiscount.FirstOrDefault();
                            if (null == first)
                                /////////////////如果是第一个优惠项目直接添加进去///////////
                                ListDiscount.Add(preDetails);
                            else
                            {
                                ////////////////组合优惠券///////////////////
                                if (0 == first.IS_COMBINATION)
                                {
                                    bool isExist = 0 == ListDiscount.Where(x => x.PREFERENTIAL_CODE == preDetails.PREFERENTIAL_CODE).Count() ? false : true;
                                    if (!isExist)
                                    {
                                        ListDiscount.Add(preDetails);
                                    }
                                    else
                                        this.lbMessage.Text = "无效优惠券!";
                                }
                                else
                                    this.lbMessage.Text = "优惠券不允许组合使用!";
                            }
                        }
                        else
                            this.lbMessage.Text = "无效优惠券!";
                        //重?新?计?算?优??惠Y值|ì
                        ReDiscount();
                    }//微?é信?支?ì付?
                    else if ("1" == this.cbPayType.SelectedValue.ToString())
                    {
                        var payMethod = EngineContext.Current.Resolve<IPayMethod>(enumPayMethod.WeChatPay.ToString());
                        int totalMoney = Convert.ToInt32(this.lbChargeMoney.ToString()) * 10 * 10;
                        bool result = payMethod.Pay(totalMoney, this.tbQRcode.Text);
                        if (result)
                        {
                            OpenGate();
                            this.btnOK.Enabled = true;
                            recordInfo.PayMethod = enumPayMethod.WeChatPay;
                            CommHelper.WindowsSound("微信支付成功!");
                            this.lbMessage.Text = "微信支付成功!";
                        }
                        else
                            this.lbMessage.Text = "微信支付失败!";
                    }//支?ì付?宝à|支?ì付?
                    else if ("2" == this.cbPayType.SelectedValue.ToString())
                    {
                        var payMethod = EngineContext.Current.Resolve<IPayMethod>(enumPayMethod.AliPay.ToString());
                        bool result = payMethod.Pay(0);
                        if (result)
                        {
                            OpenGate();
                            this.btnOK.Enabled = true;
                            recordInfo.PayMethod = enumPayMethod.AliPay;
                            CommHelper.WindowsSound("支付宝成功");
                            this.lbMessage.Text = "支付宝支付成功!";
                        }
                        else
                            this.lbMessage.Text = "支付宝支付失败!";
                    }
                }
            }
        }
        #endregion

        #region ___计算优惠券___
        /// <summary>
        /// 计?算?优??惠Y值|ì
        /// </summary>
        /// <param name="recordInfo"></param>
        private void ReDiscount()
        {
            #region _____统a3计?优??惠Y信?息?é_____
            decimal totalperMoney = 0;
            /////////////////手工优惠//////////////////////////
            decimal perMoney = 0;
            string Pident = "manual-0001";
            decimal.TryParse(this.tbPreMoney.Text, out perMoney);
            ListDiscount.Remove(ListDiscount.Where(x => x.PREFERENTIA_IDENT == Pident).FirstOrDefault());
            decimal tbChargeMoney = chargeMoney;
            if (perMoney > 0 && perMoney <= tbChargeMoney)
            {
                CRPreferentialDetails details = new CRPreferentialDetails();
                details.PREFERENTIAL_NAME = "手工优惠";
                details.MODEL_NAME = "现金优惠";
                details.PREFERENTIA_IDENT = Pident;
                details.PREFERENTIAL_CONTENT = perMoney;
                details.PREFERENTIAL_MONEY = perMoney;
                details.PREFERENTIAL_TYPE = enumPreferentialType.CASH_TICKET;
                ListDiscount.Add(details);
            }
            foreach (var temp in ListDiscount.OrderBy(x => x.CR_LEVEL))
            {
                var discount = EngineContext.Current.Resolve<IDiscount>(temp.PREFERENTIAL_TYPE.ToString());
                decimal tempMoney = discount.Discount(recordInfo, temp);
                totalperMoney += tempMoney;
                temp.PREFERENTIAL_MONEY = tempMoney;
            }
            recordInfo.ListDiscount = ListDiscount;
            totalperMoney = totalperMoney > chargeMoney ? chargeMoney : totalperMoney;
            this.lbChargeMoney.Text = (chargeMoney - totalperMoney) < 0 ? "0" : (chargeMoney - totalperMoney).ToString("#0.00");
            this.lbPreMoney.Text = (PreMoney + totalperMoney).ToString("#0.00");
            #endregion

            #region ___优??惠Y打?¨°折?后¨?放¤?行D_____
            //优惠后需要缴纳的费用小于零，直接放行
            //if (recordInfo.INOUT_RECODE.CHARGE_MONEY <= 0)
            //{
            //    recordInfo.OpenGate = true;
            //    this.Close();
            //}
            dgDiscount.DataSource = ListDiscount.ToArray();

            recordInfo.INOUT_RECODE.DUE_MONEY = decimal.Parse(this.lbDueMoney.Text.Trim());
            recordInfo.INOUT_RECODE.CHARGE_MONEY = decimal.Parse(this.lbChargeMoney.Text.Trim());
            recordInfo.INOUT_RECODE.PRE_MONEY = decimal.Parse(this.lbPreMoney.Text.Trim());
            recordInfo.INOUT_RECODE.PRE_MONEY = recordInfo.INOUT_RECODE.PRE_MONEY > recordInfo.INOUT_RECODE.DUE_MONEY ? recordInfo.INOUT_RECODE.DUE_MONEY : recordInfo.INOUT_RECODE.PRE_MONEY;
            this.tbQRcode.Text = string.Empty;
            ////////////////免费放行//////////////
            if (recordInfo.IsFree)
            {
                CRPreferentialDetails details = new CRPreferentialDetails();
                details.PREFERENTIAL_NAME = "手工全免";
                details.MODEL_NAME = "现金优惠";
                details.PREFERENTIA_IDENT = Pident;
                details.PREFERENTIAL_CONTENT = recordInfo.INOUT_RECODE.DUE_MONEY;
                details.PREFERENTIAL_MONEY = recordInfo.INOUT_RECODE.DUE_MONEY;
                details.PREFERENTIAL_TYPE = enumPreferentialType.CASH_TICKET;
                ListDiscount.Add(details);
            }
            #endregion
        }
        #endregion

        #region ___订单详细页___
        private void lblOrderNum_Click(object sender, EventArgs e)
        {
            OrderListInfo orderFrm = new OrderListInfo(order);
            orderFrm.ShowDialog();
        }
        #endregion

        #region ___车位占用详细页___
        private void lbOccupyCarNo_Click(object sender, EventArgs e)
        {
            //OccupyRecordInfo orderFrm = new OccupyRecordInfo(recordInfo);
            //orderFrm.ShowDialog();
        }
        #endregion

        #region ___重新计费___
        /// <summary>
        /// 重?计?费¤?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReCharging_Click(object sender, EventArgs e)
        {

            recordInfo.CarType = (enumCarType)(Convert.ToInt32(this.cbCarType.SelectedValue.ToString()));
            var recodeTemp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
            //获取收费标准
            var temp = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.PARTITION_CODE).FirstOrDefault();
            var carTypeCharge = temp.ListChargMap.Where(x => x.carType == Convert.ToInt32(this.cbCarType.SelectedValue.ToString())).FirstOrDefault();
            var orderThis = order.Where(x => x.INOUT_RECODE_ID == recordInfo.INOUT_RECODE.ID).FirstOrDefault();
            if (null != orderThis)
            {
                orderThis.DUE_MONEY = 0;
                var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
                var OrderDetails = orderDetailsBll.GetOrdersByInOutCode(recordInfo.INOUT_RECODE.ID);
                foreach (var tempOrderDetails in OrderDetails)
                {
                    var tempCharg = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.PARTITION_CODE).FirstOrDefault();
                    if (null != tempCharg)
                    {
                        var carType = tempCharg.ListChargMap.Where(x => x.carType == (int)recordInfo.CarType).FirstOrDefault();
                        if (null != carType)
                        {
                            string ChargeNo = string.Empty;
                            //启用日历
                            if (tempCharg.calTypeFlag)
                                ChargeNo = CommHelper.getWorkingDaysVal() ? carType.holiday : carType.working;
                            else
                                ChargeNo = carType.chargeNo;

                            var chargeType = EngineContext.Current.Resolve<IPBA_CHARGE_INFO>();
                            var model = chargeType.GetModel(ChargeNo);
                            recordInfo.chargeStandardType = (enumChargeStandardType)(Enum.Parse(typeof(enumChargeStandardType), model.CHARGE_PARAM_CODE, false));
                            var chargeStandard = EngineContext.Current.Resolve<IChargeStandard>(recordInfo.chargeStandardType.ToString());
                            chargeStandard.InitChargeStandard(ChargeNo);
                            decimal money = chargeStandard.Charge(tempOrderDetails);
                            tempOrderDetails.DUE_MONEY = money;
                            orderDetailsBll.Update(tempOrderDetails);
                            ////////////////更新订单信息//////////////
                            orderThis.DUE_MONEY += money;
                            recordInfo.CurrNeedPay = orderThis.DUE_MONEY - orderThis.ALREADY_PAID - orderThis.PER_MONEY;
                        }
                    }
                }
                /////////////////修改订单收费金额/////////////////
                orderRecord.Update(orderThis);
                order = recordInfo.ListOrder;
                this.totalMoney = 0;
                this.PreMoney = 0;
                this.chargeMoney = 0;
                this.alReadyPaid = 0;
                chargingOrder();
                this.lbDueMoney.Text = this.totalMoney.ToString();
                this.lbPreMoney.Text = this.PreMoney.ToString();
                this.lbChargeMoney.Text = this.chargeMoney.ToString();
                this.lbAlreadyPaid.Text = this.alReadyPaid.ToString();
                this.tbPreMoney.Text = "";
                //////////////////优惠打折//////////////////////
                ListDiscount.Clear();
                ReDiscount();
            }
        }
        #endregion

        #region ___取消优惠___
        /// <summary>
        /// 删除优惠券
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;
            if (CIndex == 11)
            {
                var physicalTemp = EngineContext.Current.Resolve<ICR_PREFERENTIAL_PHYSICAL>();
                string code = dgDiscount[1, e.RowIndex].Value.ToString();
                ListDiscount.Remove(ListDiscount.Where(x => x.PREFERENTIA_IDENT == code).FirstOrDefault());
                ReDiscount();
            }
        }
        #endregion

        #region ___窗口关闭事件___
        private void ChargeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChannelEngine.ProcessSet(recordInfo);
        }
        #endregion

        #region ___支付方式改变___
        private void cbPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payType = this.cbPayType.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(payType))
            {
                recordInfo.PayMethod = (enumPayMethod)(Enum.Parse(typeof(enumPayMethod), this.cbPayType.SelectedValue.ToString()));
                if ("0" != payType)
                {
                    this.btnOK.Enabled = false;
                    this.tbQRcode.Focus();
                }
                else
                    this.btnOK.Enabled = true;
            }
        }
        #endregion
    }
}