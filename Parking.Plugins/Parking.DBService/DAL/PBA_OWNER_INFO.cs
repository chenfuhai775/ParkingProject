/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:12   N/A    初版
*
* Copyright (c) 2012 Parking.DBService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
using Parking.Core;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:PBA_OWNER_INFO
	/// </summary>
	public partial class PBA_OWNER_INFO
	{
		public PBA_OWNER_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OWNER_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_OWNER_INFO");
			strSql.Append(" where OWNER_CODE=SQL2012OWNER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = OWNER_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_OWNER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_OWNER_INFO(");
			strSql.Append("OWNER_CODE,OWNER_NAME,OWNER_PHONE,OWNER_ADDRESS,OWNER_PICTURE,OWNER_STATUS,ORGANIZATION_CODE,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,PERMISSION_CODES,DIY_STR)");
			strSql.Append(" values (");
			strSql.Append("SQL2012OWNER_CODE,SQL2012OWNER_NAME,SQL2012OWNER_PHONE,SQL2012OWNER_ADDRESS,SQL2012OWNER_PICTURE,SQL2012OWNER_STATUS,SQL2012ORGANIZATION_CODE,SQL2012REMARK,SQL2012CREATE_TIME,SQL2012CREATE_USERNAME,SQL2012UPDATE_TIME,SQL2012UPDATE_USERNAME,SQL2012PERMISSION_CODES,SQL2012DIY_STR)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OWNER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OWNER_PHONE", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012OWNER_ADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012OWNER_PICTURE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012OWNER_STATUS", SqlDbType.Int,4),
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PERMISSION_CODES", SqlDbType.Text),
					new SqlParameter("SQL2012DIY_STR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.OWNER_CODE;
			parameters[1].Value = model.OWNER_NAME;
			parameters[2].Value = model.OWNER_PHONE;
			parameters[3].Value = model.OWNER_ADDRESS;
			parameters[4].Value = model.OWNER_PICTURE;
			parameters[5].Value = model.OWNER_STATUS;
			parameters[6].Value = model.ORGANIZATION_CODE;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.CREATE_USERNAME;
			parameters[10].Value = model.UPDATE_TIME;
			parameters[11].Value = model.UPDATE_USERNAME;
			parameters[12].Value = model.PERMISSION_CODES;
			parameters[13].Value = model.DIY_STR;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Parking.Core.Model.PBA_OWNER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_OWNER_INFO set ");
			strSql.Append("OWNER_NAME=SQL2012OWNER_NAME,");
			strSql.Append("OWNER_PHONE=SQL2012OWNER_PHONE,");
			strSql.Append("OWNER_ADDRESS=SQL2012OWNER_ADDRESS,");
			strSql.Append("OWNER_PICTURE=SQL2012OWNER_PICTURE,");
			strSql.Append("OWNER_STATUS=SQL2012OWNER_STATUS,");
			strSql.Append("ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERNAME=SQL2012CREATE_USERNAME,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("UPDATE_USERNAME=SQL2012UPDATE_USERNAME,");
			strSql.Append("PERMISSION_CODES=SQL2012PERMISSION_CODES,");
			strSql.Append("DIY_STR=SQL2012DIY_STR");
			strSql.Append(" where OWNER_CODE=SQL2012OWNER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OWNER_PHONE", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012OWNER_ADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012OWNER_PICTURE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012OWNER_STATUS", SqlDbType.Int,4),
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PERMISSION_CODES", SqlDbType.Text),
					new SqlParameter("SQL2012DIY_STR", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.OWNER_NAME;
			parameters[1].Value = model.OWNER_PHONE;
			parameters[2].Value = model.OWNER_ADDRESS;
			parameters[3].Value = model.OWNER_PICTURE;
			parameters[4].Value = model.OWNER_STATUS;
			parameters[5].Value = model.ORGANIZATION_CODE;
			parameters[6].Value = model.REMARK;
			parameters[7].Value = model.CREATE_TIME;
			parameters[8].Value = model.CREATE_USERNAME;
			parameters[9].Value = model.UPDATE_TIME;
			parameters[10].Value = model.UPDATE_USERNAME;
			parameters[11].Value = model.PERMISSION_CODES;
			parameters[12].Value = model.DIY_STR;
			parameters[13].Value = model.OWNER_CODE;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string OWNER_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_OWNER_INFO ");
			strSql.Append(" where OWNER_CODE=SQL2012OWNER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = OWNER_CODE;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string OWNER_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_OWNER_INFO ");
			strSql.Append(" where OWNER_CODE in ("+OWNER_CODElist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.PBA_OWNER_INFO GetModel(string OWNER_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OWNER_CODE,OWNER_NAME,OWNER_PHONE,OWNER_ADDRESS,OWNER_PICTURE,OWNER_STATUS,ORGANIZATION_CODE,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,PERMISSION_CODES,DIY_STR from PBA_OWNER_INFO ");
			strSql.Append(" where OWNER_CODE=SQL2012OWNER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = OWNER_CODE;

			Parking.Core.Model.PBA_OWNER_INFO model=new Parking.Core.Model.PBA_OWNER_INFO();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.PBA_OWNER_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_OWNER_INFO model=new Parking.Core.Model.PBA_OWNER_INFO();
			if (row != null)
			{
				if(row["OWNER_CODE"]!=null)
				{
					model.OWNER_CODE=row["OWNER_CODE"].ToString();
				}
				if(row["OWNER_NAME"]!=null)
				{
					model.OWNER_NAME=row["OWNER_NAME"].ToString();
				}
				if(row["OWNER_PHONE"]!=null)
				{
					model.OWNER_PHONE=row["OWNER_PHONE"].ToString();
				}
				if(row["OWNER_ADDRESS"]!=null)
				{
					model.OWNER_ADDRESS=row["OWNER_ADDRESS"].ToString();
				}
				if(row["OWNER_PICTURE"]!=null)
				{
					model.OWNER_PICTURE=row["OWNER_PICTURE"].ToString();
				}
				if(row["OWNER_STATUS"]!=null && row["OWNER_STATUS"].ToString()!="")
				{
					model.OWNER_STATUS=int.Parse(row["OWNER_STATUS"].ToString());
				}
				if(row["ORGANIZATION_CODE"]!=null)
				{
					model.ORGANIZATION_CODE=row["ORGANIZATION_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERNAME"]!=null)
				{
					model.CREATE_USERNAME=row["CREATE_USERNAME"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERNAME"]!=null)
				{
					model.UPDATE_USERNAME=row["UPDATE_USERNAME"].ToString();
				}
				if(row["PERMISSION_CODES"]!=null)
				{
					model.PERMISSION_CODES=row["PERMISSION_CODES"].ToString();
				}
				if(row["DIY_STR"]!=null)
				{
					model.DIY_STR=row["DIY_STR"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OWNER_CODE,OWNER_NAME,OWNER_PHONE,OWNER_ADDRESS,OWNER_PICTURE,OWNER_STATUS,ORGANIZATION_CODE,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,PERMISSION_CODES,DIY_STR ");
			strSql.Append(" FROM PBA_OWNER_INFO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" OWNER_CODE,OWNER_NAME,OWNER_PHONE,OWNER_ADDRESS,OWNER_PICTURE,OWNER_STATUS,ORGANIZATION_CODE,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,PERMISSION_CODES,DIY_STR ");
			strSql.Append(" FROM PBA_OWNER_INFO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM PBA_OWNER_INFO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.OWNER_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_OWNER_INFO T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "PBA_OWNER_INFO";
			parameters[1].Value = "OWNER_CODE";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获?取¨?人¨?员?à信?息?é
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<Parking.Core.Model.OwnerInfo> GetOwnerInfo(string strWhere, int currPageIndex, int pageSize, out int sizeCount, out int pageCount)
        {
            DataSet ds = null;
            List<Parking.Core.Model.OwnerInfo> list = new List<Parking.Core.Model.OwnerInfo>();
            int PageMax = (currPageIndex + 1) * pageSize;
            int PageMin = PageMax - pageSize + 1;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" SELECT *  FROM   ( SELECT    ROW_NUMBER() OVER ( ORDER BY T.OWNER_CODE ) AS ROW ,
                                                T.*
                                      FROM      ( SELECT    A.OWNER_CODE ,
                                                            A.OWNER_NAME ,
                                                            A.OWNER_PICTURE,
                                                            A.OWNER_PHONE,
                                                            A.ORGANIZATION_CODE ,
                                                            A.CREATE_TIME ,
                                                            B.VEHICLE_NO ,
                                                            B.VEHICLE_COLOR
                                                  FROM      PBA_OWNER_INFO A
                                                            LEFT JOIN dbo.PBA_OWNER_VEHICLE_INFO B ON A.OWNER_CODE = B.OWNER_CODE
                                                ) T ");

            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(@" WHERE " + strWhere);
            }
            strSql.Append(@"  ) TT ");
            sizeCount = DbHelperSQL.Query(strSql.ToString()).Tables[0].Rows.Count;
            pageCount = (sizeCount % pageSize) > 0 ? (sizeCount / pageSize + 1) : sizeCount / pageSize;
            strSql.Append(@" WHERE   TT.Row BETWEEN {0} AND {1}");
            ds = DbHelperSQL.Query(string.Format(strSql.ToString(), PageMin, PageMax));
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Parking.Core.Model.OwnerInfo model = new Core.Model.OwnerInfo();
                if (row["OWNER_CODE"] != null)
                {
                    model.OWNER_CODE = row["OWNER_CODE"].ToString();
                }
                if (row["OWNER_NAME"] != null)
                {
                    model.OWNER_NAME = row["OWNER_NAME"].ToString();
                }
                if (row["OWNER_PHONE"] != null)
                {
                    model.OWNER_PHONE = row["OWNER_PHONE"].ToString();
                }
                if (row["OWNER_PICTURE"] != null)
                {
                    model.OWNER_PICTURE = row["OWNER_PICTURE"].ToString();
                }
                if (row["CREATE_TIME"] != null && row["CREATE_TIME"].ToString() != "")
                {
                    model.CREATE_TIME = DateTime.Parse(row["CREATE_TIME"].ToString());
                }
                if (row["VEHICLE_NO"] != null)
                {
                    model.VEHICLE_NO = row["VEHICLE_NO"].ToString();
                }
                if (row["ORGANIZATION_CODE"] != null)
                {
                    string Address = string.Empty;
                    string Code = string.Empty;
                    string[] strArr = row["ORGANIZATION_CODE"].ToString().Split('-');
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        Code += strArr[i];
                        if (i > 0)
                        {
                            var temp = GlobalEnvironment.OwnerList.Where(x => x.ORGANIZATION_CODE == Code).FirstOrDefault();
                            if (null != temp)
                                Address += temp.ORGANIZATION_NAME + "-";
                        }
                        Code += "-";
                    }
                    Address = Address.TrimEnd('-');
                    model.OWNER_ADDRESS = Address;
                }
                list.Add(model);
            }
            return list;
        }
        #endregion  ExtensionMethod
    }
}

