/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_ORGANIZATION.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_ORGANIZATION
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:13   N/A    初版
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
	/// 数据访问类:PBA_OWNER_ORGANIZATION
	/// </summary>
	public partial class PBA_OWNER_ORGANIZATION
	{
		public PBA_OWNER_ORGANIZATION()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ORGANIZATION_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_OWNER_ORGANIZATION");
			strSql.Append(" where ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = ORGANIZATION_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_OWNER_ORGANIZATION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_OWNER_ORGANIZATION(");
			strSql.Append("ORGANIZATION_CODE,ORGANIZATION_NAME,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,ORGANIZATION_LEVEL)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ORGANIZATION_CODE,SQL2012ORGANIZATION_NAME,SQL2012REMARK,SQL2012CREATE_TIME,SQL2012CREATE_USERNAME,SQL2012UPDATE_TIME,SQL2012UPDATE_USERNAME,SQL2012ORGANIZATION_LEVEL)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012ORGANIZATION_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ORGANIZATION_LEVEL", SqlDbType.Int,4)};
			parameters[0].Value = model.ORGANIZATION_CODE;
			parameters[1].Value = model.ORGANIZATION_NAME;
			parameters[2].Value = model.REMARK;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_USERNAME;
			parameters[5].Value = model.UPDATE_TIME;
			parameters[6].Value = model.UPDATE_USERNAME;
			parameters[7].Value = model.ORGANIZATION_LEVEL;

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
		public bool Update(Parking.Core.Model.PBA_OWNER_ORGANIZATION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_OWNER_ORGANIZATION set ");
			strSql.Append("ORGANIZATION_NAME=SQL2012ORGANIZATION_NAME,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERNAME=SQL2012CREATE_USERNAME,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("UPDATE_USERNAME=SQL2012UPDATE_USERNAME,");
			strSql.Append("ORGANIZATION_LEVEL=SQL2012ORGANIZATION_LEVEL");
			strSql.Append(" where ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ORGANIZATION_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ORGANIZATION_LEVEL", SqlDbType.Int,4),
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ORGANIZATION_NAME;
			parameters[1].Value = model.REMARK;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.CREATE_USERNAME;
			parameters[4].Value = model.UPDATE_TIME;
			parameters[5].Value = model.UPDATE_USERNAME;
			parameters[6].Value = model.ORGANIZATION_LEVEL;
			parameters[7].Value = model.ORGANIZATION_CODE;

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
		public bool Delete(string ORGANIZATION_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_OWNER_ORGANIZATION ");
			strSql.Append(" where ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = ORGANIZATION_CODE;

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
		public bool DeleteList(string ORGANIZATION_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_OWNER_ORGANIZATION ");
			strSql.Append(" where ORGANIZATION_CODE in ("+ORGANIZATION_CODElist + ")  ");
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
		public Parking.Core.Model.PBA_OWNER_ORGANIZATION GetModel(string ORGANIZATION_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ORGANIZATION_CODE,ORGANIZATION_NAME,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,ORGANIZATION_LEVEL from PBA_OWNER_ORGANIZATION ");
			strSql.Append(" where ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = ORGANIZATION_CODE;

			Parking.Core.Model.PBA_OWNER_ORGANIZATION model=new Parking.Core.Model.PBA_OWNER_ORGANIZATION();
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
		public Parking.Core.Model.PBA_OWNER_ORGANIZATION DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_OWNER_ORGANIZATION model=new Parking.Core.Model.PBA_OWNER_ORGANIZATION();
			if (row != null)
			{
				if(row["ORGANIZATION_CODE"]!=null)
				{
					model.ORGANIZATION_CODE=row["ORGANIZATION_CODE"].ToString();
				}
				if(row["ORGANIZATION_NAME"]!=null)
				{
					model.ORGANIZATION_NAME=row["ORGANIZATION_NAME"].ToString();
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
				if(row["ORGANIZATION_LEVEL"]!=null && row["ORGANIZATION_LEVEL"].ToString()!="")
				{
					model.ORGANIZATION_LEVEL=int.Parse(row["ORGANIZATION_LEVEL"].ToString());
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
			strSql.Append("select ORGANIZATION_CODE,ORGANIZATION_NAME,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,ORGANIZATION_LEVEL ");
			strSql.Append(" FROM PBA_OWNER_ORGANIZATION ");
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
			strSql.Append(" ORGANIZATION_CODE,ORGANIZATION_NAME,REMARK,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,ORGANIZATION_LEVEL ");
			strSql.Append(" FROM PBA_OWNER_ORGANIZATION ");
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
			strSql.Append("select count(1) FROM PBA_OWNER_ORGANIZATION ");
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
				strSql.Append("order by T.ORGANIZATION_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_OWNER_ORGANIZATION T ");
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
			parameters[0].Value = "PBA_OWNER_ORGANIZATION";
			parameters[1].Value = "ORGANIZATION_CODE";
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

