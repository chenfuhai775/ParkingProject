/**  版本信息模板在安装目录下，可自行修改。
* CR_ORDER_RECORD_INFO.cs
*
* 功 能： N/A
* 类 名： CR_ORDER_RECORD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:03   N/A    初版
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
using Parking.Core.Record;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:CR_ORDER_RECORD_INFO
	/// </summary>
	public partial class CR_ORDER_RECORD_INFO
	{
		public CR_ORDER_RECORD_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_ORDER_RECORD_INFO");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_ORDER_RECORD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_ORDER_RECORD_INFO(");
			strSql.Append("ID,PARTITION_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,INOUT_RECODE_ID,TOTAL_TIME,VEHICLE_NO,DUE_MONEY,CHARGE_MONEY,PER_MONEY,ALREADY_PAID,PAY_PLATFORM,PAY_TYPE,IS_PAY,FREE_TIME,CREATE_TIME)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012PARTITION_CODE,SQL2012IN_CHANNEL_CODE,SQL2012OUT_CHANNEL_CODE,SQL2012INOUT_RECODE_ID,SQL2012TOTAL_TIME,SQL2012VEHICLE_NO,SQL2012DUE_MONEY,SQL2012CHARGE_MONEY,SQL2012PER_MONEY,SQL2012ALREADY_PAID,SQL2012PAY_PLATFORM,SQL2012PAY_TYPE,SQL2012IS_PAY,SQL2012FREE_TIME,SQL2012CREATE_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PARTITION_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012TOTAL_TIME", SqlDbType.Int,4),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PER_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012ALREADY_PAID", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012IS_PAY", SqlDbType.Bit,1),
					new SqlParameter("SQL2012FREE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PARTITION_CODE;
			parameters[2].Value = model.IN_CHANNEL_CODE;
			parameters[3].Value = model.OUT_CHANNEL_CODE;
			parameters[4].Value = model.INOUT_RECODE_ID;
			parameters[5].Value = model.TOTAL_TIME;
			parameters[6].Value = model.VEHICLE_NO;
			parameters[7].Value = model.DUE_MONEY;
			parameters[8].Value = model.CHARGE_MONEY;
			parameters[9].Value = model.PER_MONEY;
			parameters[10].Value = model.ALREADY_PAID;
			parameters[11].Value = model.PAY_PLATFORM;
			parameters[12].Value = model.PAY_TYPE;
			parameters[13].Value = model.IS_PAY;
			parameters[14].Value = model.FREE_TIME;
			parameters[15].Value = model.CREATE_TIME;

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
		public bool Update(Parking.Core.Model.CR_ORDER_RECORD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_ORDER_RECORD_INFO set ");
			strSql.Append("PARTITION_CODE=SQL2012PARTITION_CODE,");
			strSql.Append("IN_CHANNEL_CODE=SQL2012IN_CHANNEL_CODE,");
			strSql.Append("OUT_CHANNEL_CODE=SQL2012OUT_CHANNEL_CODE,");
			strSql.Append("INOUT_RECODE_ID=SQL2012INOUT_RECODE_ID,");
			strSql.Append("TOTAL_TIME=SQL2012TOTAL_TIME,");
			strSql.Append("VEHICLE_NO=SQL2012VEHICLE_NO,");
			strSql.Append("DUE_MONEY=SQL2012DUE_MONEY,");
			strSql.Append("CHARGE_MONEY=SQL2012CHARGE_MONEY,");
			strSql.Append("PER_MONEY=SQL2012PER_MONEY,");
			strSql.Append("ALREADY_PAID=SQL2012ALREADY_PAID,");
			strSql.Append("PAY_PLATFORM=SQL2012PAY_PLATFORM,");
			strSql.Append("PAY_TYPE=SQL2012PAY_TYPE,");
			strSql.Append("IS_PAY=SQL2012IS_PAY,");
			strSql.Append("FREE_TIME=SQL2012FREE_TIME,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012PARTITION_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012TOTAL_TIME", SqlDbType.Int,4),
					new SqlParameter("SQL2012VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PER_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012ALREADY_PAID", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PAY_PLATFORM", SqlDbType.Int,4),
					new SqlParameter("SQL2012PAY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012IS_PAY", SqlDbType.Bit,1),
					new SqlParameter("SQL2012FREE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.PARTITION_CODE;
			parameters[1].Value = model.IN_CHANNEL_CODE;
			parameters[2].Value = model.OUT_CHANNEL_CODE;
			parameters[3].Value = model.INOUT_RECODE_ID;
			parameters[4].Value = model.TOTAL_TIME;
			parameters[5].Value = model.VEHICLE_NO;
			parameters[6].Value = model.DUE_MONEY;
			parameters[7].Value = model.CHARGE_MONEY;
			parameters[8].Value = model.PER_MONEY;
			parameters[9].Value = model.ALREADY_PAID;
			parameters[10].Value = model.PAY_PLATFORM;
			parameters[11].Value = model.PAY_TYPE;
			parameters[12].Value = model.IS_PAY;
			parameters[13].Value = model.FREE_TIME;
			parameters[14].Value = model.CREATE_TIME;
			parameters[15].Value = model.ID;

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
			strSql.Append("delete from CR_ORDER_RECORD_INFO ");
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
			strSql.Append("delete from CR_ORDER_RECORD_INFO ");
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
		public Parking.Core.Model.CR_ORDER_RECORD_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PARTITION_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,INOUT_RECODE_ID,TOTAL_TIME,VEHICLE_NO,DUE_MONEY,CHARGE_MONEY,PER_MONEY,ALREADY_PAID,PAY_PLATFORM,PAY_TYPE,IS_PAY,FREE_TIME,CREATE_TIME from CR_ORDER_RECORD_INFO ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_ORDER_RECORD_INFO model=new Parking.Core.Model.CR_ORDER_RECORD_INFO();
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
		public Parking.Core.Model.CR_ORDER_RECORD_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_ORDER_RECORD_INFO model=new Parking.Core.Model.CR_ORDER_RECORD_INFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["PARTITION_CODE"]!=null)
				{
					model.PARTITION_CODE=row["PARTITION_CODE"].ToString();
				}
				if(row["IN_CHANNEL_CODE"]!=null)
				{
					model.IN_CHANNEL_CODE=row["IN_CHANNEL_CODE"].ToString();
				}
				if(row["OUT_CHANNEL_CODE"]!=null)
				{
					model.OUT_CHANNEL_CODE=row["OUT_CHANNEL_CODE"].ToString();
				}
				if(row["INOUT_RECODE_ID"]!=null)
				{
					model.INOUT_RECODE_ID=row["INOUT_RECODE_ID"].ToString();
				}
				if(row["TOTAL_TIME"]!=null && row["TOTAL_TIME"].ToString()!="")
				{
					model.TOTAL_TIME=int.Parse(row["TOTAL_TIME"].ToString());
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["DUE_MONEY"]!=null && row["DUE_MONEY"].ToString()!="")
				{
					model.DUE_MONEY=decimal.Parse(row["DUE_MONEY"].ToString());
				}
				if(row["CHARGE_MONEY"]!=null && row["CHARGE_MONEY"].ToString()!="")
				{
					model.CHARGE_MONEY=decimal.Parse(row["CHARGE_MONEY"].ToString());
				}
				if(row["PER_MONEY"]!=null && row["PER_MONEY"].ToString()!="")
				{
					model.PER_MONEY=decimal.Parse(row["PER_MONEY"].ToString());
				}
				if(row["ALREADY_PAID"]!=null && row["ALREADY_PAID"].ToString()!="")
				{
					model.ALREADY_PAID=decimal.Parse(row["ALREADY_PAID"].ToString());
				}
				if(row["PAY_PLATFORM"]!=null && row["PAY_PLATFORM"].ToString()!="")
				{
					model.PAY_PLATFORM=int.Parse(row["PAY_PLATFORM"].ToString());
				}
				if(row["PAY_TYPE"]!=null && row["PAY_TYPE"].ToString()!="")
				{
					model.PAY_TYPE=int.Parse(row["PAY_TYPE"].ToString());
				}
				if(row["IS_PAY"]!=null && row["IS_PAY"].ToString()!="")
				{
					if((row["IS_PAY"].ToString()=="1")||(row["IS_PAY"].ToString().ToLower()=="true"))
					{
						model.IS_PAY=true;
					}
					else
					{
						model.IS_PAY=false;
					}
				}
				if(row["FREE_TIME"]!=null && row["FREE_TIME"].ToString()!="")
				{
					model.FREE_TIME=DateTime.Parse(row["FREE_TIME"].ToString());
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
			strSql.Append("select ID,PARTITION_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,INOUT_RECODE_ID,TOTAL_TIME,VEHICLE_NO,DUE_MONEY,CHARGE_MONEY,PER_MONEY,ALREADY_PAID,PAY_PLATFORM,PAY_TYPE,IS_PAY,FREE_TIME,CREATE_TIME ");
			strSql.Append(" FROM CR_ORDER_RECORD_INFO ");
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
			strSql.Append(" ID,PARTITION_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,INOUT_RECODE_ID,TOTAL_TIME,VEHICLE_NO,DUE_MONEY,CHARGE_MONEY,PER_MONEY,ALREADY_PAID,PAY_PLATFORM,PAY_TYPE,IS_PAY,FREE_TIME,CREATE_TIME ");
			strSql.Append(" FROM CR_ORDER_RECORD_INFO ");
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
			strSql.Append("select count(1) FROM CR_ORDER_RECORD_INFO ");
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
			strSql.Append(")AS Row, T.*  from CR_ORDER_RECORD_INFO T ");
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
			parameters[0].Value = "CR_ORDER_RECORD_INFO";
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
        /// 获?取¨?当ì?à前??区?域?¨°所¨′有?D订?单ì￡¤
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Core.Model.CR_ORDER_RECORD_INFO GetCurrentPartitionOrder(string CURR_PARTITION_CODE, string ID)
        {
            string strSql = @"SELECT TOP 1 * FROM    dbo.CR_ORDER_RECORD_INFO
                                        WHERE   PARTITION_CODE = '{0}'
                                        AND INOUT_RECODE_ID = '{1}' ";
            strSql = string.Format(strSql, CURR_PARTITION_CODE, ID);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获?取¨?当ì?à前??区?域?¨°所¨′有?D订?单ì￡¤
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Core.Model.CR_ORDER_RECORD_INFO GetCurrentPartitionOrder(Core.Model.CR_INOUT_RECODE model)
        {
            string strSql = @"SELECT TOP 1 * FROM    dbo.CR_ORDER_RECORD_INFO
                                        WHERE   PARTITION_CODE = '{0}'
                                        AND INOUT_RECODE_ID = '{1}' ";
            strSql = string.Format(strSql, model.CURR_PARTITION_CODE, model.ID);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        ///// <summary>
        ///// 获?取¨?所¨′有?D订?单ì￡¤
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public DataSet GetOrders(string ID, string PartitionCode)
        //{
        //    string strSql = @"SELECT * FROM  dbo.CR_ORDER_RECORD_INFO  WHERE  INOUT_RECODE_ID = '{0}' AND PARTITION_CODE ='{1}' ";
        //    strSql = string.Format(strSql, ID, PartitionCode);
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
        /// <summary>
        /// 获?取¨?所¨′有?D订?单ì￡¤
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataSet GetOrders(Core.Model.CR_INOUT_RECODE model)
        {
            string strSql = @"SELECT * FROM  dbo.CR_ORDER_RECORD_INFO  WHERE  INOUT_RECODE_ID = '{0}' ";
            strSql = string.Format(strSql, model.ID);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取¨?消?订?单ì￡¤
        /// </summary>
        /// <param name="model"></param>
        public void CancelOrder(Parking.Core.Model.CR_ORDER_RECORD_INFO model)
        {
            if (this.Update(model))
            {
                CR_INOUT_RECODE recordDal = new CR_INOUT_RECODE();
                var record = recordDal.GetModel(model.INOUT_RECODE_ID);
                if (null != record)
                {
                    record.OUT_DEV_ID = string.Empty;
                    record.OUT_OPERATOR_ID = string.Empty;
                    record.OUT_CHANNEL_CODE = string.Empty;
                    record.OUT_TIME = record.IN_TIME;
                    recordDal.Update(record);
                }
            }
        }
        #endregion  ExtensionMethod
    }
}

