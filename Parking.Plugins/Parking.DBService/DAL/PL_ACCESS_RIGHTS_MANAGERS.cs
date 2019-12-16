/**  版本信息模板在安装目录下，可自行修改。
* PL_ACCESS_RIGHTS_MANAGERS.cs
*
* 功 能： N/A
* 类 名： PL_ACCESS_RIGHTS_MANAGERS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:18   N/A    初版
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
	/// 数据访问类:PL_ACCESS_RIGHTS_MANAGERS
	/// </summary>
	public partial class PL_ACCESS_RIGHTS_MANAGERS
	{
		public PL_ACCESS_RIGHTS_MANAGERS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PL_ACCESS_RIGHTS_MANAGERS");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PL_ACCESS_RIGHTS_MANAGERS(");
			strSql.Append("ID,VEHICLE_NO,BEGIN_TIME,END_TIME,ACCREDIT_NUMBER,ACCREDIT_REMARK,ACCREDIT_TYPE,SPEECH_CONTENT,LED_CONTENT,CREATE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,TIMEOUT_BILING,ACCESS_PERMISSIONS,ACCESS_CHANNEL_CODE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@VEHICLE_NO,@BEGIN_TIME,@END_TIME,@ACCREDIT_NUMBER,@ACCREDIT_REMARK,@ACCREDIT_TYPE,@SPEECH_CONTENT,@LED_CONTENT,@CREATE_TIME,@CREATE_USERID,@UPDATE_TIME,@UPDATE_USERID,@TIMEOUT_BILING,@ACCESS_PERMISSIONS,@ACCESS_CHANNEL_CODE)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCREDIT_NUMBER", SqlDbType.Int,4),
					new SqlParameter("@ACCREDIT_REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@ACCREDIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@SPEECH_CONTENT", SqlDbType.VarChar,500),
					new SqlParameter("@LED_CONTENT", SqlDbType.VarChar,500),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@TIMEOUT_BILING", SqlDbType.Int,4),
					new SqlParameter("@ACCESS_PERMISSIONS", SqlDbType.VarChar,128),
					new SqlParameter("@ACCESS_CHANNEL_CODE", SqlDbType.VarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.BEGIN_TIME;
			parameters[3].Value = model.END_TIME;
			parameters[4].Value = model.ACCREDIT_NUMBER;
			parameters[5].Value = model.ACCREDIT_REMARK;
			parameters[6].Value = model.ACCREDIT_TYPE;
			parameters[7].Value = model.SPEECH_CONTENT;
			parameters[8].Value = model.LED_CONTENT;
			parameters[9].Value = model.CREATE_TIME;
			parameters[10].Value = model.CREATE_USERID;
			parameters[11].Value = model.UPDATE_TIME;
			parameters[12].Value = model.UPDATE_USERID;
			parameters[13].Value = model.TIMEOUT_BILING;
			parameters[14].Value = model.ACCESS_PERMISSIONS;
			parameters[15].Value = model.ACCESS_CHANNEL_CODE;

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
		public bool Update(Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PL_ACCESS_RIGHTS_MANAGERS set ");
			strSql.Append("VEHICLE_NO=@VEHICLE_NO,");
			strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
			strSql.Append("END_TIME=@END_TIME,");
			strSql.Append("ACCREDIT_NUMBER=@ACCREDIT_NUMBER,");
			strSql.Append("ACCREDIT_REMARK=@ACCREDIT_REMARK,");
			strSql.Append("ACCREDIT_TYPE=@ACCREDIT_TYPE,");
			strSql.Append("SPEECH_CONTENT=@SPEECH_CONTENT,");
			strSql.Append("LED_CONTENT=@LED_CONTENT,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("UPDATE_USERID=@UPDATE_USERID,");
			strSql.Append("TIMEOUT_BILING=@TIMEOUT_BILING,");
			strSql.Append("ACCESS_PERMISSIONS=@ACCESS_PERMISSIONS,");
			strSql.Append("ACCESS_CHANNEL_CODE=@ACCESS_CHANNEL_CODE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@ACCREDIT_NUMBER", SqlDbType.Int,4),
					new SqlParameter("@ACCREDIT_REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@ACCREDIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@SPEECH_CONTENT", SqlDbType.VarChar,500),
					new SqlParameter("@LED_CONTENT", SqlDbType.VarChar,500),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@TIMEOUT_BILING", SqlDbType.Int,4),
					new SqlParameter("@ACCESS_PERMISSIONS", SqlDbType.VarChar,128),
					new SqlParameter("@ACCESS_CHANNEL_CODE", SqlDbType.VarChar,500),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.VEHICLE_NO;
			parameters[1].Value = model.BEGIN_TIME;
			parameters[2].Value = model.END_TIME;
			parameters[3].Value = model.ACCREDIT_NUMBER;
			parameters[4].Value = model.ACCREDIT_REMARK;
			parameters[5].Value = model.ACCREDIT_TYPE;
			parameters[6].Value = model.SPEECH_CONTENT;
			parameters[7].Value = model.LED_CONTENT;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.CREATE_USERID;
			parameters[10].Value = model.UPDATE_TIME;
			parameters[11].Value = model.UPDATE_USERID;
			parameters[12].Value = model.TIMEOUT_BILING;
			parameters[13].Value = model.ACCESS_PERMISSIONS;
			parameters[14].Value = model.ACCESS_CHANNEL_CODE;
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
			strSql.Append("delete from PL_ACCESS_RIGHTS_MANAGERS ");
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
			strSql.Append("delete from PL_ACCESS_RIGHTS_MANAGERS ");
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
		public Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,VEHICLE_NO,BEGIN_TIME,END_TIME,ACCREDIT_NUMBER,ACCREDIT_REMARK,ACCREDIT_TYPE,SPEECH_CONTENT,LED_CONTENT,CREATE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,TIMEOUT_BILING,ACCESS_PERMISSIONS,ACCESS_CHANNEL_CODE from PL_ACCESS_RIGHTS_MANAGERS ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model=new Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS();
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
		public Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model=new Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
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
				if(row["ACCREDIT_NUMBER"]!=null && row["ACCREDIT_NUMBER"].ToString()!="")
				{
					model.ACCREDIT_NUMBER=int.Parse(row["ACCREDIT_NUMBER"].ToString());
				}
				if(row["ACCREDIT_REMARK"]!=null)
				{
					model.ACCREDIT_REMARK=row["ACCREDIT_REMARK"].ToString();
				}
				if(row["ACCREDIT_TYPE"]!=null && row["ACCREDIT_TYPE"].ToString()!="")
				{
					model.ACCREDIT_TYPE=int.Parse(row["ACCREDIT_TYPE"].ToString());
				}
				if(row["SPEECH_CONTENT"]!=null)
				{
					model.SPEECH_CONTENT=row["SPEECH_CONTENT"].ToString();
				}
				if(row["LED_CONTENT"]!=null)
				{
					model.LED_CONTENT=row["LED_CONTENT"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERID"]!=null)
				{
					model.UPDATE_USERID=row["UPDATE_USERID"].ToString();
				}
				if(row["TIMEOUT_BILING"]!=null && row["TIMEOUT_BILING"].ToString()!="")
				{
					model.TIMEOUT_BILING=int.Parse(row["TIMEOUT_BILING"].ToString());
				}
				if(row["ACCESS_PERMISSIONS"]!=null)
				{
					model.ACCESS_PERMISSIONS=row["ACCESS_PERMISSIONS"].ToString();
				}
				if(row["ACCESS_CHANNEL_CODE"]!=null)
				{
					model.ACCESS_CHANNEL_CODE=row["ACCESS_CHANNEL_CODE"].ToString();
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
			strSql.Append("select ID,VEHICLE_NO,BEGIN_TIME,END_TIME,ACCREDIT_NUMBER,ACCREDIT_REMARK,ACCREDIT_TYPE,SPEECH_CONTENT,LED_CONTENT,CREATE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,TIMEOUT_BILING,ACCESS_PERMISSIONS,ACCESS_CHANNEL_CODE ");
			strSql.Append(" FROM PL_ACCESS_RIGHTS_MANAGERS ");
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
			strSql.Append(" ID,VEHICLE_NO,BEGIN_TIME,END_TIME,ACCREDIT_NUMBER,ACCREDIT_REMARK,ACCREDIT_TYPE,SPEECH_CONTENT,LED_CONTENT,CREATE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,TIMEOUT_BILING,ACCESS_PERMISSIONS,ACCESS_CHANNEL_CODE ");
			strSql.Append(" FROM PL_ACCESS_RIGHTS_MANAGERS ");
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
			strSql.Append("select count(1) FROM PL_ACCESS_RIGHTS_MANAGERS ");
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
			strSql.Append(")AS Row, T.*  from PL_ACCESS_RIGHTS_MANAGERS T ");
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
			parameters[0].Value = "PL_ACCESS_RIGHTS_MANAGERS";
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

