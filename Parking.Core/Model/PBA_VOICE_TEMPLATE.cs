/**  版本信息模板在安装目录下，可自行修改。
* PBA_VOICE_TEMPLATE.cs
*
* 功 能： N/A
* 类 名： PBA_VOICE_TEMPLATE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:17   N/A    初版
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
	/// 预定车位订单记录表
	/// </summary>
	[Serializable]
	public partial class PBA_VOICE_TEMPLATE
	{
		public PBA_VOICE_TEMPLATE()
		{}
		#region Model
		private string _id;
		private string _create_user;
		private DateTime? _create_time;
		private string _custom_model;
		private string _default_info;
		private int? _model_type;
		private string _remark;
		private int? _unit_type;
		private string _model_type_key;
		private string _unit_type_key;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATE_USER
		{
			set{ _create_user=value;}
			get{return _create_user;}
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
		/// 
		/// </summary>
		public string CUSTOM_MODEL
		{
			set{ _custom_model=value;}
			get{return _custom_model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEFAULT_INFO
		{
			set{ _default_info=value;}
			get{return _default_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MODEL_TYPE
		{
			set{ _model_type=value;}
			get{return _model_type;}
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
		public int? UNIT_TYPE
		{
			set{ _unit_type=value;}
			get{return _unit_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODEL_TYPE_KEY
		{
			set{ _model_type_key=value;}
			get{return _model_type_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT_TYPE_KEY
		{
			set{ _unit_type_key=value;}
			get{return _unit_type_key;}
		}
		#endregion Model

	}
}

