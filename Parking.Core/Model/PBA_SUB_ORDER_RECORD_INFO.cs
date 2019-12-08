/**  版本信息模板在安装目录下，可自行修改。
* PBA_SUB_ORDER_RECORD_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_SUB_ORDER_RECORD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:16   N/A    初版
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
	/// 预定车位订单记录表
	/// </summary>
	[Serializable]
	public partial class PBA_SUB_ORDER_RECORD_INFO
	{
		public PBA_SUB_ORDER_RECORD_INFO()
		{}
		#region Model
		private string _id;
		private string _sub_order_id;
		private DateTime? _begin_time;
		private DateTime? _end_time;
		private decimal? _charge_money;
		private int? _charge_method;
		private int? _pay_type;
		private int? _pay_platform;
		private string _remark;
		private DateTime? _create_time;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 预约主键
		/// </summary>
		public string SUB_ORDER_ID
		{
			set{ _sub_order_id=value;}
			get{return _sub_order_id;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 收费金额
		/// </summary>
		public decimal? CHARGE_MONEY
		{
			set{ _charge_money=value;}
			get{return _charge_money;}
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
		/// 0  预交费     1超时补缴    2出场缴费  3 月卡缴费   4储值卡缴费   
		/// </summary>
		public int? PAY_TYPE
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
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
		/// 记录描述
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		#endregion Model

	}
}

