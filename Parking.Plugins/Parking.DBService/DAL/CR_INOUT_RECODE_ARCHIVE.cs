/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE_ARCHIVE.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE_ARCHIVE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	/// 数据访问类:CR_INOUT_RECODE_ARCHIVE
	/// </summary>
	public partial class CR_INOUT_RECODE_ARCHIVE
	{
		public CR_INOUT_RECODE_ARCHIVE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_INOUT_RECODE_ARCHIVE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_INOUT_RECODE_ARCHIVE(");
			strSql.Append("ID,UNIQUE_IDENTIFIER,VEHICLE_NO,CAR_COLOR,CAR_EC_NO,CREDENTIALS_TYPE,IN_FIELD_CODE,IN_CHANNEL_CODE,IN_TIME,IN_OPERATOR_ID,IN_PARTITION_CODE,IN_EQ_ID,IN_DEV_ID,IN_PARK_TYPE,OUT_DEV_ID,OUT_PARK_TYPE,OUT_TIME,OUT_FIELD_CODE,OUT_CHANNEL_CODE,OUT_OPERATOR_ID,OUT_PARTITION_CODE,TOTAL_TIME,CURR_PARTITION_CODE,DUE_MONEY,CHARGE_MONEY,PRE_MONEY,OVERTIMESFJE,ADVANCE_MONEY,PAY_METHOD,OUT_EQ_ID,PAY_PLATFORM,IN_IMG_TRUST,OUT_IMG_TRUST,RECODE_STATUS,IN_LED_INFO,OUT_LED_INFO,HAS_CORRECT,LOCK_FLAG,LOCK_TIME)");
			strSql.Append(" values (");
			strSql.Append("@ID,@UNIQUE_IDENTIFIER,@VEHICLE_NO,@CAR_COLOR,@CAR_EC_NO,@CREDENTIALS_TYPE,@IN_FIELD_CODE,@IN_CHANNEL_CODE,@IN_TIME,@IN_OPERATOR_ID,@IN_PARTITION_CODE,@IN_EQ_ID,@IN_DEV_ID,@IN_PARK_TYPE,@OUT_DEV_ID,@OUT_PARK_TYPE,@OUT_TIME,@OUT_FIELD_CODE,@OUT_CHANNEL_CODE,@OUT_OPERATOR_ID,@OUT_PARTITION_CODE,@TOTAL_TIME,@CURR_PARTITION_CODE,@DUE_MONEY,@CHARGE_MONEY,@PRE_MONEY,@OVERTIMESFJE,@ADVANCE_MONEY,@PAY_METHOD,@OUT_EQ_ID,@PAY_PLATFORM,@IN_IMG_TRUST,@OUT_IMG_TRUST,@RECODE_STATUS,@IN_LED_INFO,@OUT_LED_INFO,@HAS_CORRECT,@LOCK_FLAG,@LOCK_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@CAR_COLOR", SqlDbType.VarChar,10),
					new SqlParameter("@CAR_EC_NO", SqlDbType.VarChar,50),
					new SqlParameter("@CREDENTIALS_TYPE", SqlDbType.Int,4),
					new SqlParameter("@IN_FIELD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_TIME", SqlDbType.DateTime),
					new SqlParameter("@IN_OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@IN_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_PARK_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@OUT_DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_PARK_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@OUT_TIME", SqlDbType.DateTime),
					new SqlParameter("@OUT_FIELD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@TOTAL_TIME", SqlDbType.Int,4),
					new SqlParameter("@CURR_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PRE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@OVERTIMESFJE", SqlDbType.Decimal,9),
					new SqlParameter("@ADVANCE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PAY_METHOD", SqlDbType.Int,4),
					new SqlParameter("@OUT_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("@PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@IN_IMG_TRUST", SqlDbType.Decimal,5),
					new SqlParameter("@OUT_IMG_TRUST", SqlDbType.Decimal,5),
					new SqlParameter("@RECODE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@IN_LED_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@OUT_LED_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@HAS_CORRECT", SqlDbType.Int,4),
					new SqlParameter("@LOCK_FLAG", SqlDbType.Int,4),
					new SqlParameter("@LOCK_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.UNIQUE_IDENTIFIER;
			parameters[2].Value = model.VEHICLE_NO;
			parameters[3].Value = model.CAR_COLOR;
			parameters[4].Value = model.CAR_EC_NO;
			parameters[5].Value = model.CREDENTIALS_TYPE;
			parameters[6].Value = model.IN_FIELD_CODE;
			parameters[7].Value = model.IN_CHANNEL_CODE;
			parameters[8].Value = model.IN_TIME;
			parameters[9].Value = model.IN_OPERATOR_ID;
			parameters[10].Value = model.IN_PARTITION_CODE;
			parameters[11].Value = model.IN_EQ_ID;
			parameters[12].Value = model.IN_DEV_ID;
			parameters[13].Value = model.IN_PARK_TYPE;
			parameters[14].Value = model.OUT_DEV_ID;
			parameters[15].Value = model.OUT_PARK_TYPE;
			parameters[16].Value = model.OUT_TIME;
			parameters[17].Value = model.OUT_FIELD_CODE;
			parameters[18].Value = model.OUT_CHANNEL_CODE;
			parameters[19].Value = model.OUT_OPERATOR_ID;
			parameters[20].Value = model.OUT_PARTITION_CODE;
			parameters[21].Value = model.TOTAL_TIME;
			parameters[22].Value = model.CURR_PARTITION_CODE;
			parameters[23].Value = model.DUE_MONEY;
			parameters[24].Value = model.CHARGE_MONEY;
			parameters[25].Value = model.PRE_MONEY;
			parameters[26].Value = model.OVERTIMESFJE;
			parameters[27].Value = model.ADVANCE_MONEY;
			parameters[28].Value = model.PAY_METHOD;
			parameters[29].Value = model.OUT_EQ_ID;
			parameters[30].Value = model.PAY_PLATFORM;
			parameters[31].Value = model.IN_IMG_TRUST;
			parameters[32].Value = model.OUT_IMG_TRUST;
			parameters[33].Value = model.RECODE_STATUS;
			parameters[34].Value = model.IN_LED_INFO;
			parameters[35].Value = model.OUT_LED_INFO;
			parameters[36].Value = model.HAS_CORRECT;
			parameters[37].Value = model.LOCK_FLAG;
			parameters[38].Value = model.LOCK_TIME;

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
		public bool Update(Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_INOUT_RECODE_ARCHIVE set ");
			strSql.Append("UNIQUE_IDENTIFIER=@UNIQUE_IDENTIFIER,");
			strSql.Append("VEHICLE_NO=@VEHICLE_NO,");
			strSql.Append("CAR_COLOR=@CAR_COLOR,");
			strSql.Append("CAR_EC_NO=@CAR_EC_NO,");
			strSql.Append("CREDENTIALS_TYPE=@CREDENTIALS_TYPE,");
			strSql.Append("IN_FIELD_CODE=@IN_FIELD_CODE,");
			strSql.Append("IN_CHANNEL_CODE=@IN_CHANNEL_CODE,");
			strSql.Append("IN_TIME=@IN_TIME,");
			strSql.Append("IN_OPERATOR_ID=@IN_OPERATOR_ID,");
			strSql.Append("IN_PARTITION_CODE=@IN_PARTITION_CODE,");
			strSql.Append("IN_EQ_ID=@IN_EQ_ID,");
			strSql.Append("IN_DEV_ID=@IN_DEV_ID,");
			strSql.Append("IN_PARK_TYPE=@IN_PARK_TYPE,");
			strSql.Append("OUT_DEV_ID=@OUT_DEV_ID,");
			strSql.Append("OUT_PARK_TYPE=@OUT_PARK_TYPE,");
			strSql.Append("OUT_TIME=@OUT_TIME,");
			strSql.Append("OUT_FIELD_CODE=@OUT_FIELD_CODE,");
			strSql.Append("OUT_CHANNEL_CODE=@OUT_CHANNEL_CODE,");
			strSql.Append("OUT_OPERATOR_ID=@OUT_OPERATOR_ID,");
			strSql.Append("OUT_PARTITION_CODE=@OUT_PARTITION_CODE,");
			strSql.Append("TOTAL_TIME=@TOTAL_TIME,");
			strSql.Append("CURR_PARTITION_CODE=@CURR_PARTITION_CODE,");
			strSql.Append("DUE_MONEY=@DUE_MONEY,");
			strSql.Append("CHARGE_MONEY=@CHARGE_MONEY,");
			strSql.Append("PRE_MONEY=@PRE_MONEY,");
			strSql.Append("OVERTIMESFJE=@OVERTIMESFJE,");
			strSql.Append("ADVANCE_MONEY=@ADVANCE_MONEY,");
			strSql.Append("PAY_METHOD=@PAY_METHOD,");
			strSql.Append("OUT_EQ_ID=@OUT_EQ_ID,");
			strSql.Append("PAY_PLATFORM=@PAY_PLATFORM,");
			strSql.Append("IN_IMG_TRUST=@IN_IMG_TRUST,");
			strSql.Append("OUT_IMG_TRUST=@OUT_IMG_TRUST,");
			strSql.Append("RECODE_STATUS=@RECODE_STATUS,");
			strSql.Append("IN_LED_INFO=@IN_LED_INFO,");
			strSql.Append("OUT_LED_INFO=@OUT_LED_INFO,");
			strSql.Append("HAS_CORRECT=@HAS_CORRECT,");
			strSql.Append("LOCK_FLAG=@LOCK_FLAG,");
			strSql.Append("LOCK_TIME=@LOCK_TIME");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@CAR_COLOR", SqlDbType.VarChar,10),
					new SqlParameter("@CAR_EC_NO", SqlDbType.VarChar,50),
					new SqlParameter("@CREDENTIALS_TYPE", SqlDbType.Int,4),
					new SqlParameter("@IN_FIELD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_TIME", SqlDbType.DateTime),
					new SqlParameter("@IN_OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@IN_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("@IN_PARK_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@OUT_DEV_ID", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_PARK_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@OUT_TIME", SqlDbType.DateTime),
					new SqlParameter("@OUT_FIELD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_OPERATOR_ID", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@TOTAL_TIME", SqlDbType.Int,4),
					new SqlParameter("@CURR_PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PRE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@OVERTIMESFJE", SqlDbType.Decimal,9),
					new SqlParameter("@ADVANCE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PAY_METHOD", SqlDbType.Int,4),
					new SqlParameter("@OUT_EQ_ID", SqlDbType.VarChar,32),
					new SqlParameter("@PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("@IN_IMG_TRUST", SqlDbType.Decimal,5),
					new SqlParameter("@OUT_IMG_TRUST", SqlDbType.Decimal,5),
					new SqlParameter("@RECODE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@IN_LED_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@OUT_LED_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@HAS_CORRECT", SqlDbType.Int,4),
					new SqlParameter("@LOCK_FLAG", SqlDbType.Int,4),
					new SqlParameter("@LOCK_TIME", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.UNIQUE_IDENTIFIER;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.CAR_COLOR;
			parameters[3].Value = model.CAR_EC_NO;
			parameters[4].Value = model.CREDENTIALS_TYPE;
			parameters[5].Value = model.IN_FIELD_CODE;
			parameters[6].Value = model.IN_CHANNEL_CODE;
			parameters[7].Value = model.IN_TIME;
			parameters[8].Value = model.IN_OPERATOR_ID;
			parameters[9].Value = model.IN_PARTITION_CODE;
			parameters[10].Value = model.IN_EQ_ID;
			parameters[11].Value = model.IN_DEV_ID;
			parameters[12].Value = model.IN_PARK_TYPE;
			parameters[13].Value = model.OUT_DEV_ID;
			parameters[14].Value = model.OUT_PARK_TYPE;
			parameters[15].Value = model.OUT_TIME;
			parameters[16].Value = model.OUT_FIELD_CODE;
			parameters[17].Value = model.OUT_CHANNEL_CODE;
			parameters[18].Value = model.OUT_OPERATOR_ID;
			parameters[19].Value = model.OUT_PARTITION_CODE;
			parameters[20].Value = model.TOTAL_TIME;
			parameters[21].Value = model.CURR_PARTITION_CODE;
			parameters[22].Value = model.DUE_MONEY;
			parameters[23].Value = model.CHARGE_MONEY;
			parameters[24].Value = model.PRE_MONEY;
			parameters[25].Value = model.OVERTIMESFJE;
			parameters[26].Value = model.ADVANCE_MONEY;
			parameters[27].Value = model.PAY_METHOD;
			parameters[28].Value = model.OUT_EQ_ID;
			parameters[29].Value = model.PAY_PLATFORM;
			parameters[30].Value = model.IN_IMG_TRUST;
			parameters[31].Value = model.OUT_IMG_TRUST;
			parameters[32].Value = model.RECODE_STATUS;
			parameters[33].Value = model.IN_LED_INFO;
			parameters[34].Value = model.OUT_LED_INFO;
			parameters[35].Value = model.HAS_CORRECT;
			parameters[36].Value = model.LOCK_FLAG;
			parameters[37].Value = model.LOCK_TIME;
			parameters[38].Value = model.ID;

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
			strSql.Append("delete from CR_INOUT_RECODE_ARCHIVE ");
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
			strSql.Append("delete from CR_INOUT_RECODE_ARCHIVE ");
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
		public Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UNIQUE_IDENTIFIER,VEHICLE_NO,CAR_COLOR,CAR_EC_NO,CREDENTIALS_TYPE,IN_FIELD_CODE,IN_CHANNEL_CODE,IN_TIME,IN_OPERATOR_ID,IN_PARTITION_CODE,IN_EQ_ID,IN_DEV_ID,IN_PARK_TYPE,OUT_DEV_ID,OUT_PARK_TYPE,OUT_TIME,OUT_FIELD_CODE,OUT_CHANNEL_CODE,OUT_OPERATOR_ID,OUT_PARTITION_CODE,TOTAL_TIME,CURR_PARTITION_CODE,DUE_MONEY,CHARGE_MONEY,PRE_MONEY,OVERTIMESFJE,ADVANCE_MONEY,PAY_METHOD,OUT_EQ_ID,PAY_PLATFORM,IN_IMG_TRUST,OUT_IMG_TRUST,RECODE_STATUS,IN_LED_INFO,OUT_LED_INFO,HAS_CORRECT,LOCK_FLAG,LOCK_TIME from CR_INOUT_RECODE_ARCHIVE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model=new Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE();
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
		public Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model=new Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["UNIQUE_IDENTIFIER"]!=null)
				{
					model.UNIQUE_IDENTIFIER=row["UNIQUE_IDENTIFIER"].ToString();
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["CAR_COLOR"]!=null)
				{
					model.CAR_COLOR=row["CAR_COLOR"].ToString();
				}
				if(row["CAR_EC_NO"]!=null)
				{
					model.CAR_EC_NO=row["CAR_EC_NO"].ToString();
				}
				if(row["CREDENTIALS_TYPE"]!=null && row["CREDENTIALS_TYPE"].ToString()!="")
				{
					model.CREDENTIALS_TYPE=int.Parse(row["CREDENTIALS_TYPE"].ToString());
				}
				if(row["IN_FIELD_CODE"]!=null)
				{
					model.IN_FIELD_CODE=row["IN_FIELD_CODE"].ToString();
				}
				if(row["IN_CHANNEL_CODE"]!=null)
				{
					model.IN_CHANNEL_CODE=row["IN_CHANNEL_CODE"].ToString();
				}
				if(row["IN_TIME"]!=null && row["IN_TIME"].ToString()!="")
				{
					model.IN_TIME=DateTime.Parse(row["IN_TIME"].ToString());
				}
				if(row["IN_OPERATOR_ID"]!=null)
				{
					model.IN_OPERATOR_ID=row["IN_OPERATOR_ID"].ToString();
				}
				if(row["IN_PARTITION_CODE"]!=null)
				{
					model.IN_PARTITION_CODE=row["IN_PARTITION_CODE"].ToString();
				}
				if(row["IN_EQ_ID"]!=null)
				{
					model.IN_EQ_ID=row["IN_EQ_ID"].ToString();
				}
				if(row["IN_DEV_ID"]!=null)
				{
					model.IN_DEV_ID=row["IN_DEV_ID"].ToString();
				}
				if(row["IN_PARK_TYPE"]!=null)
				{
					model.IN_PARK_TYPE=row["IN_PARK_TYPE"].ToString();
				}
				if(row["OUT_DEV_ID"]!=null)
				{
					model.OUT_DEV_ID=row["OUT_DEV_ID"].ToString();
				}
				if(row["OUT_PARK_TYPE"]!=null)
				{
					model.OUT_PARK_TYPE=row["OUT_PARK_TYPE"].ToString();
				}
				if(row["OUT_TIME"]!=null && row["OUT_TIME"].ToString()!="")
				{
					model.OUT_TIME=DateTime.Parse(row["OUT_TIME"].ToString());
				}
				if(row["OUT_FIELD_CODE"]!=null)
				{
					model.OUT_FIELD_CODE=row["OUT_FIELD_CODE"].ToString();
				}
				if(row["OUT_CHANNEL_CODE"]!=null)
				{
					model.OUT_CHANNEL_CODE=row["OUT_CHANNEL_CODE"].ToString();
				}
				if(row["OUT_OPERATOR_ID"]!=null)
				{
					model.OUT_OPERATOR_ID=row["OUT_OPERATOR_ID"].ToString();
				}
				if(row["OUT_PARTITION_CODE"]!=null)
				{
					model.OUT_PARTITION_CODE=row["OUT_PARTITION_CODE"].ToString();
				}
				if(row["TOTAL_TIME"]!=null && row["TOTAL_TIME"].ToString()!="")
				{
					model.TOTAL_TIME=int.Parse(row["TOTAL_TIME"].ToString());
				}
				if(row["CURR_PARTITION_CODE"]!=null)
				{
					model.CURR_PARTITION_CODE=row["CURR_PARTITION_CODE"].ToString();
				}
				if(row["DUE_MONEY"]!=null && row["DUE_MONEY"].ToString()!="")
				{
					model.DUE_MONEY=decimal.Parse(row["DUE_MONEY"].ToString());
				}
				if(row["CHARGE_MONEY"]!=null && row["CHARGE_MONEY"].ToString()!="")
				{
					model.CHARGE_MONEY=decimal.Parse(row["CHARGE_MONEY"].ToString());
				}
				if(row["PRE_MONEY"]!=null && row["PRE_MONEY"].ToString()!="")
				{
					model.PRE_MONEY=decimal.Parse(row["PRE_MONEY"].ToString());
				}
				if(row["OVERTIMESFJE"]!=null && row["OVERTIMESFJE"].ToString()!="")
				{
					model.OVERTIMESFJE=decimal.Parse(row["OVERTIMESFJE"].ToString());
				}
				if(row["ADVANCE_MONEY"]!=null && row["ADVANCE_MONEY"].ToString()!="")
				{
					model.ADVANCE_MONEY=decimal.Parse(row["ADVANCE_MONEY"].ToString());
				}
				if(row["PAY_METHOD"]!=null && row["PAY_METHOD"].ToString()!="")
				{
					model.PAY_METHOD=int.Parse(row["PAY_METHOD"].ToString());
				}
				if(row["OUT_EQ_ID"]!=null)
				{
					model.OUT_EQ_ID=row["OUT_EQ_ID"].ToString();
				}
				if(row["PAY_PLATFORM"]!=null && row["PAY_PLATFORM"].ToString()!="")
				{
					model.PAY_PLATFORM=int.Parse(row["PAY_PLATFORM"].ToString());
				}
				if(row["IN_IMG_TRUST"]!=null && row["IN_IMG_TRUST"].ToString()!="")
				{
					model.IN_IMG_TRUST=decimal.Parse(row["IN_IMG_TRUST"].ToString());
				}
				if(row["OUT_IMG_TRUST"]!=null && row["OUT_IMG_TRUST"].ToString()!="")
				{
					model.OUT_IMG_TRUST=decimal.Parse(row["OUT_IMG_TRUST"].ToString());
				}
				if(row["RECODE_STATUS"]!=null && row["RECODE_STATUS"].ToString()!="")
				{
					model.RECODE_STATUS=int.Parse(row["RECODE_STATUS"].ToString());
				}
				if(row["IN_LED_INFO"]!=null)
				{
					model.IN_LED_INFO=row["IN_LED_INFO"].ToString();
				}
				if(row["OUT_LED_INFO"]!=null)
				{
					model.OUT_LED_INFO=row["OUT_LED_INFO"].ToString();
				}
				if(row["HAS_CORRECT"]!=null && row["HAS_CORRECT"].ToString()!="")
				{
					model.HAS_CORRECT=int.Parse(row["HAS_CORRECT"].ToString());
				}
				if(row["LOCK_FLAG"]!=null && row["LOCK_FLAG"].ToString()!="")
				{
					model.LOCK_FLAG=int.Parse(row["LOCK_FLAG"].ToString());
				}
				if(row["LOCK_TIME"]!=null && row["LOCK_TIME"].ToString()!="")
				{
					model.LOCK_TIME=DateTime.Parse(row["LOCK_TIME"].ToString());
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
			strSql.Append("select ID,UNIQUE_IDENTIFIER,VEHICLE_NO,CAR_COLOR,CAR_EC_NO,CREDENTIALS_TYPE,IN_FIELD_CODE,IN_CHANNEL_CODE,IN_TIME,IN_OPERATOR_ID,IN_PARTITION_CODE,IN_EQ_ID,IN_DEV_ID,IN_PARK_TYPE,OUT_DEV_ID,OUT_PARK_TYPE,OUT_TIME,OUT_FIELD_CODE,OUT_CHANNEL_CODE,OUT_OPERATOR_ID,OUT_PARTITION_CODE,TOTAL_TIME,CURR_PARTITION_CODE,DUE_MONEY,CHARGE_MONEY,PRE_MONEY,OVERTIMESFJE,ADVANCE_MONEY,PAY_METHOD,OUT_EQ_ID,PAY_PLATFORM,IN_IMG_TRUST,OUT_IMG_TRUST,RECODE_STATUS,IN_LED_INFO,OUT_LED_INFO,HAS_CORRECT,LOCK_FLAG,LOCK_TIME ");
			strSql.Append(" FROM CR_INOUT_RECODE_ARCHIVE ");
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
			strSql.Append(" ID,UNIQUE_IDENTIFIER,VEHICLE_NO,CAR_COLOR,CAR_EC_NO,CREDENTIALS_TYPE,IN_FIELD_CODE,IN_CHANNEL_CODE,IN_TIME,IN_OPERATOR_ID,IN_PARTITION_CODE,IN_EQ_ID,IN_DEV_ID,IN_PARK_TYPE,OUT_DEV_ID,OUT_PARK_TYPE,OUT_TIME,OUT_FIELD_CODE,OUT_CHANNEL_CODE,OUT_OPERATOR_ID,OUT_PARTITION_CODE,TOTAL_TIME,CURR_PARTITION_CODE,DUE_MONEY,CHARGE_MONEY,PRE_MONEY,OVERTIMESFJE,ADVANCE_MONEY,PAY_METHOD,OUT_EQ_ID,PAY_PLATFORM,IN_IMG_TRUST,OUT_IMG_TRUST,RECODE_STATUS,IN_LED_INFO,OUT_LED_INFO,HAS_CORRECT,LOCK_FLAG,LOCK_TIME ");
			strSql.Append(" FROM CR_INOUT_RECODE_ARCHIVE ");
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
			strSql.Append("select count(1) FROM CR_INOUT_RECODE_ARCHIVE ");
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
			strSql.Append(")AS Row, T.*  from CR_INOUT_RECODE_ARCHIVE T ");
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
			parameters[0].Value = "CR_INOUT_RECODE_ARCHIVE";
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
        /// 统a3计?临￠¨′时o?à车|ì如¨?此??次??数oy
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int GetInOutCount(Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  COUNT(*)
                            FROM    CR_INOUT_RECODE_ARCHIVE
                            WHERE   IN_TIME BETWEEN '" + model.BEGIN_TIME + @"'
                                            AND     '" + model.END_TIME + @"'
                                    AND VEHICLE_NO = '" + model.VEHICLE_NO + @"' ");
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
        #endregion  ExtensionMethod
    }
}

