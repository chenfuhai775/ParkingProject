/**  版本信息模板在安装目录下，可自行修改。
* CR_BUSINESS_OPERATION_LOG.cs
*
* 功 能： N/A
* 类 名： CR_BUSINESS_OPERATION_LOG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:00   N/A    初版
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
	/// 数据访问类:CR_BUSINESS_OPERATION_LOG
	/// </summary>
	public partial class CR_BUSINESS_OPERATION_LOG
	{
		public CR_BUSINESS_OPERATION_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_BUSINESS_OPERATION_LOG");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_BUSINESS_OPERATION_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_BUSINESS_OPERATION_LOG(");
			strSql.Append("ID,MODULE_CODE,OPERATING_IP,OPERATING_TIME,OPERATION_BEHAVIOR,RECORD_ID,REMARK,USER_ACCOUNT,USER_NAME)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MODULE_CODE,@OPERATING_IP,@OPERATING_TIME,@OPERATION_BEHAVIOR,@RECORD_ID,@REMARK,@USER_ACCOUNT,@USER_NAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@MODULE_CODE", SqlDbType.Int,4),
					new SqlParameter("@OPERATING_IP", SqlDbType.VarChar,40),
					new SqlParameter("@OPERATING_TIME", SqlDbType.DateTime),
					new SqlParameter("@OPERATION_BEHAVIOR", SqlDbType.Int,4),
					new SqlParameter("@RECORD_ID", SqlDbType.VarChar,2000),
					new SqlParameter("@REMARK", SqlDbType.VarChar,4000),
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,40),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,40)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MODULE_CODE;
			parameters[2].Value = model.OPERATING_IP;
			parameters[3].Value = model.OPERATING_TIME;
			parameters[4].Value = model.OPERATION_BEHAVIOR;
			parameters[5].Value = model.RECORD_ID;
			parameters[6].Value = model.REMARK;
			parameters[7].Value = model.USER_ACCOUNT;
			parameters[8].Value = model.USER_NAME;

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
		public bool Update(Parking.Core.Model.CR_BUSINESS_OPERATION_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_BUSINESS_OPERATION_LOG set ");
			strSql.Append("MODULE_CODE=@MODULE_CODE,");
			strSql.Append("OPERATING_IP=@OPERATING_IP,");
			strSql.Append("OPERATING_TIME=@OPERATING_TIME,");
			strSql.Append("OPERATION_BEHAVIOR=@OPERATION_BEHAVIOR,");
			strSql.Append("RECORD_ID=@RECORD_ID,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("USER_ACCOUNT=@USER_ACCOUNT,");
			strSql.Append("USER_NAME=@USER_NAME");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MODULE_CODE", SqlDbType.Int,4),
					new SqlParameter("@OPERATING_IP", SqlDbType.VarChar,40),
					new SqlParameter("@OPERATING_TIME", SqlDbType.DateTime),
					new SqlParameter("@OPERATION_BEHAVIOR", SqlDbType.Int,4),
					new SqlParameter("@RECORD_ID", SqlDbType.VarChar,2000),
					new SqlParameter("@REMARK", SqlDbType.VarChar,4000),
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,40),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,40),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.MODULE_CODE;
			parameters[1].Value = model.OPERATING_IP;
			parameters[2].Value = model.OPERATING_TIME;
			parameters[3].Value = model.OPERATION_BEHAVIOR;
			parameters[4].Value = model.RECORD_ID;
			parameters[5].Value = model.REMARK;
			parameters[6].Value = model.USER_ACCOUNT;
			parameters[7].Value = model.USER_NAME;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from CR_BUSINESS_OPERATION_LOG ");
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
			strSql.Append("delete from CR_BUSINESS_OPERATION_LOG ");
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
		public Parking.Core.Model.CR_BUSINESS_OPERATION_LOG GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MODULE_CODE,OPERATING_IP,OPERATING_TIME,OPERATION_BEHAVIOR,RECORD_ID,REMARK,USER_ACCOUNT,USER_NAME from CR_BUSINESS_OPERATION_LOG ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_BUSINESS_OPERATION_LOG model=new Parking.Core.Model.CR_BUSINESS_OPERATION_LOG();
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
		public Parking.Core.Model.CR_BUSINESS_OPERATION_LOG DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_BUSINESS_OPERATION_LOG model=new Parking.Core.Model.CR_BUSINESS_OPERATION_LOG();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MODULE_CODE"]!=null && row["MODULE_CODE"].ToString()!="")
				{
					model.MODULE_CODE=int.Parse(row["MODULE_CODE"].ToString());
				}
				if(row["OPERATING_IP"]!=null)
				{
					model.OPERATING_IP=row["OPERATING_IP"].ToString();
				}
				if(row["OPERATING_TIME"]!=null && row["OPERATING_TIME"].ToString()!="")
				{
					model.OPERATING_TIME=DateTime.Parse(row["OPERATING_TIME"].ToString());
				}
				if(row["OPERATION_BEHAVIOR"]!=null && row["OPERATION_BEHAVIOR"].ToString()!="")
				{
					model.OPERATION_BEHAVIOR=int.Parse(row["OPERATION_BEHAVIOR"].ToString());
				}
				if(row["RECORD_ID"]!=null)
				{
					model.RECORD_ID=row["RECORD_ID"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["USER_ACCOUNT"]!=null)
				{
					model.USER_ACCOUNT=row["USER_ACCOUNT"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
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
			strSql.Append("select ID,MODULE_CODE,OPERATING_IP,OPERATING_TIME,OPERATION_BEHAVIOR,RECORD_ID,REMARK,USER_ACCOUNT,USER_NAME ");
			strSql.Append(" FROM CR_BUSINESS_OPERATION_LOG ");
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
			strSql.Append(" ID,MODULE_CODE,OPERATING_IP,OPERATING_TIME,OPERATION_BEHAVIOR,RECORD_ID,REMARK,USER_ACCOUNT,USER_NAME ");
			strSql.Append(" FROM CR_BUSINESS_OPERATION_LOG ");
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
			strSql.Append("select count(1) FROM CR_BUSINESS_OPERATION_LOG ");
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
			strSql.Append(")AS Row, T.*  from CR_BUSINESS_OPERATION_LOG T ");
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
			parameters[0].Value = "CR_BUSINESS_OPERATION_LOG";
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

