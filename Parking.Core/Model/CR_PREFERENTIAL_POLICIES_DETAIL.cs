/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_POLICIES_DETAIL.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_POLICIES_DETAIL
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
	/// 优惠策略明细
	/// </summary>
	[Serializable]
	public partial class CR_PREFERENTIAL_POLICIES_DETAIL
	{
		public CR_PREFERENTIAL_POLICIES_DETAIL()
		{}
		#region Model
		private string _id;
		private string _policies_code;
		private string _cr_preferential_id;
		private int? _is_combination;
		private int? _cr_level;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 优惠策略编号
		/// </summary>
		public string POLICIES_CODE
		{
			set{ _policies_code=value;}
			get{return _policies_code;}
		}
		/// <summary>
		/// 优惠项目表ID
		/// </summary>
		public string CR_PREFERENTIAL_ID
		{
			set{ _cr_preferential_id=value;}
			get{return _cr_preferential_id;}
		}
		/// <summary>
		/// 是否组合
		/// </summary>
		public int? IS_COMBINATION
		{
			set{ _is_combination=value;}
			get{return _is_combination;}
		}
		/// <summary>
		/// 级别
		/// </summary>
		public int? CR_LEVEL
		{
			set{ _cr_level=value;}
			get{return _cr_level;}
		}
		#endregion Model

	}
}

