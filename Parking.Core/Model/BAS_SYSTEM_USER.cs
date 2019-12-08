/**  版本信息模板在安装目录下，可自行修改。
* BAS_SYSTEM_USER.cs
*
* 功 能： N/A
* 类 名： BAS_SYSTEM_USER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:22:59   N/A    初版
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
	/// BAS_SYSTEM_USER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BAS_SYSTEM_USER
	{
		public BAS_SYSTEM_USER()
		{}
		#region Model
		private string _id;
		private string _user_account;
		private string _user_name;
		private string _pwd;
		private int? _user_type;
		private int? _status;
		private string _mobile;
		private string _email;
		private string _addr;
		private string _user_logo;
		private string _remark;
		private string _org_id;
		private string _create_by;
		private DateTime? _create_time;
		private string _last_update_by;
		private DateTime? _last_update_time;
		private string _create_user_ids;
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
		public string USER_ACCOUNT
		{
			set{ _user_account=value;}
			get{return _user_account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PWD
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? USER_TYPE
		{
			set{ _user_type=value;}
			get{return _user_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MOBILE
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDR
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_LOGO
		{
			set{ _user_logo=value;}
			get{return _user_logo;}
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
		public string ORG_ID
		{
			set{ _org_id=value;}
			get{return _org_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			set{ _create_by=value;}
			get{return _create_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LAST_UPDATE_BY
		{
			set{ _last_update_by=value;}
			get{return _last_update_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_UPDATE_TIME
		{
			set{ _last_update_time=value;}
			get{return _last_update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_USER_IDS
		{
			set{ _create_user_ids=value;}
			get{return _create_user_ids;}
		}
		#endregion Model

	}
}

