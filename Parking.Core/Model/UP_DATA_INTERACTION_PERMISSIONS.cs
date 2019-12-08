/**  版本信息模板在安装目录下，可自行修改。
* UP_DATA_INTERACTION_PERMISSIONS.cs
*
* 功 能： N/A
* 类 名： UP_DATA_INTERACTION_PERMISSIONS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:21   N/A    初版
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
	/// 数据上传权限控制表
	/// </summary>
	[Serializable]
	public partial class UP_DATA_INTERACTION_PERMISSIONS
	{
		public UP_DATA_INTERACTION_PERMISSIONS()
		{}
		#region Model
		private string _service_code;
		private string _service_name;
		private string _authentication_code;
		private string _service_remark;
		private string _send_type_collection;
		private int? _service_status;
		private int? _start_flag;
		/// <summary>
		/// 服务编号
		/// </summary>
		public string SERVICE_CODE
		{
			set{ _service_code=value;}
			get{return _service_code;}
		}
		/// <summary>
		/// 服务名称
		/// </summary>
		public string SERVICE_NAME
		{
			set{ _service_name=value;}
			get{return _service_name;}
		}
		/// <summary>
		/// 验证码
		/// </summary>
		public string AUTHENTICATION_CODE
		{
			set{ _authentication_code=value;}
			get{return _authentication_code;}
		}
		/// <summary>
		/// 服务描述
		/// </summary>
		public string SERVICE_REMARK
		{
			set{ _service_remark=value;}
			get{return _service_remark;}
		}
		/// <summary>
		/// 多个报文类型时，采用逗号分割
		/// </summary>
		public string SEND_TYPE_COLLECTION
		{
			set{ _send_type_collection=value;}
			get{return _send_type_collection;}
		}
		/// <summary>
		/// 0 在线   1离线
		/// </summary>
		public int? SERVICE_STATUS
		{
			set{ _service_status=value;}
			get{return _service_status;}
		}
		/// <summary>
		/// 0 不启动  默认    1 启动
		/// </summary>
		public int? START_FLAG
		{
			set{ _start_flag=value;}
			get{return _start_flag;}
		}
		#endregion Model

	}
}

