/**  版本信息模板在安装目录下，可自行修改。
* CR_ORDER_RECORD_DETAILS.cs
*
* 功 能： N/A
* 类 名： CR_ORDER_RECORD_DETAILS
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
	/// 数据访问类:CR_ORDER_RECORD_DETAILS
	/// </summary>
	public partial class CR_ORDER_RECORD_DETAILS
	{
		public CR_ORDER_RECORD_DETAILS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_ORDER_RECORD_DETAILS");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_ORDER_RECORD_DETAILS(");
			strSql.Append("ID,ORDER_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,IN_TIME,OUT_TIME,DUE_MONEY,CHARGE_MONEY,PER_MONEY,VEHICLE_NO)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ORDER_CODE,@IN_CHANNEL_CODE,@OUT_CHANNEL_CODE,@IN_TIME,@OUT_TIME,@DUE_MONEY,@CHARGE_MONEY,@PER_MONEY,@VEHICLE_NO)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@ORDER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_TIME", SqlDbType.DateTime),
					new SqlParameter("@OUT_TIME", SqlDbType.DateTime),
					new SqlParameter("@DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PER_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ORDER_CODE;
			parameters[2].Value = model.IN_CHANNEL_CODE;
			parameters[3].Value = model.OUT_CHANNEL_CODE;
			parameters[4].Value = model.IN_TIME;
			parameters[5].Value = model.OUT_TIME;
			parameters[6].Value = model.DUE_MONEY;
			parameters[7].Value = model.CHARGE_MONEY;
			parameters[8].Value = model.PER_MONEY;
			parameters[9].Value = model.VEHICLE_NO;

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
		public bool Update(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_ORDER_RECORD_DETAILS set ");
			strSql.Append("ORDER_CODE=@ORDER_CODE,");
			strSql.Append("IN_CHANNEL_CODE=@IN_CHANNEL_CODE,");
			strSql.Append("OUT_CHANNEL_CODE=@OUT_CHANNEL_CODE,");
			strSql.Append("IN_TIME=@IN_TIME,");
			strSql.Append("OUT_TIME=@OUT_TIME,");
			strSql.Append("DUE_MONEY=@DUE_MONEY,");
			strSql.Append("CHARGE_MONEY=@CHARGE_MONEY,");
			strSql.Append("PER_MONEY=@PER_MONEY,");
			strSql.Append("VEHICLE_NO=@VEHICLE_NO");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@OUT_CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@IN_TIME", SqlDbType.DateTime),
					new SqlParameter("@OUT_TIME", SqlDbType.DateTime),
					new SqlParameter("@DUE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@PER_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ORDER_CODE;
			parameters[1].Value = model.IN_CHANNEL_CODE;
			parameters[2].Value = model.OUT_CHANNEL_CODE;
			parameters[3].Value = model.IN_TIME;
			parameters[4].Value = model.OUT_TIME;
			parameters[5].Value = model.DUE_MONEY;
			parameters[6].Value = model.CHARGE_MONEY;
			parameters[7].Value = model.PER_MONEY;
			parameters[8].Value = model.VEHICLE_NO;
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
			strSql.Append("delete from CR_ORDER_RECORD_DETAILS ");
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
			strSql.Append("delete from CR_ORDER_RECORD_DETAILS ");
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
		public Parking.Core.Model.CR_ORDER_RECORD_DETAILS GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ORDER_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,IN_TIME,OUT_TIME,DUE_MONEY,CHARGE_MONEY,PER_MONEY,VEHICLE_NO from CR_ORDER_RECORD_DETAILS ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_ORDER_RECORD_DETAILS model=new Parking.Core.Model.CR_ORDER_RECORD_DETAILS();
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
		public Parking.Core.Model.CR_ORDER_RECORD_DETAILS DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_ORDER_RECORD_DETAILS model=new Parking.Core.Model.CR_ORDER_RECORD_DETAILS();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ORDER_CODE"]!=null)
				{
					model.ORDER_CODE=row["ORDER_CODE"].ToString();
				}
				if(row["IN_CHANNEL_CODE"]!=null)
				{
					model.IN_CHANNEL_CODE=row["IN_CHANNEL_CODE"].ToString();
				}
				if(row["OUT_CHANNEL_CODE"]!=null)
				{
					model.OUT_CHANNEL_CODE=row["OUT_CHANNEL_CODE"].ToString();
				}
				if(row["IN_TIME"]!=null && row["IN_TIME"].ToString()!="")
				{
					model.IN_TIME=DateTime.Parse(row["IN_TIME"].ToString());
				}
				if(row["OUT_TIME"]!=null && row["OUT_TIME"].ToString()!="")
				{
					model.OUT_TIME=DateTime.Parse(row["OUT_TIME"].ToString());
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
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
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
			strSql.Append("select ID,ORDER_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,IN_TIME,OUT_TIME,DUE_MONEY,CHARGE_MONEY,PER_MONEY,VEHICLE_NO ");
			strSql.Append(" FROM CR_ORDER_RECORD_DETAILS ");
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
			strSql.Append(" ID,ORDER_CODE,IN_CHANNEL_CODE,OUT_CHANNEL_CODE,IN_TIME,OUT_TIME,DUE_MONEY,CHARGE_MONEY,PER_MONEY,VEHICLE_NO ");
			strSql.Append(" FROM CR_ORDER_RECORD_DETAILS ");
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
			strSql.Append("select count(1) FROM CR_ORDER_RECORD_DETAILS ");
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
			strSql.Append(")AS Row, T.*  from CR_ORDER_RECORD_DETAILS T ");
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
			parameters[0].Value = "CR_ORDER_RECORD_DETAILS";
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
        /// 获?取¨?单ì￡¤个?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public Parking.Core.Model.CR_ORDER_RECORD_DETAILS GetOrderDetailsInfo(ProcessRecord recordInfo)
        {
            string strSql = @"SELECT  *  FROM  dbo.CR_ORDER_RECORD_DETAILS  WHERE ORDER_CODE = '{0}' AND IN_CHANNEL_CODE = '{1}' AND IN_TIME = '{2}' ";
            strSql = string.Format(strSql, recordInfo.Order.ID, recordInfo.INOUT_RECODE.IN_CHANNEL_CODE, recordInfo.INOUT_RECODE.IN_TIME);

            Parking.Core.Model.CR_ORDER_RECORD_DETAILS model = new Parking.Core.Model.CR_ORDER_RECORD_DETAILS();
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
        /// 根¨′据Y出?入¨?场?ID获?取¨?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public DataSet GetOrdersByInOutCode(string InOutCode)
        {
            string strSql = @"SELECT  * FROM    dbo.CR_ORDER_RECORD_DETAILS
                                WHERE   ORDER_CODE IN (
                                        SELECT  ID
                                        FROM    dbo.CR_ORDER_RECORD_INFO
                                        WHERE   INOUT_RECODE_ID = '{0}' )";
            strSql = string.Format(strSql, InOutCode);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根¨′据Y
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public DataSet GetDetailsByOrder(string OrderCode)
        {
            string strSql = @"SELECT  * FROM  dbo.CR_ORDER_RECORD_DETAILS  WHERE   ORDER_CODE = '" + OrderCode + @"'";
            strSql = string.Format(strSql, OrderCode);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 删|?除y订?单ì￡¤
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        public bool DeleteByOrderCode(string OrderCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CR_ORDER_RECORD_DETAILS ");
            strSql.Append(" where ORDER_CODE = @ORDER_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ORDER_CODE", SqlDbType.VarChar,32)           };
            parameters[0].Value = OrderCode;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  ExtensionMethod
    }
}

