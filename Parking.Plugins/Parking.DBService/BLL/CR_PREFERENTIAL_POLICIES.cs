/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_POLICIES.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_POLICIES
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:05   N/A    初版
*
* Copyright (c) 2012 Parking.DBService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using Parking.Core.Model;
namespace Parking.DBService.BLL
{
	/// <summary>
	/// 优惠策略
	/// </summary>
	public partial class CR_PREFERENTIAL_POLICIES
	{
		private readonly Parking.DBService.DAL.CR_PREFERENTIAL_POLICIES dal=new Parking.DBService.DAL.CR_PREFERENTIAL_POLICIES();
		public CR_PREFERENTIAL_POLICIES()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string POLICIES_CODE)
		{
			return dal.Exists(POLICIES_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_POLICIES model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_POLICIES model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string POLICIES_CODE)
		{
			
			return dal.Delete(POLICIES_CODE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string POLICIES_CODElist )
		{
			return dal.DeleteList(POLICIES_CODElist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.CR_PREFERENTIAL_POLICIES GetModel(string POLICIES_CODE)
		{
			
			return dal.GetModel(POLICIES_CODE);
		}

	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.CR_PREFERENTIAL_POLICIES> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.CR_PREFERENTIAL_POLICIES> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.CR_PREFERENTIAL_POLICIES> modelList = new List<Parking.Core.Model.CR_PREFERENTIAL_POLICIES>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.CR_PREFERENTIAL_POLICIES model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

