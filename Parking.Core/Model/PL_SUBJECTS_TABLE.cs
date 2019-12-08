/**  版本信息模板在安装目录下，可自行修改。
* PL_SUBJECTS_TABLE.cs
*
* 功 能： N/A
* 类 名： PL_SUBJECTS_TABLE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:21   N/A    初版
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
	/// 财务科目
	/// </summary>
	[Serializable]
	public partial class PL_SUBJECTS_TABLE
	{
		public PL_SUBJECTS_TABLE()
		{}
		#region Model
		private string _subject_code;
		private string _subject_name;
		private int? _subject_type;
		private DateTime? _create_time;
		private string _create_userid;
		/// <summary>
		/// 科目编号
		/// </summary>
		public string SUBJECT_CODE
		{
			set{ _subject_code=value;}
			get{return _subject_code;}
		}
		/// <summary>
		/// 科目名称
		/// </summary>
		public string SUBJECT_NAME
		{
			set{ _subject_name=value;}
			get{return _subject_name;}
		}
		/// <summary>
		/// 科目类别
		/// </summary>
		public int? SUBJECT_TYPE
		{
			set{ _subject_type=value;}
			get{return _subject_type;}
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
		public string CREATE_USERID
		{
			set{ _create_userid=value;}
			get{return _create_userid;}
		}
		#endregion Model

	}
}

