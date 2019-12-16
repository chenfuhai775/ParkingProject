/**  版本信息模板在安装目录下，可自行修改。
* UP_DATA_INTERACTION_PERMISSIONS.cs
*
* 功 能： N/A
* 类 名： UP_DATA_INTERACTION_PERMISSIONS
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
	/// 数据访问类:UP_DATA_INTERACTION_PERMISSIONS
	/// </summary>
	public partial class UP_DATA_INTERACTION_PERMISSIONS
	{
		public UP_DATA_INTERACTION_PERMISSIONS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SERVICE_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UP_DATA_INTERACTION_PERMISSIONS");
			strSql.Append(" where SERVICE_CODE=@SERVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SERVICE_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UP_DATA_INTERACTION_PERMISSIONS(");
			strSql.Append("SERVICE_CODE,SERVICE_NAME,AUTHENTICATION_CODE,SERVICE_REMARK,SEND_TYPE_COLLECTION,SERVICE_STATUS,START_FLAG)");
			strSql.Append(" values (");
			strSql.Append("@SERVICE_CODE,@SERVICE_NAME,@AUTHENTICATION_CODE,@SERVICE_REMARK,@SEND_TYPE_COLLECTION,@SERVICE_STATUS,@START_FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SERVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@AUTHENTICATION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SERVICE_REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@SEND_TYPE_COLLECTION", SqlDbType.VarChar,1000),
					new SqlParameter("@SERVICE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@START_FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.SERVICE_CODE;
			parameters[1].Value = model.SERVICE_NAME;
			parameters[2].Value = model.AUTHENTICATION_CODE;
			parameters[3].Value = model.SERVICE_REMARK;
			parameters[4].Value = model.SEND_TYPE_COLLECTION;
			parameters[5].Value = model.SERVICE_STATUS;
			parameters[6].Value = model.START_FLAG;

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
		public bool Update(Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UP_DATA_INTERACTION_PERMISSIONS set ");
			strSql.Append("SERVICE_NAME=@SERVICE_NAME,");
			strSql.Append("AUTHENTICATION_CODE=@AUTHENTICATION_CODE,");
			strSql.Append("SERVICE_REMARK=@SERVICE_REMARK,");
			strSql.Append("SEND_TYPE_COLLECTION=@SEND_TYPE_COLLECTION,");
			strSql.Append("SERVICE_STATUS=@SERVICE_STATUS,");
			strSql.Append("START_FLAG=@START_FLAG");
			strSql.Append(" where SERVICE_CODE=@SERVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SERVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@AUTHENTICATION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SERVICE_REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@SEND_TYPE_COLLECTION", SqlDbType.VarChar,1000),
					new SqlParameter("@SERVICE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@START_FLAG", SqlDbType.Int,4),
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.SERVICE_NAME;
			parameters[1].Value = model.AUTHENTICATION_CODE;
			parameters[2].Value = model.SERVICE_REMARK;
			parameters[3].Value = model.SEND_TYPE_COLLECTION;
			parameters[4].Value = model.SERVICE_STATUS;
			parameters[5].Value = model.START_FLAG;
			parameters[6].Value = model.SERVICE_CODE;

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
		public bool Delete(string SERVICE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UP_DATA_INTERACTION_PERMISSIONS ");
			strSql.Append(" where SERVICE_CODE=@SERVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SERVICE_CODE;

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
		public bool DeleteList(string SERVICE_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UP_DATA_INTERACTION_PERMISSIONS ");
			strSql.Append(" where SERVICE_CODE in ("+SERVICE_CODElist + ")  ");
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
		public Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS GetModel(string SERVICE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SERVICE_CODE,SERVICE_NAME,AUTHENTICATION_CODE,SERVICE_REMARK,SEND_TYPE_COLLECTION,SERVICE_STATUS,START_FLAG from UP_DATA_INTERACTION_PERMISSIONS ");
			strSql.Append(" where SERVICE_CODE=@SERVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SERVICE_CODE;

			Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS model=new Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS();
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
		public Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS DataRowToModel(DataRow row)
		{
			Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS model=new Parking.Core.Model.UP_DATA_INTERACTION_PERMISSIONS();
			if (row != null)
			{
				if(row["SERVICE_CODE"]!=null)
				{
					model.SERVICE_CODE=row["SERVICE_CODE"].ToString();
				}
				if(row["SERVICE_NAME"]!=null)
				{
					model.SERVICE_NAME=row["SERVICE_NAME"].ToString();
				}
				if(row["AUTHENTICATION_CODE"]!=null)
				{
					model.AUTHENTICATION_CODE=row["AUTHENTICATION_CODE"].ToString();
				}
				if(row["SERVICE_REMARK"]!=null)
				{
					model.SERVICE_REMARK=row["SERVICE_REMARK"].ToString();
				}
				if(row["SEND_TYPE_COLLECTION"]!=null)
				{
					model.SEND_TYPE_COLLECTION=row["SEND_TYPE_COLLECTION"].ToString();
				}
				if(row["SERVICE_STATUS"]!=null && row["SERVICE_STATUS"].ToString()!="")
				{
					model.SERVICE_STATUS=int.Parse(row["SERVICE_STATUS"].ToString());
				}
				if(row["START_FLAG"]!=null && row["START_FLAG"].ToString()!="")
				{
					model.START_FLAG=int.Parse(row["START_FLAG"].ToString());
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
			strSql.Append("select SERVICE_CODE,SERVICE_NAME,AUTHENTICATION_CODE,SERVICE_REMARK,SEND_TYPE_COLLECTION,SERVICE_STATUS,START_FLAG ");
			strSql.Append(" FROM UP_DATA_INTERACTION_PERMISSIONS ");
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
			strSql.Append(" SERVICE_CODE,SERVICE_NAME,AUTHENTICATION_CODE,SERVICE_REMARK,SEND_TYPE_COLLECTION,SERVICE_STATUS,START_FLAG ");
			strSql.Append(" FROM UP_DATA_INTERACTION_PERMISSIONS ");
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
			strSql.Append("select count(1) FROM UP_DATA_INTERACTION_PERMISSIONS ");
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
				strSql.Append("order by T.SERVICE_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from UP_DATA_INTERACTION_PERMISSIONS T ");
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
			parameters[0].Value = "UP_DATA_INTERACTION_PERMISSIONS";
			parameters[1].Value = "SERVICE_CODE";
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

