/**  版本信息模板在安装目录下，可自行修改。
* FN_LAYOUT_MAIN.cs
*
* 功 能： N/A
* 类 名： FN_LAYOUT_MAIN
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
	public partial class FN_LAYOUT_MAIN
	{
		public FN_LAYOUT_MAIN()
		{}
		#region Model
		private string _id;
		private string _workstation_id;
		private string _resolution;
		private int? _initial_leef_width;
		private int? _initial_leef_height;
		private DateTime? _create_time;
		private string _create_user_id;
		private int? _public_flag;
		private string _belong_user;
		private int? _select_flag;
		private string _workstation_name;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作站ID
		/// </summary>
		public string WORKSTATION_ID
		{
			set{ _workstation_id=value;}
			get{return _workstation_id;}
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
		/// 初始化偏移宽度
		/// </summary>
		public int? INITIAL_LEEF_WIDTH
		{
			set{ _initial_leef_width=value;}
			get{return _initial_leef_width;}
		}
		/// <summary>
		/// 初始化偏移高度
		/// </summary>
		public int? INITIAL_LEEF_HEIGHT
		{
			set{ _initial_leef_height=value;}
			get{return _initial_leef_height;}
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
		public string CREATE_USER_ID
		{
			set{ _create_user_id=value;}
			get{return _create_user_id;}
		}
		/// <summary>
		/// 是否公共模板
		/// </summary>
		public int? PUBLIC_FLAG
		{
			set{ _public_flag=value;}
			get{return _public_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BELONG_USER
		{
			set{ _belong_user=value;}
			get{return _belong_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SELECT_FLAG
		{
			set{ _select_flag=value;}
			get{return _select_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORKSTATION_NAME
		{
			set{ _workstation_name=value;}
			get{return _workstation_name;}
		}
		#endregion Model

	}
}

