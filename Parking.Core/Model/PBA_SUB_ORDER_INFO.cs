/**  版本信息模板在安装目录下，可自行修改。
* PBA_SUB_ORDER_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_SUB_ORDER_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:16   N/A    初版
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
	/// 车位预约管理
	/// </summary>
	[Serializable]
	public partial class PBA_SUB_ORDER_INFO
	{
		public PBA_SUB_ORDER_INFO()
		{}
		#region Model
		private string _id;
		private string _subscribe_code;
		private string _user_name;
		private string _system_code;
		private string _system_name;
		private DateTime? _begin_time;
		private DateTime? _end_time;
		private decimal? _charge_money;
		private string _spacecode;
		private string _vehicle_no;
		private int? _subscribe_status;
		private string _remark;
		private string _unique_identifier;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 预约编号
		/// </summary>
		public string SUBSCRIBE_CODE
		{
			set{ _subscribe_code=value;}
			get{return _subscribe_code;}
		}
		/// <summary>
		/// 预约人名称
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 预约系统编号
		/// </summary>
		public string SYSTEM_CODE
		{
			set{ _system_code=value;}
			get{return _system_code;}
		}
		/// <summary>
		/// 预约系统名
		/// </summary>
		public string SYSTEM_NAME
		{
			set{ _system_name=value;}
			get{return _system_name;}
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
		/// 收费金额
		/// </summary>
		public decimal? CHARGE_MONEY
		{
			set{ _charge_money=value;}
			get{return _charge_money;}
		}
		/// <summary>
		/// 车位编号
		/// </summary>
		public string SPACECODE
		{
			set{ _spacecode=value;}
			get{return _spacecode;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string VEHICLE_NO
		{
			set{ _vehicle_no=value;}
			get{return _vehicle_no;}
		}
		/// <summary>
		/// 0  取消   1正常
		/// </summary>
		public int? SUBSCRIBE_STATUS
		{
			set{ _subscribe_status=value;}
			get{return _subscribe_status;}
		}
		/// <summary>
		/// 记录描述
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 通行证唯一标识
		/// </summary>
		public string UNIQUE_IDENTIFIER
		{
			set{ _unique_identifier=value;}
			get{return _unique_identifier;}
		}
		#endregion Model

	}
}

