/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_SPACE_TYPE.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_SPACE_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
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
	/// 车位类型
	/// </summary>
	[Serializable]
	public partial class PBA_PARKING_SPACE_TYPE
	{
		public PBA_PARKING_SPACE_TYPE()
		{}
		#region Model
		private string _id;
		private int _space_type;
		private string _space_type_name;
		private string _charge_code;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 0 小车位   1 大车位  2超大车位 
		/// </summary>
		public int SPACE_TYPE
		{
			set{ _space_type=value;}
			get{return _space_type;}
		}
		/// <summary>
		/// 车位类型名称
		/// </summary>
		public string SPACE_TYPE_NAME
		{
			set{ _space_type_name=value;}
			get{return _space_type_name;}
		}
		/// <summary>
		/// 收费标准编号
		/// </summary>
		public string CHARGE_CODE
		{
			set{ _charge_code=value;}
			get{return _charge_code;}
		}
		#endregion Model

	}
}

