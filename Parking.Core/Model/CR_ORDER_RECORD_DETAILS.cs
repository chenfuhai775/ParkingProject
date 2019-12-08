/**  版本信息模板在安装目录下，可自行修改。
* CR_ORDER_RECORD_DETAILS.cs
*
* 功 能： N/A
* 类 名： CR_ORDER_RECORD_DETAILS
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
	public partial class CR_ORDER_RECORD_DETAILS
	{
		public CR_ORDER_RECORD_DETAILS()
		{}
		#region Model
		private string _id;
		private string _order_code;
		private string _in_channel_code;
		private string _out_channel_code;
		private DateTime _in_time;
		private DateTime _out_time;
		private decimal _due_money=0M;
		private decimal _charge_money=0M;
		private decimal _per_money=0M;
		private string _vehicle_no;
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
		public string ORDER_CODE
		{
			set{ _order_code=value;}
			get{return _order_code;}
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
		public string OUT_CHANNEL_CODE
		{
			set{ _out_channel_code=value;}
			get{return _out_channel_code;}
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
		public DateTime OUT_TIME
		{
			set{ _out_time=value;}
			get{return _out_time;}
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
		public decimal PER_MONEY
		{
			set{ _per_money=value;}
			get{return _per_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VEHICLE_NO
		{
			set{ _vehicle_no=value;}
			get{return _vehicle_no;}
		}
		#endregion Model

	}
}

