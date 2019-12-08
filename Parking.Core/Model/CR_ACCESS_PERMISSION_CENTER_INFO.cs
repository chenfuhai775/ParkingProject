/**  版本信息模板在安装目录下，可自行修改。
* CR_ACCESS_PERMISSION_CENTER_INFO.cs
*
* 功 能： N/A
* 类 名： CR_ACCESS_PERMISSION_CENTER_INFO
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
	/// 统计用户常用的模块和自定义模块，在首页处进行快捷访问
	/// </summary>
	[Serializable]
	public partial class CR_ACCESS_PERMISSION_CENTER_INFO
	{
		public CR_ACCESS_PERMISSION_CENTER_INFO()
		{}
		#region Model
		private string _id;
		private string _owner_code;
		private string _access_permission_id;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 业主编号
		/// </summary>
		public string OWNER_CODE
		{
			set{ _owner_code=value;}
			get{return _owner_code;}
		}
		/// <summary>
		/// 设备通行权限组ID
		/// </summary>
		public string ACCESS_PERMISSION_ID
		{
			set{ _access_permission_id=value;}
			get{return _access_permission_id;}
		}
		#endregion Model

	}
}

