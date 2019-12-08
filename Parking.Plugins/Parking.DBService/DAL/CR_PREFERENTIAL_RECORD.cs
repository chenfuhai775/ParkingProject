/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_RECORD.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_RECORD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:05   N/A    初版
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
	/// 数据访问类:CR_PREFERENTIAL_RECORD
	/// </summary>
	public partial class CR_PREFERENTIAL_RECORD
	{
		public CR_PREFERENTIAL_RECORD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PREFERENTIAL_RECORD");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_RECORD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PREFERENTIAL_RECORD(");
			strSql.Append("ID,INOUT_RECORD_CODE,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,CHARGE_MONEY,PREFERENTIAL_MONEY,PREFERENTIA_IDENT,CHARGE_ID,UNIQUE_IDENTIFIER,PREFERENTIAL_NAME,ORDER_CODE)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012INOUT_RECORD_CODE,SQL2012PREFERENTIAL_TYPE,SQL2012PREFERENTIAL_CONTENT,SQL2012CHARGE_MONEY,SQL2012PREFERENTIAL_MONEY,SQL2012PREFERENTIA_IDENT,SQL2012CHARGE_ID,SQL2012UNIQUE_IDENTIFIER,SQL2012PREFERENTIAL_NAME,SQL2012ORDER_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012INOUT_RECORD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012PREFERENTIAL_CONTENT", SqlDbType.VarChar,2000),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PREFERENTIAL_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PREFERENTIA_IDENT", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CHARGE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012PREFERENTIAL_NAME", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012ORDER_CODE", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.INOUT_RECORD_CODE;
			parameters[2].Value = model.PREFERENTIAL_TYPE;
			parameters[3].Value = model.PREFERENTIAL_CONTENT;
			parameters[4].Value = model.CHARGE_MONEY;
			parameters[5].Value = model.PREFERENTIAL_MONEY;
			parameters[6].Value = model.PREFERENTIA_IDENT;
			parameters[7].Value = model.CHARGE_ID;
			parameters[8].Value = model.UNIQUE_IDENTIFIER;
			parameters[9].Value = model.PREFERENTIAL_NAME;
			parameters[10].Value = model.ORDER_CODE;

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
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_RECORD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PREFERENTIAL_RECORD set ");
			strSql.Append("INOUT_RECORD_CODE=SQL2012INOUT_RECORD_CODE,");
			strSql.Append("PREFERENTIAL_TYPE=SQL2012PREFERENTIAL_TYPE,");
			strSql.Append("PREFERENTIAL_CONTENT=SQL2012PREFERENTIAL_CONTENT,");
			strSql.Append("CHARGE_MONEY=SQL2012CHARGE_MONEY,");
			strSql.Append("PREFERENTIAL_MONEY=SQL2012PREFERENTIAL_MONEY,");
			strSql.Append("PREFERENTIA_IDENT=SQL2012PREFERENTIA_IDENT,");
			strSql.Append("CHARGE_ID=SQL2012CHARGE_ID,");
			strSql.Append("UNIQUE_IDENTIFIER=SQL2012UNIQUE_IDENTIFIER,");
			strSql.Append("PREFERENTIAL_NAME=SQL2012PREFERENTIAL_NAME,");
			strSql.Append("ORDER_CODE=SQL2012ORDER_CODE");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012INOUT_RECORD_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012PREFERENTIAL_CONTENT", SqlDbType.VarChar,2000),
					new SqlParameter("SQL2012CHARGE_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PREFERENTIAL_MONEY", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012PREFERENTIA_IDENT", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CHARGE_ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012PREFERENTIAL_NAME", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012ORDER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.INOUT_RECORD_CODE;
			parameters[1].Value = model.PREFERENTIAL_TYPE;
			parameters[2].Value = model.PREFERENTIAL_CONTENT;
			parameters[3].Value = model.CHARGE_MONEY;
			parameters[4].Value = model.PREFERENTIAL_MONEY;
			parameters[5].Value = model.PREFERENTIA_IDENT;
			parameters[6].Value = model.CHARGE_ID;
			parameters[7].Value = model.UNIQUE_IDENTIFIER;
			parameters[8].Value = model.PREFERENTIAL_NAME;
			parameters[9].Value = model.ORDER_CODE;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from CR_PREFERENTIAL_RECORD ");
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
			strSql.Append("delete from CR_PREFERENTIAL_RECORD ");
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
		public Parking.Core.Model.CR_PREFERENTIAL_RECORD GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,INOUT_RECORD_CODE,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,CHARGE_MONEY,PREFERENTIAL_MONEY,PREFERENTIA_IDENT,CHARGE_ID,UNIQUE_IDENTIFIER,PREFERENTIAL_NAME,ORDER_CODE from CR_PREFERENTIAL_RECORD ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_PREFERENTIAL_RECORD model=new Parking.Core.Model.CR_PREFERENTIAL_RECORD();
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
		public Parking.Core.Model.CR_PREFERENTIAL_RECORD DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PREFERENTIAL_RECORD model=new Parking.Core.Model.CR_PREFERENTIAL_RECORD();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["INOUT_RECORD_CODE"]!=null)
				{
					model.INOUT_RECORD_CODE=row["INOUT_RECORD_CODE"].ToString();
				}
				if(row["PREFERENTIAL_TYPE"]!=null && row["PREFERENTIAL_TYPE"].ToString()!="")
				{
					model.PREFERENTIAL_TYPE=int.Parse(row["PREFERENTIAL_TYPE"].ToString());
				}
				if(row["PREFERENTIAL_CONTENT"]!=null)
				{
					model.PREFERENTIAL_CONTENT=row["PREFERENTIAL_CONTENT"].ToString();
				}
				if(row["CHARGE_MONEY"]!=null && row["CHARGE_MONEY"].ToString()!="")
				{
					model.CHARGE_MONEY=decimal.Parse(row["CHARGE_MONEY"].ToString());
				}
				if(row["PREFERENTIAL_MONEY"]!=null && row["PREFERENTIAL_MONEY"].ToString()!="")
				{
					model.PREFERENTIAL_MONEY=decimal.Parse(row["PREFERENTIAL_MONEY"].ToString());
				}
				if(row["PREFERENTIA_IDENT"]!=null)
				{
					model.PREFERENTIA_IDENT=row["PREFERENTIA_IDENT"].ToString();
				}
				if(row["CHARGE_ID"]!=null)
				{
					model.CHARGE_ID=row["CHARGE_ID"].ToString();
				}
				if(row["UNIQUE_IDENTIFIER"]!=null)
				{
					model.UNIQUE_IDENTIFIER=row["UNIQUE_IDENTIFIER"].ToString();
				}
				if(row["PREFERENTIAL_NAME"]!=null)
				{
					model.PREFERENTIAL_NAME=row["PREFERENTIAL_NAME"].ToString();
				}
				if(row["ORDER_CODE"]!=null)
				{
					model.ORDER_CODE=row["ORDER_CODE"].ToString();
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
			strSql.Append("select ID,INOUT_RECORD_CODE,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,CHARGE_MONEY,PREFERENTIAL_MONEY,PREFERENTIA_IDENT,CHARGE_ID,UNIQUE_IDENTIFIER,PREFERENTIAL_NAME,ORDER_CODE ");
			strSql.Append(" FROM CR_PREFERENTIAL_RECORD ");
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
			strSql.Append(" ID,INOUT_RECORD_CODE,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,CHARGE_MONEY,PREFERENTIAL_MONEY,PREFERENTIA_IDENT,CHARGE_ID,UNIQUE_IDENTIFIER,PREFERENTIAL_NAME,ORDER_CODE ");
			strSql.Append(" FROM CR_PREFERENTIAL_RECORD ");
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
			strSql.Append("select count(1) FROM CR_PREFERENTIAL_RECORD ");
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
			strSql.Append(")AS Row, T.*  from CR_PREFERENTIAL_RECORD T ");
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
			parameters[0].Value = "CR_PREFERENTIAL_RECORD";
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
        /// 获?取¨?优??惠Y信?息?é
        /// </summary>
        public DataSet GetListByInOutRecordCode(string InOutRecordCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" ID,INOUT_RECORD_CODE,PREFERENTIAL_TYPE,PREFERENTIAL_CONTENT,CHARGE_MONEY,PREFERENTIAL_MONEY,PREFERENTIA_IDENT,CHARGE_ID,UNIQUE_IDENTIFIER,PREFERENTIAL_NAME ");
            strSql.Append(" FROM CR_PREFERENTIAL_RECORD ");
            strSql.Append(" where INOUT_RECORD_CODE=@INOUT_RECORD_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@INOUT_RECORD_CODE", SqlDbType.VarChar,32)            };
            parameters[0].Value = InOutRecordCode;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        #endregion  ExtensionMethod
    }
}

