/**  版本信息模板在安装目录下，可自行修改。
* CR_PARK_EXCHANGE.cs
*
* 功 能： N/A
* 类 名： CR_PARK_EXCHANGE
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
	/// 交接班记录表
	/// </summary>
	[Serializable]
	public partial class CR_PARK_EXCHANGE
	{
		public CR_PARK_EXCHANGE()
		{}
		#region Model
		private string _id;
		private string _user_id;
		private string _user_account;
		private string _user_name;
		private DateTime _login_time;
		private DateTime _eixt_time;
		private int? _enter_num;
		private int? _eixt_num;
		private decimal? _due_money=0M;
		private decimal? _per_money=0M;
		private int? _work_status=0;
		private string _workstation_no;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 用户账户
		/// </summary>
		public string USER_ACCOUNT
		{
			set{ _user_account=value;}
			get{return _user_account;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 上班时间
		/// </summary>
		public DateTime LOGIN_TIME
		{
			set{ _login_time=value;}
			get{return _login_time;}
		}
		/// <summary>
		/// 下班时间
		/// </summary>
		public DateTime EIXT_TIME
		{
			set{ _eixt_time=value;}
			get{return _eixt_time;}
		}
		/// <summary>
		/// 进场次数
		/// </summary>
		public int? ENTER_NUM
		{
			set{ _enter_num=value;}
			get{return _enter_num;}
		}
		/// <summary>
		/// 出场次数
		/// </summary>
		public int? EIXT_NUM
		{
			set{ _eixt_num=value;}
			get{return _eixt_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DUE_MONEY
		{
			set{ _due_money=value;}
			get{return _due_money;}
		}
		/// <summary>
		/// 收费金额
		/// </summary>
		public decimal? PER_MONEY
		{
			set{ _per_money=value;}
			get{return _per_money;}
		}
		/// <summary>
		/// 0 上班   1下班
		/// </summary>
		public int? WORK_STATUS
		{
			set{ _work_status=value;}
			get{return _work_status;}
		}
		/// <summary>
		/// 工作站编号
		/// </summary>
		public string WORKSTATION_NO
		{
			set{ _workstation_no=value;}
			get{return _workstation_no;}
		}
		#endregion Model

	}
}

