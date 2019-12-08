/**  版本信息模板在安装目录下，可自行修改。
* CR_LICENSE_ANALYSIS_CORRECTION.cs
*
* 功 能： N/A
* 类 名： CR_LICENSE_ANALYSIS_CORRECTION
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	/// 车牌识别纠正分析表
	/// </summary>
	[Serializable]
	public partial class CR_LICENSE_ANALYSIS_CORRECTION
	{
		public CR_LICENSE_ANALYSIS_CORRECTION()
		{}
		#region Model
		private string _id;
		private string _veh_no_error;
		private string _veh_no_correct;
		private int? _passage_count;
		private int? _error_count;
		private int? _correct_flag;
		private DateTime? _create_time;
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
		/// 错误车牌
		/// </summary>
		public string VEH_NO_ERROR
		{
			set{ _veh_no_error=value;}
			get{return _veh_no_error;}
		}
		/// <summary>
		/// 矫正车牌
		/// </summary>
		public string VEH_NO_CORRECT
		{
			set{ _veh_no_correct=value;}
			get{return _veh_no_correct;}
		}
		/// <summary>
		/// 通行次数
		/// </summary>
		public int? PASSAGE_COUNT
		{
			set{ _passage_count=value;}
			get{return _passage_count;}
		}
		/// <summary>
		/// 错误次数
		/// </summary>
		public int? ERROR_COUNT
		{
			set{ _error_count=value;}
			get{return _error_count;}
		}
		/// <summary>
		/// 是否自动纠正
		/// </summary>
		public int? CORRECT_FLAG
		{
			set{ _correct_flag=value;}
			get{return _correct_flag;}
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

