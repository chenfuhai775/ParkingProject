/**  版本信息模板在安装目录下，可自行修改。
* PL_ARTIFICIAL_PROCESSING_IMG.cs
*
* 功 能： N/A
* 类 名： PL_ARTIFICIAL_PROCESSING_IMG
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
	/// 人工处理抓拍图片
	/// </summary>
	[Serializable]
	public partial class PL_ARTIFICIAL_PROCESSING_IMG
	{
		public PL_ARTIFICIAL_PROCESSING_IMG()
		{}
		#region Model
		private string _id;
		private string _artificial_processing_id;
		private string _dev_id;
		private string _img_url;
		private int? _img_type;
		private DateTime? _create_time;
		private string _column_7;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 人工处理日志ID
		/// </summary>
		public string ARTIFICIAL_PROCESSING_ID
		{
			set{ _artificial_processing_id=value;}
			get{return _artificial_processing_id;}
		}
		/// <summary>
		/// 设备ID
		/// </summary>
		public string DEV_ID
		{
			set{ _dev_id=value;}
			get{return _dev_id;}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string IMG_URL
		{
			set{ _img_url=value;}
			get{return _img_url;}
		}
		/// <summary>
		/// 图片类型
		/// </summary>
		public int? IMG_TYPE
		{
			set{ _img_type=value;}
			get{return _img_type;}
		}
		/// <summary>
		/// 抓拍时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Column_7
		{
			set{ _column_7=value;}
			get{return _column_7;}
		}
		#endregion Model

	}
}

