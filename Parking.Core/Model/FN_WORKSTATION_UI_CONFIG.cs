/**  版本信息模板在安装目录下，可自行修改。
* FN_WORKSTATION_UI_CONFIG.cs
*
* 功 能： N/A
* 类 名： FN_WORKSTATION_UI_CONFIG
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
	/// 工作站布局配置
	/// </summary>
	[Serializable]
	public partial class FN_WORKSTATION_UI_CONFIG
	{
		public FN_WORKSTATION_UI_CONFIG()
		{}
		#region Model
		private string _id;
		private string _workstation_code;
		private int? _fixed_flag;
		private string _resource_code;
		private string _resolution;
		private int _initial_width;
		private int _initial_height;
		private int _initial_left_width;
		private int _initial_top_height;
		private DateTime? _create_time;
		private string _create_userid;
		private string _temp_name;
		private string _temp_code;
		private string _belong_userid;
		private int? _public_flag;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作站编号
		/// </summary>
		public string WORKSTATION_CODE
		{
			set{ _workstation_code=value;}
			get{return _workstation_code;}
		}
		/// <summary>
		/// 固定标志
		/// </summary>
		public int? FIXED_FLAG
		{
			set{ _fixed_flag=value;}
			get{return _fixed_flag;}
		}
		/// <summary>
		/// 资源编码
		/// </summary>
		public string RESOURCE_CODE
		{
			set{ _resource_code=value;}
			get{return _resource_code;}
		}
		/// <summary>
		/// 分辨率
		/// </summary>
		public string RESOLUTION
		{
			set{ _resolution=value;}
			get{return _resolution;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int INITIAL_WIDTH
		{
			set{ _initial_width=value;}
			get{return _initial_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int INITIAL_HEIGHT
		{
			set{ _initial_height=value;}
			get{return _initial_height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int INITIAL_LEFT_WIDTH
		{
			set{ _initial_left_width=value;}
			get{return _initial_left_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int INITIAL_TOP_HEIGHT
		{
			set{ _initial_top_height=value;}
			get{return _initial_top_height;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATE_USERID
		{
			set{ _create_userid=value;}
			get{return _create_userid;}
		}
		/// <summary>
		/// 模版名称
		/// </summary>
		public string TEMP_NAME
		{
			set{ _temp_name=value;}
			get{return _temp_name;}
		}
		/// <summary>
		/// 模版编号
		/// </summary>
		public string TEMP_CODE
		{
			set{ _temp_code=value;}
			get{return _temp_code;}
		}
		/// <summary>
		/// 所属用户
		/// </summary>
		public string BELONG_USERID
		{
			set{ _belong_userid=value;}
			get{return _belong_userid;}
		}
		/// <summary>
		/// 是否公用
		/// </summary>
		public int? PUBLIC_FLAG
		{
			set{ _public_flag=value;}
			get{return _public_flag;}
		}
		#endregion Model

	}
}

