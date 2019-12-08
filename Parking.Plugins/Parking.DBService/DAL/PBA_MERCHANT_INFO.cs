/**  版本信息模板在安装目录下，可自行修改。
* PBA_MERCHANT_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_MERCHANT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:12   N/A    初版
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
	/// 数据访问类:PBA_MERCHANT_INFO
	/// </summary>
	public partial class PBA_MERCHANT_INFO
	{
		public PBA_MERCHANT_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_MERCHANT_INFO");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_MERCHANT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_MERCHANT_INFO(");
			strSql.Append("ID,MERCHANT_NAME,MERCHANT_CORPORATION,MERCHANT_CERTIFICATE_NO,MERCHANT_LOGO,MERCHANT_ADDRESS,MERCHANT_TEL,MERCHANT_CONTACTS,MERCHANT_QQ,MERCHANT_WECHART,MERCHANT_PHONE,MERCHANT_ID_CARD,MERCHANT_TYPE,MERCHANT_NATURE,MERCHANT_REPUTATION_LEVEL,MERCHANT_ENABLE,MERCHANT_CREATE_USER_NAME,MERCHANT_CREATE_TIME,MERCHANT_IS_BOND,MERCHANT_BOND)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012MERCHANT_NAME,SQL2012MERCHANT_CORPORATION,SQL2012MERCHANT_CERTIFICATE_NO,SQL2012MERCHANT_LOGO,SQL2012MERCHANT_ADDRESS,SQL2012MERCHANT_TEL,SQL2012MERCHANT_CONTACTS,SQL2012MERCHANT_QQ,SQL2012MERCHANT_WECHART,SQL2012MERCHANT_PHONE,SQL2012MERCHANT_ID_CARD,SQL2012MERCHANT_TYPE,SQL2012MERCHANT_NATURE,SQL2012MERCHANT_REPUTATION_LEVEL,SQL2012MERCHANT_ENABLE,SQL2012MERCHANT_CREATE_USER_NAME,SQL2012MERCHANT_CREATE_TIME,SQL2012MERCHANT_IS_BOND,SQL2012MERCHANT_BOND)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012MERCHANT_NAME", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MERCHANT_CORPORATION", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_CERTIFICATE_NO", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MERCHANT_LOGO", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012MERCHANT_ADDRESS", SqlDbType.VarChar,300),
					new SqlParameter("SQL2012MERCHANT_TEL", SqlDbType.VarChar,30),
					new SqlParameter("SQL2012MERCHANT_CONTACTS", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_QQ", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_WECHART", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_PHONE", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012MERCHANT_ID_CARD", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_NATURE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_REPUTATION_LEVEL", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_ENABLE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_CREATE_USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012MERCHANT_IS_BOND", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_BOND", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MERCHANT_NAME;
			parameters[2].Value = model.MERCHANT_CORPORATION;
			parameters[3].Value = model.MERCHANT_CERTIFICATE_NO;
			parameters[4].Value = model.MERCHANT_LOGO;
			parameters[5].Value = model.MERCHANT_ADDRESS;
			parameters[6].Value = model.MERCHANT_TEL;
			parameters[7].Value = model.MERCHANT_CONTACTS;
			parameters[8].Value = model.MERCHANT_QQ;
			parameters[9].Value = model.MERCHANT_WECHART;
			parameters[10].Value = model.MERCHANT_PHONE;
			parameters[11].Value = model.MERCHANT_ID_CARD;
			parameters[12].Value = model.MERCHANT_TYPE;
			parameters[13].Value = model.MERCHANT_NATURE;
			parameters[14].Value = model.MERCHANT_REPUTATION_LEVEL;
			parameters[15].Value = model.MERCHANT_ENABLE;
			parameters[16].Value = model.MERCHANT_CREATE_USER_NAME;
			parameters[17].Value = model.MERCHANT_CREATE_TIME;
			parameters[18].Value = model.MERCHANT_IS_BOND;
			parameters[19].Value = model.MERCHANT_BOND;

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
		public bool Update(Parking.Core.Model.PBA_MERCHANT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_MERCHANT_INFO set ");
			strSql.Append("MERCHANT_NAME=SQL2012MERCHANT_NAME,");
			strSql.Append("MERCHANT_CORPORATION=SQL2012MERCHANT_CORPORATION,");
			strSql.Append("MERCHANT_CERTIFICATE_NO=SQL2012MERCHANT_CERTIFICATE_NO,");
			strSql.Append("MERCHANT_LOGO=SQL2012MERCHANT_LOGO,");
			strSql.Append("MERCHANT_ADDRESS=SQL2012MERCHANT_ADDRESS,");
			strSql.Append("MERCHANT_TEL=SQL2012MERCHANT_TEL,");
			strSql.Append("MERCHANT_CONTACTS=SQL2012MERCHANT_CONTACTS,");
			strSql.Append("MERCHANT_QQ=SQL2012MERCHANT_QQ,");
			strSql.Append("MERCHANT_WECHART=SQL2012MERCHANT_WECHART,");
			strSql.Append("MERCHANT_PHONE=SQL2012MERCHANT_PHONE,");
			strSql.Append("MERCHANT_ID_CARD=SQL2012MERCHANT_ID_CARD,");
			strSql.Append("MERCHANT_TYPE=SQL2012MERCHANT_TYPE,");
			strSql.Append("MERCHANT_NATURE=SQL2012MERCHANT_NATURE,");
			strSql.Append("MERCHANT_REPUTATION_LEVEL=SQL2012MERCHANT_REPUTATION_LEVEL,");
			strSql.Append("MERCHANT_ENABLE=SQL2012MERCHANT_ENABLE,");
			strSql.Append("MERCHANT_CREATE_USER_NAME=SQL2012MERCHANT_CREATE_USER_NAME,");
			strSql.Append("MERCHANT_CREATE_TIME=SQL2012MERCHANT_CREATE_TIME,");
			strSql.Append("MERCHANT_IS_BOND=SQL2012MERCHANT_IS_BOND,");
			strSql.Append("MERCHANT_BOND=SQL2012MERCHANT_BOND");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012MERCHANT_NAME", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MERCHANT_CORPORATION", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_CERTIFICATE_NO", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012MERCHANT_LOGO", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012MERCHANT_ADDRESS", SqlDbType.VarChar,300),
					new SqlParameter("SQL2012MERCHANT_TEL", SqlDbType.VarChar,30),
					new SqlParameter("SQL2012MERCHANT_CONTACTS", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_QQ", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_WECHART", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_PHONE", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012MERCHANT_ID_CARD", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_NATURE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_REPUTATION_LEVEL", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_ENABLE", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_CREATE_USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012MERCHANT_CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012MERCHANT_IS_BOND", SqlDbType.Int,4),
					new SqlParameter("SQL2012MERCHANT_BOND", SqlDbType.Decimal,9),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.MERCHANT_NAME;
			parameters[1].Value = model.MERCHANT_CORPORATION;
			parameters[2].Value = model.MERCHANT_CERTIFICATE_NO;
			parameters[3].Value = model.MERCHANT_LOGO;
			parameters[4].Value = model.MERCHANT_ADDRESS;
			parameters[5].Value = model.MERCHANT_TEL;
			parameters[6].Value = model.MERCHANT_CONTACTS;
			parameters[7].Value = model.MERCHANT_QQ;
			parameters[8].Value = model.MERCHANT_WECHART;
			parameters[9].Value = model.MERCHANT_PHONE;
			parameters[10].Value = model.MERCHANT_ID_CARD;
			parameters[11].Value = model.MERCHANT_TYPE;
			parameters[12].Value = model.MERCHANT_NATURE;
			parameters[13].Value = model.MERCHANT_REPUTATION_LEVEL;
			parameters[14].Value = model.MERCHANT_ENABLE;
			parameters[15].Value = model.MERCHANT_CREATE_USER_NAME;
			parameters[16].Value = model.MERCHANT_CREATE_TIME;
			parameters[17].Value = model.MERCHANT_IS_BOND;
			parameters[18].Value = model.MERCHANT_BOND;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from PBA_MERCHANT_INFO ");
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
			strSql.Append("delete from PBA_MERCHANT_INFO ");
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
		public Parking.Core.Model.PBA_MERCHANT_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MERCHANT_NAME,MERCHANT_CORPORATION,MERCHANT_CERTIFICATE_NO,MERCHANT_LOGO,MERCHANT_ADDRESS,MERCHANT_TEL,MERCHANT_CONTACTS,MERCHANT_QQ,MERCHANT_WECHART,MERCHANT_PHONE,MERCHANT_ID_CARD,MERCHANT_TYPE,MERCHANT_NATURE,MERCHANT_REPUTATION_LEVEL,MERCHANT_ENABLE,MERCHANT_CREATE_USER_NAME,MERCHANT_CREATE_TIME,MERCHANT_IS_BOND,MERCHANT_BOND from PBA_MERCHANT_INFO ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_MERCHANT_INFO model=new Parking.Core.Model.PBA_MERCHANT_INFO();
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
		public Parking.Core.Model.PBA_MERCHANT_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_MERCHANT_INFO model=new Parking.Core.Model.PBA_MERCHANT_INFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MERCHANT_NAME"]!=null)
				{
					model.MERCHANT_NAME=row["MERCHANT_NAME"].ToString();
				}
				if(row["MERCHANT_CORPORATION"]!=null)
				{
					model.MERCHANT_CORPORATION=row["MERCHANT_CORPORATION"].ToString();
				}
				if(row["MERCHANT_CERTIFICATE_NO"]!=null)
				{
					model.MERCHANT_CERTIFICATE_NO=row["MERCHANT_CERTIFICATE_NO"].ToString();
				}
				if(row["MERCHANT_LOGO"]!=null)
				{
					model.MERCHANT_LOGO=row["MERCHANT_LOGO"].ToString();
				}
				if(row["MERCHANT_ADDRESS"]!=null)
				{
					model.MERCHANT_ADDRESS=row["MERCHANT_ADDRESS"].ToString();
				}
				if(row["MERCHANT_TEL"]!=null)
				{
					model.MERCHANT_TEL=row["MERCHANT_TEL"].ToString();
				}
				if(row["MERCHANT_CONTACTS"]!=null)
				{
					model.MERCHANT_CONTACTS=row["MERCHANT_CONTACTS"].ToString();
				}
				if(row["MERCHANT_QQ"]!=null)
				{
					model.MERCHANT_QQ=row["MERCHANT_QQ"].ToString();
				}
				if(row["MERCHANT_WECHART"]!=null)
				{
					model.MERCHANT_WECHART=row["MERCHANT_WECHART"].ToString();
				}
				if(row["MERCHANT_PHONE"]!=null)
				{
					model.MERCHANT_PHONE=row["MERCHANT_PHONE"].ToString();
				}
				if(row["MERCHANT_ID_CARD"]!=null)
				{
					model.MERCHANT_ID_CARD=row["MERCHANT_ID_CARD"].ToString();
				}
				if(row["MERCHANT_TYPE"]!=null && row["MERCHANT_TYPE"].ToString()!="")
				{
					model.MERCHANT_TYPE=int.Parse(row["MERCHANT_TYPE"].ToString());
				}
				if(row["MERCHANT_NATURE"]!=null && row["MERCHANT_NATURE"].ToString()!="")
				{
					model.MERCHANT_NATURE=int.Parse(row["MERCHANT_NATURE"].ToString());
				}
				if(row["MERCHANT_REPUTATION_LEVEL"]!=null && row["MERCHANT_REPUTATION_LEVEL"].ToString()!="")
				{
					model.MERCHANT_REPUTATION_LEVEL=int.Parse(row["MERCHANT_REPUTATION_LEVEL"].ToString());
				}
				if(row["MERCHANT_ENABLE"]!=null && row["MERCHANT_ENABLE"].ToString()!="")
				{
					model.MERCHANT_ENABLE=int.Parse(row["MERCHANT_ENABLE"].ToString());
				}
				if(row["MERCHANT_CREATE_USER_NAME"]!=null)
				{
					model.MERCHANT_CREATE_USER_NAME=row["MERCHANT_CREATE_USER_NAME"].ToString();
				}
				if(row["MERCHANT_CREATE_TIME"]!=null && row["MERCHANT_CREATE_TIME"].ToString()!="")
				{
					model.MERCHANT_CREATE_TIME=DateTime.Parse(row["MERCHANT_CREATE_TIME"].ToString());
				}
				if(row["MERCHANT_IS_BOND"]!=null && row["MERCHANT_IS_BOND"].ToString()!="")
				{
					model.MERCHANT_IS_BOND=int.Parse(row["MERCHANT_IS_BOND"].ToString());
				}
				if(row["MERCHANT_BOND"]!=null && row["MERCHANT_BOND"].ToString()!="")
				{
					model.MERCHANT_BOND=decimal.Parse(row["MERCHANT_BOND"].ToString());
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
			strSql.Append("select ID,MERCHANT_NAME,MERCHANT_CORPORATION,MERCHANT_CERTIFICATE_NO,MERCHANT_LOGO,MERCHANT_ADDRESS,MERCHANT_TEL,MERCHANT_CONTACTS,MERCHANT_QQ,MERCHANT_WECHART,MERCHANT_PHONE,MERCHANT_ID_CARD,MERCHANT_TYPE,MERCHANT_NATURE,MERCHANT_REPUTATION_LEVEL,MERCHANT_ENABLE,MERCHANT_CREATE_USER_NAME,MERCHANT_CREATE_TIME,MERCHANT_IS_BOND,MERCHANT_BOND ");
			strSql.Append(" FROM PBA_MERCHANT_INFO ");
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
			strSql.Append(" ID,MERCHANT_NAME,MERCHANT_CORPORATION,MERCHANT_CERTIFICATE_NO,MERCHANT_LOGO,MERCHANT_ADDRESS,MERCHANT_TEL,MERCHANT_CONTACTS,MERCHANT_QQ,MERCHANT_WECHART,MERCHANT_PHONE,MERCHANT_ID_CARD,MERCHANT_TYPE,MERCHANT_NATURE,MERCHANT_REPUTATION_LEVEL,MERCHANT_ENABLE,MERCHANT_CREATE_USER_NAME,MERCHANT_CREATE_TIME,MERCHANT_IS_BOND,MERCHANT_BOND ");
			strSql.Append(" FROM PBA_MERCHANT_INFO ");
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
			strSql.Append("select count(1) FROM PBA_MERCHANT_INFO ");
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
			strSql.Append(")AS Row, T.*  from PBA_MERCHANT_INFO T ");
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
			parameters[0].Value = "PBA_MERCHANT_INFO";
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

