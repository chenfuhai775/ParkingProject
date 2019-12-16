/**  版本信息模板在安装目录下，可自行修改。
* UP_LOG_RECEIVE_MESSAGE.cs
*
* 功 能： N/A
* 类 名： UP_LOG_RECEIVE_MESSAGE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:23   N/A    初版
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
	/// 数据访问类:UP_LOG_RECEIVE_MESSAGE
	/// </summary>
	public partial class UP_LOG_RECEIVE_MESSAGE
	{
		public UP_LOG_RECEIVE_MESSAGE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UP_LOG_RECEIVE_MESSAGE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UP_LOG_RECEIVE_MESSAGE(");
			strSql.Append("ID,MSG_TYPE,MSG_STR,CREATE_DATE,MSG_DATE,MSG_SEND_TYPE,MSG_SEQ,RECEIPT_MSG_DATE,RECEIPT_SEQ,RECEIPT_MSG_STR,MSG_STATUS,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MSG_TYPE,@MSG_STR,@CREATE_DATE,@MSG_DATE,@MSG_SEND_TYPE,@MSG_SEQ,@RECEIPT_MSG_DATE,@RECEIPT_SEQ,@RECEIPT_MSG_STR,@MSG_STATUS,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10),
					new SqlParameter("@MSG_STR", SqlDbType.VarChar,4000),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@MSG_DATE", SqlDbType.DateTime),
					new SqlParameter("@MSG_SEND_TYPE", SqlDbType.VarChar,500),
					new SqlParameter("@MSG_SEQ", SqlDbType.VarChar,50),
					new SqlParameter("@RECEIPT_MSG_DATE", SqlDbType.DateTime),
					new SqlParameter("@RECEIPT_SEQ", SqlDbType.VarChar,50),
					new SqlParameter("@RECEIPT_MSG_STR", SqlDbType.VarChar,4000),
					new SqlParameter("@MSG_STATUS", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MSG_TYPE;
			parameters[2].Value = model.MSG_STR;
			parameters[3].Value = model.CREATE_DATE;
			parameters[4].Value = model.MSG_DATE;
			parameters[5].Value = model.MSG_SEND_TYPE;
			parameters[6].Value = model.MSG_SEQ;
			parameters[7].Value = model.RECEIPT_MSG_DATE;
			parameters[8].Value = model.RECEIPT_SEQ;
			parameters[9].Value = model.RECEIPT_MSG_STR;
			parameters[10].Value = model.MSG_STATUS;
			parameters[11].Value = model.REMARK;

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
		public bool Update(Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UP_LOG_RECEIVE_MESSAGE set ");
			strSql.Append("MSG_TYPE=@MSG_TYPE,");
			strSql.Append("MSG_STR=@MSG_STR,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("MSG_DATE=@MSG_DATE,");
			strSql.Append("MSG_SEND_TYPE=@MSG_SEND_TYPE,");
			strSql.Append("MSG_SEQ=@MSG_SEQ,");
			strSql.Append("RECEIPT_MSG_DATE=@RECEIPT_MSG_DATE,");
			strSql.Append("RECEIPT_SEQ=@RECEIPT_SEQ,");
			strSql.Append("RECEIPT_MSG_STR=@RECEIPT_MSG_STR,");
			strSql.Append("MSG_STATUS=@MSG_STATUS,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,10),
					new SqlParameter("@MSG_STR", SqlDbType.VarChar,4000),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@MSG_DATE", SqlDbType.DateTime),
					new SqlParameter("@MSG_SEND_TYPE", SqlDbType.VarChar,500),
					new SqlParameter("@MSG_SEQ", SqlDbType.VarChar,50),
					new SqlParameter("@RECEIPT_MSG_DATE", SqlDbType.DateTime),
					new SqlParameter("@RECEIPT_SEQ", SqlDbType.VarChar,50),
					new SqlParameter("@RECEIPT_MSG_STR", SqlDbType.VarChar,4000),
					new SqlParameter("@MSG_STATUS", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.MSG_TYPE;
			parameters[1].Value = model.MSG_STR;
			parameters[2].Value = model.CREATE_DATE;
			parameters[3].Value = model.MSG_DATE;
			parameters[4].Value = model.MSG_SEND_TYPE;
			parameters[5].Value = model.MSG_SEQ;
			parameters[6].Value = model.RECEIPT_MSG_DATE;
			parameters[7].Value = model.RECEIPT_SEQ;
			parameters[8].Value = model.RECEIPT_MSG_STR;
			parameters[9].Value = model.MSG_STATUS;
			parameters[10].Value = model.REMARK;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from UP_LOG_RECEIVE_MESSAGE ");
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
			strSql.Append("delete from UP_LOG_RECEIVE_MESSAGE ");
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
		public Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MSG_TYPE,MSG_STR,CREATE_DATE,MSG_DATE,MSG_SEND_TYPE,MSG_SEQ,RECEIPT_MSG_DATE,RECEIPT_SEQ,RECEIPT_MSG_STR,MSG_STATUS,REMARK from UP_LOG_RECEIVE_MESSAGE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE model=new Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE();
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
		public Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE model=new Parking.Core.Model.UP_LOG_RECEIVE_MESSAGE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MSG_TYPE"]!=null)
				{
					model.MSG_TYPE=row["MSG_TYPE"].ToString();
				}
				if(row["MSG_STR"]!=null)
				{
					model.MSG_STR=row["MSG_STR"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["MSG_DATE"]!=null && row["MSG_DATE"].ToString()!="")
				{
					model.MSG_DATE=DateTime.Parse(row["MSG_DATE"].ToString());
				}
				if(row["MSG_SEND_TYPE"]!=null)
				{
					model.MSG_SEND_TYPE=row["MSG_SEND_TYPE"].ToString();
				}
				if(row["MSG_SEQ"]!=null)
				{
					model.MSG_SEQ=row["MSG_SEQ"].ToString();
				}
				if(row["RECEIPT_MSG_DATE"]!=null && row["RECEIPT_MSG_DATE"].ToString()!="")
				{
					model.RECEIPT_MSG_DATE=DateTime.Parse(row["RECEIPT_MSG_DATE"].ToString());
				}
				if(row["RECEIPT_SEQ"]!=null)
				{
					model.RECEIPT_SEQ=row["RECEIPT_SEQ"].ToString();
				}
				if(row["RECEIPT_MSG_STR"]!=null)
				{
					model.RECEIPT_MSG_STR=row["RECEIPT_MSG_STR"].ToString();
				}
				if(row["MSG_STATUS"]!=null && row["MSG_STATUS"].ToString()!="")
				{
					model.MSG_STATUS=int.Parse(row["MSG_STATUS"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select ID,MSG_TYPE,MSG_STR,CREATE_DATE,MSG_DATE,MSG_SEND_TYPE,MSG_SEQ,RECEIPT_MSG_DATE,RECEIPT_SEQ,RECEIPT_MSG_STR,MSG_STATUS,REMARK ");
			strSql.Append(" FROM UP_LOG_RECEIVE_MESSAGE ");
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
			strSql.Append(" ID,MSG_TYPE,MSG_STR,CREATE_DATE,MSG_DATE,MSG_SEND_TYPE,MSG_SEQ,RECEIPT_MSG_DATE,RECEIPT_SEQ,RECEIPT_MSG_STR,MSG_STATUS,REMARK ");
			strSql.Append(" FROM UP_LOG_RECEIVE_MESSAGE ");
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
			strSql.Append("select count(1) FROM UP_LOG_RECEIVE_MESSAGE ");
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
			strSql.Append(")AS Row, T.*  from UP_LOG_RECEIVE_MESSAGE T ");
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
			parameters[0].Value = "UP_LOG_RECEIVE_MESSAGE";
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

