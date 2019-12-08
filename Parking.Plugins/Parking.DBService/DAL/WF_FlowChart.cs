/**  版本信息模板在安装目录下，可自行修改。
* WF_FlowChart.cs
*
* 功 能： N/A
* 类 名： WF_FlowChart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:25   N/A    初版
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
	/// 数据访问类:WF_FlowChart
	/// </summary>
	public partial class WF_FlowChart
	{
		public WF_FlowChart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_FlowChart");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.WF_FlowChart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_FlowChart(");
			strSql.Append("ID,FlowName,FlowType,ReMark,CreateUserID,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012FlowName,SQL2012FlowType,SQL2012ReMark,SQL2012CreateUserID,SQL2012CreateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012FlowName", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012FlowType", SqlDbType.Int,4),
					new SqlParameter("SQL2012ReMark", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CreateUserID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.FlowName;
			parameters[2].Value = model.FlowType;
			parameters[3].Value = model.ReMark;
			parameters[4].Value = model.CreateUserID;
			parameters[5].Value = model.CreateTime;

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
		public bool Update(Parking.Core.Model.WF_FlowChart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_FlowChart set ");
			strSql.Append("FlowName=SQL2012FlowName,");
			strSql.Append("FlowType=SQL2012FlowType,");
			strSql.Append("ReMark=SQL2012ReMark,");
			strSql.Append("CreateUserID=SQL2012CreateUserID,");
			strSql.Append("CreateTime=SQL2012CreateTime");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FlowName", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012FlowType", SqlDbType.Int,4),
					new SqlParameter("SQL2012ReMark", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CreateUserID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CreateTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.FlowName;
			parameters[1].Value = model.FlowType;
			parameters[2].Value = model.ReMark;
			parameters[3].Value = model.CreateUserID;
			parameters[4].Value = model.CreateTime;
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
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WF_FlowChart ");
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
			strSql.Append("delete from WF_FlowChart ");
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
		public Parking.Core.Model.WF_FlowChart GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FlowName,FlowType,ReMark,CreateUserID,CreateTime from WF_FlowChart ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.WF_FlowChart model=new Parking.Core.Model.WF_FlowChart();
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
		public Parking.Core.Model.WF_FlowChart DataRowToModel(DataRow row)
		{
			Parking.Core.Model.WF_FlowChart model=new Parking.Core.Model.WF_FlowChart();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["FlowName"]!=null)
				{
					model.FlowName=row["FlowName"].ToString();
				}
				if(row["FlowType"]!=null && row["FlowType"].ToString()!="")
				{
					model.FlowType=int.Parse(row["FlowType"].ToString());
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
				}
				if(row["CreateUserID"]!=null)
				{
					model.CreateUserID=row["CreateUserID"].ToString();
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
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
			strSql.Append("select ID,FlowName,FlowType,ReMark,CreateUserID,CreateTime ");
			strSql.Append(" FROM WF_FlowChart ");
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
			strSql.Append(" ID,FlowName,FlowType,ReMark,CreateUserID,CreateTime ");
			strSql.Append(" FROM WF_FlowChart ");
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
			strSql.Append("select count(1) FROM WF_FlowChart ");
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
			strSql.Append(")AS Row, T.*  from WF_FlowChart T ");
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
			parameters[0].Value = "WF_FlowChart";
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

