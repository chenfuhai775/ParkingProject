﻿/**  版本信息模板在安装目录下，可自行修改。
* EXT_PROPERTY_COSTS.cs
*
* 功 能： N/A
* 类 名： EXT_PROPERTY_COSTS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
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
	/// 通行证信息
	/// </summary>
	public partial class EXT_PROPERTY_COSTS
	{
		private readonly Parking.DBService.DAL.EXT_PROPERTY_COSTS dal=new Parking.DBService.DAL.EXT_PROPERTY_COSTS();
		public EXT_PROPERTY_COSTS()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.EXT_PROPERTY_COSTS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.EXT_PROPERTY_COSTS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.EXT_PROPERTY_COSTS GetModel(string ID)
		{
			
			return dal.GetModel(ID);
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
		public List<Parking.Core.Model.EXT_PROPERTY_COSTS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.EXT_PROPERTY_COSTS> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.EXT_PROPERTY_COSTS> modelList = new List<Parking.Core.Model.EXT_PROPERTY_COSTS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.EXT_PROPERTY_COSTS model;
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
