/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:01   N/A    初版
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
using Parking.Core.Record;
using Parking.DBService.IBLL;

namespace Parking.DBService.BLL
{
	/// <summary>
	/// 车辆通行记录
	/// </summary>
    public partial class CR_INOUT_RECODE : ICR_INOUT_RECODE
	{
		private readonly Parking.DBService.DAL.CR_INOUT_RECODE dal=new Parking.DBService.DAL.CR_INOUT_RECODE();
		public CR_INOUT_RECODE()
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
		public bool Add(Parking.Core.Model.CR_INOUT_RECODE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.CR_INOUT_RECODE model)
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
		public Parking.Core.Model.CR_INOUT_RECODE GetModel(string ID)
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
		public List<Parking.Core.Model.CR_INOUT_RECODE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.CR_INOUT_RECODE> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.CR_INOUT_RECODE> modelList = new List<Parking.Core.Model.CR_INOUT_RECODE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.CR_INOUT_RECODE model;
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
        public List<Parking.Core.Model.CR_INOUT_RECODE> GetInOccupyRecordList(ProcessRecord recordInfo)
        {
            return dal.GetInOccupyRecordList(recordInfo);
        }
        /// <summary>
        /// 图a?片?墙?列￠D表à¨a
        /// </summary>
        /// <param name="currPageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Parking.Core.Model.CarInSideInfo> GetInSideList(string strWhere, int currPageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            return dal.GetInSideList(strWhere, currPageIndex, pageSize, out recordCount, out pageCount);
        }
        /// <summary>
        /// 查¨|询?￥场?内¨2车|ì
        /// </summary>
        /// <param name="CardNo"></param>
        /// <returns></returns>
        public Parking.Core.Model.CR_INOUT_RECODE GetInSideCarNo(Parking.Core.Model.CR_INOUT_RECODE recordInfo)
        {
            return dal.GetInSideCarNo(recordInfo);
        }
        /// <summary>
        /// 删|?除y场?内¨2记?录?
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public bool DelInSideRecord(string VEHICLE_NO)
        {
            return dal.DelInSideRecord(VEHICLE_NO);
        }
        /// <summary>
        /// 获?取¨?区?域?¨°车|ì位?数oy
        /// </summary>
        /// <param name="IN_PARTITION_CODE"></param>
        /// <returns></returns>
        public int GetPartitionCount(string IN_PARTITION_CODE, int CREDENTIALS_TYPE)
        {
            return dal.GetPartitionCount(IN_PARTITION_CODE, CREDENTIALS_TYPE);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public decimal GetOneDayTotalMoney(Parking.Core.Model.CR_ORDER_RECORD_DETAILS recordInfo)
        {
            return dal.GetOneDayTotalMoney(recordInfo);
        }
        public decimal GetNowDayTotalMoney(Parking.Core.Model.CR_ORDER_RECORD_DETAILS recordInfo)
        {
            return dal.GetNowDayTotalMoney(recordInfo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public decimal GetMultipleMoney(Parking.Core.Model.CR_ORDER_RECORD_DETAILS recordInfo)
        {
            return dal.GetMultipleMoney(recordInfo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public decimal GetExceed24HourMoney(Parking.Core.Model.CR_ORDER_RECORD_DETAILS recordInfo)
        {
            return dal.GetExceed24HourMoney(recordInfo);
        }
        public bool VehicleExists(string VEHICLE_NO)
        {
            return dal.VehicleExists(VEHICLE_NO);
        }
        public Parking.Core.Model.CR_INOUT_RECODE GetModel(string Vehicle, string InTime)
        {
            return dal.GetModel(Vehicle, InTime);
        }
        public Parking.Core.Model.CR_INOUT_RECODE GetModelByVehicleNo(string VEHICLE_NO)
        {
            return dal.GetModelByVehicleNo(VEHICLE_NO);
        }
        #endregion  ExtensionMethod
    }
}

