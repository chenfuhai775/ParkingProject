/**  版本信息模板在安装目录下，可自行修改。
* COMMON_MODULE_SORT.cs
*
* 功 能： N/A
* 类 名： COMMON_MODULE_SORT
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
	/// 统计用户常用的模块和自定义模块，在首页处进行快捷访问
	/// </summary>
	[Serializable]
	public partial class COMMON_MODULE_SORT
	{
		public COMMON_MODULE_SORT()
		{}
		#region Model
		private string _id;
		private string _user_id;
		private string _module_id;
		private int? _use_count;
		private DateTime? _last_time;
		private int? _manual_sort;
		private string _access_device;
		private string _access_agent;
		private int? _flag_import;
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
		public string USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODULE_ID
		{
			set{ _module_id=value;}
			get{return _module_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? USE_COUNT
		{
			set{ _use_count=value;}
			get{return _use_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_TIME
		{
			set{ _last_time=value;}
			get{return _last_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MANUAL_SORT
		{
			set{ _manual_sort=value;}
			get{return _manual_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCESS_DEVICE
		{
			set{ _access_device=value;}
			get{return _access_device;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCESS_AGENT
		{
			set{ _access_agent=value;}
			get{return _access_agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FLAG_IMPORT
		{
			set{ _flag_import=value;}
			get{return _flag_import;}
		}
		#endregion Model

	}
}

