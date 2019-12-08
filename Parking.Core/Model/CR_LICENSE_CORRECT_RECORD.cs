/**  版本信息模板在安装目录下，可自行修改。
* CR_LICENSE_CORRECT_RECORD.cs
*
* 功 能： N/A
* 类 名： CR_LICENSE_CORRECT_RECORD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:03   N/A    初版
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
	/// 车牌纠正记录
	/// </summary>
	[Serializable]
	public partial class CR_LICENSE_CORRECT_RECORD
	{
		public CR_LICENSE_CORRECT_RECORD()
		{}
		#region Model
		private string _id;
		private string _beforechange_vehno;
		private string _afterchange_vehno;
		private string _inout_recode_id;
		private string _deviceid;
		private string _channel_code;
		private DateTime? _change_time;
		private string _change_name;
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
		/// 纠正前车牌
		/// </summary>
		public string BEFORECHANGE_VEHNO
		{
			set{ _beforechange_vehno=value;}
			get{return _beforechange_vehno;}
		}
		/// <summary>
		/// 纠正后车牌
		/// </summary>
		public string AFTERCHANGE_VEHNO
		{
			set{ _afterchange_vehno=value;}
			get{return _afterchange_vehno;}
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
		/// 
		/// </summary>
		public string DEVICEID
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHANNEL_CODE
		{
			set{ _channel_code=value;}
			get{return _channel_code;}
		}
		/// <summary>
		/// 纠正时间
		/// </summary>
		public DateTime? CHANGE_TIME
		{
			set{ _change_time=value;}
			get{return _change_time;}
		}
		/// <summary>
		/// 纠正人
		/// </summary>
		public string CHANGE_NAME
		{
			set{ _change_name=value;}
			get{return _change_name;}
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

