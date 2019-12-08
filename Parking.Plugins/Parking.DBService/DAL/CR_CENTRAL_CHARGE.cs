/**  版本信息模板在安装目录下，可自行修改。
* CR_CENTRAL_CHARGE.cs
*
* 功 能： N/A
* 类 名： CR_CENTRAL_CHARGE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:01   N/A    初版
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
	/// 数据访问类:CR_CENTRAL_CHARGE
	/// </summary>
	public partial class CR_CENTRAL_CHARGE
	{
		public CR_CENTRAL_CHARGE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_CENTRAL_CHARGE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_CENTRAL_CHARGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_CENTRAL_CHARGE(");
			strSql.Append("ID,INOUT_RECODE_ID,CHARGE_TIME,OPERATOR_ID,BEGIN_TIME,END_TIME,PAY_METHOD,BILLING_ADDRESS,ADVANCE_MONEY,PAY_TYPE)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012INOUT_RECODE_ID,SQL2012CHARGE_TIME,SQL2012OPERATOR_ID,SQL2012BEGIN_TIME,SQL2012END_TIME,SQL2012PAY_METHOD,SQL2012BILLING_ADDRESS,SQL2012ADVANCE_MONEY,SQL2012PAY_TYPE)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CHARGE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012END_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012PAY_METHOD", SqlDbType.Int,4),
					new SqlParameter("SQL2012BILLING_ADDRESS", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012ADVANCE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.INOUT_RECODE_ID;
			parameters[2].Value = model.CHARGE_TIME;
			parameters[3].Value = model.OPERATOR_ID;
			parameters[4].Value = model.BEGIN_TIME;
			parameters[5].Value = model.END_TIME;
			parameters[6].Value = model.PAY_METHOD;
			parameters[7].Value = model.BILLING_ADDRESS;
			parameters[8].Value = model.ADVANCE_MONEY;
			parameters[9].Value = model.PAY_TYPE;

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
		public bool Update(Parking.Core.Model.CR_CENTRAL_CHARGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_CENTRAL_CHARGE set ");
			strSql.Append("INOUT_RECODE_ID=SQL2012INOUT_RECODE_ID,");
			strSql.Append("CHARGE_TIME=SQL2012CHARGE_TIME,");
			strSql.Append("OPERATOR_ID=SQL2012OPERATOR_ID,");
			strSql.Append("BEGIN_TIME=SQL2012BEGIN_TIME,");
			strSql.Append("END_TIME=SQL2012END_TIME,");
			strSql.Append("PAY_METHOD=SQL2012PAY_METHOD,");
			strSql.Append("BILLING_ADDRESS=SQL2012BILLING_ADDRESS,");
			strSql.Append("ADVANCE_MONEY=SQL2012ADVANCE_MONEY,");
			strSql.Append("PAY_TYPE=SQL2012PAY_TYPE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012CHARGE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012END_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012PAY_METHOD", SqlDbType.Int,4),
					new SqlParameter("SQL2012BILLING_ADDRESS", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012ADVANCE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.INOUT_RECODE_ID;
			parameters[1].Value = model.CHARGE_TIME;
			parameters[2].Value = model.OPERATOR_ID;
			parameters[3].Value = model.BEGIN_TIME;
			parameters[4].Value = model.END_TIME;
			parameters[5].Value = model.PAY_METHOD;
			parameters[6].Value = model.BILLING_ADDRESS;
			parameters[7].Value = model.ADVANCE_MONEY;
			parameters[8].Value = model.PAY_TYPE;
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
			strSql.Append("delete from CR_CENTRAL_CHARGE ");
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
			strSql.Append("delete from CR_CENTRAL_CHARGE ");
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
		public Parking.Core.Model.CR_CENTRAL_CHARGE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,INOUT_RECODE_ID,CHARGE_TIME,OPERATOR_ID,BEGIN_TIME,END_TIME,PAY_METHOD,BILLING_ADDRESS,ADVANCE_MONEY,PAY_TYPE from CR_CENTRAL_CHARGE ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_CENTRAL_CHARGE model=new Parking.Core.Model.CR_CENTRAL_CHARGE();
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
		public Parking.Core.Model.CR_CENTRAL_CHARGE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_CENTRAL_CHARGE model=new Parking.Core.Model.CR_CENTRAL_CHARGE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["INOUT_RECODE_ID"]!=null)
				{
					model.INOUT_RECODE_ID=row["INOUT_RECODE_ID"].ToString();
				}
				if(row["CHARGE_TIME"]!=null && row["CHARGE_TIME"].ToString()!="")
				{
					model.CHARGE_TIME=DateTime.Parse(row["CHARGE_TIME"].ToString());
				}
				if(row["OPERATOR_ID"]!=null)
				{
					model.OPERATOR_ID=row["OPERATOR_ID"].ToString();
				}
				if(row["BEGIN_TIME"]!=null && row["BEGIN_TIME"].ToString()!="")
				{
					model.BEGIN_TIME=DateTime.Parse(row["BEGIN_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
				}
				if(row["PAY_METHOD"]!=null && row["PAY_METHOD"].ToString()!="")
				{
					model.PAY_METHOD=int.Parse(row["PAY_METHOD"].ToString());
				}
				if(row["BILLING_ADDRESS"]!=null)
				{
					model.BILLING_ADDRESS=row["BILLING_ADDRESS"].ToString();
				}
				if(row["ADVANCE_MONEY"]!=null && row["ADVANCE_MONEY"].ToString()!="")
				{
					model.ADVANCE_MONEY=decimal.Parse(row["ADVANCE_MONEY"].ToString());
				}
				if(row["PAY_TYPE"]!=null && row["PAY_TYPE"].ToString()!="")
				{
					model.PAY_TYPE=int.Parse(row["PAY_TYPE"].ToString());
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
			strSql.Append("select ID,INOUT_RECODE_ID,CHARGE_TIME,OPERATOR_ID,BEGIN_TIME,END_TIME,PAY_METHOD,BILLING_ADDRESS,ADVANCE_MONEY,PAY_TYPE ");
			strSql.Append(" FROM CR_CENTRAL_CHARGE ");
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
			strSql.Append(" ID,INOUT_RECODE_ID,CHARGE_TIME,OPERATOR_ID,BEGIN_TIME,END_TIME,PAY_METHOD,BILLING_ADDRESS,ADVANCE_MONEY,PAY_TYPE ");
			strSql.Append(" FROM CR_CENTRAL_CHARGE ");
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
			strSql.Append("select count(1) FROM CR_CENTRAL_CHARGE ");
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
			strSql.Append(")AS Row, T.*  from CR_CENTRAL_CHARGE T ");
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
			parameters[0].Value = "CR_CENTRAL_CHARGE";
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

