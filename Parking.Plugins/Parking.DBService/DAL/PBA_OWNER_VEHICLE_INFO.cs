/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_VEHICLE_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_VEHICLE_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:14   N/A    初版
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
	/// 数据访问类:PBA_OWNER_VEHICLE_INFO
	/// </summary>
	public partial class PBA_OWNER_VEHICLE_INFO
	{
		public PBA_OWNER_VEHICLE_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_OWNER_VEHICLE_INFO");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_OWNER_VEHICLE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_OWNER_VEHICLE_INFO(");
			strSql.Append("ID,OWNER_CODE,VEHICLE_NO,VEHICLE_COLOR,VEHICLE_TYPE,VEHICLE_CATEGORY,VEHICLE_LOGO,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012OWNER_CODE,SQL2012VEHICLE_NO,SQL2012VEHICLE_COLOR,SQL2012VEHICLE_TYPE,SQL2012VEHICLE_CATEGORY,SQL2012VEHICLE_LOGO,SQL2012CREATE_TIME,SQL2012CREATE_USERNAME,SQL2012UPDATE_TIME,SQL2012UPDATE_USERNAME)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_COLOR", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012VEHICLE_CATEGORY", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_LOGO", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.OWNER_CODE;
			parameters[2].Value = model.VEHICLE_NO;
			parameters[3].Value = model.VEHICLE_COLOR;
			parameters[4].Value = model.VEHICLE_TYPE;
			parameters[5].Value = model.VEHICLE_CATEGORY;
			parameters[6].Value = model.VEHICLE_LOGO;
			parameters[7].Value = model.CREATE_TIME;
			parameters[8].Value = model.CREATE_USERNAME;
			parameters[9].Value = model.UPDATE_TIME;
			parameters[10].Value = model.UPDATE_USERNAME;

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
		public bool Update(Parking.Core.Model.PBA_OWNER_VEHICLE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_OWNER_VEHICLE_INFO set ");
			strSql.Append("OWNER_CODE=SQL2012OWNER_CODE,");
			strSql.Append("VEHICLE_NO=SQL2012VEHICLE_NO,");
			strSql.Append("VEHICLE_COLOR=SQL2012VEHICLE_COLOR,");
			strSql.Append("VEHICLE_TYPE=SQL2012VEHICLE_TYPE,");
			strSql.Append("VEHICLE_CATEGORY=SQL2012VEHICLE_CATEGORY,");
			strSql.Append("VEHICLE_LOGO=SQL2012VEHICLE_LOGO,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERNAME=SQL2012CREATE_USERNAME,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("UPDATE_USERNAME=SQL2012UPDATE_USERNAME");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_COLOR", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012VEHICLE_CATEGORY", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012VEHICLE_LOGO", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.OWNER_CODE;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.VEHICLE_COLOR;
			parameters[3].Value = model.VEHICLE_TYPE;
			parameters[4].Value = model.VEHICLE_CATEGORY;
			parameters[5].Value = model.VEHICLE_LOGO;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.CREATE_USERNAME;
			parameters[8].Value = model.UPDATE_TIME;
			parameters[9].Value = model.UPDATE_USERNAME;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from PBA_OWNER_VEHICLE_INFO ");
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
			strSql.Append("delete from PBA_OWNER_VEHICLE_INFO ");
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
		public Parking.Core.Model.PBA_OWNER_VEHICLE_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OWNER_CODE,VEHICLE_NO,VEHICLE_COLOR,VEHICLE_TYPE,VEHICLE_CATEGORY,VEHICLE_LOGO,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME from PBA_OWNER_VEHICLE_INFO ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_OWNER_VEHICLE_INFO model=new Parking.Core.Model.PBA_OWNER_VEHICLE_INFO();
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
		public Parking.Core.Model.PBA_OWNER_VEHICLE_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_OWNER_VEHICLE_INFO model=new Parking.Core.Model.PBA_OWNER_VEHICLE_INFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["OWNER_CODE"]!=null)
				{
					model.OWNER_CODE=row["OWNER_CODE"].ToString();
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["VEHICLE_COLOR"]!=null)
				{
					model.VEHICLE_COLOR=row["VEHICLE_COLOR"].ToString();
				}
				if(row["VEHICLE_TYPE"]!=null && row["VEHICLE_TYPE"].ToString()!="")
				{
					model.VEHICLE_TYPE=int.Parse(row["VEHICLE_TYPE"].ToString());
				}
				if(row["VEHICLE_CATEGORY"]!=null)
				{
					model.VEHICLE_CATEGORY=row["VEHICLE_CATEGORY"].ToString();
				}
				if(row["VEHICLE_LOGO"]!=null)
				{
					model.VEHICLE_LOGO=row["VEHICLE_LOGO"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERNAME"]!=null)
				{
					model.CREATE_USERNAME=row["CREATE_USERNAME"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERNAME"]!=null)
				{
					model.UPDATE_USERNAME=row["UPDATE_USERNAME"].ToString();
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
			strSql.Append("select ID,OWNER_CODE,VEHICLE_NO,VEHICLE_COLOR,VEHICLE_TYPE,VEHICLE_CATEGORY,VEHICLE_LOGO,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME ");
			strSql.Append(" FROM PBA_OWNER_VEHICLE_INFO ");
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
			strSql.Append(" ID,OWNER_CODE,VEHICLE_NO,VEHICLE_COLOR,VEHICLE_TYPE,VEHICLE_CATEGORY,VEHICLE_LOGO,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME ");
			strSql.Append(" FROM PBA_OWNER_VEHICLE_INFO ");
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
			strSql.Append("select count(1) FROM PBA_OWNER_VEHICLE_INFO ");
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
			strSql.Append(")AS Row, T.*  from PBA_OWNER_VEHICLE_INFO T ");
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
			parameters[0].Value = "PBA_OWNER_VEHICLE_INFO";
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

