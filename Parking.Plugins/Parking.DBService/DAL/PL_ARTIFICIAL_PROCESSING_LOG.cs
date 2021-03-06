﻿/**  版本信息模板在安装目录下，可自行修改。
* PL_ARTIFICIAL_PROCESSING_LOG.cs
*
* 功 能： N/A
* 类 名： PL_ARTIFICIAL_PROCESSING_LOG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:19   N/A    初版
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
	/// 数据访问类:PL_ARTIFICIAL_PROCESSING_LOG
	/// </summary>
	public partial class PL_ARTIFICIAL_PROCESSING_LOG
	{
		public PL_ARTIFICIAL_PROCESSING_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PL_ARTIFICIAL_PROCESSING_LOG");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PL_ARTIFICIAL_PROCESSING_LOG(");
			strSql.Append("ID,DEAL_TIME,DEAL_USERID,DEAL_REMARK,DEAL_PLATFORM,CONTROL_EQUIPMENT,DEAL_TYPE,INOUT_RECODE_ID,DEAL_STATUS,CHANNEL_TYPE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@DEAL_TIME,@DEAL_USERID,@DEAL_REMARK,@DEAL_PLATFORM,@CONTROL_EQUIPMENT,@DEAL_TYPE,@INOUT_RECODE_ID,@DEAL_STATUS,@CHANNEL_TYPE)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@DEAL_TIME", SqlDbType.DateTime),
					new SqlParameter("@DEAL_USERID", SqlDbType.VarChar,32),
					new SqlParameter("@DEAL_REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@DEAL_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@CONTROL_EQUIPMENT", SqlDbType.Int,4),
					new SqlParameter("@DEAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@DEAL_STATUS", SqlDbType.Int,4),
					new SqlParameter("@CHANNEL_TYPE", SqlDbType.VarChar,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DEAL_TIME;
			parameters[2].Value = model.DEAL_USERID;
			parameters[3].Value = model.DEAL_REMARK;
			parameters[4].Value = model.DEAL_PLATFORM;
			parameters[5].Value = model.CONTROL_EQUIPMENT;
			parameters[6].Value = model.DEAL_TYPE;
			parameters[7].Value = model.INOUT_RECODE_ID;
			parameters[8].Value = model.DEAL_STATUS;
			parameters[9].Value = model.CHANNEL_TYPE;

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
		public bool Update(Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PL_ARTIFICIAL_PROCESSING_LOG set ");
			strSql.Append("DEAL_TIME=@DEAL_TIME,");
			strSql.Append("DEAL_USERID=@DEAL_USERID,");
			strSql.Append("DEAL_REMARK=@DEAL_REMARK,");
			strSql.Append("DEAL_PLATFORM=@DEAL_PLATFORM,");
			strSql.Append("CONTROL_EQUIPMENT=@CONTROL_EQUIPMENT,");
			strSql.Append("DEAL_TYPE=@DEAL_TYPE,");
			strSql.Append("INOUT_RECODE_ID=@INOUT_RECODE_ID,");
			strSql.Append("DEAL_STATUS=@DEAL_STATUS,");
			strSql.Append("CHANNEL_TYPE=@CHANNEL_TYPE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEAL_TIME", SqlDbType.DateTime),
					new SqlParameter("@DEAL_USERID", SqlDbType.VarChar,32),
					new SqlParameter("@DEAL_REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@DEAL_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@CONTROL_EQUIPMENT", SqlDbType.Int,4),
					new SqlParameter("@DEAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@DEAL_STATUS", SqlDbType.Int,4),
					new SqlParameter("@CHANNEL_TYPE", SqlDbType.VarChar,1),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.DEAL_TIME;
			parameters[1].Value = model.DEAL_USERID;
			parameters[2].Value = model.DEAL_REMARK;
			parameters[3].Value = model.DEAL_PLATFORM;
			parameters[4].Value = model.CONTROL_EQUIPMENT;
			parameters[5].Value = model.DEAL_TYPE;
			parameters[6].Value = model.INOUT_RECODE_ID;
			parameters[7].Value = model.DEAL_STATUS;
			parameters[8].Value = model.CHANNEL_TYPE;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from PL_ARTIFICIAL_PROCESSING_LOG ");
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
			strSql.Append("delete from PL_ARTIFICIAL_PROCESSING_LOG ");
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
		public Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DEAL_TIME,DEAL_USERID,DEAL_REMARK,DEAL_PLATFORM,CONTROL_EQUIPMENT,DEAL_TYPE,INOUT_RECODE_ID,DEAL_STATUS,CHANNEL_TYPE from PL_ARTIFICIAL_PROCESSING_LOG ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG model=new Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG();
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
		public Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG model=new Parking.Core.Model.PL_ARTIFICIAL_PROCESSING_LOG();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DEAL_TIME"]!=null && row["DEAL_TIME"].ToString()!="")
				{
					model.DEAL_TIME=DateTime.Parse(row["DEAL_TIME"].ToString());
				}
				if(row["DEAL_USERID"]!=null)
				{
					model.DEAL_USERID=row["DEAL_USERID"].ToString();
				}
				if(row["DEAL_REMARK"]!=null)
				{
					model.DEAL_REMARK=row["DEAL_REMARK"].ToString();
				}
				if(row["DEAL_PLATFORM"]!=null && row["DEAL_PLATFORM"].ToString()!="")
				{
					model.DEAL_PLATFORM=int.Parse(row["DEAL_PLATFORM"].ToString());
				}
				if(row["CONTROL_EQUIPMENT"]!=null && row["CONTROL_EQUIPMENT"].ToString()!="")
				{
					model.CONTROL_EQUIPMENT=int.Parse(row["CONTROL_EQUIPMENT"].ToString());
				}
				if(row["DEAL_TYPE"]!=null && row["DEAL_TYPE"].ToString()!="")
				{
					model.DEAL_TYPE=int.Parse(row["DEAL_TYPE"].ToString());
				}
				if(row["INOUT_RECODE_ID"]!=null)
				{
					model.INOUT_RECODE_ID=row["INOUT_RECODE_ID"].ToString();
				}
				if(row["DEAL_STATUS"]!=null && row["DEAL_STATUS"].ToString()!="")
				{
					model.DEAL_STATUS=int.Parse(row["DEAL_STATUS"].ToString());
				}
				if(row["CHANNEL_TYPE"]!=null)
				{
					model.CHANNEL_TYPE=row["CHANNEL_TYPE"].ToString();
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
			strSql.Append("select ID,DEAL_TIME,DEAL_USERID,DEAL_REMARK,DEAL_PLATFORM,CONTROL_EQUIPMENT,DEAL_TYPE,INOUT_RECODE_ID,DEAL_STATUS,CHANNEL_TYPE ");
			strSql.Append(" FROM PL_ARTIFICIAL_PROCESSING_LOG ");
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
			strSql.Append(" ID,DEAL_TIME,DEAL_USERID,DEAL_REMARK,DEAL_PLATFORM,CONTROL_EQUIPMENT,DEAL_TYPE,INOUT_RECODE_ID,DEAL_STATUS,CHANNEL_TYPE ");
			strSql.Append(" FROM PL_ARTIFICIAL_PROCESSING_LOG ");
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
			strSql.Append("select count(1) FROM PL_ARTIFICIAL_PROCESSING_LOG ");
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
			strSql.Append(")AS Row, T.*  from PL_ARTIFICIAL_PROCESSING_LOG T ");
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
			parameters[0].Value = "PL_ARTIFICIAL_PROCESSING_LOG";
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

