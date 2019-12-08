/**  版本信息模板在安装目录下，可自行修改。
* CR_BUSINESS_OPERATION_LOG.cs
*
* 功 能： N/A
* 类 名： CR_BUSINESS_OPERATION_LOG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:00   N/A    初版
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
	/// 设备通行权限分组
	/// </summary>
	[Serializable]
	public partial class CR_BUSINESS_OPERATION_LOG
	{
		public CR_BUSINESS_OPERATION_LOG()
		{}
		#region Model
		private string _id;
		private int? _module_code;
		private string _operating_ip;
		private DateTime? _operating_time;
		private int? _operation_behavior;
		private string _record_id;
		private string _remark;
		private string _user_account;
		private string _user_name;
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
		public int? MODULE_CODE
		{
			set{ _module_code=value;}
			get{return _module_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPERATING_IP
		{
			set{ _operating_ip=value;}
			get{return _operating_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OPERATING_TIME
		{
			set{ _operating_time=value;}
			get{return _operating_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OPERATION_BEHAVIOR
		{
			set{ _operation_behavior=value;}
			get{return _operation_behavior;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECORD_ID
		{
			set{ _record_id=value;}
			get{return _record_id;}
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
		/// 
		/// </summary>
		public string USER_ACCOUNT
		{
			set{ _user_account=value;}
			get{return _user_account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		#endregion Model

	}
}

