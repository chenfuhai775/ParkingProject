/**  版本信息模板在安装目录下，可自行修改。
* FN_LAYOUT_PARAM_CONFIG.cs
*
* 功 能： N/A
* 类 名： FN_LAYOUT_PARAM_CONFIG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:07   N/A    初版
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
	/// 布局参数配置
	/// </summary>
	[Serializable]
	public partial class FN_LAYOUT_PARAM_CONFIG
	{
		public FN_LAYOUT_PARAM_CONFIG()
		{}
		#region Model
		private string _id;
		private string _workstation_id;
		private string _model_code;
		private int _initial_width;
		private int _initial_height;
		private int _initial_left_width;
		private int _initial_top_height;
		private DateTime? _create_time;
		private string _create_userid;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作站布局配置ID
		/// </summary>
		public string WORKSTATION_ID
		{
			set{ _workstation_id=value;}
			get{return _workstation_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODEL_CODE
		{
			set{ _model_code=value;}
			get{return _model_code;}
		}
		/// <summary>
		/// 初始宽度
		/// </summary>
		public int INITIAL_WIDTH
		{
			set{ _initial_width=value;}
			get{return _initial_width;}
		}
		/// <summary>
		/// 初始高度
		/// </summary>
		public int INITIAL_HEIGHT
		{
			set{ _initial_height=value;}
			get{return _initial_height;}
		}
		/// <summary>
		/// 初始左边距
		/// </summary>
		public int INITIAL_LEFT_WIDTH
		{
			set{ _initial_left_width=value;}
			get{return _initial_left_width;}
		}
		/// <summary>
		/// 初始上边剧
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
		#endregion Model

	}
}

