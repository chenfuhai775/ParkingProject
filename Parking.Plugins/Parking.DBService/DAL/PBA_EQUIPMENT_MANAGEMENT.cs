/**  版本信息模板在安装目录下，可自行修改。
* PBA_EQUIPMENT_MANAGEMENT.cs
*
* 功 能： N/A
* 类 名： PBA_EQUIPMENT_MANAGEMENT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:10   N/A    初版
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
	/// 数据访问类:PBA_EQUIPMENT_MANAGEMENT
	/// </summary>
	public partial class PBA_EQUIPMENT_MANAGEMENT
	{
		public PBA_EQUIPMENT_MANAGEMENT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_EQUIPMENT_MANAGEMENT");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_EQUIPMENT_MANAGEMENT(");
			strSql.Append("ID,DISPLAY_KEY,DISPLAY_VALUE,GROUPING_CODE,PARAM_SETTINGS_GROUP,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012DISPLAY_KEY,SQL2012DISPLAY_VALUE,SQL2012GROUPING_CODE,SQL2012PARAM_SETTINGS_GROUP,SQL2012UPDATE_TIME,SQL2012UPDATE_USERID,SQL2012ORGANIZATION_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012DISPLAY_KEY", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DISPLAY_VALUE", SqlDbType.VarChar,4000),
					new SqlParameter("SQL2012GROUPING_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PARAM_SETTINGS_GROUP", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DISPLAY_KEY;
			parameters[2].Value = model.DISPLAY_VALUE;
			parameters[3].Value = model.GROUPING_CODE;
			parameters[4].Value = model.PARAM_SETTINGS_GROUP;
			parameters[5].Value = model.UPDATE_TIME;
			parameters[6].Value = model.UPDATE_USERID;
			parameters[7].Value = model.ORGANIZATION_CODE;

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
		public bool Update(Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_EQUIPMENT_MANAGEMENT set ");
			strSql.Append("DISPLAY_KEY=SQL2012DISPLAY_KEY,");
			strSql.Append("DISPLAY_VALUE=SQL2012DISPLAY_VALUE,");
			strSql.Append("GROUPING_CODE=SQL2012GROUPING_CODE,");
			strSql.Append("PARAM_SETTINGS_GROUP=SQL2012PARAM_SETTINGS_GROUP,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("UPDATE_USERID=SQL2012UPDATE_USERID,");
			strSql.Append("ORGANIZATION_CODE=SQL2012ORGANIZATION_CODE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DISPLAY_KEY", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DISPLAY_VALUE", SqlDbType.VarChar,4000),
					new SqlParameter("SQL2012GROUPING_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PARAM_SETTINGS_GROUP", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ORGANIZATION_CODE", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.DISPLAY_KEY;
			parameters[1].Value = model.DISPLAY_VALUE;
			parameters[2].Value = model.GROUPING_CODE;
			parameters[3].Value = model.PARAM_SETTINGS_GROUP;
			parameters[4].Value = model.UPDATE_TIME;
			parameters[5].Value = model.UPDATE_USERID;
			parameters[6].Value = model.ORGANIZATION_CODE;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from PBA_EQUIPMENT_MANAGEMENT ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
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
			strSql.Append("delete from PBA_EQUIPMENT_MANAGEMENT ");
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
		public Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DISPLAY_KEY,DISPLAY_VALUE,GROUPING_CODE,PARAM_SETTINGS_GROUP,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE from PBA_EQUIPMENT_MANAGEMENT ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT model=new Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT();
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
		public Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT model=new Parking.Core.Model.PBA_EQUIPMENT_MANAGEMENT();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DISPLAY_KEY"]!=null)
				{
					model.DISPLAY_KEY=row["DISPLAY_KEY"].ToString();
				}
				if(row["DISPLAY_VALUE"]!=null)
				{
					model.DISPLAY_VALUE=row["DISPLAY_VALUE"].ToString();
				}
				if(row["GROUPING_CODE"]!=null)
				{
					model.GROUPING_CODE=row["GROUPING_CODE"].ToString();
				}
				if(row["PARAM_SETTINGS_GROUP"]!=null)
				{
					model.PARAM_SETTINGS_GROUP=row["PARAM_SETTINGS_GROUP"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERID"]!=null)
				{
					model.UPDATE_USERID=row["UPDATE_USERID"].ToString();
				}
				if(row["ORGANIZATION_CODE"]!=null)
				{
					model.ORGANIZATION_CODE=row["ORGANIZATION_CODE"].ToString();
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
			strSql.Append("select ID,DISPLAY_KEY,DISPLAY_VALUE,GROUPING_CODE,PARAM_SETTINGS_GROUP,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE ");
			strSql.Append(" FROM PBA_EQUIPMENT_MANAGEMENT ");
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
			strSql.Append(" ID,DISPLAY_KEY,DISPLAY_VALUE,GROUPING_CODE,PARAM_SETTINGS_GROUP,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE ");
			strSql.Append(" FROM PBA_EQUIPMENT_MANAGEMENT ");
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
			strSql.Append("select count(1) FROM PBA_EQUIPMENT_MANAGEMENT ");
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
			strSql.Append(")AS Row, T.*  from PBA_EQUIPMENT_MANAGEMENT T ");
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
			parameters[0].Value = "PBA_EQUIPMENT_MANAGEMENT";
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

