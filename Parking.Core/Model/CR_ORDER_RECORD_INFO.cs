/**  版本信息模板在安装目录下，可自行修改。
* CR_ORDER_RECORD_INFO.cs
*
* 功 能： N/A
* 类 名： CR_ORDER_RECORD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:03   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Parking.Core.Model
{
    /// <summary>
    /// 车牌纠正记录
    /// </summary>
    [Serializable]
    public partial class CR_ORDER_RECORD_INFO
    {
        public CR_ORDER_RECORD_INFO()
        { }
        #region Model
        private string _id;
        private string _partition_code;
        private string _in_channel_code;
        private string _out_channel_code;
        private string _inout_recode_id;
        private double _total_time = 0;
        private string _vehicle_no;
        private decimal _due_money = 0M;
        private decimal _charge_money = 0M;
        private decimal _per_money = 0M;
        private decimal _already_paid = 0M;
        private int? _pay_platform;
        private int? _pay_type;
        private bool _is_pay;
        private DateTime? _free_time;
        private DateTime? _create_time;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_CODE
        {
            set { _partition_code = value; }
            get { return _partition_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IN_CHANNEL_CODE
        {
            set { _in_channel_code = value; }
            get { return _in_channel_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OUT_CHANNEL_CODE
        {
            set { _out_channel_code = value; }
            get { return _out_channel_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INOUT_RECODE_ID
        {
            set { _inout_recode_id = value; }
            get { return _inout_recode_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double TOTAL_TIME
        {
            set { _total_time = value; }
            get { return _total_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VEHICLE_NO
        {
            set { _vehicle_no = value; }
            get { return _vehicle_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DUE_MONEY
        {
            set { _due_money = value; }
            get { return _due_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CHARGE_MONEY
        {
            set { _charge_money = value; }
            get { return _charge_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PER_MONEY
        {
            set { _per_money = value; }
            get { return _per_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ALREADY_PAID
        {
            set { _already_paid = value; }
            get { return _already_paid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PAY_PLATFORM
        {
            set { _pay_platform = value; }
            get { return _pay_platform; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PAY_TYPE
        {
            set { _pay_type = value; }
            get { return _pay_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IS_PAY
        {
            set { _is_pay = value; }
            get { return _is_pay; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FREE_TIME
        {
            set { _free_time = value; }
            get { return _free_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        #endregion Model

    }
}

