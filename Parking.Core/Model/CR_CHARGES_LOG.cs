/**  版本信息模板在安装目录下，可自行修改。
* CR_CHARGES_LOG.cs
*
* 功 能： N/A
* 类 名： CR_CHARGES_LOG
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
	/// 所有充值缴费的记录
	///
	///月卡开卡   月卡延期   储值卡开卡   储值卡充值   临时卡收费 等等
	/// </summary>
	[Serializable]
	public partial class CR_CHARGES_LOG
	{
		public CR_CHARGES_LOG()
		{}
		#region Model
		private string _id;
		private string _traffic_permit_type_identity;
		private int? _traffic_permit_type;
		private string _unique_identifier;
		private int? _charge_method;
		private decimal _charge_money=0;
		private DateTime? _charge_time;
		private string _charge_userid;
		private string _vehicle_no;
		private DateTime _begin_time;
		private DateTime _end_time;
		private int? _stop_time;
		private string _in_channel_code;
		private string _out_channel_code;
		private string _partition_code;
		private string _billing_address;
		private int? _pay_type;
		private string _charges_eq_id;
		private int? _pay_platform;
		private string _owner_code;
		private string _space_code;
		private string _remark;
		private decimal _due_money=0;
		private decimal _pre_money=0;
		private string _in_field_code;
		private string _in_partition_code;
		private string _out_field_code;
		private string _out_partition_code;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 0 临时卡   1月卡   2储值卡
		/// </summary>
		public string TRAFFIC_PERMIT_TYPE_IDENTITY
		{
			set{ _traffic_permit_type_identity=value;}
			get{return _traffic_permit_type_identity;}
		}
		/// <summary>
		/// 为方便查询，存储通行证类型的值，并非外键
		/// </summary>
		public int? TRAFFIC_PERMIT_TYPE
		{
			set{ _traffic_permit_type=value;}
			get{return _traffic_permit_type;}
		}
		/// <summary>
		/// 通行证唯一标识
		/// </summary>
		public string UNIQUE_IDENTIFIER
		{
			set{ _unique_identifier=value;}
			get{return _unique_identifier;}
		}
		/// <summary>
		/// 0 现金收费  1微信收费  2支付宝收费
		/// </summary>
		public int? CHARGE_METHOD
		{
			set{ _charge_method=value;}
			get{return _charge_method;}
		}
		/// <summary>
		/// 收费金额
		/// </summary>
		public decimal CHARGE_MONEY
		{
			set{ _charge_money=value;}
			get{return _charge_money;}
		}
		/// <summary>
		/// 收费时间
		/// </summary>
		public DateTime? CHARGE_TIME
		{
			set{ _charge_time=value;}
			get{return _charge_time;}
		}
		/// <summary>
		/// 收费人
		/// </summary>
		public string CHARGE_USERID
		{
			set{ _charge_userid=value;}
			get{return _charge_userid;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string VEHICLE_NO
		{
			set{ _vehicle_no=value;}
			get{return _vehicle_no;}
		}
		/// <summary>
		/// 缴费开始时间
		/// </summary>
		public DateTime BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 缴费结束时间
		/// </summary>
		public DateTime END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 停车时长
		/// </summary>
		public int? STOP_TIME
		{
			set{ _stop_time=value;}
			get{return _stop_time;}
		}
		/// <summary>
		/// 入口通道
		/// </summary>
		public string IN_CHANNEL_CODE
		{
			set{ _in_channel_code=value;}
			get{return _in_channel_code;}
		}
		/// <summary>
		/// 出口通道
		/// </summary>
		public string OUT_CHANNEL_CODE
		{
			set{ _out_channel_code=value;}
			get{return _out_channel_code;}
		}
		/// <summary>
		/// 所属分区
		/// </summary>
		public string PARTITION_CODE
		{
			set{ _partition_code=value;}
			get{return _partition_code;}
		}
		/// <summary>
		/// 收费地点
		/// </summary>
		public string BILLING_ADDRESS
		{
			set{ _billing_address=value;}
			get{return _billing_address;}
		}
		/// <summary>
		/// 0  预交费     1超时补缴    2出场缴费  3 月卡缴费   4储值卡缴费   
		/// </summary>
		public int? PAY_TYPE
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
		}
		/// <summary>
		/// 收费手持设备
		/// </summary>
		public string CHARGES_EQ_ID
		{
			set{ _charges_eq_id=value;}
			get{return _charges_eq_id;}
		}
		/// <summary>
		/// 支付平台
		/// </summary>
		public int? PAY_PLATFORM
		{
			set{ _pay_platform=value;}
			get{return _pay_platform;}
		}
		/// <summary>
		/// 业主编号
		/// </summary>
		public string OWNER_CODE
		{
			set{ _owner_code=value;}
			get{return _owner_code;}
		}
		/// <summary>
		/// 车位编号
		/// </summary>
		public string SPACE_CODE
		{
			set{ _space_code=value;}
			get{return _space_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 应收金额
		/// </summary>
		public decimal DUE_MONEY
		{
			set{ _due_money=value;}
			get{return _due_money;}
		}
		/// <summary>
		/// 优惠金额
		/// </summary>
		public decimal PRE_MONEY
		{
			set{ _pre_money=value;}
			get{return _pre_money;}
		}
		/// <summary>
		/// 入场工作站
		/// </summary>
		public string IN_FIELD_CODE
		{
			set{ _in_field_code=value;}
			get{return _in_field_code;}
		}
		/// <summary>
		/// 入场分区
		/// </summary>
		public string IN_PARTITION_CODE
		{
			set{ _in_partition_code=value;}
			get{return _in_partition_code;}
		}
		/// <summary>
		/// 出场工作站
		/// </summary>
		public string OUT_FIELD_CODE
		{
			set{ _out_field_code=value;}
			get{return _out_field_code;}
		}
		/// <summary>
		/// 出场分区
		/// </summary>
		public string OUT_PARTITION_CODE
		{
			set{ _out_partition_code=value;}
			get{return _out_partition_code;}
		}
		#endregion Model

	}
}

