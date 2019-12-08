/**  版本信息模板在安装目录下，可自行修改。
* PL_ACCESS_RIGHTS_MANAGERS.cs
*
* 功 能： N/A
* 类 名： PL_ACCESS_RIGHTS_MANAGERS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:18   N/A    初版
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
	/// 临时授权通行或者临时授权禁行
	/// </summary>
	[Serializable]
	public partial class PL_ACCESS_RIGHTS_MANAGERS
	{
		public PL_ACCESS_RIGHTS_MANAGERS()
		{}
		#region Model
		private string _id;
		private string _vehicle_no;
		private DateTime _begin_time;
		private DateTime _end_time;
		private int? _accredit_number;
		private string _accredit_remark;
		private int? _accredit_type;
		private string _speech_content;
		private string _led_content;
		private DateTime? _create_time;
		private string _create_userid;
		private DateTime? _update_time;
		private string _update_userid;
		private int? _timeout_biling;
		private string _access_permissions;
		private string _access_channel_code;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
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
		/// 有效开始时间
		/// </summary>
		public DateTime BEGIN_TIME
		{
			set{ _begin_time=value;}
			get{return _begin_time;}
		}
		/// <summary>
		/// 有效结束时间
		/// </summary>
		public DateTime END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 授权次数
		/// </summary>
		public int? ACCREDIT_NUMBER
		{
			set{ _accredit_number=value;}
			get{return _accredit_number;}
		}
		/// <summary>
		/// 授权原因
		/// </summary>
		public string ACCREDIT_REMARK
		{
			set{ _accredit_remark=value;}
			get{return _accredit_remark;}
		}
		/// <summary>
		/// 1 通行  0 禁行
		/// </summary>
		public int? ACCREDIT_TYPE
		{
			set{ _accredit_type=value;}
			get{return _accredit_type;}
		}
		/// <summary>
		/// 语音播报内容
		/// </summary>
		public string SPEECH_CONTENT
		{
			set{ _speech_content=value;}
			get{return _speech_content;}
		}
		/// <summary>
		/// LED显示内容
		/// </summary>
		public string LED_CONTENT
		{
			set{ _led_content=value;}
			get{return _led_content;}
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
		public string CREATE_USERID
		{
			set{ _create_userid=value;}
			get{return _create_userid;}
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
		public string UPDATE_USERID
		{
			set{ _update_userid=value;}
			get{return _update_userid;}
		}
		/// <summary>
		/// 1计费 0不计费
		/// </summary>
		public int? TIMEOUT_BILING
		{
			set{ _timeout_biling=value;}
			get{return _timeout_biling;}
		}
		/// <summary>
		/// 初始化为128位0，每位对应控制板编号的通行权限。当拥有对应的权限时把对应位数0 该为 1 

        ///0 表示无权限   1表示有权限
		/// </summary>
		public string ACCESS_PERMISSIONS
		{
			set{ _access_permissions=value;}
			get{return _access_permissions;}
		}
		/// <summary>
		/// 通行通道编号
		/// </summary>
		public string ACCESS_CHANNEL_CODE
		{
			set{ _access_channel_code=value;}
			get{return _access_channel_code;}
		}
		#endregion Model

	}
}

