/**  版本信息模板在安装目录下，可自行修改。
* PBA_MERCHANT_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_MERCHANT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:12   N/A    初版
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
	/// 有商务合作的商家信息关联表
	/// </summary>
	[Serializable]
	public partial class PBA_MERCHANT_INFO
	{
		public PBA_MERCHANT_INFO()
		{}
		#region Model
		private string _id;
		private string _merchant_name;
		private string _merchant_corporation;
		private string _merchant_certificate_no;
		private string _merchant_logo;
		private string _merchant_address;
		private string _merchant_tel;
		private string _merchant_contacts;
		private string _merchant_qq;
		private string _merchant_wechart;
		private string _merchant_phone;
		private string _merchant_id_card;
		private int? _merchant_type;
		private int? _merchant_nature;
		private int? _merchant_reputation_level;
		private int? _merchant_enable;
		private string _merchant_create_user_name;
		private DateTime? _merchant_create_time;
		private int? _merchant_is_bond;
		private decimal? _merchant_bond;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_NAME
		{
			set{ _merchant_name=value;}
			get{return _merchant_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_CORPORATION
		{
			set{ _merchant_corporation=value;}
			get{return _merchant_corporation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_CERTIFICATE_NO
		{
			set{ _merchant_certificate_no=value;}
			get{return _merchant_certificate_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_LOGO
		{
			set{ _merchant_logo=value;}
			get{return _merchant_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_ADDRESS
		{
			set{ _merchant_address=value;}
			get{return _merchant_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_TEL
		{
			set{ _merchant_tel=value;}
			get{return _merchant_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_CONTACTS
		{
			set{ _merchant_contacts=value;}
			get{return _merchant_contacts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_QQ
		{
			set{ _merchant_qq=value;}
			get{return _merchant_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_WECHART
		{
			set{ _merchant_wechart=value;}
			get{return _merchant_wechart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_PHONE
		{
			set{ _merchant_phone=value;}
			get{return _merchant_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_ID_CARD
		{
			set{ _merchant_id_card=value;}
			get{return _merchant_id_card;}
		}
		/// <summary>
		/// 0.餐饮
        ///1.酒店
        ///2.旅馆
		/// </summary>
		public int? MERCHANT_TYPE
		{
			set{ _merchant_type=value;}
			get{return _merchant_type;}
		}
		/// <summary>
		/// 0.民营企业
        /// 1.事业单位
        /// 2.政府机构

		/// </summary>
		public int? MERCHANT_NATURE
		{
			set{ _merchant_nature=value;}
			get{return _merchant_nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MERCHANT_REPUTATION_LEVEL
		{
			set{ _merchant_reputation_level=value;}
			get{return _merchant_reputation_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MERCHANT_ENABLE
		{
			set{ _merchant_enable=value;}
			get{return _merchant_enable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERCHANT_CREATE_USER_NAME
		{
			set{ _merchant_create_user_name=value;}
			get{return _merchant_create_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MERCHANT_CREATE_TIME
		{
			set{ _merchant_create_time=value;}
			get{return _merchant_create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MERCHANT_IS_BOND
		{
			set{ _merchant_is_bond=value;}
			get{return _merchant_is_bond;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MERCHANT_BOND
		{
			set{ _merchant_bond=value;}
			get{return _merchant_bond;}
		}
		#endregion Model

	}
}

