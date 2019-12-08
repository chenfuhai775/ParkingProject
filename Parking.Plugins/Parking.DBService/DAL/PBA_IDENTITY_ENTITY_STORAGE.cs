/**  版本信息模板在安装目录下，可自行修改。
* PBA_IDENTITY_ENTITY_STORAGE.cs
*
* 功 能： N/A
* 类 名： PBA_IDENTITY_ENTITY_STORAGE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:11   N/A    初版
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
	/// 数据访问类:PBA_IDENTITY_ENTITY_STORAGE
	/// </summary>
	public partial class PBA_IDENTITY_ENTITY_STORAGE
	{
		public PBA_IDENTITY_ENTITY_STORAGE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_IDENTITY_ENTITY_STORAGE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_IDENTITY_ENTITY_STORAGE(");
			strSql.Append("ID,IDENTITY_ID,IDENTITY_REMARK,IDENTITY_VISUAL_ID,IDENTITY_TYPE,STATUS,REMARK,CREATE_USER_ID,CREATE_TIME,UPDATE_USER_ID,UPDATE_TIME)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012IDENTITY_ID,SQL2012IDENTITY_REMARK,SQL2012IDENTITY_VISUAL_ID,SQL2012IDENTITY_TYPE,SQL2012STATUS,SQL2012REMARK,SQL2012CREATE_USER_ID,SQL2012CREATE_TIME,SQL2012UPDATE_USER_ID,SQL2012UPDATE_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012IDENTITY_ID", SqlDbType.VarChar,256),
					new SqlParameter("SQL2012IDENTITY_REMARK", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012IDENTITY_VISUAL_ID", SqlDbType.VarChar,256),
					new SqlParameter("SQL2012IDENTITY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012STATUS", SqlDbType.Int,4),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012CREATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.IDENTITY_ID;
			parameters[2].Value = model.IDENTITY_REMARK;
			parameters[3].Value = model.IDENTITY_VISUAL_ID;
			parameters[4].Value = model.IDENTITY_TYPE;
			parameters[5].Value = model.STATUS;
			parameters[6].Value = model.REMARK;
			parameters[7].Value = model.CREATE_USER_ID;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.UPDATE_USER_ID;
			parameters[10].Value = model.UPDATE_TIME;

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
		public bool Update(Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_IDENTITY_ENTITY_STORAGE set ");
			strSql.Append("IDENTITY_ID=SQL2012IDENTITY_ID,");
			strSql.Append("IDENTITY_REMARK=SQL2012IDENTITY_REMARK,");
			strSql.Append("IDENTITY_VISUAL_ID=SQL2012IDENTITY_VISUAL_ID,");
			strSql.Append("IDENTITY_TYPE=SQL2012IDENTITY_TYPE,");
			strSql.Append("STATUS=SQL2012STATUS,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("CREATE_USER_ID=SQL2012CREATE_USER_ID,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("UPDATE_USER_ID=SQL2012UPDATE_USER_ID,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012IDENTITY_ID", SqlDbType.VarChar,256),
					new SqlParameter("SQL2012IDENTITY_REMARK", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012IDENTITY_VISUAL_ID", SqlDbType.VarChar,256),
					new SqlParameter("SQL2012IDENTITY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012STATUS", SqlDbType.Int,4),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012CREATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.IDENTITY_ID;
			parameters[1].Value = model.IDENTITY_REMARK;
			parameters[2].Value = model.IDENTITY_VISUAL_ID;
			parameters[3].Value = model.IDENTITY_TYPE;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.REMARK;
			parameters[6].Value = model.CREATE_USER_ID;
			parameters[7].Value = model.CREATE_TIME;
			parameters[8].Value = model.UPDATE_USER_ID;
			parameters[9].Value = model.UPDATE_TIME;
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
			strSql.Append("delete from PBA_IDENTITY_ENTITY_STORAGE ");
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
			strSql.Append("delete from PBA_IDENTITY_ENTITY_STORAGE ");
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
		public Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,IDENTITY_ID,IDENTITY_REMARK,IDENTITY_VISUAL_ID,IDENTITY_TYPE,STATUS,REMARK,CREATE_USER_ID,CREATE_TIME,UPDATE_USER_ID,UPDATE_TIME from PBA_IDENTITY_ENTITY_STORAGE ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE model=new Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE();
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
		public Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE model=new Parking.Core.Model.PBA_IDENTITY_ENTITY_STORAGE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["IDENTITY_ID"]!=null)
				{
					model.IDENTITY_ID=row["IDENTITY_ID"].ToString();
				}
				if(row["IDENTITY_REMARK"]!=null)
				{
					model.IDENTITY_REMARK=row["IDENTITY_REMARK"].ToString();
				}
				if(row["IDENTITY_VISUAL_ID"]!=null)
				{
					model.IDENTITY_VISUAL_ID=row["IDENTITY_VISUAL_ID"].ToString();
				}
				if(row["IDENTITY_TYPE"]!=null && row["IDENTITY_TYPE"].ToString()!="")
				{
					model.IDENTITY_TYPE=int.Parse(row["IDENTITY_TYPE"].ToString());
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(row["STATUS"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["CREATE_USER_ID"]!=null)
				{
					model.CREATE_USER_ID=row["CREATE_USER_ID"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["UPDATE_USER_ID"]!=null)
				{
					model.UPDATE_USER_ID=row["UPDATE_USER_ID"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
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
			strSql.Append("select ID,IDENTITY_ID,IDENTITY_REMARK,IDENTITY_VISUAL_ID,IDENTITY_TYPE,STATUS,REMARK,CREATE_USER_ID,CREATE_TIME,UPDATE_USER_ID,UPDATE_TIME ");
			strSql.Append(" FROM PBA_IDENTITY_ENTITY_STORAGE ");
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
			strSql.Append(" ID,IDENTITY_ID,IDENTITY_REMARK,IDENTITY_VISUAL_ID,IDENTITY_TYPE,STATUS,REMARK,CREATE_USER_ID,CREATE_TIME,UPDATE_USER_ID,UPDATE_TIME ");
			strSql.Append(" FROM PBA_IDENTITY_ENTITY_STORAGE ");
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
			strSql.Append("select count(1) FROM PBA_IDENTITY_ENTITY_STORAGE ");
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
			strSql.Append(")AS Row, T.*  from PBA_IDENTITY_ENTITY_STORAGE T ");
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
			parameters[0].Value = "PBA_IDENTITY_ENTITY_STORAGE";
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

