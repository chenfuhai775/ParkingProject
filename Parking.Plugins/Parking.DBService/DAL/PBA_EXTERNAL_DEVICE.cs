/**  版本信息模板在安装目录下，可自行修改。
* PBA_EXTERNAL_DEVICE.cs
*
* 功 能： N/A
* 类 名： PBA_EXTERNAL_DEVICE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:10   N/A    初版
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
	/// 数据访问类:PBA_EXTERNAL_DEVICE
	/// </summary>
	public partial class PBA_EXTERNAL_DEVICE
	{
		public PBA_EXTERNAL_DEVICE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DEVICE_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_EXTERNAL_DEVICE");
			strSql.Append(" where DEVICE_CODE=SQL2012DEVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = DEVICE_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_EXTERNAL_DEVICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_EXTERNAL_DEVICE(");
			strSql.Append("DEVICE_CODE,DEVICE_NAME,DEVICE_TYPE,DEVICE_NUMBER,IP_ADDRESS,PORT,CREATE_TIME,CREATE_USERID,REMARK)");
			strSql.Append(" values (");
			strSql.Append("SQL2012DEVICE_CODE,SQL2012DEVICE_NAME,SQL2012DEVICE_TYPE,SQL2012DEVICE_NUMBER,SQL2012IP_ADDRESS,SQL2012PORT,SQL2012CREATE_TIME,SQL2012CREATE_USERID,SQL2012REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012DEVICE_NUMBER", SqlDbType.Int,4),
					new SqlParameter("SQL2012IP_ADDRESS", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PORT", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,500)};
			parameters[0].Value = model.DEVICE_CODE;
			parameters[1].Value = model.DEVICE_NAME;
			parameters[2].Value = model.DEVICE_TYPE;
			parameters[3].Value = model.DEVICE_NUMBER;
			parameters[4].Value = model.IP_ADDRESS;
			parameters[5].Value = model.PORT;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.CREATE_USERID;
			parameters[8].Value = model.REMARK;

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
		public bool Update(Parking.Core.Model.PBA_EXTERNAL_DEVICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_EXTERNAL_DEVICE set ");
			strSql.Append("DEVICE_NAME=SQL2012DEVICE_NAME,");
			strSql.Append("DEVICE_TYPE=SQL2012DEVICE_TYPE,");
			strSql.Append("DEVICE_NUMBER=SQL2012DEVICE_NUMBER,");
			strSql.Append("IP_ADDRESS=SQL2012IP_ADDRESS,");
			strSql.Append("PORT=SQL2012PORT,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USERID=SQL2012CREATE_USERID,");
			strSql.Append("REMARK=SQL2012REMARK");
			strSql.Append(" where DEVICE_CODE=SQL2012DEVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012DEVICE_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012DEVICE_NUMBER", SqlDbType.Int,4),
					new SqlParameter("SQL2012IP_ADDRESS", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PORT", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,500),
					new SqlParameter("SQL2012DEVICE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DEVICE_NAME;
			parameters[1].Value = model.DEVICE_TYPE;
			parameters[2].Value = model.DEVICE_NUMBER;
			parameters[3].Value = model.IP_ADDRESS;
			parameters[4].Value = model.PORT;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CREATE_USERID;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.DEVICE_CODE;

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
		public bool Delete(string DEVICE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_EXTERNAL_DEVICE ");
			strSql.Append(" where DEVICE_CODE=SQL2012DEVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = DEVICE_CODE;

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
		public bool DeleteList(string DEVICE_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_EXTERNAL_DEVICE ");
			strSql.Append(" where DEVICE_CODE in ("+DEVICE_CODElist + ")  ");
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
		public Parking.Core.Model.PBA_EXTERNAL_DEVICE GetModel(string DEVICE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DEVICE_CODE,DEVICE_NAME,DEVICE_TYPE,DEVICE_NUMBER,IP_ADDRESS,PORT,CREATE_TIME,CREATE_USERID,REMARK from PBA_EXTERNAL_DEVICE ");
			strSql.Append(" where DEVICE_CODE=SQL2012DEVICE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012DEVICE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = DEVICE_CODE;

			Parking.Core.Model.PBA_EXTERNAL_DEVICE model=new Parking.Core.Model.PBA_EXTERNAL_DEVICE();
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
		public Parking.Core.Model.PBA_EXTERNAL_DEVICE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_EXTERNAL_DEVICE model=new Parking.Core.Model.PBA_EXTERNAL_DEVICE();
			if (row != null)
			{
				if(row["DEVICE_CODE"]!=null)
				{
					model.DEVICE_CODE=row["DEVICE_CODE"].ToString();
				}
				if(row["DEVICE_NAME"]!=null)
				{
					model.DEVICE_NAME=row["DEVICE_NAME"].ToString();
				}
				if(row["DEVICE_TYPE"]!=null && row["DEVICE_TYPE"].ToString()!="")
				{
					model.DEVICE_TYPE=int.Parse(row["DEVICE_TYPE"].ToString());
				}
				if(row["DEVICE_NUMBER"]!=null && row["DEVICE_NUMBER"].ToString()!="")
				{
					model.DEVICE_NUMBER=int.Parse(row["DEVICE_NUMBER"].ToString());
				}
				if(row["IP_ADDRESS"]!=null)
				{
					model.IP_ADDRESS=row["IP_ADDRESS"].ToString();
				}
				if(row["PORT"]!=null && row["PORT"].ToString()!="")
				{
					model.PORT=int.Parse(row["PORT"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select DEVICE_CODE,DEVICE_NAME,DEVICE_TYPE,DEVICE_NUMBER,IP_ADDRESS,PORT,CREATE_TIME,CREATE_USERID,REMARK ");
			strSql.Append(" FROM PBA_EXTERNAL_DEVICE ");
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
			strSql.Append(" DEVICE_CODE,DEVICE_NAME,DEVICE_TYPE,DEVICE_NUMBER,IP_ADDRESS,PORT,CREATE_TIME,CREATE_USERID,REMARK ");
			strSql.Append(" FROM PBA_EXTERNAL_DEVICE ");
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
			strSql.Append("select count(1) FROM PBA_EXTERNAL_DEVICE ");
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
				strSql.Append("order by T.DEVICE_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_EXTERNAL_DEVICE T ");
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
			parameters[0].Value = "PBA_EXTERNAL_DEVICE";
			parameters[1].Value = "DEVICE_CODE";
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

