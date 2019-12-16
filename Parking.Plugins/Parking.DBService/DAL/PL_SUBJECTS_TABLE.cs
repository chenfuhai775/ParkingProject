/**  版本信息模板在安装目录下，可自行修改。
* PL_SUBJECTS_TABLE.cs
*
* 功 能： N/A
* 类 名： PL_SUBJECTS_TABLE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:21   N/A    初版
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
	/// 数据访问类:PL_SUBJECTS_TABLE
	/// </summary>
	public partial class PL_SUBJECTS_TABLE
	{
		public PL_SUBJECTS_TABLE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SUBJECT_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PL_SUBJECTS_TABLE");
			strSql.Append(" where SUBJECT_CODE=@SUBJECT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBJECT_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = SUBJECT_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PL_SUBJECTS_TABLE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PL_SUBJECTS_TABLE(");
			strSql.Append("SUBJECT_CODE,SUBJECT_NAME,SUBJECT_TYPE,CREATE_TIME,CREATE_USERID)");
			strSql.Append(" values (");
			strSql.Append("@SUBJECT_CODE,@SUBJECT_NAME,@SUBJECT_TYPE,@CREATE_TIME,@CREATE_USERID)");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBJECT_CODE", SqlDbType.VarChar,200),
					new SqlParameter("@SUBJECT_NAME", SqlDbType.VarChar,200),
					new SqlParameter("@SUBJECT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.SUBJECT_CODE;
			parameters[1].Value = model.SUBJECT_NAME;
			parameters[2].Value = model.SUBJECT_TYPE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_USERID;

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
		public bool Update(Parking.Core.Model.PL_SUBJECTS_TABLE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PL_SUBJECTS_TABLE set ");
			strSql.Append("SUBJECT_NAME=@SUBJECT_NAME,");
			strSql.Append("SUBJECT_TYPE=@SUBJECT_TYPE,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID");
			strSql.Append(" where SUBJECT_CODE=@SUBJECT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBJECT_NAME", SqlDbType.VarChar,200),
					new SqlParameter("@SUBJECT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@SUBJECT_CODE", SqlDbType.VarChar,200)};
			parameters[0].Value = model.SUBJECT_NAME;
			parameters[1].Value = model.SUBJECT_TYPE;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.CREATE_USERID;
			parameters[4].Value = model.SUBJECT_CODE;

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
		public bool Delete(string SUBJECT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PL_SUBJECTS_TABLE ");
			strSql.Append(" where SUBJECT_CODE=@SUBJECT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBJECT_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = SUBJECT_CODE;

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
		public bool DeleteList(string SUBJECT_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PL_SUBJECTS_TABLE ");
			strSql.Append(" where SUBJECT_CODE in ("+SUBJECT_CODElist + ")  ");
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
		public Parking.Core.Model.PL_SUBJECTS_TABLE GetModel(string SUBJECT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SUBJECT_CODE,SUBJECT_NAME,SUBJECT_TYPE,CREATE_TIME,CREATE_USERID from PL_SUBJECTS_TABLE ");
			strSql.Append(" where SUBJECT_CODE=@SUBJECT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBJECT_CODE", SqlDbType.VarChar,200)			};
			parameters[0].Value = SUBJECT_CODE;

			Parking.Core.Model.PL_SUBJECTS_TABLE model=new Parking.Core.Model.PL_SUBJECTS_TABLE();
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
		public Parking.Core.Model.PL_SUBJECTS_TABLE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PL_SUBJECTS_TABLE model=new Parking.Core.Model.PL_SUBJECTS_TABLE();
			if (row != null)
			{
				if(row["SUBJECT_CODE"]!=null)
				{
					model.SUBJECT_CODE=row["SUBJECT_CODE"].ToString();
				}
				if(row["SUBJECT_NAME"]!=null)
				{
					model.SUBJECT_NAME=row["SUBJECT_NAME"].ToString();
				}
				if(row["SUBJECT_TYPE"]!=null && row["SUBJECT_TYPE"].ToString()!="")
				{
					model.SUBJECT_TYPE=int.Parse(row["SUBJECT_TYPE"].ToString());
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
			strSql.Append("select SUBJECT_CODE,SUBJECT_NAME,SUBJECT_TYPE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM PL_SUBJECTS_TABLE ");
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
			strSql.Append(" SUBJECT_CODE,SUBJECT_NAME,SUBJECT_TYPE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM PL_SUBJECTS_TABLE ");
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
			strSql.Append("select count(1) FROM PL_SUBJECTS_TABLE ");
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
				strSql.Append("order by T.SUBJECT_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PL_SUBJECTS_TABLE T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "PL_SUBJECTS_TABLE";
			parameters[1].Value = "SUBJECT_CODE";
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

