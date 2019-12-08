/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:01   N/A    初版
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
	/// 车辆通行记录
	/// </summary>
	[Serializable]
	public partial class CR_INOUT_RECODE
	{
		public CR_INOUT_RECODE()
		{}
        #region Model
        private string _id;
        private string _occupyids;
        private string _unique_identifier;
        private int? _vehicle_type;
        private string _vehicle_no;
        private string _car_color;
        private string _car_ec_no;
        private int _credentials_type;
        private string _in_field_code;
        private string _in_channel_code;
        private DateTime _in_time = DateTime.Now;
        private string _in_operator_id;
        private string _in_partition_code;
        private string _in_eq_id;
        private string _in_dev_id;
        private string _in_park_type;
        private string _out_dev_id;
        private string _out_park_type;
        private DateTime _out_time = Convert.ToDateTime("1900-01-01");
        private string _out_field_code;
        private string _out_channel_code;
        private string _out_operator_id;
        private string _out_partition_code;
        private double _total_time = 0;
        private string _curr_partition_code;
        private decimal _due_money = 0M;
        private decimal _charge_money = 0M;
        private decimal _pre_money = 0M;
        private decimal? _overtimesfje;
        private decimal? _advance_money;
        private int? _pay_method;
        private string _out_eq_id;
        private int? _pay_platform;
        private decimal? _in_img_trust;
        private decimal? _out_img_trust;
        private int? _recode_status;
        private string _in_led_info;
        private string _out_led_info;
        private int? _lock_flag = 0;
        private DateTime? _lock_time;
        private int? _has_correct = 0;
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string OccupyIds
        {
            set { _occupyids = value; }
            get { return _occupyids; }
        }
        /// <summary>
        /// 通a?§行D证?è唯?§一°?标à¨o识o?
        /// </summary>
        public string UNIQUE_IDENTIFIER
        {
            set { _unique_identifier = value; }
            get { return _unique_identifier; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VEHICLE_TYPE
        {
            set { _vehicle_type = value; }
            get { return _vehicle_type; }
        }
        /// <summary>
        /// 车|ì牌?号?
        /// </summary>
        public string VEHICLE_NO
        {
            set { _vehicle_no = value; }
            get { return _vehicle_no; }
        }
        /// <summary>
        /// 车|ì牌?颜?色|?
        /// </summary>
        public string CAR_COLOR
        {
            set { _car_color = value; }
            get { return _car_color; }
        }
        /// <summary>
        /// 电ì?子á¨?车|ì牌?号?
        /// </summary>
        public string CAR_EC_NO
        {
            set { _car_ec_no = value; }
            get { return _car_ec_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CREDENTIALS_TYPE
        {
            set { _credentials_type = value; }
            get { return _credentials_type; }
        }
        /// <summary>
        /// 入¨?口¨2工?è作á??站?编à¨¤号?
        /// </summary>
        public string IN_FIELD_CODE
        {
            set { _in_field_code = value; }
            get { return _in_field_code; }
        }
        /// <summary>
        /// 入¨?口¨2通a?§道ì¨¤编à¨¤号?
        /// </summary>
        public string IN_CHANNEL_CODE
        {
            set { _in_channel_code = value; }
            get { return _in_channel_code; }
        }
        /// <summary>
        /// 入¨?场?时o?à间?
        /// </summary>
        public DateTime IN_TIME
        {
            set { _in_time = value; }
            get { return _in_time; }
        }
        /// <summary>
        /// 入¨?场?收o?费¤?员?à
        /// </summary>
        public string IN_OPERATOR_ID
        {
            set { _in_operator_id = value; }
            get { return _in_operator_id; }
        }
        /// <summary>
        /// 入¨?场?所¨′属o?分¤?区?
        /// </summary>
        public string IN_PARTITION_CODE
        {
            set { _in_partition_code = value; }
            get { return _in_partition_code; }
        }
        /// <summary>
        /// 入¨?口¨2手o?持?设|¨¨备à?
        /// </summary>
        public string IN_EQ_ID
        {
            set { _in_eq_id = value; }
            get { return _in_eq_id; }
        }
        /// <summary>
        /// 入¨?口¨2设|¨¨备à?ID
        /// </summary>
        public string IN_DEV_ID
        {
            set { _in_dev_id = value; }
            get { return _in_dev_id; }
        }
        /// <summary>
        /// 入¨?场?方¤?式o?
        /// </summary>
        public string IN_PARK_TYPE
        {
            set { _in_park_type = value; }
            get { return _in_park_type; }
        }
        /// <summary>
        /// 出?口¨2设|¨¨备à?ID
        /// </summary>
        public string OUT_DEV_ID
        {
            set { _out_dev_id = value; }
            get { return _out_dev_id; }
        }
        /// <summary>
        /// 出?场?方¤?式o?
        /// </summary>
        public string OUT_PARK_TYPE
        {
            set { _out_park_type = value; }
            get { return _out_park_type; }
        }
        /// <summary>
        /// 出?场?时o?à间?
        /// </summary>
        public DateTime OUT_TIME
        {
            set { _out_time = value; }
            get { return _out_time; }
        }
        /// <summary>
        /// 出?口¨2工?è作á??站?编à¨¤号?
        /// </summary>
        public string OUT_FIELD_CODE
        {
            set { _out_field_code = value; }
            get { return _out_field_code; }
        }
        /// <summary>
        /// 出?口¨2通a?§道ì¨¤编à¨¤号?
        /// </summary>
        public string OUT_CHANNEL_CODE
        {
            set { _out_channel_code = value; }
            get { return _out_channel_code; }
        }
        /// <summary>
        /// 出?口¨2收o?费¤?员?à
        /// </summary>
        public string OUT_OPERATOR_ID
        {
            set { _out_operator_id = value; }
            get { return _out_operator_id; }
        }
        /// <summary>
        /// 出?口¨2所¨′属o?分¤?区?
        /// </summary>
        public string OUT_PARTITION_CODE
        {
            set { _out_partition_code = value; }
            get { return _out_partition_code; }
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
        public string CURR_PARTITION_CODE
        {
            set { _curr_partition_code = value; }
            get { return _curr_partition_code; }
        }
        /// <summary>
        /// 应?|收o?金e额?
        /// </summary>
        public decimal DUE_MONEY
        {
            set { _due_money = value; }
            get { return _due_money; }
        }
        /// <summary>
        /// 收o?费¤?金e额?
        /// </summary>
        public decimal CHARGE_MONEY
        {
            set { _charge_money = value; }
            get { return _charge_money; }
        }
        /// <summary>
        /// 优??惠Y金e额?
        /// </summary>
        public decimal PRE_MONEY
        {
            set { _pre_money = value; }
            get { return _pre_money; }
        }
        /// <summary>
        /// 超?时o?à收o?费¤?金e额?
        /// </summary>
        public decimal? OVERTIMESFJE
        {
            set { _overtimesfje = value; }
            get { return _overtimesfje; }
        }
        /// <summary>
        /// 预?è交?金e额?
        /// </summary>
        public decimal? ADVANCE_MONEY
        {
            set { _advance_money = value; }
            get { return _advance_money; }
        }
        /// <summary>
        /// 1:现?金e支?ì付?  2:app支?ì付?  3储??é值|ì卡?§扣?费¤?   4微?é信?支?ì付?  5 阿??é里¤?支?ì付?
        /// </summary>
        public int? PAY_METHOD
        {
            set { _pay_method = value; }
            get { return _pay_method; }
        }
        /// <summary>
        /// 出?口¨2手o?持?设|¨¨备à?
        /// </summary>
        public string OUT_EQ_ID
        {
            set { _out_eq_id = value; }
            get { return _out_eq_id; }
        }
        /// <summary>
        /// 支?ì付?平?台??§
        /// </summary>
        public int? PAY_PLATFORM
        {
            set { _pay_platform = value; }
            get { return _pay_platform; }
        }
        /// <summary>
        /// 入¨?场?图a?片?可¨|信?度¨¨
        /// </summary>
        public decimal? IN_IMG_TRUST
        {
            set { _in_img_trust = value; }
            get { return _in_img_trust; }
        }
        /// <summary>
        /// 出?场?图a?片?可¨|信?度¨¨
        /// </summary>
        public decimal? OUT_IMG_TRUST
        {
            set { _out_img_trust = value; }
            get { return _out_img_trust; }
        }
        /// <summary>
        /// 0 入¨?场?    1 出?场?   2 废¤?弃¨2
        /// </summary>
        public int? RECODE_STATUS
        {
            set { _recode_status = value; }
            get { return _recode_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IN_LED_INFO
        {
            set { _in_led_info = value; }
            get { return _in_led_info; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OUT_LED_INFO
        {
            set { _out_led_info = value; }
            get { return _out_led_info; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? LOCK_FLAG
        {
            set { _lock_flag = value; }
            get { return _lock_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LOCK_TIME
        {
            set { _lock_time = value; }
            get { return _lock_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? HAS_CORRECT
        {
            set { _has_correct = value; }
            get { return _has_correct; }
        }
        #endregion Model
    }
}
