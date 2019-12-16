/**  版本信息模板在安装目录下，可自行修改。
* PBA_SUB_ORDER_RECORD_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_SUB_ORDER_RECORD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:17   N/A    初版
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
	/// 数据访问类:PBA_SUB_ORDER_RECORD_INFO
	/// </summary>
	public partial class PBA_SUB_ORDER_RECORD_INFO
	{
		public PBA_SUB_ORDER_RECORD_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_SUB_ORDER_RECORD_INFO");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_SUB_ORDER_RECORD_INFO(");
			strSql.Append("ID,SUB_ORDER_ID,BEGIN_TIME,END_TIME,CHARGE_MONEY,CHARGE_METHOD,PAY_TYPE,PAY_PLATFORM,REMARK,CREATE_TIME)");
			strSql.Append(" values (");
			strSql.Append("@ID,@SUB_ORDER_ID,@BEGIN_TIME,@END_TIME,@CHARGE_MONEY,@CHARGE_METHOD,@PAY_TYPE,@PAY_PLATFORM,@REMARK,@CREATE_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@SUB_ORDER_ID", SqlDbType.VarChar,32),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_METHOD", SqlDbType.Int,4),
					new SqlParameter("@PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("@PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SUB_ORDER_ID;
			parameters[2].Value = model.BEGIN_TIME;
			parameters[3].Value = model.END_TIME;
			parameters[4].Value = model.CHARGE_MONEY;
			parameters[5].Value = model.CHARGE_METHOD;
			parameters[6].Value = model.PAY_TYPE;
			parameters[7].Value = model.PAY_PLATFORM;
			parameters[8].Value = model.REMARK;
			parameters[9].Value = model.CREATE_TIME;

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
		public bool Update(Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_SUB_ORDER_RECORD_INFO set ");
			strSql.Append("SUB_ORDER_ID=@SUB_ORDER_ID,");
			strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
			strSql.Append("END_TIME=@END_TIME,");
			strSql.Append("CHARGE_MONEY=@CHARGE_MONEY,");
			strSql.Append("CHARGE_METHOD=@CHARGE_METHOD,");
			strSql.Append("PAY_TYPE=@PAY_TYPE,");
			strSql.Append("PAY_PLATFORM=@PAY_PLATFORM,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("CREATE_TIME=@CREATE_TIME");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SUB_ORDER_ID", SqlDbType.VarChar,32),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_METHOD", SqlDbType.Int,4),
					new SqlParameter("@PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("@PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.SUB_ORDER_ID;
			parameters[1].Value = model.BEGIN_TIME;
			parameters[2].Value = model.END_TIME;
			parameters[3].Value = model.CHARGE_MONEY;
			parameters[4].Value = model.CHARGE_METHOD;
			parameters[5].Value = model.PAY_TYPE;
			parameters[6].Value = model.PAY_PLATFORM;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from PBA_SUB_ORDER_RECORD_INFO ");
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
			strSql.Append("delete from PBA_SUB_ORDER_RECORD_INFO ");
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
		public Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SUB_ORDER_ID,BEGIN_TIME,END_TIME,CHARGE_MONEY,CHARGE_METHOD,PAY_TYPE,PAY_PLATFORM,REMARK,CREATE_TIME from PBA_SUB_ORDER_RECORD_INFO ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO model=new Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO();
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
		public Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO model=new Parking.Core.Model.PBA_SUB_ORDER_RECORD_INFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["SUB_ORDER_ID"]!=null)
				{
					model.SUB_ORDER_ID=row["SUB_ORDER_ID"].ToString();
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
				if(row["CHARGE_METHOD"]!=null && row["CHARGE_METHOD"].ToString()!="")
				{
					model.CHARGE_METHOD=int.Parse(row["CHARGE_METHOD"].ToString());
				}
				if(row["PAY_TYPE"]!=null && row["PAY_TYPE"].ToString()!="")
				{
					model.PAY_TYPE=int.Parse(row["PAY_TYPE"].ToString());
				}
				if(row["PAY_PLATFORM"]!=null && row["PAY_PLATFORM"].ToString()!="")
				{
					model.PAY_PLATFORM=int.Parse(row["PAY_PLATFORM"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
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
			strSql.Append("select ID,SUB_ORDER_ID,BEGIN_TIME,END_TIME,CHARGE_MONEY,CHARGE_METHOD,PAY_TYPE,PAY_PLATFORM,REMARK,CREATE_TIME ");
			strSql.Append(" FROM PBA_SUB_ORDER_RECORD_INFO ");
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
			strSql.Append(" ID,SUB_ORDER_ID,BEGIN_TIME,END_TIME,CHARGE_MONEY,CHARGE_METHOD,PAY_TYPE,PAY_PLATFORM,REMARK,CREATE_TIME ");
			strSql.Append(" FROM PBA_SUB_ORDER_RECORD_INFO ");
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
			strSql.Append("select count(1) FROM PBA_SUB_ORDER_RECORD_INFO ");
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
			strSql.Append(")AS Row, T.*  from PBA_SUB_ORDER_RECORD_INFO T ");
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
			parameters[0].Value = "PBA_SUB_ORDER_RECORD_INFO";
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

