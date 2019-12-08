/**  版本信息模板在安装目录下，可自行修改。
* CR_TRAFFIC_PERMIT_TYPE.cs
*
* 功 能： N/A
* 类 名： CR_TRAFFIC_PERMIT_TYPE
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
	public partial class CR_TRAFFIC_PERMIT_TYPE
	{
		public CR_TRAFFIC_PERMIT_TYPE()
		{}
		#region Model
		private string _id;
		private string _access_channel_code;
		private string _access_permissions;
		private string _charge_type_code;
		private DateTime? _create_time;
		private string _create_userid;
		private string _identity_name;
		private int? _is_enable;
		private decimal? _pay_money;
		private string _traffic_permit_name;
		private int? _traffic_permit_type;
		private DateTime? _update_time;
		private string _update_userid;
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
		public string ACCESS_CHANNEL_CODE
		{
			set{ _access_channel_code=value;}
			get{return _access_channel_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCESS_PERMISSIONS
		{
			set{ _access_permissions=value;}
			get{return _access_permissions;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHARGE_TYPE_CODE
		{
			set{ _charge_type_code=value;}
			get{return _charge_type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_USERID
		{
			set{ _create_userid=value;}
			get{return _create_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDENTITY_NAME
		{
			set{ _identity_name=value;}
			get{return _identity_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IS_ENABLE
		{
			set{ _is_enable=value;}
			get{return _is_enable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PAY_MONEY
		{
			set{ _pay_money=value;}
			get{return _pay_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRAFFIC_PERMIT_NAME
		{
			set{ _traffic_permit_name=value;}
			get{return _traffic_permit_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TRAFFIC_PERMIT_TYPE
		{
			set{ _traffic_permit_type=value;}
			get{return _traffic_permit_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATE_USERID
		{
			set{ _update_userid=value;}
			get{return _update_userid;}
		}
		#endregion Model

	}
}

