/**  版本信息模板在安装目录下，可自行修改。
* PBA_DEVICE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PBA_DEVICE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:09   N/A    初版
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
	/// 数据访问类:PBA_DEVICE_MANAGER
	/// </summary>
	public partial class PBA_DEVICE_MANAGER
	{
		public PBA_DEVICE_MANAGER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_DEVICE_MANAGER");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_DEVICE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_DEVICE_MANAGER(");
			strSql.Append("ID,DEVICE_NAME,DEVICE_TYPE,DEVICE_IMG,DEVICE_CATEGORIES,SINGLE_FLAG,MASTER_FLAG,VIDEO_FLAG)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012DEVICE_NAME,SQL2012DEVICE_TYPE,SQL2012DEVICE_IMG,SQL2012DEVICE_CATEGORIES,SQL2012SINGLE_FLAG,SQL2012MASTER_FLAG,SQL2012VIDEO_FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012DEVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012DEVICE_IMG", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_CATEGORIES", SqlDbType.Int,4),
					new SqlParameter("SQL2012SINGLE_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012MASTER_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012VIDEO_FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DEVICE_NAME;
			parameters[2].Value = model.DEVICE_TYPE;
			parameters[3].Value = model.DEVICE_IMG;
			parameters[4].Value = model.DEVICE_CATEGORIES;
			parameters[5].Value = model.SINGLE_FLAG;
			parameters[6].Value = model.MASTER_FLAG;
			parameters[7].Value = model.VIDEO_FLAG;

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
		public bool Update(Parking.Core.Model.PBA_DEVICE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_DEVICE_MANAGER set ");
			strSql.Append("DEVICE_NAME=SQL2012DEVICE_NAME,");
			strSql.Append("DEVICE_TYPE=SQL2012DEVICE_TYPE,");
			strSql.Append("DEVICE_IMG=SQL2012DEVICE_IMG,");
			strSql.Append("DEVICE_CATEGORIES=SQL2012DEVICE_CATEGORIES,");
			strSql.Append("SINGLE_FLAG=SQL2012SINGLE_FLAG,");
			strSql.Append("MASTER_FLAG=SQL2012MASTER_FLAG,");
			strSql.Append("VIDEO_FLAG=SQL2012VIDEO_FLAG");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012DEVICE_IMG", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_CATEGORIES", SqlDbType.Int,4),
					new SqlParameter("SQL2012SINGLE_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012MASTER_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012VIDEO_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.DEVICE_NAME;
			parameters[1].Value = model.DEVICE_TYPE;
			parameters[2].Value = model.DEVICE_IMG;
			parameters[3].Value = model.DEVICE_CATEGORIES;
			parameters[4].Value = model.SINGLE_FLAG;
			parameters[5].Value = model.MASTER_FLAG;
			parameters[6].Value = model.VIDEO_FLAG;
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
			strSql.Append("delete from PBA_DEVICE_MANAGER ");
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
			strSql.Append("delete from PBA_DEVICE_MANAGER ");
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
		public Parking.Core.Model.PBA_DEVICE_MANAGER GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DEVICE_NAME,DEVICE_TYPE,DEVICE_IMG,DEVICE_CATEGORIES,SINGLE_FLAG,MASTER_FLAG,VIDEO_FLAG from PBA_DEVICE_MANAGER ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_DEVICE_MANAGER model=new Parking.Core.Model.PBA_DEVICE_MANAGER();
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
		public Parking.Core.Model.PBA_DEVICE_MANAGER DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_DEVICE_MANAGER model=new Parking.Core.Model.PBA_DEVICE_MANAGER();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DEVICE_NAME"]!=null)
				{
					model.DEVICE_NAME=row["DEVICE_NAME"].ToString();
				}
				if(row["DEVICE_TYPE"]!=null && row["DEVICE_TYPE"].ToString()!="")
				{
					model.DEVICE_TYPE=int.Parse(row["DEVICE_TYPE"].ToString());
				}
				if(row["DEVICE_IMG"]!=null)
				{
					model.DEVICE_IMG=row["DEVICE_IMG"].ToString();
				}
				if(row["DEVICE_CATEGORIES"]!=null && row["DEVICE_CATEGORIES"].ToString()!="")
				{
					model.DEVICE_CATEGORIES=int.Parse(row["DEVICE_CATEGORIES"].ToString());
				}
				if(row["SINGLE_FLAG"]!=null && row["SINGLE_FLAG"].ToString()!="")
				{
					model.SINGLE_FLAG=int.Parse(row["SINGLE_FLAG"].ToString());
				}
				if(row["MASTER_FLAG"]!=null && row["MASTER_FLAG"].ToString()!="")
				{
					model.MASTER_FLAG=int.Parse(row["MASTER_FLAG"].ToString());
				}
				if(row["VIDEO_FLAG"]!=null && row["VIDEO_FLAG"].ToString()!="")
				{
					model.VIDEO_FLAG=int.Parse(row["VIDEO_FLAG"].ToString());
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
			strSql.Append("select ID,DEVICE_NAME,DEVICE_TYPE,DEVICE_IMG,DEVICE_CATEGORIES,SINGLE_FLAG,MASTER_FLAG,VIDEO_FLAG ");
			strSql.Append(" FROM PBA_DEVICE_MANAGER ");
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
			strSql.Append(" ID,DEVICE_NAME,DEVICE_TYPE,DEVICE_IMG,DEVICE_CATEGORIES,SINGLE_FLAG,MASTER_FLAG,VIDEO_FLAG ");
			strSql.Append(" FROM PBA_DEVICE_MANAGER ");
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
			strSql.Append("select count(1) FROM PBA_DEVICE_MANAGER ");
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
			strSql.Append(")AS Row, T.*  from PBA_DEVICE_MANAGER T ");
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
			parameters[0].Value = "PBA_DEVICE_MANAGER";
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

