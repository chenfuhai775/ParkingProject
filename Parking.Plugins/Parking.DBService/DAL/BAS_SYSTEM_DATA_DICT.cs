/**  版本信息模板在安装目录下，可自行修改。
* BAS_SYSTEM_DATA_DICT.cs
*
* 功 能： N/A
* 类 名： BAS_SYSTEM_DATA_DICT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:22:59   N/A    初版
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
	/// 数据访问类:BAS_SYSTEM_DATA_DICT
	/// </summary>
	public partial class BAS_SYSTEM_DATA_DICT
	{
		public BAS_SYSTEM_DATA_DICT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_SYSTEM_DATA_DICT");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.BAS_SYSTEM_DATA_DICT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_SYSTEM_DATA_DICT(");
			strSql.Append("ID,BOTT_LEVEL,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MODEL_KEY,MODEL_NAME,MODEL_VALUE,PARENT_MODEL_KEY,REMARK,SORT_NO)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012BOTT_LEVEL,SQL2012CREATE_BY,SQL2012CREATE_TIME,SQL2012LAST_UPDATE_BY,SQL2012LAST_UPDATE_TIME,SQL2012MODEL_KEY,SQL2012MODEL_NAME,SQL2012MODEL_VALUE,SQL2012PARENT_MODEL_KEY,SQL2012REMARK,SQL2012SORT_NO)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012BOTT_LEVEL", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_BY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012LAST_UPDATE_BY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012MODEL_KEY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012MODEL_NAME", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012MODEL_VALUE", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012PARENT_MODEL_KEY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012SORT_NO", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.BOTT_LEVEL;
			parameters[2].Value = model.CREATE_BY;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.LAST_UPDATE_BY;
			parameters[5].Value = model.LAST_UPDATE_TIME;
			parameters[6].Value = model.MODEL_KEY;
			parameters[7].Value = model.MODEL_NAME;
			parameters[8].Value = model.MODEL_VALUE;
			parameters[9].Value = model.PARENT_MODEL_KEY;
			parameters[10].Value = model.REMARK;
			parameters[11].Value = model.SORT_NO;

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
		public bool Update(Parking.Core.Model.BAS_SYSTEM_DATA_DICT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_SYSTEM_DATA_DICT set ");
			strSql.Append("BOTT_LEVEL=SQL2012BOTT_LEVEL,");
			strSql.Append("CREATE_BY=SQL2012CREATE_BY,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("LAST_UPDATE_BY=SQL2012LAST_UPDATE_BY,");
			strSql.Append("LAST_UPDATE_TIME=SQL2012LAST_UPDATE_TIME,");
			strSql.Append("MODEL_KEY=SQL2012MODEL_KEY,");
			strSql.Append("MODEL_NAME=SQL2012MODEL_NAME,");
			strSql.Append("MODEL_VALUE=SQL2012MODEL_VALUE,");
			strSql.Append("PARENT_MODEL_KEY=SQL2012PARENT_MODEL_KEY,");
			strSql.Append("REMARK=SQL2012REMARK,");
			strSql.Append("SORT_NO=SQL2012SORT_NO");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012BOTT_LEVEL", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_BY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012LAST_UPDATE_BY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012MODEL_KEY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012MODEL_NAME", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012MODEL_VALUE", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012PARENT_MODEL_KEY", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012REMARK", SqlDbType.VarChar,255),
					new SqlParameter("SQL2012SORT_NO", SqlDbType.Int,4),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.BOTT_LEVEL;
			parameters[1].Value = model.CREATE_BY;
			parameters[2].Value = model.CREATE_TIME;
			parameters[3].Value = model.LAST_UPDATE_BY;
			parameters[4].Value = model.LAST_UPDATE_TIME;
			parameters[5].Value = model.MODEL_KEY;
			parameters[6].Value = model.MODEL_NAME;
			parameters[7].Value = model.MODEL_VALUE;
			parameters[8].Value = model.PARENT_MODEL_KEY;
			parameters[9].Value = model.REMARK;
			parameters[10].Value = model.SORT_NO;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from BAS_SYSTEM_DATA_DICT ");
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
			strSql.Append("delete from BAS_SYSTEM_DATA_DICT ");
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
		public Parking.Core.Model.BAS_SYSTEM_DATA_DICT GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,BOTT_LEVEL,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MODEL_KEY,MODEL_NAME,MODEL_VALUE,PARENT_MODEL_KEY,REMARK,SORT_NO from BAS_SYSTEM_DATA_DICT ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.BAS_SYSTEM_DATA_DICT model=new Parking.Core.Model.BAS_SYSTEM_DATA_DICT();
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
		public Parking.Core.Model.BAS_SYSTEM_DATA_DICT DataRowToModel(DataRow row)
		{
			Parking.Core.Model.BAS_SYSTEM_DATA_DICT model=new Parking.Core.Model.BAS_SYSTEM_DATA_DICT();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["BOTT_LEVEL"]!=null && row["BOTT_LEVEL"].ToString()!="")
				{
					model.BOTT_LEVEL=int.Parse(row["BOTT_LEVEL"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["LAST_UPDATE_BY"]!=null)
				{
					model.LAST_UPDATE_BY=row["LAST_UPDATE_BY"].ToString();
				}
				if(row["LAST_UPDATE_TIME"]!=null && row["LAST_UPDATE_TIME"].ToString()!="")
				{
					model.LAST_UPDATE_TIME=DateTime.Parse(row["LAST_UPDATE_TIME"].ToString());
				}
				if(row["MODEL_KEY"]!=null)
				{
					model.MODEL_KEY=row["MODEL_KEY"].ToString();
				}
				if(row["MODEL_NAME"]!=null)
				{
					model.MODEL_NAME=row["MODEL_NAME"].ToString();
				}
				if(row["MODEL_VALUE"]!=null)
				{
					model.MODEL_VALUE=row["MODEL_VALUE"].ToString();
				}
				if(row["PARENT_MODEL_KEY"]!=null)
				{
					model.PARENT_MODEL_KEY=row["PARENT_MODEL_KEY"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["SORT_NO"]!=null && row["SORT_NO"].ToString()!="")
				{
					model.SORT_NO=int.Parse(row["SORT_NO"].ToString());
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
			strSql.Append("select ID,BOTT_LEVEL,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MODEL_KEY,MODEL_NAME,MODEL_VALUE,PARENT_MODEL_KEY,REMARK,SORT_NO ");
			strSql.Append(" FROM BAS_SYSTEM_DATA_DICT ");
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
			strSql.Append(" ID,BOTT_LEVEL,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,MODEL_KEY,MODEL_NAME,MODEL_VALUE,PARENT_MODEL_KEY,REMARK,SORT_NO ");
			strSql.Append(" FROM BAS_SYSTEM_DATA_DICT ");
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
			strSql.Append("select count(1) FROM BAS_SYSTEM_DATA_DICT ");
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
			strSql.Append(")AS Row, T.*  from BAS_SYSTEM_DATA_DICT T ");
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
			parameters[0].Value = "BAS_SYSTEM_DATA_DICT";
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
        /// 获取字典信息
        /// </summary>
        /// <param name="ModelKey"></param>
        /// <returns></returns>
        public DataSet GetListByParentModelKey(string ModelKey)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT * FROM dbo.BAS_SYSTEM_DATA_DICT WHERE PARENT_MODEL_KEY = '{0}' ORDER BY SORT_NO ", ModelKey);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

