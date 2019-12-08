/**  版本信息模板在安装目录下，可自行修改。
* PBA_CHARGE_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_CHARGE_INFO
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
	/// </summary>
	[Serializable]
	public partial class PBA_CHARGE_INFO
	{
		public PBA_CHARGE_INFO()
		{}
		#region Model
		private string _charge_code;
		private string _charge_name;
		private int _charge_type = 0;
		private string _charge_param_code;
		private DateTime _create_time;
		private string _create_userid;
		/// <summary>
		/// 收费标准编号
		/// </summary>
		public string CHARGE_CODE
		{
			set{ _charge_code=value;}
			get{return _charge_code;}
		}
		/// <summary>
		/// 收费标准名称
		/// </summary>
		public string CHARGE_NAME
		{
			set{ _charge_name=value;}
			get{return _charge_name;}
		}
		/// <summary>
		/// 0 临时  1 包期
		/// </summary>
		public int CHARGE_TYPE
		{
			set{ _charge_type=value;}
			get{return _charge_type;}
		}
		/// <summary>
		/// 0  按单位时段收费   1 按总计时长收费  2 按次收费 3日夜组合收费  4按停车时长收费
		/// </summary>
		public string CHARGE_PARAM_CODE
		{
			set{ _charge_param_code=value;}
			get{return _charge_param_code;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CREATE_TIME
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

