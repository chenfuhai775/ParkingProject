/**  版本信息模板在安装目录下，可自行修改。
* EXT_PROPERTY_COSTS.cs
*
* 功 能： N/A
* 类 名： EXT_PROPERTY_COSTS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
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
	/// 数据访问类:EXT_PROPERTY_COSTS
	/// </summary>
	public partial class EXT_PROPERTY_COSTS
	{
		public EXT_PROPERTY_COSTS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EXT_PROPERTY_COSTS");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.EXT_PROPERTY_COSTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EXT_PROPERTY_COSTS(");
			strSql.Append("ROOM,REMARK,PAY_MONTH,CREATE_TIME,UPDATE_TIME,ID,PAY_FLAG)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ROOM,SQL2012REMARK,SQL2012PAY_MONTH,SQL2012CREATE_TIME,SQL2012UPDATE_TIME,SQL2012ID,SQL2012PAY_FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ROOM", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("SQL2012PAY_MONTH", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PAY_FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.ROOM;
			parameters[1].Value = model.REMARK;
			parameters[2].Value = model.PAY_MONTH;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.UPDATE_TIME;
			parameters[5].Value = model.ID;
			parameters[6].Value = model.PAY_FLAG;

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
		public bool Update(Parking.Core.Model.EXT_PROPERTY_COSTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EXT_PROPERTY_COSTS set ");
			strSql.Append("ROOM=SQL2012ROOM,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("PAY_MONTH=SQL2012PAY_MONTH,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("PAY_FLAG=SQL2012PAY_FLAG");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ROOM", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("SQL2012PAY_MONTH", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012PAY_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ROOM;
			parameters[1].Value = model.REMARK;
			parameters[2].Value = model.PAY_MONTH;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.UPDATE_TIME;
			parameters[5].Value = model.PAY_FLAG;
			parameters[6].Value = model.ID;

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
			strSql.Append("delete from EXT_PROPERTY_COSTS ");
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
			strSql.Append("delete from EXT_PROPERTY_COSTS ");
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
		public Parking.Core.Model.EXT_PROPERTY_COSTS GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ROOM,REMARK,PAY_MONTH,CREATE_TIME,UPDATE_TIME,ID,PAY_FLAG from EXT_PROPERTY_COSTS ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.EXT_PROPERTY_COSTS model=new Parking.Core.Model.EXT_PROPERTY_COSTS();
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
		public Parking.Core.Model.EXT_PROPERTY_COSTS DataRowToModel(DataRow row)
		{
			Parking.Core.Model.EXT_PROPERTY_COSTS model=new Parking.Core.Model.EXT_PROPERTY_COSTS();
			if (row != null)
			{
				if(row["ROOM"]!=null)
				{
					model.ROOM=row["ROOM"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["PAY_MONTH"]!=null)
				{
					model.PAY_MONTH=row["PAY_MONTH"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["PAY_FLAG"]!=null && row["PAY_FLAG"].ToString()!="")
				{
					model.PAY_FLAG=int.Parse(row["PAY_FLAG"].ToString());
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
			strSql.Append("select ROOM,REMARK,PAY_MONTH,CREATE_TIME,UPDATE_TIME,ID,PAY_FLAG ");
			strSql.Append(" FROM EXT_PROPERTY_COSTS ");
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
			strSql.Append(" ROOM,REMARK,PAY_MONTH,CREATE_TIME,UPDATE_TIME,ID,PAY_FLAG ");
			strSql.Append(" FROM EXT_PROPERTY_COSTS ");
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
			strSql.Append("select count(1) FROM EXT_PROPERTY_COSTS ");
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
			strSql.Append(")AS Row, T.*  from EXT_PROPERTY_COSTS T ");
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
			parameters[0].Value = "EXT_PROPERTY_COSTS";
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

