/**  版本信息模板在安装目录下，可自行修改。
* FN_MODEL_UI_MANAGER.cs
*
* 功 能： N/A
* 类 名： FN_MODEL_UI_MANAGER
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
	/// 模块功能管理
	/// </summary>
	[Serializable]
	public partial class FN_MODEL_UI_MANAGER
	{
		public FN_MODEL_UI_MANAGER()
		{}
		#region Model
		private string _model_code;
		private string _model_name;
		private string _resource_code;
		private DateTime? _create_time;
		private string _create_userid;
		private int? _model_status;
		/// <summary>
		/// 功能编码
		/// </summary>
		public string MODEL_CODE
		{
			set{ _model_code=value;}
			get{return _model_code;}
		}
		/// <summary>
		/// 功能名称
		/// </summary>
		public string MODEL_NAME
		{
			set{ _model_name=value;}
			get{return _model_name;}
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
		/// 功能状态
		/// </summary>
		public int? MODEL_STATUS
		{
			set{ _model_status=value;}
			get{return _model_status;}
		}
		#endregion Model

	}
}

