/**  版本信息模板在安装目录下，可自行修改。
* UP_DYNAMIC_PARAMETERS_DICT.cs
*
* 功 能： N/A
* 类 名： UP_DYNAMIC_PARAMETERS_DICT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:22   N/A    初版
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
	/// 功能动态参数字典维护
	/// </summary>
	[Serializable]
	public partial class UP_DYNAMIC_PARAMETERS_DICT
	{
		public UP_DYNAMIC_PARAMETERS_DICT()
		{}
		#region Model
		private string _id;
		private string _resource_code;
		private string _systen_code;
		private string _service_code;
		private string _display_name;
		private int? _field_type;
		private string _default_val;
		private string _filling_dict_code;
		private string _remark;
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
		/// 资源编码
		/// </summary>
		public string RESOURCE_CODE
		{
			set{ _resource_code=value;}
			get{return _resource_code;}
		}
		/// <summary>
		/// 系统管理编码
		/// </summary>
		public string SYSTEN_CODE
		{
			set{ _systen_code=value;}
			get{return _systen_code;}
		}
		/// <summary>
		/// 服务编号
		/// </summary>
		public string SERVICE_CODE
		{
			set{ _service_code=value;}
			get{return _service_code;}
		}
		/// <summary>
		/// 显示名
		/// </summary>
		public string DISPLAY_NAME
		{
			set{ _display_name=value;}
			get{return _display_name;}
		}
		/// <summary>
		/// 0 文本框    1复选框    2 Boolean型   3 下拉列表
		/// </summary>
		public int? FIELD_TYPE
		{
			set{ _field_type=value;}
			get{return _field_type;}
		}
		/// <summary>
		/// 默认值
		/// </summary>
		public string DEFAULT_VAL
		{
			set{ _default_val=value;}
			get{return _default_val;}
		}
		/// <summary>
		/// 如果字段类型为 复选框、下拉列表， 则此字段值对应字典表的父键，当成候选值
		/// </summary>
		public string FILLING_DICT_CODE
		{
			set{ _filling_dict_code=value;}
			get{return _filling_dict_code;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
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

