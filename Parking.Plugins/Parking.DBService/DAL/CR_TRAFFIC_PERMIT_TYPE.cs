/**  版本信息模板在安装目录下，可自行修改。
* CR_TRAFFIC_PERMIT_TYPE.cs
*
* 功 能： N/A
* 类 名： CR_TRAFFIC_PERMIT_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
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
	/// 数据访问类:CR_TRAFFIC_PERMIT_TYPE
	/// </summary>
	public partial class CR_TRAFFIC_PERMIT_TYPE
	{
		public CR_TRAFFIC_PERMIT_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_TRAFFIC_PERMIT_TYPE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_TRAFFIC_PERMIT_TYPE(");
			strSql.Append("ID,ACCESS_CHANNEL_CODE,ACCESS_PERMISSIONS,CHARGE_TYPE_CODE,CREATE_TIME,CREATE_USERID,IDENTITY_NAME,IS_ENABLE,PAY_MONEY,TRAFFIC_PERMIT_NAME,TRAFFIC_PERMIT_TYPE,UPDATE_TIME,UPDATE_USERID)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ACCESS_CHANNEL_CODE,@ACCESS_PERMISSIONS,@CHARGE_TYPE_CODE,@CREATE_TIME,@CREATE_USERID,@IDENTITY_NAME,@IS_ENABLE,@PAY_MONEY,@TRAFFIC_PERMIT_NAME,@TRAFFIC_PERMIT_TYPE,@UPDATE_TIME,@UPDATE_USERID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@ACCESS_CHANNEL_CODE", SqlDbType.VarChar,500),
					new SqlParameter("@ACCESS_PERMISSIONS", SqlDbType.VarChar,128),
					new SqlParameter("@CHARGE_TYPE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@IDENTITY_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IS_ENABLE", SqlDbType.Int,4),
					new SqlParameter("@PAY_MONEY", SqlDbType.Float,8),
					new SqlParameter("@TRAFFIC_PERMIT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TRAFFIC_PERMIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ACCESS_CHANNEL_CODE;
			parameters[2].Value = model.ACCESS_PERMISSIONS;
			parameters[3].Value = model.CHARGE_TYPE_CODE;
			parameters[4].Value = model.CREATE_TIME;
			parameters[5].Value = model.CREATE_USERID;
			parameters[6].Value = model.IDENTITY_NAME;
			parameters[7].Value = model.IS_ENABLE;
			parameters[8].Value = model.PAY_MONEY;
			parameters[9].Value = model.TRAFFIC_PERMIT_NAME;
			parameters[10].Value = model.TRAFFIC_PERMIT_TYPE;
			parameters[11].Value = model.UPDATE_TIME;
			parameters[12].Value = model.UPDATE_USERID;

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
		public bool Update(Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_TRAFFIC_PERMIT_TYPE set ");
			strSql.Append("ACCESS_CHANNEL_CODE=@ACCESS_CHANNEL_CODE,");
			strSql.Append("ACCESS_PERMISSIONS=@ACCESS_PERMISSIONS,");
			strSql.Append("CHARGE_TYPE_CODE=@CHARGE_TYPE_CODE,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID,");
			strSql.Append("IDENTITY_NAME=@IDENTITY_NAME,");
			strSql.Append("IS_ENABLE=@IS_ENABLE,");
			strSql.Append("PAY_MONEY=@PAY_MONEY,");
			strSql.Append("TRAFFIC_PERMIT_NAME=@TRAFFIC_PERMIT_NAME,");
			strSql.Append("TRAFFIC_PERMIT_TYPE=@TRAFFIC_PERMIT_TYPE,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("UPDATE_USERID=@UPDATE_USERID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ACCESS_CHANNEL_CODE", SqlDbType.VarChar,500),
					new SqlParameter("@ACCESS_PERMISSIONS", SqlDbType.VarChar,128),
					new SqlParameter("@CHARGE_TYPE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@IDENTITY_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IS_ENABLE", SqlDbType.Int,4),
					new SqlParameter("@PAY_MONEY", SqlDbType.Float,8),
					new SqlParameter("@TRAFFIC_PERMIT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TRAFFIC_PERMIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ACCESS_CHANNEL_CODE;
			parameters[1].Value = model.ACCESS_PERMISSIONS;
			parameters[2].Value = model.CHARGE_TYPE_CODE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_USERID;
			parameters[5].Value = model.IDENTITY_NAME;
			parameters[6].Value = model.IS_ENABLE;
			parameters[7].Value = model.PAY_MONEY;
			parameters[8].Value = model.TRAFFIC_PERMIT_NAME;
			parameters[9].Value = model.TRAFFIC_PERMIT_TYPE;
			parameters[10].Value = model.UPDATE_TIME;
			parameters[11].Value = model.UPDATE_USERID;
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
			strSql.Append("delete from CR_TRAFFIC_PERMIT_TYPE ");
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
			strSql.Append("delete from CR_TRAFFIC_PERMIT_TYPE ");
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
		public Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ACCESS_CHANNEL_CODE,ACCESS_PERMISSIONS,CHARGE_TYPE_CODE,CREATE_TIME,CREATE_USERID,IDENTITY_NAME,IS_ENABLE,PAY_MONEY,TRAFFIC_PERMIT_NAME,TRAFFIC_PERMIT_TYPE,UPDATE_TIME,UPDATE_USERID from CR_TRAFFIC_PERMIT_TYPE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE model=new Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE();
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
		public Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE model=new Parking.Core.Model.CR_TRAFFIC_PERMIT_TYPE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ACCESS_CHANNEL_CODE"]!=null)
				{
					model.ACCESS_CHANNEL_CODE=row["ACCESS_CHANNEL_CODE"].ToString();
				}
				if(row["ACCESS_PERMISSIONS"]!=null)
				{
					model.ACCESS_PERMISSIONS=row["ACCESS_PERMISSIONS"].ToString();
				}
				if(row["CHARGE_TYPE_CODE"]!=null)
				{
					model.CHARGE_TYPE_CODE=row["CHARGE_TYPE_CODE"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
				}
				if(row["IDENTITY_NAME"]!=null)
				{
					model.IDENTITY_NAME=row["IDENTITY_NAME"].ToString();
				}
				if(row["IS_ENABLE"]!=null && row["IS_ENABLE"].ToString()!="")
				{
					model.IS_ENABLE=int.Parse(row["IS_ENABLE"].ToString());
				}
				if(row["PAY_MONEY"]!=null && row["PAY_MONEY"].ToString()!="")
				{
					model.PAY_MONEY=decimal.Parse(row["PAY_MONEY"].ToString());
				}
				if(row["TRAFFIC_PERMIT_NAME"]!=null)
				{
					model.TRAFFIC_PERMIT_NAME=row["TRAFFIC_PERMIT_NAME"].ToString();
				}
				if(row["TRAFFIC_PERMIT_TYPE"]!=null && row["TRAFFIC_PERMIT_TYPE"].ToString()!="")
				{
					model.TRAFFIC_PERMIT_TYPE=int.Parse(row["TRAFFIC_PERMIT_TYPE"].ToString());
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERID"]!=null)
				{
					model.UPDATE_USERID=row["UPDATE_USERID"].ToString();
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
			strSql.Append("select ID,ACCESS_CHANNEL_CODE,ACCESS_PERMISSIONS,CHARGE_TYPE_CODE,CREATE_TIME,CREATE_USERID,IDENTITY_NAME,IS_ENABLE,PAY_MONEY,TRAFFIC_PERMIT_NAME,TRAFFIC_PERMIT_TYPE,UPDATE_TIME,UPDATE_USERID ");
			strSql.Append(" FROM CR_TRAFFIC_PERMIT_TYPE ");
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
			strSql.Append(" ID,ACCESS_CHANNEL_CODE,ACCESS_PERMISSIONS,CHARGE_TYPE_CODE,CREATE_TIME,CREATE_USERID,IDENTITY_NAME,IS_ENABLE,PAY_MONEY,TRAFFIC_PERMIT_NAME,TRAFFIC_PERMIT_TYPE,UPDATE_TIME,UPDATE_USERID ");
			strSql.Append(" FROM CR_TRAFFIC_PERMIT_TYPE ");
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
			strSql.Append("select count(1) FROM CR_TRAFFIC_PERMIT_TYPE ");
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
			strSql.Append(")AS Row, T.*  from CR_TRAFFIC_PERMIT_TYPE T ");
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
			parameters[0].Value = "CR_TRAFFIC_PERMIT_TYPE";
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

