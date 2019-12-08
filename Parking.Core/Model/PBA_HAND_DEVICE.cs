/**  版本信息模板在安装目录下，可自行修改。
* PBA_HAND_DEVICE.cs
*
* 功 能： N/A
* 类 名： PBA_HAND_DEVICE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:11   N/A    初版
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
	/// 外接设备参数
	/// </summary>
	[Serializable]
	public partial class PBA_HAND_DEVICE
	{
		public PBA_HAND_DEVICE()
		{}
		#region Model
		private string _id;
		private string _create_by;
		private DateTime? _create_time;
		private string _device_code;
		private string _device_name;
		private string _last_update_by;
		private DateTime? _last_update_time;
		private string _mac_address;
		private string _remark;
		private string _software_version;
		private int? _status;
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
		public string DEVICE_CODE
		{
			set{ _device_code=value;}
			get{return _device_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEVICE_NAME
		{
			set{ _device_name=value;}
			get{return _device_name;}
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
		public string MAC_ADDRESS
		{
			set{ _mac_address=value;}
			get{return _mac_address;}
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
		public string SOFTWARE_VERSION
		{
			set{ _software_version=value;}
			get{return _software_version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

