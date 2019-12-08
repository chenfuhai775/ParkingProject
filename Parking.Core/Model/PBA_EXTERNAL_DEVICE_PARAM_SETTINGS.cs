/**  版本信息模板在安装目录下，可自行修改。
* PBA_EXTERNAL_DEVICE_PARAM_SETTINGS.cs
*
* 功 能： N/A
* 类 名： PBA_EXTERNAL_DEVICE_PARAM_SETTINGS
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
	/// 外接设备参数
	/// </summary>
	[Serializable]
	public partial class PBA_EXTERNAL_DEVICE_PARAM_SETTINGS
	{
		public PBA_EXTERNAL_DEVICE_PARAM_SETTINGS()
		{}
		#region Model
		private string _id;
		private string _display_key;
		private string _display_value;
		private string _param_settings_group;
		private string _grouping_code;
		private string _device_code;
		private DateTime? _update_time;
		private string _update_userid;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 显示字段
		/// </summary>
		public string DISPLAY_KEY
		{
			set{ _display_key=value;}
			get{return _display_key;}
		}
		/// <summary>
		/// 显示值
		/// </summary>
		public string DISPLAY_VALUE
		{
			set{ _display_value=value;}
			get{return _display_value;}
		}
		/// <summary>
		/// 参数配置分组
		/// </summary>
		public string PARAM_SETTINGS_GROUP
		{
			set{ _param_settings_group=value;}
			get{return _param_settings_group;}
		}
		/// <summary>
		/// 参数配置组内分组 如：收费标准A中包含 键值对，并包含grid列表值则 键值对为一组，grid列表值为一组
		/// </summary>
		public string GROUPING_CODE
		{
			set{ _grouping_code=value;}
			get{return _grouping_code;}
		}
		/// <summary>
		/// 编码规则
		/// </summary>
		public string DEVICE_CODE
		{
			set{ _device_code=value;}
			get{return _device_code;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATE_USERID
		{
			set{ _update_userid=value;}
			get{return _update_userid;}
		}
		#endregion Model

	}
}

