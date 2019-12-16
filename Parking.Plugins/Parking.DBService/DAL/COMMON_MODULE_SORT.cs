/**  版本信息模板在安装目录下，可自行修改。
* COMMON_MODULE_SORT.cs
*
* 功 能： N/A
* 类 名： COMMON_MODULE_SORT
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
	/// 数据访问类:COMMON_MODULE_SORT
	/// </summary>
	public partial class COMMON_MODULE_SORT
	{
		public COMMON_MODULE_SORT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COMMON_MODULE_SORT");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.COMMON_MODULE_SORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COMMON_MODULE_SORT(");
			strSql.Append("ID,USER_ID,MODULE_ID,USE_COUNT,LAST_TIME,MANUAL_SORT,ACCESS_DEVICE,ACCESS_AGENT,FLAG_IMPORT)");
			strSql.Append(" values (");
			strSql.Append("@ID,@USER_ID,@MODULE_ID,@USE_COUNT,@LAST_TIME,@MANUAL_SORT,@ACCESS_DEVICE,@ACCESS_AGENT,@FLAG_IMPORT)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_ID", SqlDbType.VarChar,32),
					new SqlParameter("@MODULE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@USE_COUNT", SqlDbType.Int,4),
					new SqlParameter("@LAST_TIME", SqlDbType.DateTime),
					new SqlParameter("@MANUAL_SORT", SqlDbType.Int,4),
					new SqlParameter("@ACCESS_DEVICE", SqlDbType.VarChar,50),
					new SqlParameter("@ACCESS_AGENT", SqlDbType.VarChar,500),
					new SqlParameter("@FLAG_IMPORT", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.USER_ID;
			parameters[2].Value = model.MODULE_ID;
			parameters[3].Value = model.USE_COUNT;
			parameters[4].Value = model.LAST_TIME;
			parameters[5].Value = model.MANUAL_SORT;
			parameters[6].Value = model.ACCESS_DEVICE;
			parameters[7].Value = model.ACCESS_AGENT;
			parameters[8].Value = model.FLAG_IMPORT;

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
		public bool Update(Parking.Core.Model.COMMON_MODULE_SORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COMMON_MODULE_SORT set ");
			strSql.Append("USER_ID=@USER_ID,");
			strSql.Append("MODULE_ID=@MODULE_ID,");
			strSql.Append("USE_COUNT=@USE_COUNT,");
			strSql.Append("LAST_TIME=@LAST_TIME,");
			strSql.Append("MANUAL_SORT=@MANUAL_SORT,");
			strSql.Append("ACCESS_DEVICE=@ACCESS_DEVICE,");
			strSql.Append("ACCESS_AGENT=@ACCESS_AGENT,");
			strSql.Append("FLAG_IMPORT=@FLAG_IMPORT");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.VarChar,32),
					new SqlParameter("@MODULE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@USE_COUNT", SqlDbType.Int,4),
					new SqlParameter("@LAST_TIME", SqlDbType.DateTime),
					new SqlParameter("@MANUAL_SORT", SqlDbType.Int,4),
					new SqlParameter("@ACCESS_DEVICE", SqlDbType.VarChar,50),
					new SqlParameter("@ACCESS_AGENT", SqlDbType.VarChar,500),
					new SqlParameter("@FLAG_IMPORT", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.USER_ID;
			parameters[1].Value = model.MODULE_ID;
			parameters[2].Value = model.USE_COUNT;
			parameters[3].Value = model.LAST_TIME;
			parameters[4].Value = model.MANUAL_SORT;
			parameters[5].Value = model.ACCESS_DEVICE;
			parameters[6].Value = model.ACCESS_AGENT;
			parameters[7].Value = model.FLAG_IMPORT;
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
			strSql.Append("delete from COMMON_MODULE_SORT ");
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
			strSql.Append("delete from COMMON_MODULE_SORT ");
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
		public Parking.Core.Model.COMMON_MODULE_SORT GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,USER_ID,MODULE_ID,USE_COUNT,LAST_TIME,MANUAL_SORT,ACCESS_DEVICE,ACCESS_AGENT,FLAG_IMPORT from COMMON_MODULE_SORT ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.COMMON_MODULE_SORT model=new Parking.Core.Model.COMMON_MODULE_SORT();
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
		public Parking.Core.Model.COMMON_MODULE_SORT DataRowToModel(DataRow row)
		{
			Parking.Core.Model.COMMON_MODULE_SORT model=new Parking.Core.Model.COMMON_MODULE_SORT();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["USER_ID"]!=null)
				{
					model.USER_ID=row["USER_ID"].ToString();
				}
				if(row["MODULE_ID"]!=null)
				{
					model.MODULE_ID=row["MODULE_ID"].ToString();
				}
				if(row["USE_COUNT"]!=null && row["USE_COUNT"].ToString()!="")
				{
					model.USE_COUNT=int.Parse(row["USE_COUNT"].ToString());
				}
				if(row["LAST_TIME"]!=null && row["LAST_TIME"].ToString()!="")
				{
					model.LAST_TIME=DateTime.Parse(row["LAST_TIME"].ToString());
				}
				if(row["MANUAL_SORT"]!=null && row["MANUAL_SORT"].ToString()!="")
				{
					model.MANUAL_SORT=int.Parse(row["MANUAL_SORT"].ToString());
				}
				if(row["ACCESS_DEVICE"]!=null)
				{
					model.ACCESS_DEVICE=row["ACCESS_DEVICE"].ToString();
				}
				if(row["ACCESS_AGENT"]!=null)
				{
					model.ACCESS_AGENT=row["ACCESS_AGENT"].ToString();
				}
				if(row["FLAG_IMPORT"]!=null && row["FLAG_IMPORT"].ToString()!="")
				{
					model.FLAG_IMPORT=int.Parse(row["FLAG_IMPORT"].ToString());
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
			strSql.Append("select ID,USER_ID,MODULE_ID,USE_COUNT,LAST_TIME,MANUAL_SORT,ACCESS_DEVICE,ACCESS_AGENT,FLAG_IMPORT ");
			strSql.Append(" FROM COMMON_MODULE_SORT ");
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
			strSql.Append(" ID,USER_ID,MODULE_ID,USE_COUNT,LAST_TIME,MANUAL_SORT,ACCESS_DEVICE,ACCESS_AGENT,FLAG_IMPORT ");
			strSql.Append(" FROM COMMON_MODULE_SORT ");
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
			strSql.Append("select count(1) FROM COMMON_MODULE_SORT ");
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
			strSql.Append(")AS Row, T.*  from COMMON_MODULE_SORT T ");
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
			parameters[0].Value = "COMMON_MODULE_SORT";
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

