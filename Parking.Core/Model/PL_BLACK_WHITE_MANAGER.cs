/**  版本信息模板在安装目录下，可自行修改。
* PL_BLACK_WHITE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PL_BLACK_WHITE_MANAGER
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
	/// 黑白名单
	/// </summary>
	[Serializable]
	public partial class PL_BLACK_WHITE_MANAGER
	{
		public PL_BLACK_WHITE_MANAGER()
		{}
		#region Model
		private string _unique_identifier;
		private string _vehicle_no;
		private int? _data_type;
		private DateTime? _create_time;
		private string _create_id;
		private string _id;
		private string _customer_id;
		private string _remark;
		private int? _take_up_spaces=0;
		/// <summary>
		/// 通行证唯一标识
		/// </summary>
		public string UNIQUE_IDENTIFIER
		{
			set{ _unique_identifier=value;}
			get{return _unique_identifier;}
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
		/// 数据类型
		/// </summary>
		public int? DATA_TYPE
		{
			set{ _data_type=value;}
			get{return _data_type;}
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
		public string CREATE_ID
		{
			set{ _create_id=value;}
			get{return _create_id;}
		}
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
		public string CUSTOMER_ID
		{
			set{ _customer_id=value;}
			get{return _customer_id;}
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
		public int? TAKE_UP_SPACES
		{
			set{ _take_up_spaces=value;}
			get{return _take_up_spaces;}
		}
		#endregion Model

	}
}

