namespace Parking.ChargeStandard
{
    using Parking.Core.Infrastructure;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Parking.DBService.IBLL;
    using System;
    using System.Collections.Generic;

    public class BaseCharge : IChargeStandard
    {
        #region __属性__
        public string ChargeName { get; set; }
        public string ChargeCode { get; set; }
        public int ChargeType { get; set; }
        public string ChargeParamCode { get; set; }
        /// <summary>
        /// 当ì?à天?¨?收o?费¤?总á¨1额?
        /// </summary>
        public decimal TotalMoney { get; set; }
        private List<string> _listChargeInfo = new List<string>();
        public List<string> ListChargeInfo
        {
            get { return _listChargeInfo; }
            set { _listChargeInfo = value; }
        }
        #endregion

        #region __全属性信息__
        Dictionary<string, string> _attribute = new Dictionary<string, string>();
        public Dictionary<string, string> Attributes
        {
            get { return _attribute; }
            set { _attribute = value; }
        }
        #endregion

        #region __初始化数据__
        public void InitChargeStandard(string ChargeCode)
        {
            var temp = EngineContext.Current.Resolve<IPBA_CHARGE_INFO>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            PBA_CHARGE_INFO charge = temp.getChargeInfo(ChargeCode, ref dic);
            this.ChargeCode = charge.CHARGE_CODE;
            this.ChargeName = charge.CHARGE_NAME;
            this.ChargeParamCode = charge.CHARGE_PARAM_CODE;
            this.ChargeType = charge.CHARGE_TYPE;
            this.Attributes = dic;
        }
        #endregion

        #region __计费__
        /// <summary>
        /// 当日计费
        /// </summary>
        /// <param name="VEHICLE_NO"></param>
        /// <returns></returns>
        public decimal GetTotalMoney(string VEHICLE_NO, DateTime InTime, DateTime OutTime, bool isDay)
        {
            var tempChargesLog = EngineContext.Current.Resolve<ICR_CHARGES_LOG>();
            return tempChargesLog.GetTotalMoney(VEHICLE_NO, InTime, OutTime, isDay);
        }
        /// <summary>
        /// 计?费¤?
        /// </summary>
        /// <param name="OrderDetails"></param>
        /// <param name="freeTime"></param>
        /// <returns></returns>
        public virtual decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int freeTime = 0)
        {
            return 5;
        }
        #endregion
    }
}

