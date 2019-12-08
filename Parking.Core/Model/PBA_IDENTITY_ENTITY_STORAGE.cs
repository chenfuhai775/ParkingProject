/**  版本信息模板在安装目录下，可自行修改。
* PBA_IDENTITY_ENTITY_STORAGE.cs
*
* 功 能： N/A
* 类 名： PBA_IDENTITY_ENTITY_STORAGE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:11   N/A    初版
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
	/// 身份识别实体入库记录
	/// </summary>
	[Serializable]
	public partial class PBA_IDENTITY_ENTITY_STORAGE
	{
		public PBA_IDENTITY_ENTITY_STORAGE()
		{}
		#region Model
		private string _id;
		private string _identity_id;
		private string _identity_remark;
		private string _identity_visual_id;
		private int? _identity_type;
		private int? _status;
		private string _remark;
		private string _create_user_id;
		private DateTime? _create_time;
		private string _update_user_id;
		private DateTime? _update_time;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类似IC卡物理卡号等身份识别实体的唯一标识
		/// </summary>
		public string IDENTITY_ID
		{
			set{ _identity_id=value;}
			get{return _identity_id;}
		}
		/// <summary>
		/// 存放身份识别实体除唯一识别码外的其他信息，以JSON格式存储
		/// </summary>
		public string IDENTITY_REMARK
		{
			set{ _identity_remark=value;}
			get{return _identity_remark;}
		}
		/// <summary>
		/// 类似印刷卡号等能用肉眼看到得标识
		/// </summary>
		public string IDENTITY_VISUAL_ID
		{
			set{ _identity_visual_id=value;}
			get{return _identity_visual_id;}
		}
		/// <summary>
		/// 0.IC卡   1.暂无
		/// </summary>
		public int? IDENTITY_TYPE
		{
			set{ _identity_type=value;}
			get{return _identity_type;}
		}
		/// <summary>
		/// 0.禁止  1.启用
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 该身份识别实体的说明信息
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_USER_ID
		{
			set{ _create_user_id=value;}
			get{return _create_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TIME
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATE_USER_ID
		{
			set{ _update_user_id=value;}
			get{return _update_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		#endregion Model

	}
}

