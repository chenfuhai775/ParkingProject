/**  版本信息模板在安装目录下，可自行修改。
* WF_ProcessNode.cs
*
* 功 能： N/A
* 类 名： WF_ProcessNode
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:27   N/A    初版
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
	public partial class WF_ProcessNode
	{
		public WF_ProcessNode()
		{}
		#region Model
		private string _id;
		private string _nodename;
		private string _nodecode;
		private string _flowid;
		private string _previousnode;
		private string _nextnode;
		private string _jumpnode;
		private bool _determine= false;
		private bool _ismodel= false;
		private bool _pn_flag= true;
		private int? _pn_sort;
		private string _remark;
		private decimal? _position_x;
		private decimal? _position_y;
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
		public string NodeName
		{
			set{ _nodename=value;}
			get{return _nodename;}
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
		public string FlowID
		{
			set{ _flowid=value;}
			get{return _flowid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreviousNode
		{
			set{ _previousnode=value;}
			get{return _previousnode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NextNode
		{
			set{ _nextnode=value;}
			get{return _nextnode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JumpNode
		{
			set{ _jumpnode=value;}
			get{return _jumpnode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DeterMine
		{
			set{ _determine=value;}
			get{return _determine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsModel
		{
			set{ _ismodel=value;}
			get{return _ismodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PN_Flag
		{
			set{ _pn_flag=value;}
			get{return _pn_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PN_Sort
		{
			set{ _pn_sort=value;}
			get{return _pn_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? POSITION_X
		{
			set{ _position_x=value;}
			get{return _position_x;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? POSITION_Y
		{
			set{ _position_y=value;}
			get{return _position_y;}
		}
		#endregion Model

	}
}

