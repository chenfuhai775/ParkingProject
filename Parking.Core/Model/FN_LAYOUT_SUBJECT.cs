/**  版本信息模板在安装目录下，可自行修改。
* FN_LAYOUT_SUBJECT.cs
*
* 功 能： N/A
* 类 名： FN_LAYOUT_SUBJECT
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
	public partial class FN_LAYOUT_SUBJECT
	{
		public FN_LAYOUT_SUBJECT()
		{}
		#region Model
		private string _id;
		private string _main_id;
		private string _client_type;
		private decimal? _width;
		private decimal? _height;
		private decimal? _leef_x;
		private decimal? _leef_y;
		private string _parent_id;
		private string _css_info;
		private string _device_id;
		private string _title;
		private string _name;
		private string _html_tag;
		private int? _panel_flag;
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
		public string MAIN_ID
		{
			set{ _main_id=value;}
			get{return _main_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_TYPE
		{
			set{ _client_type=value;}
			get{return _client_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WIDTH
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HEIGHT
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LEEF_X
		{
			set{ _leef_x=value;}
			get{return _leef_x;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LEEF_Y
		{
			set{ _leef_y=value;}
			get{return _leef_y;}
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
		public string CSS_INFO
		{
			set{ _css_info=value;}
			get{return _css_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TITLE
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTML_TAG
		{
			set{ _html_tag=value;}
			get{return _html_tag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PANEL_FLAG
		{
			set{ _panel_flag=value;}
			get{return _panel_flag;}
		}
		#endregion Model

	}
}

