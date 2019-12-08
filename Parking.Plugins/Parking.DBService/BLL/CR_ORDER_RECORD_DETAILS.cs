/**  版本信息模板在安装目录下，可自行修改。
* CR_ORDER_RECORD_DETAILS.cs
*
* 功 能： N/A
* 类 名： CR_ORDER_RECORD_DETAILS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:03   N/A    初版
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
using Parking.Core.Record;
using Parking.DBService.IBLL;
namespace Parking.DBService.BLL
{
	/// <summary>
	/// 车牌纠正记录
	/// </summary>
	public partial class CR_ORDER_RECORD_DETAILS: ICR_ORDER_RECORD_DETAILS
    {
		private readonly Parking.DBService.DAL.CR_ORDER_RECORD_DETAILS dal=new Parking.DBService.DAL.CR_ORDER_RECORD_DETAILS();
		public CR_ORDER_RECORD_DETAILS()
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
		public bool Add(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model)
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
		public Parking.Core.Model.CR_ORDER_RECORD_DETAILS GetModel(string ID)
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
		public List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> modelList = new List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.CR_ORDER_RECORD_DETAILS model;
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
        /// 获?取¨?单ì￡¤个?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public Parking.Core.Model.CR_ORDER_RECORD_DETAILS GetOrderDetailsInfo(ProcessRecord recordInfo)
        {
            return dal.GetOrderDetailsInfo(recordInfo);
        }
        /// <summary>
        /// 获?取¨?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> GetOrdersByInOutCode(string InOutCode)
        {
            DataSet ds = dal.GetOrdersByInOutCode(InOutCode);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获?取¨?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> GetDetailsByOrder(string OrderCode)
        {
            DataSet ds = dal.GetDetailsByOrder(OrderCode);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 删|?除y订?单ì￡¤
        /// </summary>
        /// <param name="OrderCode"></param>
        public bool DeleteByOrderCode(string OrderCode)
        {
            return dal.DeleteByOrderCode(OrderCode);
        }
        #endregion  ExtensionMethod
    }
}

