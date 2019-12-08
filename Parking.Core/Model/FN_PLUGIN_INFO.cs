/**  版本信息模板在安装目录下，可自行修改。
* FN_PLUGIN_INFO.cs
*
* 功 能： N/A
* 类 名： FN_PLUGIN_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:08   N/A    初版
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
	/// 模块功能管理
	/// </summary>
	[Serializable]
	public partial class FN_PLUGIN_INFO
	{
		public FN_PLUGIN_INFO()
		{}
		#region Model
		private string _id;
		private string _workstation_id;
		private string _plugin_type_code;
		private string _plugin_name;
		private string _parent_id;
		private int? _initial_height;
		private int? _initial_width;
		private int? _initial_top_height;
		private int? _initial_left_width;
		private bool _enable;
		private bool _absolute= false;
		private DateTime? _create_time;
		private string _create_userid;
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
		public string WORKSTATION_ID
		{
			set{ _workstation_id=value;}
			get{return _workstation_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PLUGIN_TYPE_CODE
		{
			set{ _plugin_type_code=value;}
			get{return _plugin_type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PLUGIN_NAME
		{
			set{ _plugin_name=value;}
			get{return _plugin_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_ID
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? INITIAL_HEIGHT
		{
			set{ _initial_height=value;}
			get{return _initial_height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? INITIAL_WIDTH
		{
			set{ _initial_width=value;}
			get{return _initial_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? INITIAL_TOP_HEIGHT
		{
			set{ _initial_top_height=value;}
			get{return _initial_top_height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? INITIAL_LEFT_WIDTH
		{
			set{ _initial_left_width=value;}
			get{return _initial_left_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ENABLE
		{
			set{ _enable=value;}
			get{return _enable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ABSOLUTE
		{
			set{ _absolute=value;}
			get{return _absolute;}
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
		#endregion Model

	}
}

