/**  版本信息模板在安装目录下，可自行修改。
* WF_FlowChart.cs
*
* 功 能： N/A
* 类 名： WF_FlowChart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:25   N/A    初版
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
	/// 需要发送的报文临时存储表
	/// </summary>
	[Serializable]
	public partial class WF_FlowChart
	{
		public WF_FlowChart()
		{}
		#region Model
		private string _id;
		private string _flowname;
		private int _flowtype;
		private string _remark;
		private string _createuserid;
		private DateTime? _createtime= DateTime.Now;
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
		public string FlowName
		{
			set{ _flowname=value;}
			get{return _flowname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FlowType
		{
			set{ _flowtype=value;}
			get{return _flowtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateUserID
		{
			set{ _createuserid=value;}
			get{return _createuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

