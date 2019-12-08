/**  版本信息模板在安装目录下，可自行修改。
* PL_ARTIFICIAL_PROCESSING_LOG.cs
*
* 功 能： N/A
* 类 名： PL_ARTIFICIAL_PROCESSING_LOG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:19   N/A    初版
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
	/// 人工处理日志 包含： 软件开闸  遥控开闸
	/// </summary>
	[Serializable]
	public partial class PL_ARTIFICIAL_PROCESSING_LOG
	{
		public PL_ARTIFICIAL_PROCESSING_LOG()
		{}
		#region Model
		private string _id;
		private DateTime? _deal_time;
		private string _deal_userid;
		private string _deal_remark;
		private int? _deal_platform;
		private int? _control_equipment;
		private int? _deal_type;
		private string _inout_recode_id;
		private int? _deal_status;
		private string _channel_type;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? DEAL_TIME
		{
			set{ _deal_time=value;}
			get{return _deal_time;}
		}
		/// <summary>
		/// 处理人员
		/// </summary>
		public string DEAL_USERID
		{
			set{ _deal_userid=value;}
			get{return _deal_userid;}
		}
		/// <summary>
		/// 处理原因
		/// </summary>
		public string DEAL_REMARK
		{
			set{ _deal_remark=value;}
			get{return _deal_remark;}
		}
		/// <summary>
		/// 0 管理中心   1 监控终端
		/// </summary>
		public int? DEAL_PLATFORM
		{
			set{ _deal_platform=value;}
			get{return _deal_platform;}
		}
		/// <summary>
		/// 控制设备
		/// </summary>
		public int? CONTROL_EQUIPMENT
		{
			set{ _control_equipment=value;}
			get{return _control_equipment;}
		}
		/// <summary>
		/// 1录入车牌开闸  2软件直接开闸  3线控开闸    4遥控开闸    

		/// </summary>
		public int? DEAL_TYPE
		{
			set{ _deal_type=value;}
			get{return _deal_type;}
		}
		/// <summary>
		/// 通行记录主键
		/// </summary>
		public string INOUT_RECODE_ID
		{
			set{ _inout_recode_id=value;}
			get{return _inout_recode_id;}
		}
		/// <summary>
		/// 处理结果   0 失败  1成功
		/// </summary>
		public int? DEAL_STATUS
		{
			set{ _deal_status=value;}
			get{return _deal_status;}
		}
		/// <summary>
		/// 进出场类型   I 进场  E出场
		/// </summary>
		public string CHANNEL_TYPE
		{
			set{ _channel_type=value;}
			get{return _channel_type;}
		}
		#endregion Model

	}
}

