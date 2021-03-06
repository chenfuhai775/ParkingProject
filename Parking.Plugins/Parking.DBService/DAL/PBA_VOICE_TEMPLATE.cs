﻿/**  版本信息模板在安装目录下，可自行修改。
* PBA_VOICE_TEMPLATE.cs
*
* 功 能： N/A
* 类 名： PBA_VOICE_TEMPLATE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:17   N/A    初版
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
	/// 数据访问类:PBA_VOICE_TEMPLATE
	/// </summary>
	public partial class PBA_VOICE_TEMPLATE
	{
		public PBA_VOICE_TEMPLATE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_VOICE_TEMPLATE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_VOICE_TEMPLATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_VOICE_TEMPLATE(");
			strSql.Append("ID,CREATE_USER,CREATE_TIME,CUSTOM_MODEL,DEFAULT_INFO,MODEL_TYPE,REMARK,UNIT_TYPE,MODEL_TYPE_KEY,UNIT_TYPE_KEY)");
			strSql.Append(" values (");
			strSql.Append("@ID,@CREATE_USER,@CREATE_TIME,@CUSTOM_MODEL,@DEFAULT_INFO,@MODEL_TYPE,@REMARK,@UNIT_TYPE,@MODEL_TYPE_KEY,@UNIT_TYPE_KEY)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CUSTOM_MODEL", SqlDbType.VarChar,500),
					new SqlParameter("@DEFAULT_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@MODEL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@UNIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@MODEL_TYPE_KEY", SqlDbType.VarChar,100),
					new SqlParameter("@UNIT_TYPE_KEY", SqlDbType.VarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CREATE_USER;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.CUSTOM_MODEL;
			parameters[4].Value = model.DEFAULT_INFO;
			parameters[5].Value = model.MODEL_TYPE;
			parameters[6].Value = model.REMARK;
			parameters[7].Value = model.UNIT_TYPE;
			parameters[8].Value = model.MODEL_TYPE_KEY;
			parameters[9].Value = model.UNIT_TYPE_KEY;

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
		public bool Update(Parking.Core.Model.PBA_VOICE_TEMPLATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_VOICE_TEMPLATE set ");
			strSql.Append("CREATE_USER=@CREATE_USER,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CUSTOM_MODEL=@CUSTOM_MODEL,");
			strSql.Append("DEFAULT_INFO=@DEFAULT_INFO,");
			strSql.Append("MODEL_TYPE=@MODEL_TYPE,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("UNIT_TYPE=@UNIT_TYPE,");
			strSql.Append("MODEL_TYPE_KEY=@MODEL_TYPE_KEY,");
			strSql.Append("UNIT_TYPE_KEY=@UNIT_TYPE_KEY");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CREATE_USER", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CUSTOM_MODEL", SqlDbType.VarChar,500),
					new SqlParameter("@DEFAULT_INFO", SqlDbType.VarChar,500),
					new SqlParameter("@MODEL_TYPE", SqlDbType.Int,4),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@UNIT_TYPE", SqlDbType.Int,4),
					new SqlParameter("@MODEL_TYPE_KEY", SqlDbType.VarChar,100),
					new SqlParameter("@UNIT_TYPE_KEY", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.CREATE_USER;
			parameters[1].Value = model.CREATE_TIME;
			parameters[2].Value = model.CUSTOM_MODEL;
			parameters[3].Value = model.DEFAULT_INFO;
			parameters[4].Value = model.MODEL_TYPE;
			parameters[5].Value = model.REMARK;
			parameters[6].Value = model.UNIT_TYPE;
			parameters[7].Value = model.MODEL_TYPE_KEY;
			parameters[8].Value = model.UNIT_TYPE_KEY;
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
			strSql.Append("delete from PBA_VOICE_TEMPLATE ");
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
			strSql.Append("delete from PBA_VOICE_TEMPLATE ");
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
		public Parking.Core.Model.PBA_VOICE_TEMPLATE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CREATE_USER,CREATE_TIME,CUSTOM_MODEL,DEFAULT_INFO,MODEL_TYPE,REMARK,UNIT_TYPE,MODEL_TYPE_KEY,UNIT_TYPE_KEY from PBA_VOICE_TEMPLATE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PBA_VOICE_TEMPLATE model=new Parking.Core.Model.PBA_VOICE_TEMPLATE();
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
		public Parking.Core.Model.PBA_VOICE_TEMPLATE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_VOICE_TEMPLATE model=new Parking.Core.Model.PBA_VOICE_TEMPLATE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CREATE_USER"]!=null)
				{
					model.CREATE_USER=row["CREATE_USER"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CUSTOM_MODEL"]!=null)
				{
					model.CUSTOM_MODEL=row["CUSTOM_MODEL"].ToString();
				}
				if(row["DEFAULT_INFO"]!=null)
				{
					model.DEFAULT_INFO=row["DEFAULT_INFO"].ToString();
				}
				if(row["MODEL_TYPE"]!=null && row["MODEL_TYPE"].ToString()!="")
				{
					model.MODEL_TYPE=int.Parse(row["MODEL_TYPE"].ToString());
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["UNIT_TYPE"]!=null && row["UNIT_TYPE"].ToString()!="")
				{
					model.UNIT_TYPE=int.Parse(row["UNIT_TYPE"].ToString());
				}
				if(row["MODEL_TYPE_KEY"]!=null)
				{
					model.MODEL_TYPE_KEY=row["MODEL_TYPE_KEY"].ToString();
				}
				if(row["UNIT_TYPE_KEY"]!=null)
				{
					model.UNIT_TYPE_KEY=row["UNIT_TYPE_KEY"].ToString();
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
			strSql.Append("select ID,CREATE_USER,CREATE_TIME,CUSTOM_MODEL,DEFAULT_INFO,MODEL_TYPE,REMARK,UNIT_TYPE,MODEL_TYPE_KEY,UNIT_TYPE_KEY ");
			strSql.Append(" FROM PBA_VOICE_TEMPLATE ");
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
			strSql.Append(" ID,CREATE_USER,CREATE_TIME,CUSTOM_MODEL,DEFAULT_INFO,MODEL_TYPE,REMARK,UNIT_TYPE,MODEL_TYPE_KEY,UNIT_TYPE_KEY ");
			strSql.Append(" FROM PBA_VOICE_TEMPLATE ");
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
			strSql.Append("select count(1) FROM PBA_VOICE_TEMPLATE ");
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
			strSql.Append(")AS Row, T.*  from PBA_VOICE_TEMPLATE T ");
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
			parameters[0].Value = "PBA_VOICE_TEMPLATE";
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
        public Parking.Core.Model.PBA_VOICE_TEMPLATE GetModelByType(int MODEL_TYPE, int UNIT_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * FROM PBA_VOICE_TEMPLATE");
            strSql.Append(" where MODEL_TYPE = @MODEL_TYPE ");
            strSql.Append(" AND UNIT_TYPE = @UNIT_TYPE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MODEL_TYPE", SqlDbType.Int,4),
                    new SqlParameter("@UNIT_TYPE", SqlDbType.Int,4) };
            parameters[0].Value = MODEL_TYPE;
            parameters[1].Value = UNIT_TYPE;

            Parking.Core.Model.PBA_VOICE_TEMPLATE model = new Parking.Core.Model.PBA_VOICE_TEMPLATE();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

