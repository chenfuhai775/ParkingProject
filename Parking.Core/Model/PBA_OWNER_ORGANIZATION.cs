/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_ORGANIZATION.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_ORGANIZATION
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:13   N/A    初版
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
	/// 管理停车场业主组织架构管理，无限层级
	/// </summary>
	[Serializable]
	public partial class PBA_OWNER_ORGANIZATION
	{
		public PBA_OWNER_ORGANIZATION()
		{}
		#region Model
		private string _organization_code;
		private string _organization_name;
		private string _remark;
		private DateTime? _create_time;
		private string _create_username;
		private DateTime? _update_time;
		private string _update_username;
		private int? _organization_level;
		/// <summary>
		/// 主键
		/// </summary>
		public string ORGANIZATION_CODE
		{
			set{ _organization_code=value;}
			get{return _organization_code;}
		}
		/// <summary>
		/// 组织名称
		/// </summary>
		public string ORGANIZATION_NAME
		{
			set{ _organization_name=value;}
			get{return _organization_name;}
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
		public string CREATE_USERNAME
		{
			set{ _create_username=value;}
			get{return _create_username;}
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
		public string UPDATE_USERNAME
		{
			set{ _update_username=value;}
			get{return _update_username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORGANIZATION_LEVEL
		{
			set{ _organization_level=value;}
			get{return _organization_level;}
		}
		#endregion Model

	}
}

