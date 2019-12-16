/**  版本信息模板在安装目录下，可自行修改。
* UP_DYNAMIC_PARAMETERS_DICT.cs
*
* 功 能： N/A
* 类 名： UP_DYNAMIC_PARAMETERS_DICT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:22   N/A    初版
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
	/// 数据访问类:UP_DYNAMIC_PARAMETERS_DICT
	/// </summary>
	public partial class UP_DYNAMIC_PARAMETERS_DICT
	{
		public UP_DYNAMIC_PARAMETERS_DICT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UP_DYNAMIC_PARAMETERS_DICT");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UP_DYNAMIC_PARAMETERS_DICT(");
			strSql.Append("ID,RESOURCE_CODE,SYSTEN_CODE,SERVICE_CODE,DISPLAY_NAME,FIELD_TYPE,DEFAULT_VAL,FILLING_DICT_CODE,REMARK,CREATE_TIME,CREATE_USERID)");
			strSql.Append(" values (");
			strSql.Append("@ID,@RESOURCE_CODE,@SYSTEN_CODE,@SERVICE_CODE,@DISPLAY_NAME,@FIELD_TYPE,@DEFAULT_VAL,@FILLING_DICT_CODE,@REMARK,@CREATE_TIME,@CREATE_USERID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@SYSTEN_CODE", SqlDbType.VarChar,20),
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DISPLAY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FIELD_TYPE", SqlDbType.Int,4),
					new SqlParameter("@DEFAULT_VAL", SqlDbType.VarChar,200),
					new SqlParameter("@FILLING_DICT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,500),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.RESOURCE_CODE;
			parameters[2].Value = model.SYSTEN_CODE;
			parameters[3].Value = model.SERVICE_CODE;
			parameters[4].Value = model.DISPLAY_NAME;
			parameters[5].Value = model.FIELD_TYPE;
			parameters[6].Value = model.DEFAULT_VAL;
			parameters[7].Value = model.FILLING_DICT_CODE;
			parameters[8].Value = model.REMARK;
			parameters[9].Value = model.CREATE_TIME;
			parameters[10].Value = model.CREATE_USERID;

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
		public bool Update(Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UP_DYNAMIC_PARAMETERS_DICT set ");
			strSql.Append("RESOURCE_CODE=@RESOURCE_CODE,");
			strSql.Append("SYSTEN_CODE=@SYSTEN_CODE,");
			strSql.Append("SERVICE_CODE=@SERVICE_CODE,");
			strSql.Append("DISPLAY_NAME=@DISPLAY_NAME,");
			strSql.Append("FIELD_TYPE=@FIELD_TYPE,");
			strSql.Append("DEFAULT_VAL=@DEFAULT_VAL,");
			strSql.Append("FILLING_DICT_CODE=@FILLING_DICT_CODE,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@SYSTEN_CODE", SqlDbType.VarChar,20),
					new SqlParameter("@SERVICE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DISPLAY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FIELD_TYPE", SqlDbType.Int,4),
					new SqlParameter("@DEFAULT_VAL", SqlDbType.VarChar,200),
					new SqlParameter("@FILLING_DICT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,500),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.RESOURCE_CODE;
			parameters[1].Value = model.SYSTEN_CODE;
			parameters[2].Value = model.SERVICE_CODE;
			parameters[3].Value = model.DISPLAY_NAME;
			parameters[4].Value = model.FIELD_TYPE;
			parameters[5].Value = model.DEFAULT_VAL;
			parameters[6].Value = model.FILLING_DICT_CODE;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.CREATE_USERID;
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
			strSql.Append("delete from UP_DYNAMIC_PARAMETERS_DICT ");
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
			strSql.Append("delete from UP_DYNAMIC_PARAMETERS_DICT ");
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
		public Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,RESOURCE_CODE,SYSTEN_CODE,SERVICE_CODE,DISPLAY_NAME,FIELD_TYPE,DEFAULT_VAL,FILLING_DICT_CODE,REMARK,CREATE_TIME,CREATE_USERID from UP_DYNAMIC_PARAMETERS_DICT ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT model=new Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT();
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
		public Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT DataRowToModel(DataRow row)
		{
			Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT model=new Parking.Core.Model.UP_DYNAMIC_PARAMETERS_DICT();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["RESOURCE_CODE"]!=null)
				{
					model.RESOURCE_CODE=row["RESOURCE_CODE"].ToString();
				}
				if(row["SYSTEN_CODE"]!=null)
				{
					model.SYSTEN_CODE=row["SYSTEN_CODE"].ToString();
				}
				if(row["SERVICE_CODE"]!=null)
				{
					model.SERVICE_CODE=row["SERVICE_CODE"].ToString();
				}
				if(row["DISPLAY_NAME"]!=null)
				{
					model.DISPLAY_NAME=row["DISPLAY_NAME"].ToString();
				}
				if(row["FIELD_TYPE"]!=null && row["FIELD_TYPE"].ToString()!="")
				{
					model.FIELD_TYPE=int.Parse(row["FIELD_TYPE"].ToString());
				}
				if(row["DEFAULT_VAL"]!=null)
				{
					model.DEFAULT_VAL=row["DEFAULT_VAL"].ToString();
				}
				if(row["FILLING_DICT_CODE"]!=null)
				{
					model.FILLING_DICT_CODE=row["FILLING_DICT_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
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
			strSql.Append("select ID,RESOURCE_CODE,SYSTEN_CODE,SERVICE_CODE,DISPLAY_NAME,FIELD_TYPE,DEFAULT_VAL,FILLING_DICT_CODE,REMARK,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM UP_DYNAMIC_PARAMETERS_DICT ");
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
			strSql.Append(" ID,RESOURCE_CODE,SYSTEN_CODE,SERVICE_CODE,DISPLAY_NAME,FIELD_TYPE,DEFAULT_VAL,FILLING_DICT_CODE,REMARK,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM UP_DYNAMIC_PARAMETERS_DICT ");
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
			strSql.Append("select count(1) FROM UP_DYNAMIC_PARAMETERS_DICT ");
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
			strSql.Append(")AS Row, T.*  from UP_DYNAMIC_PARAMETERS_DICT T ");
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
			parameters[0].Value = "UP_DYNAMIC_PARAMETERS_DICT";
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

