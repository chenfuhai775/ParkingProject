/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_POLICIES.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_POLICIES
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:05   N/A    初版
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
	/// 优惠策略
	/// </summary>
	[Serializable]
	public partial class CR_PREFERENTIAL_POLICIES
	{
		public CR_PREFERENTIAL_POLICIES()
		{}
		#region Model
		private string _policies_code;
		private string _policies_name;
		private string _create_user;
		private DateTime? _create_time;
		/// <summary>
		/// 优惠策略编号
		/// </summary>
		public string POLICIES_CODE
		{
			set{ _policies_code=value;}
			get{return _policies_code;}
		}
		/// <summary>
		/// 优惠策略名称
		/// </summary>
		public string POLICIES_NAME
		{
			set{ _policies_name=value;}
			get{return _policies_name;}
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
		#endregion Model

	}
}

