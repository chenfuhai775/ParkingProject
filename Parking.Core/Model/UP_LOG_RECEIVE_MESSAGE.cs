/**  版本信息模板在安装目录下，可自行修改。
* UP_LOG_RECEIVE_MESSAGE.cs
*
* 功 能： N/A
* 类 名： UP_LOG_RECEIVE_MESSAGE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:23   N/A    初版
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
	/// 接收报文处理日志表
	/// </summary>
	[Serializable]
	public partial class UP_LOG_RECEIVE_MESSAGE
	{
		public UP_LOG_RECEIVE_MESSAGE()
		{}
		#region Model
		private string _id;
		private string _msg_type;
		private string _msg_str;
		private DateTime? _create_date;
		private DateTime? _msg_date;
		private string _msg_send_type;
		private string _msg_seq;
		private DateTime? _receipt_msg_date;
		private string _receipt_seq;
		private string _receipt_msg_str;
		private int? _msg_status;
		private string _remark;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 报文类型
		/// </summary>
		public string MSG_TYPE
		{
			set{ _msg_type=value;}
			get{return _msg_type;}
		}
		/// <summary>
		/// 报文内容
		/// </summary>
		public string MSG_STR
		{
			set{ _msg_str=value;}
			get{return _msg_str;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 报文发送时间
		/// </summary>
		public DateTime? MSG_DATE
		{
			set{ _msg_date=value;}
			get{return _msg_date;}
		}
		/// <summary>
		/// 报文发送方
		/// </summary>
		public string MSG_SEND_TYPE
		{
			set{ _msg_send_type=value;}
			get{return _msg_send_type;}
		}
		/// <summary>
		/// 报文流水号
		/// </summary>
		public string MSG_SEQ
		{
			set{ _msg_seq=value;}
			get{return _msg_seq;}
		}
		/// <summary>
		/// 回执发送时间
		/// </summary>
		public DateTime? RECEIPT_MSG_DATE
		{
			set{ _receipt_msg_date=value;}
			get{return _receipt_msg_date;}
		}
		/// <summary>
		/// 回执报文流水号
		/// </summary>
		public string RECEIPT_SEQ
		{
			set{ _receipt_seq=value;}
			get{return _receipt_seq;}
		}
		/// <summary>
		/// 回执报文内容
		/// </summary>
		public string RECEIPT_MSG_STR
		{
			set{ _receipt_msg_str=value;}
			get{return _receipt_msg_str;}
		}
		/// <summary>
		/// 报文处理状态
		/// </summary>
		public int? MSG_STATUS
		{
			set{ _msg_status=value;}
			get{return _msg_status;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

