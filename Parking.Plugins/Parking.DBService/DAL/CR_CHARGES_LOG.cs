/**  版本信息模板在安装目录下，可自行修改。
* CR_CHARGES_LOG.cs
*
* 功 能： N/A
* 类 名： CR_CHARGES_LOG
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
using System.Collections.Generic;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:CR_CHARGES_LOG
	/// </summary>
	public partial class CR_CHARGES_LOG
	{
		public CR_CHARGES_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_CHARGES_LOG");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_CHARGES_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_CHARGES_LOG(");
			strSql.Append("ID,TRAFFIC_PERMIT_TYPE_IDENTITY,TRAFFIC_PERMIT_TYPE,UNIQUE_IDENTIFIER,CHARGE_METHOD,CHARGE_MONEY,CHARGE_TIME,CHARGE_USERID,VEHICLE_NO,BEGIN_TIME,END_TIME,STOP_TIME,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,PARTITION_CODE,BILLING_ADDRESS,PAY_TYPE,CHARGES_EQ_ID,PAY_PLATFORM,OWNER_CODE,SPACE_CODE,REMARK,DUE_MONEY,PRE_MONEY,IN_FIELD_CODE,IN_PARTITION_CODE,OUT_FIELD_CODE,OUT_PARTITION_CODE)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012TRAFFIC_PERMIT_TYPE_IDENTITY,SQL2012TRAFFIC_PERMIT_TYPE,SQL2012UNIQUE_IDENTIFIER,SQL2012CHARGE_METHOD,SQL2012CHARGE_MONEY,SQL2012CHARGE_TIME,SQL2012CHARGE_USERID,SQL2012VEHICLE_NO,SQL2012BEGIN_TIME,SQL2012END_TIME,SQL2012STOP_TIME,SQL2012IN_CHANNEL_CODE,SQL2012OUT_CHANNEL_CODE,SQL2012PARTITION_CODE,SQL2012BILLING_ADDRESS,SQL2012PAY_TYPE,SQL2012CHARGES_EQ_ID,SQL2012PAY_PLATFORM,SQL2012OWNER_CODE,SQL2012SPACE_CODE,SQL2012REMARK,SQL2012DUE_MONEY,SQL2012PRE_MONEY,SQL2012IN_FIELD_CODE,SQL2012IN_PARTITION_CODE,SQL2012OUT_FIELD_CODE,SQL2012OUT_PARTITION_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012TRAFFIC_PERMIT_TYPE_IDENTITY", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012TRAFFIC_PERMIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012CHARGE_METHOD", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012CHARGE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CHARGE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012END_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012STOP_TIME", SqlDbType.Int,4),
					new SqlParameter("SQL2012IN_CHANNEL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_CHANNEL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012BILLING_ADDRESS", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGES_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012SPACE_CODE", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PRE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012IN_FIELD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012IN_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_FIELD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_PARTITION_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.TRAFFIC_PERMIT_TYPE_IDENTITY;
			parameters[2].Value = model.TRAFFIC_PERMIT_TYPE;
			parameters[3].Value = model.UNIQUE_IDENTIFIER;
			parameters[4].Value = model.CHARGE_METHOD;
			parameters[5].Value = model.CHARGE_MONEY;
			parameters[6].Value = model.CHARGE_TIME;
			parameters[7].Value = model.CHARGE_USERID;
			parameters[8].Value = model.VEHICLE_NO;
			parameters[9].Value = model.BEGIN_TIME;
			parameters[10].Value = model.END_TIME;
			parameters[11].Value = model.STOP_TIME;
			parameters[12].Value = model.IN_CHANNEL_CODE;
			parameters[13].Value = model.OUT_CHANNEL_CODE;
			parameters[14].Value = model.PARTITION_CODE;
			parameters[15].Value = model.BILLING_ADDRESS;
			parameters[16].Value = model.PAY_TYPE;
			parameters[17].Value = model.CHARGES_EQ_ID;
			parameters[18].Value = model.PAY_PLATFORM;
			parameters[19].Value = model.OWNER_CODE;
			parameters[20].Value = model.SPACE_CODE;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.DUE_MONEY;
			parameters[23].Value = model.PRE_MONEY;
			parameters[24].Value = model.IN_FIELD_CODE;
			parameters[25].Value = model.IN_PARTITION_CODE;
			parameters[26].Value = model.OUT_FIELD_CODE;
			parameters[27].Value = model.OUT_PARTITION_CODE;

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
		public bool Update(Parking.Core.Model.CR_CHARGES_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_CHARGES_LOG set ");
			strSql.Append("TRAFFIC_PERMIT_TYPE_IDENTITY=SQL2012TRAFFIC_PERMIT_TYPE_IDENTITY,");
			strSql.Append("TRAFFIC_PERMIT_TYPE=SQL2012TRAFFIC_PERMIT_TYPE,");
			strSql.Append("UNIQUE_IDENTIFIER=SQL2012UNIQUE_IDENTIFIER,");
			strSql.Append("CHARGE_METHOD=SQL2012CHARGE_METHOD,");
			strSql.Append("CHARGE_MONEY=SQL2012CHARGE_MONEY,");
			strSql.Append("CHARGE_TIME=SQL2012CHARGE_TIME,");
			strSql.Append("CHARGE_USERID=SQL2012CHARGE_USERID,");
			strSql.Append("VEHICLE_NO=SQL2012VEHICLE_NO,");
			strSql.Append("BEGIN_TIME=SQL2012BEGIN_TIME,");
			strSql.Append("END_TIME=SQL2012END_TIME,");
			strSql.Append("STOP_TIME=SQL2012STOP_TIME,");
			strSql.Append("IN_CHANNEL_CODE=SQL2012IN_CHANNEL_CODE,");
			strSql.Append("OUT_CHANNEL_CODE=SQL2012OUT_CHANNEL_CODE,");
			strSql.Append("PARTITION_CODE=SQL2012PARTITION_CODE,");
			strSql.Append("BILLING_ADDRESS=SQL2012BILLING_ADDRESS,");
			strSql.Append("PAY_TYPE=SQL2012PAY_TYPE,");
			strSql.Append("CHARGES_EQ_ID=SQL2012CHARGES_EQ_ID,");
			strSql.Append("PAY_PLATFORM=SQL2012PAY_PLATFORM,");
			strSql.Append("OWNER_CODE=SQL2012OWNER_CODE,");
			strSql.Append("SPACE_CODE=SQL2012SPACE_CODE,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("DUE_MONEY=SQL2012DUE_MONEY,");
			strSql.Append("PRE_MONEY=SQL2012PRE_MONEY,");
			strSql.Append("IN_FIELD_CODE=SQL2012IN_FIELD_CODE,");
			strSql.Append("IN_PARTITION_CODE=SQL2012IN_PARTITION_CODE,");
			strSql.Append("OUT_FIELD_CODE=SQL2012OUT_FIELD_CODE,");
			strSql.Append("OUT_PARTITION_CODE=SQL2012OUT_PARTITION_CODE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012TRAFFIC_PERMIT_TYPE_IDENTITY", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012TRAFFIC_PERMIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012CHARGE_METHOD", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012CHARGE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CHARGE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012END_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012STOP_TIME", SqlDbType.Int,4),
					new SqlParameter("SQL2012IN_CHANNEL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_CHANNEL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012BILLING_ADDRESS", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012CHARGES_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("SQL2012OWNER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012SPACE_CODE", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PRE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012IN_FIELD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012IN_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_FIELD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012OUT_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.TRAFFIC_PERMIT_TYPE_IDENTITY;
			parameters[1].Value = model.TRAFFIC_PERMIT_TYPE;
			parameters[2].Value = model.UNIQUE_IDENTIFIER;
			parameters[3].Value = model.CHARGE_METHOD;
			parameters[4].Value = model.CHARGE_MONEY;
			parameters[5].Value = model.CHARGE_TIME;
			parameters[6].Value = model.CHARGE_USERID;
			parameters[7].Value = model.VEHICLE_NO;
			parameters[8].Value = model.BEGIN_TIME;
			parameters[9].Value = model.END_TIME;
			parameters[10].Value = model.STOP_TIME;
			parameters[11].Value = model.IN_CHANNEL_CODE;
			parameters[12].Value = model.OUT_CHANNEL_CODE;
			parameters[13].Value = model.PARTITION_CODE;
			parameters[14].Value = model.BILLING_ADDRESS;
			parameters[15].Value = model.PAY_TYPE;
			parameters[16].Value = model.CHARGES_EQ_ID;
			parameters[17].Value = model.PAY_PLATFORM;
			parameters[18].Value = model.OWNER_CODE;
			parameters[19].Value = model.SPACE_CODE;
			parameters[20].Value = model.REMARK;
			parameters[21].Value = model.DUE_MONEY;
			parameters[22].Value = model.PRE_MONEY;
			parameters[23].Value = model.IN_FIELD_CODE;
			parameters[24].Value = model.IN_PARTITION_CODE;
			parameters[25].Value = model.OUT_FIELD_CODE;
			parameters[26].Value = model.OUT_PARTITION_CODE;
			parameters[27].Value = model.ID;

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
			strSql.Append("delete from CR_CHARGES_LOG ");
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
			strSql.Append("delete from CR_CHARGES_LOG ");
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
		public Parking.Core.Model.CR_CHARGES_LOG GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,TRAFFIC_PERMIT_TYPE_IDENTITY,TRAFFIC_PERMIT_TYPE,UNIQUE_IDENTIFIER,CHARGE_METHOD,CHARGE_MONEY,CHARGE_TIME,CHARGE_USERID,VEHICLE_NO,BEGIN_TIME,END_TIME,STOP_TIME,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,PARTITION_CODE,BILLING_ADDRESS,PAY_TYPE,CHARGES_EQ_ID,PAY_PLATFORM,OWNER_CODE,SPACE_CODE,REMARK,DUE_MONEY,PRE_MONEY,IN_FIELD_CODE,IN_PARTITION_CODE,OUT_FIELD_CODE,OUT_PARTITION_CODE from CR_CHARGES_LOG ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_CHARGES_LOG model=new Parking.Core.Model.CR_CHARGES_LOG();
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
		public Parking.Core.Model.CR_CHARGES_LOG DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_CHARGES_LOG model=new Parking.Core.Model.CR_CHARGES_LOG();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["TRAFFIC_PERMIT_TYPE_IDENTITY"]!=null)
				{
					model.TRAFFIC_PERMIT_TYPE_IDENTITY=row["TRAFFIC_PERMIT_TYPE_IDENTITY"].ToString();
				}
				if(row["TRAFFIC_PERMIT_TYPE"]!=null && row["TRAFFIC_PERMIT_TYPE"].ToString()!="")
				{
					model.TRAFFIC_PERMIT_TYPE=int.Parse(row["TRAFFIC_PERMIT_TYPE"].ToString());
				}
				if(row["UNIQUE_IDENTIFIER"]!=null)
				{
					model.UNIQUE_IDENTIFIER=row["UNIQUE_IDENTIFIER"].ToString();
				}
				if(row["CHARGE_METHOD"]!=null && row["CHARGE_METHOD"].ToString()!="")
				{
					model.CHARGE_METHOD=int.Parse(row["CHARGE_METHOD"].ToString());
				}
				if(row["CHARGE_MONEY"]!=null && row["CHARGE_MONEY"].ToString()!="")
				{
					model.CHARGE_MONEY=decimal.Parse(row["CHARGE_MONEY"].ToString());
				}
				if(row["CHARGE_TIME"]!=null && row["CHARGE_TIME"].ToString()!="")
				{
					model.CHARGE_TIME=DateTime.Parse(row["CHARGE_TIME"].ToString());
				}
				if(row["CHARGE_USERID"]!=null)
				{
					model.CHARGE_USERID=row["CHARGE_USERID"].ToString();
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["BEGIN_TIME"]!=null && row["BEGIN_TIME"].ToString()!="")
				{
					model.BEGIN_TIME=DateTime.Parse(row["BEGIN_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
				}
				if(row["STOP_TIME"]!=null && row["STOP_TIME"].ToString()!="")
				{
					model.STOP_TIME=int.Parse(row["STOP_TIME"].ToString());
				}
				if(row["IN_CHANNEL_CODE"]!=null)
				{
					model.IN_CHANNEL_CODE=row["IN_CHANNEL_CODE"].ToString();
				}
				if(row["OUT_CHANNEL_CODE"]!=null)
				{
					model.OUT_CHANNEL_CODE=row["OUT_CHANNEL_CODE"].ToString();
				}
				if(row["PARTITION_CODE"]!=null)
				{
					model.PARTITION_CODE=row["PARTITION_CODE"].ToString();
				}
				if(row["BILLING_ADDRESS"]!=null)
				{
					model.BILLING_ADDRESS=row["BILLING_ADDRESS"].ToString();
				}
				if(row["PAY_TYPE"]!=null && row["PAY_TYPE"].ToString()!="")
				{
					model.PAY_TYPE=int.Parse(row["PAY_TYPE"].ToString());
				}
				if(row["CHARGES_EQ_ID"]!=null)
				{
					model.CHARGES_EQ_ID=row["CHARGES_EQ_ID"].ToString();
				}
				if(row["PAY_PLATFORM"]!=null && row["PAY_PLATFORM"].ToString()!="")
				{
					model.PAY_PLATFORM=int.Parse(row["PAY_PLATFORM"].ToString());
				}
				if(row["OWNER_CODE"]!=null)
				{
					model.OWNER_CODE=row["OWNER_CODE"].ToString();
				}
				if(row["SPACE_CODE"]!=null)
				{
					model.SPACE_CODE=row["SPACE_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["DUE_MONEY"]!=null && row["DUE_MONEY"].ToString()!="")
				{
					model.DUE_MONEY=decimal.Parse(row["DUE_MONEY"].ToString());
				}
				if(row["PRE_MONEY"]!=null && row["PRE_MONEY"].ToString()!="")
				{
					model.PRE_MONEY=decimal.Parse(row["PRE_MONEY"].ToString());
				}
				if(row["IN_FIELD_CODE"]!=null)
				{
					model.IN_FIELD_CODE=row["IN_FIELD_CODE"].ToString();
				}
				if(row["IN_PARTITION_CODE"]!=null)
				{
					model.IN_PARTITION_CODE=row["IN_PARTITION_CODE"].ToString();
				}
				if(row["OUT_FIELD_CODE"]!=null)
				{
					model.OUT_FIELD_CODE=row["OUT_FIELD_CODE"].ToString();
				}
				if(row["OUT_PARTITION_CODE"]!=null)
				{
					model.OUT_PARTITION_CODE=row["OUT_PARTITION_CODE"].ToString();
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
			strSql.Append("select ID,TRAFFIC_PERMIT_TYPE_IDENTITY,TRAFFIC_PERMIT_TYPE,UNIQUE_IDENTIFIER,CHARGE_METHOD,CHARGE_MONEY,CHARGE_TIME,CHARGE_USERID,VEHICLE_NO,BEGIN_TIME,END_TIME,STOP_TIME,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,PARTITION_CODE,BILLING_ADDRESS,PAY_TYPE,CHARGES_EQ_ID,PAY_PLATFORM,OWNER_CODE,SPACE_CODE,REMARK,DUE_MONEY,PRE_MONEY,IN_FIELD_CODE,IN_PARTITION_CODE,OUT_FIELD_CODE,OUT_PARTITION_CODE ");
			strSql.Append(" FROM CR_CHARGES_LOG ");
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
			strSql.Append(" ID,TRAFFIC_PERMIT_TYPE_IDENTITY,TRAFFIC_PERMIT_TYPE,UNIQUE_IDENTIFIER,CHARGE_METHOD,CHARGE_MONEY,CHARGE_TIME,CHARGE_USERID,VEHICLE_NO,BEGIN_TIME,END_TIME,STOP_TIME,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,PARTITION_CODE,BILLING_ADDRESS,PAY_TYPE,CHARGES_EQ_ID,PAY_PLATFORM,OWNER_CODE,SPACE_CODE,REMARK,DUE_MONEY,PRE_MONEY,IN_FIELD_CODE,IN_PARTITION_CODE,OUT_FIELD_CODE,OUT_PARTITION_CODE ");
			strSql.Append(" FROM CR_CHARGES_LOG ");
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
			strSql.Append("select count(1) FROM CR_CHARGES_LOG ");
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
			strSql.Append(")AS Row, T.*  from CR_CHARGES_LOG T ");
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
			parameters[0].Value = "CR_CHARGES_LOG";
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
        /// <summary>
        /// 当ì?à天?¨?总á¨1额?
        /// </summary>
        /// <param name="VEHICLE_NO"></param>
        /// <returns></returns>
        public decimal GetTotalMoney(string VEHICLE_NO, DateTime InTime, DateTime OutTime, bool isDay = true)
        {
            string strSql = string.Empty;
            if (isDay)
            {
                strSql = @"SELECT  SUM(A.CHARGE_MONEY)
                                FROM    ( SELECT    CHARGE_MONEY ,
                                                    VEHICLE_NO
                                          FROM      CR_CHARGES_LOG
                                          WHERE     CONVERT(VARCHAR(100), CHARGE_TIME, 23) = '" + OutTime.ToString("yyyy-MM-dd") + @"'
                                                    AND VEHICLE_NO = '{0}'
                                                    AND BEGIN_TIME <> '{1}'
                                        ) A ";
                strSql = string.Format(strSql.ToString(), VEHICLE_NO, InTime);
            }
            else
            {
                strSql = @"SELECT  SUM(A.CHARGE_MONEY)
                                FROM    ( SELECT    CHARGE_MONEY ,
                                                    VEHICLE_NO
                                          FROM      CR_CHARGES_LOG
                                          WHERE     CHARGE_TIME BETWEEN '{0}' AND '{1}'
                                                    AND VEHICLE_NO = '{2}'
                                                    AND BEGIN_TIME <> '{3}'
                                        ) A ";
                strSql = string.Format(strSql.ToString(), OutTime.AddHours(-24), OutTime, VEHICLE_NO, InTime);
            }
            object obj = DbHelperSQL.GetSingle(strSql);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(obj);
            }
        }
        /// <summary>
        /// 根¨′据Y入¨?场?时o?à间?获?取¨?
        /// </summary>
        /// <param name="VEHICLE_NO"></param>
        /// <param name="InTime"></param>
        /// <param name="OutTime"></param>
        /// <param name="isDay"></param>
        /// <returns></returns>
        public List<Parking.Core.Model.CR_CHARGES_LOG> GetListByInTime(string VEHICLE_NO, DateTime InTime)
        {
            List<Parking.Core.Model.CR_CHARGES_LOG> ListModel = new List<Core.Model.CR_CHARGES_LOG>();

            string strSql = @"SELECT * FROM dbo.CR_CHARGES_LOG WHERE BEGIN_TIME = '{0}' AND VEHICLE_NO ='{1}' ";
            strSql = string.Format(strSql.ToString(), InTime, VEHICLE_NO);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListModel.Add(DataRowToModel(dr));
                }
            }
            return ListModel;
        }
        #endregion  ExtensionMethod
    }
}

