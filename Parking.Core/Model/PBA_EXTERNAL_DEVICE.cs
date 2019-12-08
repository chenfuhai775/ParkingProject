/**  版本信息模板在安装目录下，可自行修改。
* PBA_EXTERNAL_DEVICE.cs
*
* 功 能： N/A
* 类 名： PBA_EXTERNAL_DEVICE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:10   N/A    初版
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
	/// 收费标准
	///
	///收费标准采用竖表方式存储
	///
	///当显示值为键值对时， key为显示字段   value为显示值，当显示值为grid列表时，每一行保存一条记录， key为排序号  value为每一行的显示JSON对象
	/// </summary>
	[Serializable]
	public partial class PBA_EXTERNAL_DEVICE
	{
		public PBA_EXTERNAL_DEVICE()
		{}
		#region Model
		private string _device_code;
		private string _device_name;
		private int? _device_type;
		private int? _device_number;
		private string _ip_address;
		private int? _port;
		private DateTime? _create_time;
		private string _create_userid;
		private string _remark;
		/// <summary>
		/// 设备编号
		/// </summary>
		public string DEVICE_CODE
		{
			set{ _device_code=value;}
			get{return _device_code;}
		}
		/// <summary>
		/// 设备名称
		/// </summary>
		public string DEVICE_NAME
		{
			set{ _device_name=value;}
			get{return _device_name;}
		}
		/// <summary>
		/// 设备类型
		/// </summary>
		public int? DEVICE_TYPE
		{
			set{ _device_type=value;}
			get{return _device_type;}
		}
		/// <summary>
		/// 设备机号
		/// </summary>
		public int? DEVICE_NUMBER
		{
			set{ _device_number=value;}
			get{return _device_number;}
		}
		/// <summary>
		/// ip地址
		/// </summary>
		public string IP_ADDRESS
		{
			set{ _ip_address=value;}
			get{return _ip_address;}
		}
		/// <summary>
		/// 端口号
		/// </summary>
		public int? PORT
		{
			set{ _port=value;}
			get{return _port;}
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
		public string CREATE_USERID
		{
			set{ _create_userid=value;}
			get{return _create_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

