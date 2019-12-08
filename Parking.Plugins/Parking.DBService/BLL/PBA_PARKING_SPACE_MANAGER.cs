/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_SPACE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_SPACE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
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
using Parking.DBService.IBLL;
namespace Parking.DBService.BLL
{
	/// <summary>
	/// 车位管理
	/// </summary>
    public partial class PBA_PARKING_SPACE_MANAGER : IPBA_PARKING_SPACE_MANAGER
	{
		private readonly Parking.DBService.DAL.PBA_PARKING_SPACE_MANAGER dal=new Parking.DBService.DAL.PBA_PARKING_SPACE_MANAGER();
		public PBA_PARKING_SPACE_MANAGER()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SPACE_CODE)
		{
			return dal.Exists(SPACE_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string SPACE_CODE)
		{
			
			return dal.Delete(SPACE_CODE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SPACE_CODElist )
		{
			return dal.DeleteList(SPACE_CODElist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.PBA_PARKING_SPACE_MANAGER GetModel(string SPACE_CODE)
		{
			
			return dal.GetModel(SPACE_CODE);
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
		public List<Parking.Core.Model.PBA_PARKING_SPACE_MANAGER> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.PBA_PARKING_SPACE_MANAGER> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.PBA_PARKING_SPACE_MANAGER> modelList = new List<Parking.Core.Model.PBA_PARKING_SPACE_MANAGER>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model;
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
        /// <summary>
        /// 锁?定?§/解a锁?车|ì位?
        /// </summary>
        /// <param name="ID"></param>
        public void UpdateStatus(string SPACE_CODE, int STATUS, string INOUT_RECORD_ID = "")
        {
            dal.UpdateStatus(SPACE_CODE, STATUS, INOUT_RECORD_ID);
        }

        public Parking.Core.Model.PBA_PARKING_SPACE_MANAGER GetModelByINOUTID(string INOUT_RECORD_ID)
        {
            return dal.GetModelByINOUTID(INOUT_RECORD_ID);
        }
        /// <summary>
        /// 是o?否¤?有?D剩o?ê余?¨¤车|ì位?
        /// </summary>
        /// <param name="VEHICLENO"></param>
        /// <returns></returns>
        public bool IsSurplus(string VEHICLENO)
        {
            return dal.IsSurplus(VEHICLENO);
        }
        #endregion  ExtensionMethod
    }
}

