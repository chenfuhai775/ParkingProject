/**  版本信息模板在安装目录下，可自行修改。
* PBA_CHARGE_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_CHARGE_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:09   N/A    初版
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
using System.Collections.Generic;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:PBA_CHARGE_INFO
	/// </summary>
	public partial class PBA_CHARGE_INFO
	{
		public PBA_CHARGE_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CHARGE_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_CHARGE_INFO");
			strSql.Append(" where CHARGE_CODE=SQL2012CHARGE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CHARGE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = CHARGE_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_CHARGE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_CHARGE_INFO(");
			strSql.Append("CHARGE_CODE,CHARGE_NAME,CHARGE_TYPE,CHARGE_PARAM_CODE,CREATE_TIME,CREATE_USERID)");
			strSql.Append(" values (");
			strSql.Append("SQL2012CHARGE_CODE,SQL2012CHARGE_NAME,SQL2012CHARGE_TYPE,SQL2012CHARGE_PARAM_CODE,SQL2012CREATE_TIME,SQL2012CREATE_USERID)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CHARGE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CHARGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CHARGE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGE_PARAM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CHARGE_CODE;
			parameters[1].Value = model.CHARGE_NAME;
			parameters[2].Value = model.CHARGE_TYPE;
			parameters[3].Value = model.CHARGE_PARAM_CODE;
			parameters[4].Value = model.CREATE_TIME;
			parameters[5].Value = model.CREATE_USERID;

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
		public bool Update(Parking.Core.Model.PBA_CHARGE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_CHARGE_INFO set ");
			strSql.Append("CHARGE_NAME=SQL2012CHARGE_NAME,");
			strSql.Append("CHARGE_TYPE=SQL2012CHARGE_TYPE,");
			strSql.Append("CHARGE_PARAM_CODE=SQL2012CHARGE_PARAM_CODE,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERID=SQL2012CREATE_USERID");
			strSql.Append(" where CHARGE_CODE=SQL2012CHARGE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CHARGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CHARGE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGE_PARAM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CHARGE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CHARGE_NAME;
			parameters[1].Value = model.CHARGE_TYPE;
			parameters[2].Value = model.CHARGE_PARAM_CODE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_USERID;
			parameters[5].Value = model.CHARGE_CODE;

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
		public bool Delete(string CHARGE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_CHARGE_INFO ");
			strSql.Append(" where CHARGE_CODE=SQL2012CHARGE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CHARGE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = CHARGE_CODE;

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
		public bool DeleteList(string CHARGE_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_CHARGE_INFO ");
			strSql.Append(" where CHARGE_CODE in ("+CHARGE_CODElist + ")  ");
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
		public Parking.Core.Model.PBA_CHARGE_INFO GetModel(string CHARGE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CHARGE_CODE,CHARGE_NAME,CHARGE_TYPE,CHARGE_PARAM_CODE,CREATE_TIME,CREATE_USERID from PBA_CHARGE_INFO ");
			strSql.Append(" where CHARGE_CODE=SQL2012CHARGE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CHARGE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = CHARGE_CODE;

			Parking.Core.Model.PBA_CHARGE_INFO model=new Parking.Core.Model.PBA_CHARGE_INFO();
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
		public Parking.Core.Model.PBA_CHARGE_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_CHARGE_INFO model=new Parking.Core.Model.PBA_CHARGE_INFO();
			if (row != null)
			{
				if(row["CHARGE_CODE"]!=null)
				{
					model.CHARGE_CODE=row["CHARGE_CODE"].ToString();
				}
				if(row["CHARGE_NAME"]!=null)
				{
					model.CHARGE_NAME=row["CHARGE_NAME"].ToString();
				}
				if(row["CHARGE_TYPE"]!=null && row["CHARGE_TYPE"].ToString()!="")
				{
					model.CHARGE_TYPE=int.Parse(row["CHARGE_TYPE"].ToString());
				}
				if(row["CHARGE_PARAM_CODE"]!=null)
				{
					model.CHARGE_PARAM_CODE=row["CHARGE_PARAM_CODE"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
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
			strSql.Append("select CHARGE_CODE,CHARGE_NAME,CHARGE_TYPE,CHARGE_PARAM_CODE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM PBA_CHARGE_INFO ");
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
			strSql.Append(" CHARGE_CODE,CHARGE_NAME,CHARGE_TYPE,CHARGE_PARAM_CODE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM PBA_CHARGE_INFO ");
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
			strSql.Append("select count(1) FROM PBA_CHARGE_INFO ");
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
				strSql.Append("order by T.CHARGE_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_CHARGE_INFO T ");
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
			parameters[0].Value = "PBA_CHARGE_INFO";
			parameters[1].Value = "CHARGE_CODE";
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
        /// 加¨?载?收o?费¤?标à¨o准á?及??参?数oy
        /// </summary>
        /// <param name="ChargeCode"></param>
        /// <returns></returns>
        public Parking.Core.Model.PBA_CHARGE_INFO getChargeInfo(string ChargeCode, ref Dictionary<string, string> Attributes)
        {
            var model = this.GetModel(ChargeCode);
            PBA_CHARGE_STANDARD_INFO p = new PBA_CHARGE_STANDARD_INFO();
            var paramsList = p.GetList("CHARGE_TYPE_CODE = '" + ChargeCode + "'");
            foreach (DataRow dr in paramsList.Tables[0].Rows)
            {
                if (Attributes.ContainsKey(dr["GROUPING_CODE"].ToString() + "_" + dr["DISPLAY_KEY"].ToString()))
                    Attributes.Remove(dr["GROUPING_CODE"].ToString() + "_" + dr["DISPLAY_KEY"].ToString());
                Attributes.Add(dr["GROUPING_CODE"].ToString() + "_" + dr["DISPLAY_KEY"].ToString(), dr["DISPLAY_VALUE"].ToString());
            }
            return model;
        }
        public DataTable getChargeList()
        {
            string strSql = "select CHARGE_CODE, CHARGE_NAME from PBA_CHARGE_INFO WHERE CHARGE_TYPE = 1";
            DataSet ds = DbHelperSQL.Query(strSql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0];

            return null;
        }
        #endregion  ExtensionMethod
    }
}

