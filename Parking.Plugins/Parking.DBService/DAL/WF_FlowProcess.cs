/**  版本信息模板在安装目录下，可自行修改。
* WF_FlowProcess.cs
*
* 功 能： N/A
* 类 名： WF_FlowProcess
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:26   N/A    初版
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
	/// 数据访问类:WF_FlowProcess
	/// </summary>
	public partial class WF_FlowProcess
	{
		public WF_FlowProcess()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_FlowProcess");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.WF_FlowProcess model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_FlowProcess(");
			strSql.Append("ID,FlowCode,NodeCode,RecordID,CarNo,UserID,ExecutionTime,Result,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ID,@FlowCode,@NodeCode,@RecordID,@CarNo,@UserID,@ExecutionTime,@Result,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@FlowCode", SqlDbType.VarChar,32),
					new SqlParameter("@NodeCode", SqlDbType.VarChar,32),
					new SqlParameter("@RecordID", SqlDbType.VarChar,32),
					new SqlParameter("@CarNo", SqlDbType.VarChar,20),
					new SqlParameter("@UserID", SqlDbType.VarChar,32),
					new SqlParameter("@ExecutionTime", SqlDbType.DateTime),
					new SqlParameter("@Result", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.FlowCode;
			parameters[2].Value = model.NodeCode;
			parameters[3].Value = model.RecordID;
			parameters[4].Value = model.CarNo;
			parameters[5].Value = model.UserID;
			parameters[6].Value = model.ExecutionTime;
			parameters[7].Value = model.Result;
			parameters[8].Value = model.Remark;

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
		public bool Update(Parking.Core.Model.WF_FlowProcess model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_FlowProcess set ");
			strSql.Append("FlowCode=@FlowCode,");
			strSql.Append("NodeCode=@NodeCode,");
			strSql.Append("RecordID=@RecordID,");
			strSql.Append("CarNo=@CarNo,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("ExecutionTime=@ExecutionTime,");
			strSql.Append("Result=@Result,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FlowCode", SqlDbType.VarChar,32),
					new SqlParameter("@NodeCode", SqlDbType.VarChar,32),
					new SqlParameter("@RecordID", SqlDbType.VarChar,32),
					new SqlParameter("@CarNo", SqlDbType.VarChar,20),
					new SqlParameter("@UserID", SqlDbType.VarChar,32),
					new SqlParameter("@ExecutionTime", SqlDbType.DateTime),
					new SqlParameter("@Result", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,32),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.FlowCode;
			parameters[1].Value = model.NodeCode;
			parameters[2].Value = model.RecordID;
			parameters[3].Value = model.CarNo;
			parameters[4].Value = model.UserID;
			parameters[5].Value = model.ExecutionTime;
			parameters[6].Value = model.Result;
			parameters[7].Value = model.Remark;
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
			strSql.Append("delete from WF_FlowProcess ");
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
			strSql.Append("delete from WF_FlowProcess ");
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
		public Parking.Core.Model.WF_FlowProcess GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FlowCode,NodeCode,RecordID,CarNo,UserID,ExecutionTime,Result,Remark from WF_FlowProcess ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.WF_FlowProcess model=new Parking.Core.Model.WF_FlowProcess();
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
		public Parking.Core.Model.WF_FlowProcess DataRowToModel(DataRow row)
		{
			Parking.Core.Model.WF_FlowProcess model=new Parking.Core.Model.WF_FlowProcess();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["FlowCode"]!=null)
				{
					model.FlowCode=row["FlowCode"].ToString();
				}
				if(row["NodeCode"]!=null)
				{
					model.NodeCode=row["NodeCode"].ToString();
				}
				if(row["RecordID"]!=null)
				{
					model.RecordID=row["RecordID"].ToString();
				}
				if(row["CarNo"]!=null)
				{
					model.CarNo=row["CarNo"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["ExecutionTime"]!=null && row["ExecutionTime"].ToString()!="")
				{
					model.ExecutionTime=DateTime.Parse(row["ExecutionTime"].ToString());
				}
				if(row["Result"]!=null && row["Result"].ToString()!="")
				{
					if((row["Result"].ToString()=="1")||(row["Result"].ToString().ToLower()=="true"))
					{
						model.Result=true;
					}
					else
					{
						model.Result=false;
					}
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select ID,FlowCode,NodeCode,RecordID,CarNo,UserID,ExecutionTime,Result,Remark ");
			strSql.Append(" FROM WF_FlowProcess ");
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
			strSql.Append(" ID,FlowCode,NodeCode,RecordID,CarNo,UserID,ExecutionTime,Result,Remark ");
			strSql.Append(" FROM WF_FlowProcess ");
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
			strSql.Append("select count(1) FROM WF_FlowProcess ");
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
			strSql.Append(")AS Row, T.*  from WF_FlowProcess T ");
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
			parameters[0].Value = "WF_FlowProcess";
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

