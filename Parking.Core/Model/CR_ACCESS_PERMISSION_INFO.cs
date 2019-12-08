/**  版本信息模板在安装目录下，可自行修改。
* CR_ACCESS_PERMISSION_INFO.cs
*
* 功 能： N/A
* 类 名： CR_ACCESS_PERMISSION_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:00   N/A    初版
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
	/// 设备通行权限分组
	/// </summary>
	[Serializable]
	public partial class CR_ACCESS_PERMISSION_INFO
	{
		public CR_ACCESS_PERMISSION_INFO()
		{}
		#region Model
		private string _id;
		private string _access_name;
		private string _access_code;
		private int? _is_enable;
		private string _access_permissions;
		private string _access_channel_code;
		private DateTime? _create_time;
		private string _create_userid;
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
		/// 通行权限组名称
		/// </summary>
		public string ACCESS_NAME
		{
			set{ _access_name=value;}
			get{return _access_name;}
		}
		/// <summary>
		/// 通行权限组编号
		/// </summary>
		public string ACCESS_CODE
		{
			set{ _access_code=value;}
			get{return _access_code;}
		}
		/// <summary>
		/// 0 启用   1停用
		/// </summary>
		public int? IS_ENABLE
		{
			set{ _is_enable=value;}
			get{return _is_enable;}
		}
		/// <summary>
		/// 初始化为128位0，每位对应设备机号的通行权限。当拥有对应的权限时把对应位数0 该为 1 

        ///0 表示无权限   1表示有权限
		/// </summary>
		public string ACCESS_PERMISSIONS
		{
			set{ _access_permissions=value;}
			get{return _access_permissions;}
		}
		/// <summary>
		/// 通行通道编号
		/// </summary>
		public string ACCESS_CHANNEL_CODE
		{
			set{ _access_channel_code=value;}
			get{return _access_channel_code;}
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

