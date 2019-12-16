/**  版本信息模板在安装目录下，可自行修改。
* PL_BLACK_WHITE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PL_BLACK_WHITE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:19   N/A    初版
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
	/// 数据访问类:PL_BLACK_WHITE_MANAGER
	/// </summary>
	public partial class PL_BLACK_WHITE_MANAGER
	{
		public PL_BLACK_WHITE_MANAGER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PL_BLACK_WHITE_MANAGER");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PL_BLACK_WHITE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PL_BLACK_WHITE_MANAGER(");
			strSql.Append("UNIQUE_IDENTIFIER,VEHICLE_NO,DATA_TYPE,CREATE_TIME,CREATE_ID,ID,CUSTOMER_ID,REMARK,TAKE_UP_SPACES)");
			strSql.Append(" values (");
			strSql.Append("@UNIQUE_IDENTIFIER,@VEHICLE_NO,@DATA_TYPE,@CREATE_TIME,@CREATE_ID,@ID,@CUSTOMER_ID,@REMARK,@TAKE_UP_SPACES)");
			SqlParameter[] parameters = {
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@DATA_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_ID", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@CUSTOMER_ID", SqlDbType.VarChar,100),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@TAKE_UP_SPACES", SqlDbType.Int,4)};
			parameters[0].Value = model.UNIQUE_IDENTIFIER;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.DATA_TYPE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_ID;
			parameters[5].Value = model.ID;
			parameters[6].Value = model.CUSTOMER_ID;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.TAKE_UP_SPACES;

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
		public bool Update(Parking.Core.Model.PL_BLACK_WHITE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PL_BLACK_WHITE_MANAGER set ");
			strSql.Append("UNIQUE_IDENTIFIER=@UNIQUE_IDENTIFIER,");
			strSql.Append("VEHICLE_NO=@VEHICLE_NO,");
			strSql.Append("DATA_TYPE=@DATA_TYPE,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_ID=@CREATE_ID,");
			strSql.Append("CUSTOMER_ID=@CUSTOMER_ID,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("TAKE_UP_SPACES=@TAKE_UP_SPACES");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UNIQUE_IDENTIFIER", SqlDbType.VarChar,100),
					new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
					new SqlParameter("@DATA_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_ID", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOMER_ID", SqlDbType.VarChar,100),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@TAKE_UP_SPACES", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.UNIQUE_IDENTIFIER;
			parameters[1].Value = model.VEHICLE_NO;
			parameters[2].Value = model.DATA_TYPE;
			parameters[3].Value = model.CREATE_TIME;
			parameters[4].Value = model.CREATE_ID;
			parameters[5].Value = model.CUSTOMER_ID;
			parameters[6].Value = model.REMARK;
			parameters[7].Value = model.TAKE_UP_SPACES;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from PL_BLACK_WHITE_MANAGER ");
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
			strSql.Append("delete from PL_BLACK_WHITE_MANAGER ");
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
		public Parking.Core.Model.PL_BLACK_WHITE_MANAGER GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UNIQUE_IDENTIFIER,VEHICLE_NO,DATA_TYPE,CREATE_TIME,CREATE_ID,ID,CUSTOMER_ID,REMARK,TAKE_UP_SPACES from PL_BLACK_WHITE_MANAGER ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.PL_BLACK_WHITE_MANAGER model=new Parking.Core.Model.PL_BLACK_WHITE_MANAGER();
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
		public Parking.Core.Model.PL_BLACK_WHITE_MANAGER DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PL_BLACK_WHITE_MANAGER model=new Parking.Core.Model.PL_BLACK_WHITE_MANAGER();
			if (row != null)
			{
				if(row["UNIQUE_IDENTIFIER"]!=null)
				{
					model.UNIQUE_IDENTIFIER=row["UNIQUE_IDENTIFIER"].ToString();
				}
				if(row["VEHICLE_NO"]!=null)
				{
					model.VEHICLE_NO=row["VEHICLE_NO"].ToString();
				}
				if(row["DATA_TYPE"]!=null && row["DATA_TYPE"].ToString()!="")
				{
					model.DATA_TYPE=int.Parse(row["DATA_TYPE"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_ID"]!=null)
				{
					model.CREATE_ID=row["CREATE_ID"].ToString();
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CUSTOMER_ID"]!=null)
				{
					model.CUSTOMER_ID=row["CUSTOMER_ID"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["TAKE_UP_SPACES"]!=null && row["TAKE_UP_SPACES"].ToString()!="")
				{
					model.TAKE_UP_SPACES=int.Parse(row["TAKE_UP_SPACES"].ToString());
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
			strSql.Append("select UNIQUE_IDENTIFIER,VEHICLE_NO,DATA_TYPE,CREATE_TIME,CREATE_ID,ID,CUSTOMER_ID,REMARK,TAKE_UP_SPACES ");
			strSql.Append(" FROM PL_BLACK_WHITE_MANAGER ");
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
			strSql.Append(" UNIQUE_IDENTIFIER,VEHICLE_NO,DATA_TYPE,CREATE_TIME,CREATE_ID,ID,CUSTOMER_ID,REMARK,TAKE_UP_SPACES ");
			strSql.Append(" FROM PL_BLACK_WHITE_MANAGER ");
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
			strSql.Append("select count(1) FROM PL_BLACK_WHITE_MANAGER ");
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
			strSql.Append(")AS Row, T.*  from PL_BLACK_WHITE_MANAGER T ");
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
			parameters[0].Value = "PL_BLACK_WHITE_MANAGER";
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
        ///  获?取¨?车|ì牌?鉴?权¨?§
        /// </summary>
        /// <param name="vehicle_no"></param>
        /// <returns></returns>
        internal int getVEHICLE_NOType(string vehicle_no)
        {
            string strSql = "select DATA_TYPE from PL_BLACK_WHITE_MANAGER where VEHICLE_NO = '" + vehicle_no + "'";
            object obj = DbHelperSQL.GetSingle(strSql) ?? 0;
            return Convert.ToInt32(obj);
        }
        #endregion  ExtensionMethod
    }
}

