﻿/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_POLICIES_DETAIL.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_POLICIES_DETAIL
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
	/// 数据访问类:CR_PREFERENTIAL_POLICIES_DETAIL
	/// </summary>
	public partial class CR_PREFERENTIAL_POLICIES_DETAIL
	{
		public CR_PREFERENTIAL_POLICIES_DETAIL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PREFERENTIAL_POLICIES_DETAIL");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PREFERENTIAL_POLICIES_DETAIL(");
			strSql.Append("ID,POLICIES_CODE,CR_PREFERENTIAL_ID,IS_COMBINATION,CR_LEVEL)");
			strSql.Append(" values (");
			strSql.Append("@ID,@POLICIES_CODE,@CR_PREFERENTIAL_ID,@IS_COMBINATION,@CR_LEVEL)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@POLICIES_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CR_PREFERENTIAL_ID", SqlDbType.VarChar,50),
					new SqlParameter("@IS_COMBINATION", SqlDbType.Int,4),
					new SqlParameter("@CR_LEVEL", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.POLICIES_CODE;
			parameters[2].Value = model.CR_PREFERENTIAL_ID;
			parameters[3].Value = model.IS_COMBINATION;
			parameters[4].Value = model.CR_LEVEL;

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
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PREFERENTIAL_POLICIES_DETAIL set ");
			strSql.Append("POLICIES_CODE=@POLICIES_CODE,");
			strSql.Append("CR_PREFERENTIAL_ID=@CR_PREFERENTIAL_ID,");
			strSql.Append("IS_COMBINATION=@IS_COMBINATION,");
			strSql.Append("CR_LEVEL=@CR_LEVEL");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@POLICIES_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CR_PREFERENTIAL_ID", SqlDbType.VarChar,50),
					new SqlParameter("@IS_COMBINATION", SqlDbType.Int,4),
					new SqlParameter("@CR_LEVEL", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.POLICIES_CODE;
			parameters[1].Value = model.CR_PREFERENTIAL_ID;
			parameters[2].Value = model.IS_COMBINATION;
			parameters[3].Value = model.CR_LEVEL;
			parameters[4].Value = model.ID;

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
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_POLICIES_DETAIL ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_POLICIES_DETAIL ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,POLICIES_CODE,CR_PREFERENTIAL_ID,IS_COMBINATION,CR_LEVEL from CR_PREFERENTIAL_POLICIES_DETAIL ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL model=new Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL();
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
		public Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL model=new Parking.Core.Model.CR_PREFERENTIAL_POLICIES_DETAIL();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["POLICIES_CODE"]!=null)
				{
					model.POLICIES_CODE=row["POLICIES_CODE"].ToString();
				}
				if(row["CR_PREFERENTIAL_ID"]!=null)
				{
					model.CR_PREFERENTIAL_ID=row["CR_PREFERENTIAL_ID"].ToString();
				}
				if(row["IS_COMBINATION"]!=null && row["IS_COMBINATION"].ToString()!="")
				{
					model.IS_COMBINATION=int.Parse(row["IS_COMBINATION"].ToString());
				}
				if(row["CR_LEVEL"]!=null && row["CR_LEVEL"].ToString()!="")
				{
					model.CR_LEVEL=int.Parse(row["CR_LEVEL"].ToString());
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
			strSql.Append("select ID,POLICIES_CODE,CR_PREFERENTIAL_ID,IS_COMBINATION,CR_LEVEL ");
			strSql.Append(" FROM CR_PREFERENTIAL_POLICIES_DETAIL ");
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
			strSql.Append(" ID,POLICIES_CODE,CR_PREFERENTIAL_ID,IS_COMBINATION,CR_LEVEL ");
			strSql.Append(" FROM CR_PREFERENTIAL_POLICIES_DETAIL ");
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
			strSql.Append("select count(1) FROM CR_PREFERENTIAL_POLICIES_DETAIL ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from CR_PREFERENTIAL_POLICIES_DETAIL T ");
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
			parameters[0].Value = "CR_PREFERENTIAL_POLICIES_DETAIL";
			parameters[1].Value = "ID";
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

