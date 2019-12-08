/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_INFO.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_INFO
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
	/// 优惠项目表
	/// </summary>
	[Serializable]
	public partial class CR_PREFERENTIAL_INFO
	{
		public CR_PREFERENTIAL_INFO()
		{}
		#region Model
		private string _preferential_code;
		private string _preferential_name;
		private int? _preferential_type;
		private decimal? _preferential_content;
		private DateTime? _begin_time;
		private DateTime? _end_time;
		private DateTime? _create_time;
		private string _create_user;
		private int? _policies_object;
		private string _remark;
		private string _merchant_id;
		/// <summary>
		/// 优惠策略编号
		/// </summary>
		public string PREFERENTIAL_CODE
		{
			set{ _preferential_code=value;}
			get{return _preferential_code;}
		}
		/// <summary>
		/// 优惠策略名称
		/// </summary>
		public string PREFERENTIAL_NAME
		{
			set{ _preferential_name=value;}
			get{return _preferential_name;}
		}
		/// <summary>
		/// 优惠类型
		/// </summary>
		public int? PREFERENTIAL_TYPE
		{
			set{ _preferential_type=value;}
			get{return _preferential_type;}
		}
		/// <summary>
		/// 优惠金额
		/// </summary>
		public decimal? PREFERENTIAL_CONTENT
		{
			set{ _preferential_content=value;}
			get{return _preferential_content;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
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
		public string CREATE_USER
		{
			set{ _create_user=value;}
			get{return _create_user;}
		}
		/// <summary>
		/// 0.临时卡优惠
        ///1.包期优惠
        ///2.储值卡优惠
		/// </summary>
		public int? POLICIES_OBJECT
		{
			set{ _policies_object=value;}
			get{return _policies_object;}
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
		public string MERCHANT_ID
		{
			set{ _merchant_id=value;}
			get{return _merchant_id;}
		}
		#endregion Model

	}
}

