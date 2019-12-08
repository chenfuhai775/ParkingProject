/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_ORGANIZATION_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_ORGANIZATION_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:14   N/A    初版
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
using Parking.Core.Oragnization;
using System.Data.SqlClient;
using Parking.DBService.IBLL;
namespace Parking.DBService.BLL
{
	/// <summary>
	/// 车主车辆信息
	/// </summary>
    public partial class PBA_PARKING_ORGANIZATION_INFO : IPBA_PARKING_ORGANIZATION_INFO
	{
        private readonly Parking.DBService.DAL.PBA_PARKING_ORGANIZATION_INFO dal = new Parking.DBService.DAL.PBA_PARKING_ORGANIZATION_INFO();
        private readonly Parking.DBService.DAL.PBA_PARKING_PARAM_SETTINGS settingdal = new Parking.DBService.DAL.PBA_PARKING_PARAM_SETTINGS();
        public PBA_PARKING_ORGANIZATION_INFO()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ORGANIZATION_CODE)
		{
			return dal.Exists(ORGANIZATION_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ORGANIZATION_CODE)
		{
			
			return dal.Delete(ORGANIZATION_CODE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ORGANIZATION_CODElist )
		{
			return dal.DeleteList(ORGANIZATION_CODElist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO GetModel(string ORGANIZATION_CODE)
		{
			
			return dal.GetModel(ORGANIZATION_CODE);
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
		public List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> modelList = new List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model;
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
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> GetTreeDeviceByIP(string IP)
        {
            SqlParameter sqlparameter = new SqlParameter("@IP", SqlDbType.VarChar, 20);
            sqlparameter.Value = IP;
            IDataParameter[] parameters = new IDataParameter[] { sqlparameter };
            List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> list = dal.GetList("sp_getDeviceTree", parameters, "PBA_PARKING_ORGANIZATION_INFO");

            foreach (var temp in list)
            {
                List<Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS> listSetting = new List<Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS>();
                DataSet ds = settingdal.GetList("ORGANIZATION_CODE = '" + temp.ORGANIZATION_CODE + "'");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS tempModel = settingdal.DataRowToModel(dr);
                        listSetting.Add(tempModel);
                    }
                    temp.ParamSettings = listSetting;
                }
            }
            return list;
        }
        /// <summary>
        /// 获?取¨?组á¨|织?￥信?息?é
        /// </summary>
        /// <param name="listOrg"></param>
        /// <returns></returns>
        public List<Equipment> GetOragnizationInfo()
        {
            return dal.GetOragnizationInfo();
        }
        #endregion  ExtensionMethod
    }
}

