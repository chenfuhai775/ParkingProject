/**  版本信息模板在安装目录下，可自行修改。
* CR_CENTRAL_CHARGE.cs
*
* 功 能： N/A
* 类 名： CR_CENTRAL_CHARGE
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
	/// 预交费记录
	/// </summary>
	[Serializable]
	public partial class CR_CENTRAL_CHARGE
	{
		public CR_CENTRAL_CHARGE()
		{}
		#region Model
		private string _id;
		private string _inout_recode_id;
		private DateTime? _charge_time;
		private string _operator_id;
		private DateTime? _begin_time;
		private DateTime? _end_time;
		private int? _pay_method;
		private string _billing_address;
		private decimal? _advance_money;
		private int? _pay_type;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 通行记录主键
		/// </summary>
		public string INOUT_RECODE_ID
		{
			set{ _inout_recode_id=value;}
			get{return _inout_recode_id;}
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
		public string OPERATOR_ID
		{
			set{ _operator_id=value;}
			get{return _operator_id;}
		}
		/// <summary>
		/// 计费开始时间
		/// </summary>
		public DateTime? BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 计费结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 1:现金支付  2:app支付  3储值卡扣费   4微信支付  5 阿里支付
		/// </summary>
		public int? PAY_METHOD
		{
			set{ _pay_method=value;}
			get{return _pay_method;}
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
		/// 预交金额
		/// </summary>
		public decimal? ADVANCE_MONEY
		{
			set{ _advance_money=value;}
			get{return _advance_money;}
		}
		/// <summary>
		/// 0  预交费     1超时补缴
		/// </summary>
		public int? PAY_TYPE
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
		}
		#endregion Model

	}
}

