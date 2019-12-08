/**  版本信息模板在安装目录下，可自行修改。
* UP_MSG_TYPE_DICT_INFO.cs
*
* 功 能： N/A
* 类 名： UP_MSG_TYPE_DICT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:24   N/A    初版
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
	/// 报文类型字典表
	/// </summary>
	[Serializable]
	public partial class UP_MSG_TYPE_DICT_INFO
	{
		public UP_MSG_TYPE_DICT_INFO()
		{}
		#region Model
		private string _msg_type;
		private string _msg_name;
		private string _msg_remark;
		private int? _reissue_count;
		private int? _reissue_interval;
		/// <summary>
		/// 报文类型
		/// </summary>
		public string MSG_TYPE
		{
			set{ _msg_type=value;}
			get{return _msg_type;}
		}
		/// <summary>
		/// 报文名称
		/// </summary>
		public string MSG_NAME
		{
			set{ _msg_name=value;}
			get{return _msg_name;}
		}
		/// <summary>
		/// 报文描述
		/// </summary>
		public string MSG_REMARK
		{
			set{ _msg_remark=value;}
			get{return _msg_remark;}
		}
		/// <summary>
		/// 补发次数
		/// </summary>
		public int? REISSUE_COUNT
		{
			set{ _reissue_count=value;}
			get{return _reissue_count;}
		}
		/// <summary>
		/// 时间单位秒
		/// </summary>
		public int? REISSUE_INTERVAL
		{
			set{ _reissue_interval=value;}
			get{return _reissue_interval;}
		}
		#endregion Model

	}
}

