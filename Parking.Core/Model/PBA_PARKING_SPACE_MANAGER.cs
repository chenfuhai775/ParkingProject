/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_SPACE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_SPACE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
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
	/// 车位管理
	/// </summary>
	[Serializable]
	public partial class PBA_PARKING_SPACE_MANAGER
	{
		public PBA_PARKING_SPACE_MANAGER()
		{}
		#region Model
		private string _space_code;
		private string _inout_record_id;
		private int? _space_status;
		private string _partition_code;
		private int? _space_type;
		private DateTime? _create_time;
		private string _create_username;
		private DateTime? _update_time;
		private string _update_username;
		private string _remark;
		private DateTime _begin_time;
		private DateTime _end_time;
		/// <summary>
		/// 车位编号
		/// </summary>
		public string SPACE_CODE
		{
			set{ _space_code=value;}
			get{return _space_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INOUT_RECORD_ID
		{
			set{ _inout_record_id=value;}
			get{return _inout_record_id;}
		}
		/// <summary>
		/// 0 未使用  1已使用 2已预约
		/// </summary>
		public int? SPACE_STATUS
		{
			set{ _space_status=value;}
			get{return _space_status;}
		}
		/// <summary>
		/// 所属分区
		/// </summary>
		public string PARTITION_CODE
		{
			set{ _partition_code=value;}
			get{return _partition_code;}
		}
		/// <summary>
		/// 0 小车位   1 大车位  2超大车位
		/// </summary>
		public int? SPACE_TYPE
		{
			set{ _space_type=value;}
			get{return _space_type;}
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
		public string CREATE_USERNAME
		{
			set{ _create_username=value;}
			get{return _create_username;}
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
		public string UPDATE_USERNAME
		{
			set{ _update_username=value;}
			get{return _update_username;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		#endregion Model

	}
}

