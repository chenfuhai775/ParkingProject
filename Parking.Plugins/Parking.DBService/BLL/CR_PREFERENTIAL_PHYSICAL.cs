/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_PHYSICAL.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_PHYSICAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:04   N/A    初版
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
using Parking.Core.Enum;
using Parking.Core.Model;
using Parking.DBService.IBLL;
namespace Parking.DBService.BLL
{
	/// <summary>
	/// 用于发二维码优惠卷或者优惠码
	/// </summary>
    public partial class CR_PREFERENTIAL_PHYSICAL : ICR_PREFERENTIAL_PHYSICAL
	{
		private readonly Parking.DBService.DAL.CR_PREFERENTIAL_PHYSICAL dal=new Parking.DBService.DAL.CR_PREFERENTIAL_PHYSICAL();
		public CR_PREFERENTIAL_PHYSICAL()
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
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model)
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
		public Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL GetModel(string ID)
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
		public List<Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL> DataTableToList(DataTable dt)
		{
			List<Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL> modelList = new List<Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model;
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
        /// 获?取¨?优??惠Y券¨?￥号?码?
        /// </summary>
        /// <returns></returns>
        public List<CRPreferentialDetails> GetPhysicalByCodeNo(string Preferentia_Ident)
        {
            List<CRPreferentialDetails> list = new List<CRPreferentialDetails>();
            DataSet ds = dal.GetPhysicalByCodeNo(Preferentia_Ident);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Parking.Core.Model.CRPreferentialDetails model = new Parking.Core.Model.CRPreferentialDetails();
                if (row != null)
                {
                    if (row["PREFERENTIAL_CODE"] != null)
                    {
                        model.PREFERENTIAL_CODE = row["PREFERENTIAL_CODE"].ToString();
                    }
                    if (row["PREFERENTIA_IDENT"] != null)
                    {
                        model.PREFERENTIA_IDENT = row["PREFERENTIA_IDENT"].ToString();
                    }
                    if (row["PREFERENTIAL_TYPE"] != null && row["PREFERENTIAL_TYPE"].ToString() != "")
                    {
                        model.PREFERENTIAL_TYPE = (enumPreferentialType)Enum.Parse(typeof(enumPreferentialType), row["PREFERENTIAL_TYPE"].ToString());
                    }
                    if (row["PREFERENTIAL_CONTENT"] != null && row["PREFERENTIAL_CONTENT"].ToString() != "")
                    {
                        model.PREFERENTIAL_CONTENT = decimal.Parse(row["PREFERENTIAL_CONTENT"].ToString());
                    }
                    if (row["PREFERENTIAL_NAME"] != null && row["PREFERENTIAL_NAME"].ToString() != "")
                    {
                        model.PREFERENTIAL_NAME = row["PREFERENTIAL_NAME"].ToString();
                    }
                    if (row["MODEL_NAME"] != null && row["MODEL_NAME"].ToString() != "")
                    {
                        model.MODEL_NAME = row["MODEL_NAME"].ToString();
                    }
                    if (row["POLICIES_NAME"] != null && row["POLICIES_NAME"].ToString() != "")
                    {
                        model.POLICIES_NAME = row["POLICIES_NAME"].ToString();
                    }
                    if (row["POLICIES_CODE"] != null && row["POLICIES_CODE"].ToString() != "")
                    {
                        model.POLICIES_CODE = row["POLICIES_CODE"].ToString();
                    }
                    if (row["IS_COMBINATION"] != null && row["IS_COMBINATION"].ToString() != "")
                    {
                        model.IS_COMBINATION = int.Parse(row["IS_COMBINATION"].ToString());
                    }
                    if (row["CR_LEVEL"] != null && row["CR_LEVEL"].ToString() != "")
                    {
                        model.CR_LEVEL = int.Parse(row["CR_LEVEL"].ToString());
                    }
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 获?取¨?优??惠Y券¨?￥号?码?
        /// </summary>
        /// <returns></returns>
        public List<CRPreferentialDetails> GetPhysicalByVehicleNo(string Vehicle_No)
        {
            List<CRPreferentialDetails> list = new List<CRPreferentialDetails>();
            DataSet ds = dal.GetPhysicalByVehicleNo(Vehicle_No);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Parking.Core.Model.CRPreferentialDetails model = new Parking.Core.Model.CRPreferentialDetails();
                if (row != null)
                {
                    if (row["PREFERENTIAL_CODE"] != null)
                    {
                        model.PREFERENTIAL_CODE = row["PREFERENTIAL_CODE"].ToString();
                    }
                    if (row["PREFERENTIA_IDENT"] != null)
                    {
                        model.PREFERENTIA_IDENT = row["PREFERENTIA_IDENT"].ToString();
                    }
                    if (row["PREFERENTIAL_TYPE"] != null && row["PREFERENTIAL_TYPE"].ToString() != "")
                    {
                        model.PREFERENTIAL_TYPE = (enumPreferentialType)Enum.Parse(typeof(enumPreferentialType), row["PREFERENTIAL_TYPE"].ToString());
                    }
                    if (row["PREFERENTIAL_CONTENT"] != null && row["PREFERENTIAL_CONTENT"].ToString() != "")
                    {
                        model.PREFERENTIAL_CONTENT = decimal.Parse(row["PREFERENTIAL_CONTENT"].ToString());
                    }
                    if (row["PREFERENTIAL_NAME"] != null && row["PREFERENTIAL_NAME"].ToString() != "")
                    {
                        model.PREFERENTIAL_NAME = row["PREFERENTIAL_NAME"].ToString();
                    }
                    if (row["MODEL_NAME"] != null && row["MODEL_NAME"].ToString() != "")
                    {
                        model.MODEL_NAME = row["MODEL_NAME"].ToString();
                    }
                    if (row["POLICIES_NAME"] != null && row["POLICIES_NAME"].ToString() != "")
                    {
                        model.POLICIES_NAME = row["POLICIES_NAME"].ToString();
                    }
                    if (row["POLICIES_CODE"] != null && row["POLICIES_CODE"].ToString() != "")
                    {
                        model.POLICIES_CODE = row["POLICIES_CODE"].ToString();
                    }
                    if (row["IS_COMBINATION"] != null && row["IS_COMBINATION"].ToString() != "")
                    {
                        model.IS_COMBINATION = int.Parse(row["IS_COMBINATION"].ToString());
                    }
                    if (row["CR_LEVEL"] != null && row["CR_LEVEL"].ToString() != "")
                    {
                        model.CR_LEVEL = int.Parse(row["CR_LEVEL"].ToString());
                    }
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 修T改?优??惠Y劵?状á??态??
        /// </summary>
        /// <param name="idEnt"></param>
        /// <returns></returns>
        public bool update(string idEnt, int statues)
        {
            return dal.update(idEnt, statues);
        }
        #endregion  ExtensionMethod
    }
}

