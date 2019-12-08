/**  版本信息模板在安装目录下，可自行修改。
* CODE_GENERATE.cs
*
* 功 能： N/A
* 类 名： CODE_GENERATE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:00   N/A    初版
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
	/// 将需要生成CODE的规则添加在这里
	/// </summary>
	[Serializable]
	public partial class CODE_GENERATE
	{
		public CODE_GENERATE()
		{}
		#region Model
		private int _id;
		private string _pref_name;
		private string _modular_name;
		private int? _max_stream_number;
		private string _format;
		private string _split;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 程序通过PREF_NAME查询此条记录的生成格式
		/// </summary>
		public string PREF_NAME
		{
			set{ _pref_name=value;}
			get{return _pref_name;}
		}
		/// <summary>
		/// 自定义模块名称 (随你喜欢写什么)
		/// </summary>
		public string MODULAR_NAME
		{
			set{ _modular_name=value;}
			get{return _modular_name;}
		}
		/// <summary>
		/// 如题
		/// </summary>
		public int? MAX_STREAM_NUMBER
		{
			set{ _max_stream_number=value;}
			get{return _max_stream_number;}
		}
		/// <summary>
		/// 示例 ：X2,N2,M
		/// </summary>
		public string FORMAT
		{
			set{ _format=value;}
			get{return _format;}
		}
		/// <summary>
		/// 将代替format当中的逗号
		/// </summary>
		public string SPLIT
		{
			set{ _split=value;}
			get{return _split;}
		}
		#endregion Model

	}
}

