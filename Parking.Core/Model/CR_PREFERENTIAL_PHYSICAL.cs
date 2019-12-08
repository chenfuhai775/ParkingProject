/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_PHYSICAL.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_PHYSICAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:04   N/A    初版
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
	/// 用于发二维码优惠卷或者优惠码，一个优惠卷只能消费一次的
	/// </summary>
	[Serializable]
	public partial class CR_PREFERENTIAL_PHYSICAL
	{
		public CR_PREFERENTIAL_PHYSICAL()
		{}
		#region Model
		private string _id;
		private string _preferential_code;
		private string _preferentia_ident;
		private int? _cr_preferential_type;
		private int? _employ_type;
		private DateTime? _employ_time;
		private DateTime? _create_time;
		private string _create_user_id;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 优惠项目表ID
		/// </summary>
		public string PREFERENTIAL_CODE
		{
			set{ _preferential_code=value;}
			get{return _preferential_code;}
		}
		/// <summary>
		/// 优惠唯一标识
		/// </summary>
		public string PREFERENTIA_IDENT
		{
			set{ _preferentia_ident=value;}
			get{return _preferentia_ident;}
		}
		/// <summary>
		/// 二维码、优惠码、其他
		/// </summary>
		public int? CR_PREFERENTIAL_TYPE
		{
			set{ _cr_preferential_type=value;}
			get{return _cr_preferential_type;}
		}
		/// <summary>
		/// 是否使用
		/// </summary>
		public int? EMPLOY_TYPE
		{
			set{ _employ_type=value;}
			get{return _employ_type;}
		}
		/// <summary>
		/// 使用时间
		/// </summary>
		public DateTime? EMPLOY_TIME
		{
			set{ _employ_time=value;}
			get{return _employ_time;}
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
		public string CREATE_USER_ID
		{
			set{ _create_user_id=value;}
			get{return _create_user_id;}
		}
		#endregion Model

	}
}

