/**  版本信息模板在安装目录下，可自行修改。
* BAS_SYSTEM_DATA_DICT.cs
*
* 功 能： N/A
* 类 名： BAS_SYSTEM_DATA_DICT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:22:59   N/A    初版
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
	/// BAS_SYSTEM_DATA_DICT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BAS_SYSTEM_DATA_DICT
	{
		public BAS_SYSTEM_DATA_DICT()
		{}
		#region Model
		private string _id;
		private int? _bott_level;
		private string _create_by;
		private DateTime? _create_time;
		private string _last_update_by;
		private DateTime? _last_update_time;
		private string _model_key;
		private string _model_name;
		private string _model_value;
		private string _parent_model_key;
		private string _remark;
		private int? _sort_no;
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
		public int? BOTT_LEVEL
		{
			set{ _bott_level=value;}
			get{return _bott_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			set{ _create_by=value;}
			get{return _create_by;}
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
		public string LAST_UPDATE_BY
		{
			set{ _last_update_by=value;}
			get{return _last_update_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_UPDATE_TIME
		{
			set{ _last_update_time=value;}
			get{return _last_update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODEL_KEY
		{
			set{ _model_key=value;}
			get{return _model_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODEL_NAME
		{
			set{ _model_name=value;}
			get{return _model_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODEL_VALUE
		{
			set{ _model_value=value;}
			get{return _model_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_MODEL_KEY
		{
			set{ _parent_model_key=value;}
			get{return _parent_model_key;}
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
		public int? SORT_NO
		{
			set{ _sort_no=value;}
			get{return _sort_no;}
		}
		#endregion Model

	}
}

