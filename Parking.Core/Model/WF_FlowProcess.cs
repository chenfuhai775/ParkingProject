/**  版本信息模板在安装目录下，可自行修改。
* WF_FlowProcess.cs
*
* 功 能： N/A
* 类 名： WF_FlowProcess
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:26   N/A    初版
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
	public partial class WF_FlowProcess
	{
		public WF_FlowProcess()
		{}
		#region Model
		private string _id;
		private string _flowcode;
		private string _nodecode;
		private string _recordid;
		private string _carno;
		private string _userid;
		private DateTime? _executiontime;
		private bool _result;
		private string _remark;
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
		public string FlowCode
		{
			set{ _flowcode=value;}
			get{return _flowcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NodeCode
		{
			set{ _nodecode=value;}
			get{return _nodecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecordID
		{
			set{ _recordid=value;}
			get{return _recordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarNo
		{
			set{ _carno=value;}
			get{return _carno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExecutionTime
		{
			set{ _executiontime=value;}
			get{return _executiontime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

