/**  版本信息模板在安装目录下，可自行修改。
* CR_PARKING_LOG.cs
*
* 功 能： N/A
* 类 名： CR_PARKING_LOG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:04   N/A    初版
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
	/// 交接班记录表
	/// </summary>
	[Serializable]
	public partial class CR_PARKING_LOG
	{
		public CR_PARKING_LOG()
		{}
		#region Model
		private string _id;
		private string _space_code;
		private string _unique_identifier;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 车位编号
		/// </summary>
		public string SPACE_CODE
		{
			set{ _space_code=value;}
			get{return _space_code;}
		}
		/// <summary>
		/// 通行证唯一外键
		/// </summary>
		public string UNIQUE_IDENTIFIER
		{
			set{ _unique_identifier=value;}
			get{return _unique_identifier;}
		}
		#endregion Model

	}
}

