/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE_IMG.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE_IMG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	/// 数据访问类:CR_INOUT_RECODE_IMG
	/// </summary>
	public partial class CR_INOUT_RECODE_IMG
	{
		public CR_INOUT_RECODE_IMG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_INOUT_RECODE_IMG");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_INOUT_RECODE_IMG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_INOUT_RECODE_IMG(");
			strSql.Append("ID,RECODE_ID,VEHICLE_NO,DEV_ID,IMG_URL,IMG_TYPE,CREATE_TIME,CHANNEL_TYPE,CHANNEL_CODE)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012RECODE_ID,SQL2012VEHICLE_NO,SQL2012DEV_ID,SQL2012IMG_URL,SQL2012IMG_TYPE,SQL2012CREATE_TIME,SQL2012CHANNEL_TYPE,SQL2012CHANNEL_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CHANNEL_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012IMG_URL", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012IMG_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CHANNEL_TYPE", SqlDbType.VarChar,10),
					new SqlParameter("SQL2012CHANNEL_CODE", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.RECODE_ID;
			parameters[2].Value = model.VEHICLE_NO;
			parameters[3].Value = model.DEV_ID;
			parameters[4].Value = model.IMG_URL;
			parameters[5].Value = model.IMG_TYPE;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.CHANNEL_TYPE;
			parameters[8].Value = model.CHANNEL_CODE;

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
		public bool Update(Parking.Core.Model.CR_INOUT_RECODE_IMG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_INOUT_RECODE_IMG set ");
			strSql.Append("RECODE_ID=SQL2012RECODE_ID,");
			strSql.Append("CHANNEL_ID=SQL2012CHANNEL_ID,");
			strSql.Append("DEV_ID=SQL2012DEV_ID,");
			strSql.Append("IMG_URL=SQL2012IMG_URL,");
			strSql.Append("IMG_TYPE=SQL2012IMG_TYPE,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CHANNEL_TYPE=SQL2012CHANNEL_TYPE,");
			strSql.Append("CHANNEL_CODE=SQL2012CHANNEL_CODE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CHANNEL_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012IMG_URL", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012IMG_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CHANNEL_TYPE", SqlDbType.VarChar,10),
					new SqlParameter("SQL2012CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.RECODE_ID;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.DEV_ID;
			parameters[3].Value = model.IMG_URL;
			parameters[4].Value = model.IMG_TYPE;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CHANNEL_TYPE;
			parameters[7].Value = model.CHANNEL_CODE;
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
			strSql.Append("delete from CR_INOUT_RECODE_IMG ");
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
			strSql.Append("delete from CR_INOUT_RECODE_IMG ");
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
		public Parking.Core.Model.CR_INOUT_RECODE_IMG GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,RECODE_ID,CHANNEL_ID,DEV_ID,IMG_URL,IMG_TYPE,CREATE_TIME,CHANNEL_TYPE,CHANNEL_CODE from CR_INOUT_RECODE_IMG ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_INOUT_RECODE_IMG model=new Parking.Core.Model.CR_INOUT_RECODE_IMG();
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
		public Parking.Core.Model.CR_INOUT_RECODE_IMG DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_INOUT_RECODE_IMG model=new Parking.Core.Model.CR_INOUT_RECODE_IMG();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["RECODE_ID"]!=null)
				{
					model.RECODE_ID=row["RECODE_ID"].ToString();
				}
				if(row["VEHICLE_NO"] !=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["DEV_ID"]!=null)
				{
					model.DEV_ID=row["DEV_ID"].ToString();
				}
				if(row["IMG_URL"]!=null)
				{
					model.IMG_URL=row["IMG_URL"].ToString();
				}
				if(row["IMG_TYPE"]!=null && row["IMG_TYPE"].ToString()!="")
				{
					model.IMG_TYPE=int.Parse(row["IMG_TYPE"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CHANNEL_TYPE"]!=null)
				{
					model.CHANNEL_TYPE=row["CHANNEL_TYPE"].ToString();
				}
				if(row["CHANNEL_CODE"]!=null)
				{
					model.CHANNEL_CODE=row["CHANNEL_CODE"].ToString();
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
			strSql.Append("select ID,RECODE_ID,CHANNEL_ID,DEV_ID,IMG_URL,IMG_TYPE,CREATE_TIME,CHANNEL_TYPE,CHANNEL_CODE ");
			strSql.Append(" FROM CR_INOUT_RECODE_IMG ");
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
			strSql.Append(" ID,RECODE_ID,CHANNEL_ID,DEV_ID,IMG_URL,IMG_TYPE,CREATE_TIME,CHANNEL_TYPE,CHANNEL_CODE ");
			strSql.Append(" FROM CR_INOUT_RECODE_IMG ");
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
			strSql.Append("select count(1) FROM CR_INOUT_RECODE_IMG ");
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
			strSql.Append(")AS Row, T.*  from CR_INOUT_RECODE_IMG T ");
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
			parameters[0].Value = "CR_INOUT_RECODE_IMG";
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

