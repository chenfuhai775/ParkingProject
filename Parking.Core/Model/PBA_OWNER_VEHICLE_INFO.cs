/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_VEHICLE_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_VEHICLE_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:14   N/A    初版
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
	/// 车主车辆信息
	/// </summary>
	[Serializable]
	public partial class PBA_OWNER_VEHICLE_INFO
	{
		public PBA_OWNER_VEHICLE_INFO()
		{}
		#region Model
		private string _id;
		private string _owner_code;
		private string _vehicle_no;
		private string _vehicle_color;
		private int? _vehicle_type;
		private string _vehicle_category;
		private string _vehicle_logo;
		private DateTime? _create_time;
		private string _create_username;
		private DateTime? _update_time;
		private string _update_username;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 业主编号
		/// </summary>
		public string OWNER_CODE
		{
			set{ _owner_code=value;}
			get{return _owner_code;}
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
		/// 车辆颜色
		/// </summary>
		public string VEHICLE_COLOR
		{
			set{ _vehicle_color=value;}
			get{return _vehicle_color;}
		}
		/// <summary>
		/// 车辆类型
		/// </summary>
		public int? VEHICLE_TYPE
		{
			set{ _vehicle_type=value;}
			get{return _vehicle_type;}
		}
		/// <summary>
		/// 车辆类别， 就是属于什么牌子
		/// </summary>
		public string VEHICLE_CATEGORY
		{
			set{ _vehicle_category=value;}
			get{return _vehicle_category;}
		}
		/// <summary>
		/// 车辆的车标管理， 显示URL
		/// </summary>
		public string VEHICLE_LOGO
		{
			set{ _vehicle_logo=value;}
			get{return _vehicle_logo;}
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
		#endregion Model

	}
}

