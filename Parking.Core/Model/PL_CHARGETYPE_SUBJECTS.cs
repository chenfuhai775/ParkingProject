/**  版本信息模板在安装目录下，可自行修改。
* PL_CHARGETYPE_SUBJECTS.cs
*
* 功 能： N/A
* 类 名： PL_CHARGETYPE_SUBJECTS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:20   N/A    初版
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
	/// 收费与科目对应表
	/// </summary>
	[Serializable]
	public partial class PL_CHARGETYPE_SUBJECTS
	{
		public PL_CHARGETYPE_SUBJECTS()
		{}
		#region Model
		private string _id;
		private string _subject_code;
		private int? _pay_type;
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 科目编号
		/// </summary>
		public string SUBJECT_CODE
		{
			set{ _subject_code=value;}
			get{return _subject_code;}
		}
		/// <summary>
		/// 0  预交费     1超时补缴    2出场缴费  3 月卡缴费   4储值卡缴费   
		/// </summary>
		public int? PAY_TYPE
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
		}
		#endregion Model

	}
}

