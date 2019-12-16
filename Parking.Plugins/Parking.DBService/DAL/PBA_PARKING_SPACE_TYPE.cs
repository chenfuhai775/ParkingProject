/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_SPACE_TYPE.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_SPACE_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
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
	/// 数据访问类:PBA_PARKING_SPACE_TYPE
	/// </summary>
	public partial class PBA_PARKING_SPACE_TYPE
	{
		public PBA_PARKING_SPACE_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SPACE_TYPE", "PBA_PARKING_SPACE_TYPE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SPACE_TYPE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_PARKING_SPACE_TYPE");
			strSql.Append(" where SPACE_TYPE=@SPACE_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4)			};
			parameters[0].Value = SPACE_TYPE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_PARKING_SPACE_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_PARKING_SPACE_TYPE(");
			strSql.Append("ID,SPACE_TYPE,SPACE_TYPE_NAME,CHARGE_CODE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@SPACE_TYPE,@SPACE_TYPE_NAME,@CHARGE_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4),
					new SqlParameter("@SPACE_TYPE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CHARGE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SPACE_TYPE;
			parameters[2].Value = model.SPACE_TYPE_NAME;
			parameters[3].Value = model.CHARGE_CODE;

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
		public bool Update(Parking.Core.Model.PBA_PARKING_SPACE_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_PARKING_SPACE_TYPE set ");
			strSql.Append("ID=@ID,");
			strSql.Append("SPACE_TYPE_NAME=@SPACE_TYPE_NAME,");
			strSql.Append("CHARGE_CODE=@CHARGE_CODE");
			strSql.Append(" where SPACE_TYPE=@SPACE_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@SPACE_TYPE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CHARGE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SPACE_TYPE_NAME;
			parameters[2].Value = model.CHARGE_CODE;
			parameters[3].Value = model.SPACE_TYPE;

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
		public bool Delete(int SPACE_TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_PARKING_SPACE_TYPE ");
			strSql.Append(" where SPACE_TYPE=@SPACE_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4)			};
			parameters[0].Value = SPACE_TYPE;

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
		public bool DeleteList(string SPACE_TYPElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_PARKING_SPACE_TYPE ");
			strSql.Append(" where SPACE_TYPE in ("+SPACE_TYPElist + ")  ");
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
		public Parking.Core.Model.PBA_PARKING_SPACE_TYPE GetModel(int SPACE_TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SPACE_TYPE,SPACE_TYPE_NAME,CHARGE_CODE from PBA_PARKING_SPACE_TYPE ");
			strSql.Append(" where SPACE_TYPE=@SPACE_TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4)			};
			parameters[0].Value = SPACE_TYPE;

			Parking.Core.Model.PBA_PARKING_SPACE_TYPE model=new Parking.Core.Model.PBA_PARKING_SPACE_TYPE();
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
		public Parking.Core.Model.PBA_PARKING_SPACE_TYPE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_PARKING_SPACE_TYPE model=new Parking.Core.Model.PBA_PARKING_SPACE_TYPE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["SPACE_TYPE"]!=null && row["SPACE_TYPE"].ToString()!="")
				{
					model.SPACE_TYPE=int.Parse(row["SPACE_TYPE"].ToString());
				}
				if(row["SPACE_TYPE_NAME"]!=null)
				{
					model.SPACE_TYPE_NAME=row["SPACE_TYPE_NAME"].ToString();
				}
				if(row["CHARGE_CODE"]!=null)
				{
					model.CHARGE_CODE=row["CHARGE_CODE"].ToString();
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
			strSql.Append("select ID,SPACE_TYPE,SPACE_TYPE_NAME,CHARGE_CODE ");
			strSql.Append(" FROM PBA_PARKING_SPACE_TYPE ");
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
			strSql.Append(" ID,SPACE_TYPE,SPACE_TYPE_NAME,CHARGE_CODE ");
			strSql.Append(" FROM PBA_PARKING_SPACE_TYPE ");
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
			strSql.Append("select count(1) FROM PBA_PARKING_SPACE_TYPE ");
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
				strSql.Append("order by T.SPACE_TYPE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_PARKING_SPACE_TYPE T ");
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
			parameters[0].Value = "PBA_PARKING_SPACE_TYPE";
			parameters[1].Value = "SPACE_TYPE";
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

