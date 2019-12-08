/**  版本信息模板在安装目录下，可自行修改。
* PBA_DEVICE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PBA_DEVICE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:09   N/A    初版
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
	public partial class PBA_DEVICE_MANAGER
	{
		public PBA_DEVICE_MANAGER()
		{}
		#region Model
		private string _id;
		private string _device_name;
		private int _device_type;
		private string _device_img;
		private int? _device_categories;
		private int? _single_flag=0;
		private int? _master_flag;
		private int? _video_flag;
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
		public string DEVICE_NAME
		{
			set{ _device_name=value;}
			get{return _device_name;}
		}
		/// <summary>
		///   1 LONIX车牌识别相机I型（臻识）
         ///     2 LONIX车牌识别相机II型（智信）
          ///    3 LONIX车牌识别相机III型（大华）
          ///    4 环境摄像机
          ///    5 朗易通I型控制板
          ///    6 一体机显示屏
          ///    7 单行显示屏
          ///    8 四行显示屏
         ///     9 余位显示屏
         ///   10 临时计费器
        ///   11 IC卡发行器
		/// </summary>
		public int DEVICE_TYPE
		{
			set{ _device_type=value;}
			get{return _device_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEVICE_IMG
		{
			set{ _device_img=value;}
			get{return _device_img;}
		}
		/// <summary>
		/// 设备类型大类
		/// </summary>
		public int? DEVICE_CATEGORIES
		{
			set{ _device_categories=value;}
			get{return _device_categories;}
		}
		/// <summary>
		/// 是否可独立使用
		/// </summary>
		public int? SINGLE_FLAG
		{
			set{ _single_flag=value;}
			get{return _single_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MASTER_FLAG
		{
			set{ _master_flag=value;}
			get{return _master_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? VIDEO_FLAG
		{
			set{ _video_flag=value;}
			get{return _video_flag;}
		}
		#endregion Model

	}
}

