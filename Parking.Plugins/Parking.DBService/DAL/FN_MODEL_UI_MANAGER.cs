/**  版本信息模板在安装目录下，可自行修改。
* FN_MODEL_UI_MANAGER.cs
*
* 功 能： N/A
* 类 名： FN_MODEL_UI_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:08   N/A    初版
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
	/// 数据访问类:FN_MODEL_UI_MANAGER
	/// </summary>
	public partial class FN_MODEL_UI_MANAGER
	{
		public FN_MODEL_UI_MANAGER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MODEL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FN_MODEL_UI_MANAGER");
			strSql.Append(" where MODEL_CODE=SQL2012MODEL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MODEL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = MODEL_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.FN_MODEL_UI_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FN_MODEL_UI_MANAGER(");
			strSql.Append("MODEL_CODE,MODEL_NAME,RESOURCE_CODE,CREATE_TIME,CREATE_USERID,MODEL_STATUS)");
			strSql.Append(" values (");
			strSql.Append("SQL2012MODEL_CODE,SQL2012MODEL_NAME,SQL2012RESOURCE_CODE,SQL2012CREATE_TIME,SQL2012CREATE_USERID,SQL2012MODEL_STATUS)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MODEL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MODEL_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MODEL_STATUS", SqlDbType.Int,4)};
			parameters[0].Value = model.MODEL_CODE;
			parameters[1].Value = model.MODEL_NAME;
			parameters[2].Value = model.RESOURCE_CODE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_USERID;
			parameters[5].Value = model.MODEL_STATUS;

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
		public bool Update(Parking.Core.Model.FN_MODEL_UI_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FN_MODEL_UI_MANAGER set ");
			strSql.Append("MODEL_NAME=SQL2012MODEL_NAME,");
			strSql.Append("RESOURCE_CODE=SQL2012RESOURCE_CODE,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERID=SQL2012CREATE_USERID,");
			strSql.Append("MODEL_STATUS=SQL2012MODEL_STATUS");
			strSql.Append(" where MODEL_CODE=SQL2012MODEL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MODEL_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MODEL_STATUS", SqlDbType.Int,4),
					new SqlParameter("SQL2012MODEL_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MODEL_NAME;
			parameters[1].Value = model.RESOURCE_CODE;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.CREATE_USERID;
			parameters[4].Value = model.MODEL_STATUS;
			parameters[5].Value = model.MODEL_CODE;

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
		public bool Delete(string MODEL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FN_MODEL_UI_MANAGER ");
			strSql.Append(" where MODEL_CODE=SQL2012MODEL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MODEL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = MODEL_CODE;

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
		public bool DeleteList(string MODEL_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FN_MODEL_UI_MANAGER ");
			strSql.Append(" where MODEL_CODE in ("+MODEL_CODElist + ")  ");
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
		public Parking.Core.Model.FN_MODEL_UI_MANAGER GetModel(string MODEL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MODEL_CODE,MODEL_NAME,RESOURCE_CODE,CREATE_TIME,CREATE_USERID,MODEL_STATUS from FN_MODEL_UI_MANAGER ");
			strSql.Append(" where MODEL_CODE=SQL2012MODEL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MODEL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = MODEL_CODE;

			Parking.Core.Model.FN_MODEL_UI_MANAGER model=new Parking.Core.Model.FN_MODEL_UI_MANAGER();
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
		public Parking.Core.Model.FN_MODEL_UI_MANAGER DataRowToModel(DataRow row)
		{
			Parking.Core.Model.FN_MODEL_UI_MANAGER model=new Parking.Core.Model.FN_MODEL_UI_MANAGER();
			if (row != null)
			{
				if(row["MODEL_CODE"]!=null)
				{
					model.MODEL_CODE=row["MODEL_CODE"].ToString();
				}
				if(row["MODEL_NAME"]!=null)
				{
					model.MODEL_NAME=row["MODEL_NAME"].ToString();
				}
				if(row["RESOURCE_CODE"]!=null)
				{
					model.RESOURCE_CODE=row["RESOURCE_CODE"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
				}
				if(row["MODEL_STATUS"]!=null && row["MODEL_STATUS"].ToString()!="")
				{
					model.MODEL_STATUS=int.Parse(row["MODEL_STATUS"].ToString());
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
			strSql.Append("select MODEL_CODE,MODEL_NAME,RESOURCE_CODE,CREATE_TIME,CREATE_USERID,MODEL_STATUS ");
			strSql.Append(" FROM FN_MODEL_UI_MANAGER ");
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
			strSql.Append(" MODEL_CODE,MODEL_NAME,RESOURCE_CODE,CREATE_TIME,CREATE_USERID,MODEL_STATUS ");
			strSql.Append(" FROM FN_MODEL_UI_MANAGER ");
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
			strSql.Append("select count(1) FROM FN_MODEL_UI_MANAGER ");
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
				strSql.Append("order by T.MODEL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from FN_MODEL_UI_MANAGER T ");
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
			parameters[0].Value = "FN_MODEL_UI_MANAGER";
			parameters[1].Value = "MODEL_CODE";
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

