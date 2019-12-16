/**  版本信息模板在安装目录下，可自行修改。
* PBA_SUB_ORDER_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_SUB_ORDER_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:16   N/A    初版
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
	/// 数据访问类:PBA_SUB_ORDER_INFO
	/// </summary>
	public partial class PBA_SUB_ORDER_INFO
	{
		public PBA_SUB_ORDER_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_SUB_ORDER_INFO");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_SUB_ORDER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_SUB_ORDER_INFO(");
			strSql.Append("ID,SUBSCRIBE_CODE,USER_NAME,SYSTEM_CODE,SYSTEM_NAME,BEGIN_TIME,END_TIME,CHARGE_MONEY,SPACECODE,VEHICLE_NO,SUBSCRIBE_STATUS,REMARK,UNIQUE_IDENTIFIER)");
			strSql.Append(" values (");
			strSql.Append("@ID,@SUBSCRIBE_CODE,@USER_NAME,@SYSTEM_CODE,@SYSTEM_NAME,@BEGIN_TIME,@END_TIME,@CHARGE_MONEY,@SPACECODE,@VEHICLE_NO,@SUBSCRIBE_STATUS,@REMARK,@UNIQUE_IDENTIFIER)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@SUBSCRIBE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@SYSTEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SYSTEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@SPACECODE", SqlDbType.VarChar,50),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@SUBSCRIBE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SUBSCRIBE_CODE;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.SYSTEM_CODE;
			parameters[4].Value = model.SYSTEM_NAME;
			parameters[5].Value = model.BEGIN_TIME;
			parameters[6].Value = model.END_TIME;
			parameters[7].Value = model.CHARGE_MONEY;
			parameters[8].Value = model.SPACECODE;
			parameters[9].Value = model.VEHICLE_NO;
			parameters[10].Value = model.SUBSCRIBE_STATUS;
			parameters[11].Value = model.REMARK;
			parameters[12].Value = model.UNIQUE_IDENTIFIER;

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
		public bool Update(Parking.Core.Model.PBA_SUB_ORDER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_SUB_ORDER_INFO set ");
			strSql.Append("SUBSCRIBE_CODE=@SUBSCRIBE_CODE,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("SYSTEM_CODE=@SYSTEM_CODE,");
			strSql.Append("SYSTEM_NAME=@SYSTEM_NAME,");
			strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
			strSql.Append("END_TIME=@END_TIME,");
			strSql.Append("CHARGE_MONEY=@CHARGE_MONEY,");
			strSql.Append("SPACECODE=@SPACECODE,");
			strSql.Append("VEHICLE_NO=@VEHICLE_NO,");
			strSql.Append("SUBSCRIBE_STATUS=@SUBSCRIBE_STATUS,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("UNIQUE_IDENTIFIER=@UNIQUE_IDENTIFIER");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUBSCRIBE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@SYSTEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SYSTEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@SPACECODE", SqlDbType.VarChar,50),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@SUBSCRIBE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.SUBSCRIBE_CODE;
			parameters[1].Value = model.USER_NAME;
			parameters[2].Value = model.SYSTEM_CODE;
			parameters[3].Value = model.SYSTEM_NAME;
			parameters[4].Value = model.BEGIN_TIME;
			parameters[5].Value = model.END_TIME;
			parameters[6].Value = model.CHARGE_MONEY;
			parameters[7].Value = model.SPACECODE;
			parameters[8].Value = model.VEHICLE_NO;
			parameters[9].Value = model.SUBSCRIBE_STATUS;
			parameters[10].Value = model.REMARK;
			parameters[11].Value = model.UNIQUE_IDENTIFIER;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from PBA_SUB_ORDER_INFO ");
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
			strSql.Append("delete from PBA_SUB_ORDER_INFO ");
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
		public Parking.Core.Model.PBA_SUB_ORDER_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SUBSCRIBE_CODE,USER_NAME,SYSTEM_CODE,SYSTEM_NAME,BEGIN_TIME,END_TIME,CHARGE_MONEY,SPACECODE,VEHICLE_NO,SUBSCRIBE_STATUS,REMARK,UNIQUE_IDENTIFIER from PBA_SUB_ORDER_INFO ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_SUB_ORDER_INFO model=new Parking.Core.Model.PBA_SUB_ORDER_INFO();
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
		public Parking.Core.Model.PBA_SUB_ORDER_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_SUB_ORDER_INFO model=new Parking.Core.Model.PBA_SUB_ORDER_INFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["SUBSCRIBE_CODE"]!=null)
				{
					model.SUBSCRIBE_CODE=row["SUBSCRIBE_CODE"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
				}
				if(row["SYSTEM_CODE"]!=null)
				{
					model.SYSTEM_CODE=row["SYSTEM_CODE"].ToString();
				}
				if(row["SYSTEM_NAME"]!=null)
				{
					model.SYSTEM_NAME=row["SYSTEM_NAME"].ToString();
				}
				if(row["BEGIN_TIME"]!=null && row["BEGIN_TIME"].ToString()!="")
				{
					model.BEGIN_TIME=DateTime.Parse(row["BEGIN_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
				}
				if(row["CHARGE_MONEY"]!=null && row["CHARGE_MONEY"].ToString()!="")
				{
					model.CHARGE_MONEY=decimal.Parse(row["CHARGE_MONEY"].ToString());
				}
				if(row["SPACECODE"]!=null)
				{
					model.SPACECODE=row["SPACECODE"].ToString();
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["SUBSCRIBE_STATUS"]!=null && row["SUBSCRIBE_STATUS"].ToString()!="")
				{
					model.SUBSCRIBE_STATUS=int.Parse(row["SUBSCRIBE_STATUS"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["UNIQUE_IDENTIFIER"]!=null)
				{
					model.UNIQUE_IDENTIFIER=row["UNIQUE_IDENTIFIER"].ToString();
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
			strSql.Append("select ID,SUBSCRIBE_CODE,USER_NAME,SYSTEM_CODE,SYSTEM_NAME,BEGIN_TIME,END_TIME,CHARGE_MONEY,SPACECODE,VEHICLE_NO,SUBSCRIBE_STATUS,REMARK,UNIQUE_IDENTIFIER ");
			strSql.Append(" FROM PBA_SUB_ORDER_INFO ");
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
			strSql.Append(" ID,SUBSCRIBE_CODE,USER_NAME,SYSTEM_CODE,SYSTEM_NAME,BEGIN_TIME,END_TIME,CHARGE_MONEY,SPACECODE,VEHICLE_NO,SUBSCRIBE_STATUS,REMARK,UNIQUE_IDENTIFIER ");
			strSql.Append(" FROM PBA_SUB_ORDER_INFO ");
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
			strSql.Append("select count(1) FROM PBA_SUB_ORDER_INFO ");
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
			strSql.Append(")AS Row, T.*  from PBA_SUB_ORDER_INFO T ");
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
			parameters[0].Value = "PBA_SUB_ORDER_INFO";
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

