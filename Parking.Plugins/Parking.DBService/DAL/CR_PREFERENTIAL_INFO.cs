/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_INFO.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:04   N/A    初版
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
	/// 数据访问类:CR_PREFERENTIAL_INFO
	/// </summary>
	public partial class CR_PREFERENTIAL_INFO
	{
		public CR_PREFERENTIAL_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PREFERENTIAL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PREFERENTIAL_INFO");
			strSql.Append(" where PREFERENTIAL_CODE=@PREFERENTIAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PREFERENTIAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = PREFERENTIAL_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PREFERENTIAL_INFO(");
			strSql.Append("PREFERENTIAL_CODE,PREFERENTIAL_NAME,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,BEGIN_TIME,END_TIME,CREATE_TIME,CREATE_USER,POLICIES_OBJECT,REMARK,MERCHANT_ID)");
			strSql.Append(" values (");
			strSql.Append("@PREFERENTIAL_CODE,@PREFERENTIAL_NAME,@PREFERENTIAL_TYPE,@PREFERENTIAL_CONTENT,@BEGIN_TIME,@END_TIME,@CREATE_TIME,@CREATE_USER,@POLICIES_OBJECT,@REMARK,@MERCHANT_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("@PREFERENTIAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@PREFERENTIAL_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@PREFERENTIAL_CONTENT", SqlDbType.Decimal,9),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("@POLICIES_OBJECT", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@MERCHANT_ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.PREFERENTIAL_CODE;
			parameters[1].Value = model.PREFERENTIAL_NAME;
			parameters[2].Value = model.PREFERENTIAL_TYPE;
			parameters[3].Value = model.PREFERENTIAL_CONTENT;
			parameters[4].Value = model.BEGIN_TIME;
			parameters[5].Value = model.END_TIME;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.CREATE_USER;
			parameters[8].Value = model.POLICIES_OBJECT;
			parameters[9].Value = model.REMARK;
			parameters[10].Value = model.MERCHANT_ID;

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
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PREFERENTIAL_INFO set ");
			strSql.Append("PREFERENTIAL_NAME=@PREFERENTIAL_NAME,");
			strSql.Append("PREFERENTIAL_TYPE=@PREFERENTIAL_TYPE,");
			strSql.Append("PREFERENTIAL_CONTENT=@PREFERENTIAL_CONTENT,");
			strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
			strSql.Append("END_TIME=@END_TIME,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USER=@CREATE_USER,");
			strSql.Append("POLICIES_OBJECT=@POLICIES_OBJECT,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("MERCHANT_ID=@MERCHANT_ID");
			strSql.Append(" where PREFERENTIAL_CODE=@PREFERENTIAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PREFERENTIAL_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@PREFERENTIAL_CONTENT", SqlDbType.Decimal,9),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("@POLICIES_OBJECT", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@MERCHANT_ID", SqlDbType.VarChar,32),
					new SqlParameter("@PREFERENTIAL_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.PREFERENTIAL_NAME;
			parameters[1].Value = model.PREFERENTIAL_TYPE;
			parameters[2].Value = model.PREFERENTIAL_CONTENT;
			parameters[3].Value = model.BEGIN_TIME;
			parameters[4].Value = model.END_TIME;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CREATE_USER;
			parameters[7].Value = model.POLICIES_OBJECT;
			parameters[8].Value = model.REMARK;
			parameters[9].Value = model.MERCHANT_ID;
			parameters[10].Value = model.PREFERENTIAL_CODE;

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
		public bool Delete(string PREFERENTIAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_INFO ");
			strSql.Append(" where PREFERENTIAL_CODE=@PREFERENTIAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PREFERENTIAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = PREFERENTIAL_CODE;

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
		public bool DeleteList(string PREFERENTIAL_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_PREFERENTIAL_INFO ");
			strSql.Append(" where PREFERENTIAL_CODE in ("+PREFERENTIAL_CODElist + ")  ");
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
		public Parking.Core.Model.CR_PREFERENTIAL_INFO GetModel(string PREFERENTIAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PREFERENTIAL_CODE,PREFERENTIAL_NAME,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,BEGIN_TIME,END_TIME,CREATE_TIME,CREATE_USER,POLICIES_OBJECT,REMARK,MERCHANT_ID from CR_PREFERENTIAL_INFO ");
			strSql.Append(" where PREFERENTIAL_CODE=@PREFERENTIAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PREFERENTIAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = PREFERENTIAL_CODE;

			Parking.Core.Model.CR_PREFERENTIAL_INFO model=new Parking.Core.Model.CR_PREFERENTIAL_INFO();
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
		public Parking.Core.Model.CR_PREFERENTIAL_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PREFERENTIAL_INFO model=new Parking.Core.Model.CR_PREFERENTIAL_INFO();
			if (row != null)
			{
				if(row["PREFERENTIAL_CODE"]!=null)
				{
					model.PREFERENTIAL_CODE=row["PREFERENTIAL_CODE"].ToString();
				}
				if(row["PREFERENTIAL_NAME"]!=null)
				{
					model.PREFERENTIAL_NAME=row["PREFERENTIAL_NAME"].ToString();
				}
				if(row["PREFERENTIAL_TYPE"]!=null && row["PREFERENTIAL_TYPE"].ToString()!="")
				{
					model.PREFERENTIAL_TYPE=int.Parse(row["PREFERENTIAL_TYPE"].ToString());
				}
				if(row["PREFERENTIAL_CONTENT"]!=null && row["PREFERENTIAL_CONTENT"].ToString()!="")
				{
					model.PREFERENTIAL_CONTENT=decimal.Parse(row["PREFERENTIAL_CONTENT"].ToString());
				}
				if(row["BEGIN_TIME"]!=null && row["BEGIN_TIME"].ToString()!="")
				{
					model.BEGIN_TIME=DateTime.Parse(row["BEGIN_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USER"]!=null)
				{
					model.CREATE_USER=row["CREATE_USER"].ToString();
				}
				if(row["POLICIES_OBJECT"]!=null && row["POLICIES_OBJECT"].ToString()!="")
				{
					model.POLICIES_OBJECT=int.Parse(row["POLICIES_OBJECT"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["MERCHANT_ID"]!=null)
				{
					model.MERCHANT_ID=row["MERCHANT_ID"].ToString();
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
			strSql.Append("select PREFERENTIAL_CODE,PREFERENTIAL_NAME,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,BEGIN_TIME,END_TIME,CREATE_TIME,CREATE_USER,POLICIES_OBJECT,REMARK,MERCHANT_ID ");
			strSql.Append(" FROM CR_PREFERENTIAL_INFO ");
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
			strSql.Append(" PREFERENTIAL_CODE,PREFERENTIAL_NAME,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,BEGIN_TIME,END_TIME,CREATE_TIME,CREATE_USER,POLICIES_OBJECT,REMARK,MERCHANT_ID ");
			strSql.Append(" FROM CR_PREFERENTIAL_INFO ");
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
			strSql.Append("select count(1) FROM CR_PREFERENTIAL_INFO ");
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
				strSql.Append("order by T.PREFERENTIAL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from CR_PREFERENTIAL_INFO T ");
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
			parameters[0].Value = "CR_PREFERENTIAL_INFO";
			parameters[1].Value = "PREFERENTIAL_CODE";
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

