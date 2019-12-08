/**  版本信息模板在安装目录下，可自行修改。
* CODE_GENERATE.cs
*
* 功 能： N/A
* 类 名： CODE_GENERATE
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
	/// 数据访问类:CODE_GENERATE
	/// </summary>
	public partial class CODE_GENERATE
	{
		public CODE_GENERATE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CODE_GENERATE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CODE_GENERATE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CODE_GENERATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CODE_GENERATE(");
			strSql.Append("ID,PREF_NAME,MODULAR_NAME,MAX_STREAM_NUMBER,FORMAT,SPLIT)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012PREF_NAME,SQL2012MODULAR_NAME,SQL2012MAX_STREAM_NUMBER,SQL2012FORMAT,SQL2012SPLIT)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4),
					new SqlParameter("SQL2012PREF_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MODULAR_NAME", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MAX_STREAM_NUMBER", SqlDbType.Int,4),
					new SqlParameter("SQL2012FORMAT", SqlDbType.VarChar,300),
					new SqlParameter("SQL2012SPLIT", SqlDbType.VarChar,30)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PREF_NAME;
			parameters[2].Value = model.MODULAR_NAME;
			parameters[3].Value = model.MAX_STREAM_NUMBER;
			parameters[4].Value = model.FORMAT;
			parameters[5].Value = model.SPLIT;

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
		public bool Update(Parking.Core.Model.CODE_GENERATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CODE_GENERATE set ");
			strSql.Append("PREF_NAME=SQL2012PREF_NAME,");
			strSql.Append("MODULAR_NAME=SQL2012MODULAR_NAME,");
			strSql.Append("MAX_STREAM_NUMBER=SQL2012MAX_STREAM_NUMBER,");
			strSql.Append("FORMAT=SQL2012FORMAT,");
			strSql.Append("SPLIT=SQL2012SPLIT");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012PREF_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MODULAR_NAME", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MAX_STREAM_NUMBER", SqlDbType.Int,4),
					new SqlParameter("SQL2012FORMAT", SqlDbType.VarChar,300),
					new SqlParameter("SQL2012SPLIT", SqlDbType.VarChar,30),
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PREF_NAME;
			parameters[1].Value = model.MODULAR_NAME;
			parameters[2].Value = model.MAX_STREAM_NUMBER;
			parameters[3].Value = model.FORMAT;
			parameters[4].Value = model.SPLIT;
			parameters[5].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CODE_GENERATE ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)			};
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
			strSql.Append("delete from CODE_GENERATE ");
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
		public Parking.Core.Model.CODE_GENERATE GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PREF_NAME,MODULAR_NAME,MAX_STREAM_NUMBER,FORMAT,SPLIT from CODE_GENERATE ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CODE_GENERATE model=new Parking.Core.Model.CODE_GENERATE();
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
		public Parking.Core.Model.CODE_GENERATE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CODE_GENERATE model=new Parking.Core.Model.CODE_GENERATE();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PREF_NAME"]!=null)
				{
					model.PREF_NAME=row["PREF_NAME"].ToString();
				}
				if(row["MODULAR_NAME"]!=null)
				{
					model.MODULAR_NAME=row["MODULAR_NAME"].ToString();
				}
				if(row["MAX_STREAM_NUMBER"]!=null && row["MAX_STREAM_NUMBER"].ToString()!="")
				{
					model.MAX_STREAM_NUMBER=int.Parse(row["MAX_STREAM_NUMBER"].ToString());
				}
				if(row["FORMAT"]!=null)
				{
					model.FORMAT=row["FORMAT"].ToString();
				}
				if(row["SPLIT"]!=null)
				{
					model.SPLIT=row["SPLIT"].ToString();
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
			strSql.Append("select ID,PREF_NAME,MODULAR_NAME,MAX_STREAM_NUMBER,FORMAT,SPLIT ");
			strSql.Append(" FROM CODE_GENERATE ");
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
			strSql.Append(" ID,PREF_NAME,MODULAR_NAME,MAX_STREAM_NUMBER,FORMAT,SPLIT ");
			strSql.Append(" FROM CODE_GENERATE ");
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
			strSql.Append("select count(1) FROM CODE_GENERATE ");
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
			strSql.Append(")AS Row, T.*  from CODE_GENERATE T ");
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
			parameters[0].Value = "CODE_GENERATE";
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

