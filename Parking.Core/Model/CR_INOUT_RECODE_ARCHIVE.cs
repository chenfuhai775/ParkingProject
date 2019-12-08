/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE_ARCHIVE.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE_ARCHIVE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	public partial class CR_INOUT_RECODE_ARCHIVE
	{
		public CR_INOUT_RECODE_ARCHIVE()
		{}
		#region Model
		private string _id;
		private string _unique_identifier;
		private string _vehicle_no;
		private string _car_color;
		private string _car_ec_no;
		private int _credentials_type;
		private string _in_field_code;
		private string _in_channel_code;
		private DateTime _in_time;
		private string _in_operator_id;
		private string _in_partition_code;
		private string _in_eq_id;
		private string _in_dev_id;
		private string _in_park_type;
		private string _out_dev_id;
		private string _out_park_type;
		private DateTime _out_time;
		private string _out_field_code;
		private string _out_channel_code;
		private string _out_operator_id;
		private string _out_partition_code;
        private double _total_time;
		private string _curr_partition_code;
		private decimal _due_money;
		private decimal _charge_money;
		private decimal _pre_money;
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
		private int? _has_correct;
		private int? _lock_flag;
		private DateTime? _lock_time;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIQUE_IDENTIFIER
		{
			set{ _unique_identifier=value;}
			get{return _unique_identifier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VEHICLE_NO
		{
			set{ _vehicle_no=value;}
			get{return _vehicle_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CAR_COLOR
		{
			set{ _car_color=value;}
			get{return _car_color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CAR_EC_NO
		{
			set{ _car_ec_no=value;}
			get{return _car_ec_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CREDENTIALS_TYPE
		{
			set{ _credentials_type=value;}
			get{return _credentials_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_FIELD_CODE
		{
			set{ _in_field_code=value;}
			get{return _in_field_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_CHANNEL_CODE
		{
			set{ _in_channel_code=value;}
			get{return _in_channel_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime IN_TIME
		{
			set{ _in_time=value;}
			get{return _in_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_OPERATOR_ID
		{
			set{ _in_operator_id=value;}
			get{return _in_operator_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_PARTITION_CODE
		{
			set{ _in_partition_code=value;}
			get{return _in_partition_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_EQ_ID
		{
			set{ _in_eq_id=value;}
			get{return _in_eq_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_DEV_ID
		{
			set{ _in_dev_id=value;}
			get{return _in_dev_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_PARK_TYPE
		{
			set{ _in_park_type=value;}
			get{return _in_park_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_DEV_ID
		{
			set{ _out_dev_id=value;}
			get{return _out_dev_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_PARK_TYPE
		{
			set{ _out_park_type=value;}
			get{return _out_park_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OUT_TIME
		{
			set{ _out_time=value;}
			get{return _out_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_FIELD_CODE
		{
			set{ _out_field_code=value;}
			get{return _out_field_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_CHANNEL_CODE
		{
			set{ _out_channel_code=value;}
			get{return _out_channel_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_OPERATOR_ID
		{
			set{ _out_operator_id=value;}
			get{return _out_operator_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_PARTITION_CODE
		{
			set{ _out_partition_code=value;}
			get{return _out_partition_code;}
		}
		/// <summary>
		/// 
		/// </summary>
        public double TOTAL_TIME
		{
			set{ _total_time=value;}
			get{return _total_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CURR_PARTITION_CODE
		{
			set{ _curr_partition_code=value;}
			get{return _curr_partition_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal DUE_MONEY
		{
			set{ _due_money=value;}
			get{return _due_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CHARGE_MONEY
		{
			set{ _charge_money=value;}
			get{return _charge_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PRE_MONEY
		{
			set{ _pre_money=value;}
			get{return _pre_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OVERTIMESFJE
		{
			set{ _overtimesfje=value;}
			get{return _overtimesfje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ADVANCE_MONEY
		{
			set{ _advance_money=value;}
			get{return _advance_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PAY_METHOD
		{
			set{ _pay_method=value;}
			get{return _pay_method;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_EQ_ID
		{
			set{ _out_eq_id=value;}
			get{return _out_eq_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PAY_PLATFORM
		{
			set{ _pay_platform=value;}
			get{return _pay_platform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? IN_IMG_TRUST
		{
			set{ _in_img_trust=value;}
			get{return _in_img_trust;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OUT_IMG_TRUST
		{
			set{ _out_img_trust=value;}
			get{return _out_img_trust;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RECODE_STATUS
		{
			set{ _recode_status=value;}
			get{return _recode_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_LED_INFO
		{
			set{ _in_led_info=value;}
			get{return _in_led_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OUT_LED_INFO
		{
			set{ _out_led_info=value;}
			get{return _out_led_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HAS_CORRECT
		{
			set{ _has_correct=value;}
			get{return _has_correct;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LOCK_FLAG
		{
			set{ _lock_flag=value;}
			get{return _lock_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LOCK_TIME
		{
			set{ _lock_time=value;}
			get{return _lock_time;}
		}
		#endregion Model

	}
}

