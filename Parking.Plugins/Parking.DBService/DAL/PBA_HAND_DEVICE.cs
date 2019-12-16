/**  版本信息模板在安装目录下，可自行修改。
* PBA_HAND_DEVICE.cs
*
* 功 能： N/A
* 类 名： PBA_HAND_DEVICE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:11   N/A    初版
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
	/// 数据访问类:PBA_HAND_DEVICE
	/// </summary>
	public partial class PBA_HAND_DEVICE
	{
		public PBA_HAND_DEVICE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_HAND_DEVICE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,40)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_HAND_DEVICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_HAND_DEVICE(");
			strSql.Append("ID,CREATE_BY,CREATE_TIME,DEVICE_CODE,DEVICE_NAME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MAC_ADDRESS,REMARK,SOFTWARE_VERSION,STATUS)");
			strSql.Append(" values (");
			strSql.Append("@ID,@CREATE_BY,@CREATE_TIME,@DEVICE_CODE,@DEVICE_NAME,@LAST_UPDATE_BY,@LAST_UPDATE_TIME,@MAC_ADDRESS,@REMARK,@SOFTWARE_VERSION,@STATUS)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@DEVICE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@DEVICE_NAME", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@MAC_ADDRESS", SqlDbType.VarChar,40),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@SOFTWARE_VERSION", SqlDbType.VarChar,40),
					new SqlParameter("@STATUS", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CREATE_BY;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.DEVICE_CODE;
			parameters[4].Value = model.DEVICE_NAME;
			parameters[5].Value = model.LAST_UPDATE_BY;
			parameters[6].Value = model.LAST_UPDATE_TIME;
			parameters[7].Value = model.MAC_ADDRESS;
			parameters[8].Value = model.REMARK;
			parameters[9].Value = model.SOFTWARE_VERSION;
			parameters[10].Value = model.STATUS;

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
		public bool Update(Parking.Core.Model.PBA_HAND_DEVICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_HAND_DEVICE set ");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("DEVICE_CODE=@DEVICE_CODE,");
			strSql.Append("DEVICE_NAME=@DEVICE_NAME,");
			strSql.Append("LAST_UPDATE_BY=@LAST_UPDATE_BY,");
			strSql.Append("LAST_UPDATE_TIME=@LAST_UPDATE_TIME,");
			strSql.Append("MAC_ADDRESS=@MAC_ADDRESS,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("SOFTWARE_VERSION=@SOFTWARE_VERSION,");
			strSql.Append("STATUS=@STATUS");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CREATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@DEVICE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@DEVICE_NAME", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@MAC_ADDRESS", SqlDbType.VarChar,40),
					new SqlParameter("@REMARK", SqlDbType.VarChar,2000),
					new SqlParameter("@SOFTWARE_VERSION", SqlDbType.VarChar,40),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,40)};
			parameters[0].Value = model.CREATE_BY;
			parameters[1].Value = model.CREATE_TIME;
			parameters[2].Value = model.DEVICE_CODE;
			parameters[3].Value = model.DEVICE_NAME;
			parameters[4].Value = model.LAST_UPDATE_BY;
			parameters[5].Value = model.LAST_UPDATE_TIME;
			parameters[6].Value = model.MAC_ADDRESS;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.SOFTWARE_VERSION;
			parameters[9].Value = model.STATUS;
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
			strSql.Append("delete from PBA_HAND_DEVICE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,40)			};
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
			strSql.Append("delete from PBA_HAND_DEVICE ");
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
		public Parking.Core.Model.PBA_HAND_DEVICE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CREATE_BY,CREATE_TIME,DEVICE_CODE,DEVICE_NAME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MAC_ADDRESS,REMARK,SOFTWARE_VERSION,STATUS from PBA_HAND_DEVICE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,40)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_HAND_DEVICE model=new Parking.Core.Model.PBA_HAND_DEVICE();
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
		public Parking.Core.Model.PBA_HAND_DEVICE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_HAND_DEVICE model=new Parking.Core.Model.PBA_HAND_DEVICE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["DEVICE_CODE"]!=null)
				{
					model.DEVICE_CODE=row["DEVICE_CODE"].ToString();
				}
				if(row["DEVICE_NAME"]!=null)
				{
					model.DEVICE_NAME=row["DEVICE_NAME"].ToString();
				}
				if(row["LAST_UPDATE_BY"]!=null)
				{
					model.LAST_UPDATE_BY=row["LAST_UPDATE_BY"].ToString();
				}
				if(row["LAST_UPDATE_TIME"]!=null && row["LAST_UPDATE_TIME"].ToString()!="")
				{
					model.LAST_UPDATE_TIME=DateTime.Parse(row["LAST_UPDATE_TIME"].ToString());
				}
				if(row["MAC_ADDRESS"]!=null)
				{
					model.MAC_ADDRESS=row["MAC_ADDRESS"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["SOFTWARE_VERSION"]!=null)
				{
					model.SOFTWARE_VERSION=row["SOFTWARE_VERSION"].ToString();
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(row["STATUS"].ToString());
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
			strSql.Append("select ID,CREATE_BY,CREATE_TIME,DEVICE_CODE,DEVICE_NAME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MAC_ADDRESS,REMARK,SOFTWARE_VERSION,STATUS ");
			strSql.Append(" FROM PBA_HAND_DEVICE ");
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
			strSql.Append(" ID,CREATE_BY,CREATE_TIME,DEVICE_CODE,DEVICE_NAME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MAC_ADDRESS,REMARK,SOFTWARE_VERSION,STATUS ");
			strSql.Append(" FROM PBA_HAND_DEVICE ");
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
			strSql.Append("select count(1) FROM PBA_HAND_DEVICE ");
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
			strSql.Append(")AS Row, T.*  from PBA_HAND_DEVICE T ");
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
			parameters[0].Value = "PBA_HAND_DEVICE";
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

