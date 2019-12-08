/**  版本信息模板在安装目录下，可自行修改。
* EXT_PROPERTY_COSTS.cs
*
* 功 能： N/A
* 类 名： EXT_PROPERTY_COSTS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
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
	/// 通行证信息
	/// </summary>
	[Serializable]
	public partial class EXT_PROPERTY_COSTS
	{
		public EXT_PROPERTY_COSTS()
		{}
		#region Model
		private string _room;
		private string _remark;
		private string _pay_month;
		private DateTime? _create_time;
		private DateTime? _update_time;
		private string _id;
		private int? _pay_flag=0;
		/// <summary>
		/// 户主房间编号
		/// </summary>
		public string ROOM
		{
			set{ _room=value;}
			get{return _room;}
		}
		/// <summary>
		/// 请求备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 支付月份
		/// </summary>
		public string PAY_MONTH
		{
			set{ _pay_month=value;}
			get{return _pay_month;}
		}
		/// <summary>
		/// 第一次请求时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 最后一次请求时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 是否支付   0 未交费   1 已交费   2无此房号
		/// </summary>
		public int? PAY_FLAG
		{
			set{ _pay_flag=value;}
			get{return _pay_flag;}
		}
		#endregion Model

	}
}

