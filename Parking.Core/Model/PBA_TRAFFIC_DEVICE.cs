/**  版本信息模板在安装目录下，可自行修改。
* PBA_TRAFFIC_DEVICE.cs
*
* 功 能： N/A
* 类 名： PBA_TRAFFIC_DEVICE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:17   N/A    初版
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
	/// 预定车位订单记录表
	/// </summary>
	[Serializable]
	public partial class PBA_TRAFFIC_DEVICE
	{
		public PBA_TRAFFIC_DEVICE()
		{}
		#region Model
		private string _id;
		private string _traffic_value;
		private string _channel_type;
		private string _device_id;
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
		public string TRAFFIC_VALUE
		{
			set{ _traffic_value=value;}
			get{return _traffic_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHANNEL_TYPE
		{
			set{ _channel_type=value;}
			get{return _channel_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		#endregion Model

	}
}

