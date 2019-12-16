/**  版本信息模板在安装目录下，可自行修改。
* UP_MSG_TYPE_DICT_INFO.cs
*
* 功 能： N/A
* 类 名： UP_MSG_TYPE_DICT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:24   N/A    初版
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
	/// 数据访问类:UP_MSG_TYPE_DICT_INFO
	/// </summary>
	public partial class UP_MSG_TYPE_DICT_INFO
	{
		public UP_MSG_TYPE_DICT_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MSG_TYPE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UP_MSG_TYPE_DICT_INFO");
			strSql.Append(" where MSG_TYPE=@MSG_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10)			};
			parameters[0].Value = MSG_TYPE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.UP_MSG_TYPE_DICT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UP_MSG_TYPE_DICT_INFO(");
			strSql.Append("MSG_TYPE,MSG_NAME,MSG_REMARK,REISSUE_COUNT,REISSUE_INTERVAL)");
			strSql.Append(" values (");
			strSql.Append("@MSG_TYPE,@MSG_NAME,@MSG_REMARK,@REISSUE_COUNT,@REISSUE_INTERVAL)");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10),
					new SqlParameter("@MSG_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@MSG_REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@REISSUE_COUNT", SqlDbType.Int,4),
					new SqlParameter("@REISSUE_INTERVAL", SqlDbType.Int,4)};
			parameters[0].Value = model.MSG_TYPE;
			parameters[1].Value = model.MSG_NAME;
			parameters[2].Value = model.MSG_REMARK;
			parameters[3].Value = model.REISSUE_COUNT;
			parameters[4].Value = model.REISSUE_INTERVAL;

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
		public bool Update(Parking.Core.Model.UP_MSG_TYPE_DICT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UP_MSG_TYPE_DICT_INFO set ");
			strSql.Append("MSG_NAME=@MSG_NAME,");
			strSql.Append("MSG_REMARK=@MSG_REMARK,");
			strSql.Append("REISSUE_COUNT=@REISSUE_COUNT,");
			strSql.Append("REISSUE_INTERVAL=@REISSUE_INTERVAL");
			strSql.Append(" where MSG_TYPE=@MSG_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@MSG_REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@REISSUE_COUNT", SqlDbType.Int,4),
					new SqlParameter("@REISSUE_INTERVAL", SqlDbType.Int,4),
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10)};
			parameters[0].Value = model.MSG_NAME;
			parameters[1].Value = model.MSG_REMARK;
			parameters[2].Value = model.REISSUE_COUNT;
			parameters[3].Value = model.REISSUE_INTERVAL;
			parameters[4].Value = model.MSG_TYPE;

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
		public bool Delete(string MSG_TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UP_MSG_TYPE_DICT_INFO ");
			strSql.Append(" where MSG_TYPE=@MSG_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10)			};
			parameters[0].Value = MSG_TYPE;

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
		public bool DeleteList(string MSG_TYPElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UP_MSG_TYPE_DICT_INFO ");
			strSql.Append(" where MSG_TYPE in ("+MSG_TYPElist + ")  ");
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
		public Parking.Core.Model.UP_MSG_TYPE_DICT_INFO GetModel(string MSG_TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MSG_TYPE,MSG_NAME,MSG_REMARK,REISSUE_COUNT,REISSUE_INTERVAL from UP_MSG_TYPE_DICT_INFO ");
			strSql.Append(" where MSG_TYPE=@MSG_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10)			};
			parameters[0].Value = MSG_TYPE;

			Parking.Core.Model.UP_MSG_TYPE_DICT_INFO model=new Parking.Core.Model.UP_MSG_TYPE_DICT_INFO();
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
		public Parking.Core.Model.UP_MSG_TYPE_DICT_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.UP_MSG_TYPE_DICT_INFO model=new Parking.Core.Model.UP_MSG_TYPE_DICT_INFO();
			if (row != null)
			{
				if(row["MSG_TYPE"]!=null)
				{
					model.MSG_TYPE=row["MSG_TYPE"].ToString();
				}
				if(row["MSG_NAME"]!=null)
				{
					model.MSG_NAME=row["MSG_NAME"].ToString();
				}
				if(row["MSG_REMARK"]!=null)
				{
					model.MSG_REMARK=row["MSG_REMARK"].ToString();
				}
				if(row["REISSUE_COUNT"]!=null && row["REISSUE_COUNT"].ToString()!="")
				{
					model.REISSUE_COUNT=int.Parse(row["REISSUE_COUNT"].ToString());
				}
				if(row["REISSUE_INTERVAL"]!=null && row["REISSUE_INTERVAL"].ToString()!="")
				{
					model.REISSUE_INTERVAL=int.Parse(row["REISSUE_INTERVAL"].ToString());
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
			strSql.Append("select MSG_TYPE,MSG_NAME,MSG_REMARK,REISSUE_COUNT,REISSUE_INTERVAL ");
			strSql.Append(" FROM UP_MSG_TYPE_DICT_INFO ");
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
			strSql.Append(" MSG_TYPE,MSG_NAME,MSG_REMARK,REISSUE_COUNT,REISSUE_INTERVAL ");
			strSql.Append(" FROM UP_MSG_TYPE_DICT_INFO ");
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
			strSql.Append("select count(1) FROM UP_MSG_TYPE_DICT_INFO ");
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
				strSql.Append("order by T.MSG_TYPE desc");
			}
			strSql.Append(")AS Row, T.*  from UP_MSG_TYPE_DICT_INFO T ");
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
			parameters[0].Value = "UP_MSG_TYPE_DICT_INFO";
			parameters[1].Value = "MSG_TYPE";
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

