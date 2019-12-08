/**  版本信息模板在安装目录下，可自行修改。
* PBA_EQUIPMENT_MANAGEMENT.cs
*
* 功 能： N/A
* 类 名： PBA_EQUIPMENT_MANAGEMENT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:10   N/A    初版
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
	/// 收费标准
	///
	///收费标准采用竖表方式存储
	///
	///当显示值为键值对时， key为显示字段   value为显示值，当显示值为grid列表时，每一行保存一条记录， key为排序号  value为每一行的显示JSON对象
	/// </summary>
	[Serializable]
	public partial class PBA_EQUIPMENT_MANAGEMENT
	{
		public PBA_EQUIPMENT_MANAGEMENT()
		{}
		#region Model
		private string _id;
		private string _display_key;
		private string _display_value;
		private string _grouping_code;
		private string _param_settings_group;
		private DateTime? _update_time;
		private string _update_userid;
		private string _organization_code;
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
		public string DISPLAY_KEY
		{
			set{ _display_key=value;}
			get{return _display_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISPLAY_VALUE
		{
			set{ _display_value=value;}
			get{return _display_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROUPING_CODE
		{
			set{ _grouping_code=value;}
			get{return _grouping_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARAM_SETTINGS_GROUP
		{
			set{ _param_settings_group=value;}
			get{return _param_settings_group;}
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
		/// <summary>
		/// 
		/// </summary>
		public string ORGANIZATION_CODE
		{
			set{ _organization_code=value;}
			get{return _organization_code;}
		}
		#endregion Model

	}
}

