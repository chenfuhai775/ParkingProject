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
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:CR_PREFERENTIAL_POLICIES
	/// </summary>
	public partial class CR_PREFERENTIAL_POLICIES
	{
		public CR_PREFERENTIAL_POLICIES()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string POLICIES_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PREFERENTIAL_POLICIES");
			strSql.Append(" where POLICIES_CODE=SQL2012POLICIES_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012POLICIES_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = POLICIES_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_POLICIES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PREFERENTIAL_POLICIES(");
			strSql.Append("POLICIES_CODE,POLICIES_NAME,CREATE_USER,CREATE_TIME)");
			strSql.Append(" values (");
			strSql.Append("SQL2012POLICIES_CODE,SQL2012POLICIES_NAME,SQL2012CREATE_USER,SQL2012CREATE_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012POLICIES_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012POLICIES_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.POLICIES_CODE;
			parameters[1].Value = model.POLICIES_NAME;
			parameters[2].Value = model.CREATE_USER;
			parameters[3].Value = model.CREATE_TIME;

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
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_POLICIES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PREFERENTIAL_POLICIES set ");
			strSql.Append("POLICIES_NAME=SQL2012POLICIES_NAME,");
			strSql.Append("CREATE_USER=SQL2012CREATE_USER,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME");
			strSql.Append(" where POLICIES_CODE=SQL2012POLICIES_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012POLICIES_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012POLICIES_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.POLICIES_NAME;
			parameters[1].Value = model.CREATE_USER;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.POLICIES_CODE;

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
		public bool Delete(string POLICIES_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_POLICIES ");
			strSql.Append(" where POLICIES_CODE=SQL2012POLICIES_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012POLICIES_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = POLICIES_CODE;

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
		public bool DeleteList(string POLICIES_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_POLICIES ");
			strSql.Append(" where POLICIES_CODE in ("+POLICIES_CODElist + ")  ");
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
		public Parking.Core.Model.CR_PREFERENTIAL_POLICIES GetModel(string POLICIES_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 POLICIES_CODE,POLICIES_NAME,CREATE_USER,CREATE_TIME from CR_PREFERENTIAL_POLICIES ");
			strSql.Append(" where POLICIES_CODE=SQL2012POLICIES_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012POLICIES_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = POLICIES_CODE;

			Parking.Core.Model.CR_PREFERENTIAL_POLICIES model=new Parking.Core.Model.CR_PREFERENTIAL_POLICIES();
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
		public Parking.Core.Model.CR_PREFERENTIAL_POLICIES DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PREFERENTIAL_POLICIES model=new Parking.Core.Model.CR_PREFERENTIAL_POLICIES();
			if (row != null)
			{
				if(row["POLICIES_CODE"]!=null)
				{
					model.POLICIES_CODE=row["POLICIES_CODE"].ToString();
				}
				if(row["POLICIES_NAME"]!=null)
				{
					model.POLICIES_NAME=row["POLICIES_NAME"].ToString();
				}
				if(row["CREATE_USER"]!=null)
				{
					model.CREATE_USER=row["CREATE_USER"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
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
			strSql.Append("select POLICIES_CODE,POLICIES_NAME,CREATE_USER,CREATE_TIME ");
			strSql.Append(" FROM CR_PREFERENTIAL_POLICIES ");
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
			strSql.Append(" POLICIES_CODE,POLICIES_NAME,CREATE_USER,CREATE_TIME ");
			strSql.Append(" FROM CR_PREFERENTIAL_POLICIES ");
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
			strSql.Append("select count(1) FROM CR_PREFERENTIAL_POLICIES ");
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
				strSql.Append("order by T.POLICIES_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from CR_PREFERENTIAL_POLICIES T ");
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
			parameters[0].Value = "CR_PREFERENTIAL_POLICIES";
			parameters[1].Value = "POLICIES_CODE";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

