/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_SPACE_MANAGER.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_SPACE_MANAGER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
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
	/// 数据访问类:PBA_PARKING_SPACE_MANAGER
	/// </summary>
	public partial class PBA_PARKING_SPACE_MANAGER
	{
		public PBA_PARKING_SPACE_MANAGER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SPACE_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PBA_PARKING_SPACE_MANAGER");
			strSql.Append(" where SPACE_CODE=@SPACE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SPACE_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PBA_PARKING_SPACE_MANAGER(");
			strSql.Append("SPACE_CODE,INOUT_RECORD_ID,SPACE_STATUS,PARTITION_CODE,SPACE_TYPE,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,REMARK,BEGIN_TIME,END_TIME)");
			strSql.Append(" values (");
			strSql.Append("@SPACE_CODE,@INOUT_RECORD_ID,@SPACE_STATUS,@PARTITION_CODE,@SPACE_TYPE,@CREATE_TIME,@CREATE_USERNAME,@UPDATE_TIME,@UPDATE_USERNAME,@REMARK,@BEGIN_TIME,@END_TIME)");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@INOUT_RECORD_ID", SqlDbType.VarChar,32),
					new SqlParameter("@SPACE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime)};
			parameters[0].Value = model.SPACE_CODE;
			parameters[1].Value = model.INOUT_RECORD_ID;
			parameters[2].Value = model.SPACE_STATUS;
			parameters[3].Value = model.PARTITION_CODE;
			parameters[4].Value = model.SPACE_TYPE;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CREATE_USERNAME;
			parameters[7].Value = model.UPDATE_TIME;
			parameters[8].Value = model.UPDATE_USERNAME;
			parameters[9].Value = model.REMARK;
			parameters[10].Value = model.BEGIN_TIME;
			parameters[11].Value = model.END_TIME;

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
		public bool Update(Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PBA_PARKING_SPACE_MANAGER set ");
			strSql.Append("INOUT_RECORD_ID=@INOUT_RECORD_ID,");
			strSql.Append("SPACE_STATUS=@SPACE_STATUS,");
			strSql.Append("PARTITION_CODE=@PARTITION_CODE,");
			strSql.Append("SPACE_TYPE=@SPACE_TYPE,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERNAME=@CREATE_USERNAME,");
			strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
			strSql.Append("UPDATE_USERNAME=@UPDATE_USERNAME,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
			strSql.Append("END_TIME=@END_TIME");
			strSql.Append(" where SPACE_CODE=@SPACE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INOUT_RECORD_ID", SqlDbType.VarChar,32),
					new SqlParameter("@SPACE_STATUS", SqlDbType.Int,4),
					new SqlParameter("@PARTITION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SPACE_TYPE", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@END_TIME", SqlDbType.DateTime),
					new SqlParameter("@SPACE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.INOUT_RECORD_ID;
			parameters[1].Value = model.SPACE_STATUS;
			parameters[2].Value = model.PARTITION_CODE;
			parameters[3].Value = model.SPACE_TYPE;
			parameters[4].Value = model.CREATE_TIME;
			parameters[5].Value = model.CREATE_USERNAME;
			parameters[6].Value = model.UPDATE_TIME;
			parameters[7].Value = model.UPDATE_USERNAME;
			parameters[8].Value = model.REMARK;
			parameters[9].Value = model.BEGIN_TIME;
			parameters[10].Value = model.END_TIME;
			parameters[11].Value = model.SPACE_CODE;

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
		public bool Delete(string SPACE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_PARKING_SPACE_MANAGER ");
			strSql.Append(" where SPACE_CODE=@SPACE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SPACE_CODE;

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
		public bool DeleteList(string SPACE_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PBA_PARKING_SPACE_MANAGER ");
			strSql.Append(" where SPACE_CODE in ("+SPACE_CODElist + ")  ");
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
		public Parking.Core.Model.PBA_PARKING_SPACE_MANAGER GetModel(string SPACE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SPACE_CODE,INOUT_RECORD_ID,SPACE_STATUS,PARTITION_CODE,SPACE_TYPE,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,REMARK,BEGIN_TIME,END_TIME from PBA_PARKING_SPACE_MANAGER ");
			strSql.Append(" where SPACE_CODE=@SPACE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SPACE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = SPACE_CODE;

			Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model=new Parking.Core.Model.PBA_PARKING_SPACE_MANAGER();
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
		public Parking.Core.Model.PBA_PARKING_SPACE_MANAGER DataRowToModel(DataRow row)
		{
			Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model=new Parking.Core.Model.PBA_PARKING_SPACE_MANAGER();
			if (row != null)
			{
				if(row["SPACE_CODE"]!=null)
				{
					model.SPACE_CODE=row["SPACE_CODE"].ToString();
				}
				if(row["INOUT_RECORD_ID"]!=null)
				{
					model.INOUT_RECORD_ID=row["INOUT_RECORD_ID"].ToString();
				}
				if(row["SPACE_STATUS"]!=null && row["SPACE_STATUS"].ToString()!="")
				{
					model.SPACE_STATUS=int.Parse(row["SPACE_STATUS"].ToString());
				}
				if(row["PARTITION_CODE"]!=null)
				{
					model.PARTITION_CODE=row["PARTITION_CODE"].ToString();
				}
				if(row["SPACE_TYPE"]!=null && row["SPACE_TYPE"].ToString()!="")
				{
					model.SPACE_TYPE=int.Parse(row["SPACE_TYPE"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERNAME"]!=null)
				{
					model.CREATE_USERNAME=row["CREATE_USERNAME"].ToString();
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERNAME"]!=null)
				{
					model.UPDATE_USERNAME=row["UPDATE_USERNAME"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["BEGIN_TIME"]!=null && row["BEGIN_TIME"].ToString()!="")
				{
					model.BEGIN_TIME=DateTime.Parse(row["BEGIN_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
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
			strSql.Append("select SPACE_CODE,INOUT_RECORD_ID,SPACE_STATUS,PARTITION_CODE,SPACE_TYPE,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,REMARK,BEGIN_TIME,END_TIME ");
			strSql.Append(" FROM PBA_PARKING_SPACE_MANAGER ");
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
			strSql.Append(" SPACE_CODE,INOUT_RECORD_ID,SPACE_STATUS,PARTITION_CODE,SPACE_TYPE,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,REMARK,BEGIN_TIME,END_TIME ");
			strSql.Append(" FROM PBA_PARKING_SPACE_MANAGER ");
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
			strSql.Append("select count(1) FROM PBA_PARKING_SPACE_MANAGER ");
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
				strSql.Append("order by T.SPACE_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PBA_PARKING_SPACE_MANAGER T ");
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
			parameters[0].Value = "PBA_PARKING_SPACE_MANAGER";
			parameters[1].Value = "SPACE_CODE";
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
        /// 更¨1新?车|ì位?状á??态??
        /// </summary>
        /// <param name="SPACE_CODE"></param>
        /// <param name="STATUS"></param>
        public void UpdateStatus(string SPACE_CODE, int STATUS, string INOUT_RECORD_ID = "")
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PBA_PARKING_SPACE_MANAGER set UPDATE_TIME=GETDATE(),SPACE_STATUS = " + STATUS + " ,INOUT_RECORD_ID = '" + INOUT_RECORD_ID + "' WHERE SPACE_CODE = '" + SPACE_CODE + "'");
            DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获?取¨?车|ì位?信?息?é
        /// </summary>
        /// <param name="SPACE_CODE"></param>
        /// <returns></returns>
        public Parking.Core.Model.PBA_PARKING_SPACE_MANAGER GetModelByINOUTID(string INOUT_RECORD_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SPACE_CODE,INOUT_RECORD_ID,SPACE_STATUS,PARTITION_CODE,SPACE_TYPE,CREATE_TIME,CREATE_USERNAME,UPDATE_TIME,UPDATE_USERNAME,REMARK,BEGIN_TIME,END_TIME from PBA_PARKING_SPACE_MANAGER ");
            strSql.Append(" where INOUT_RECORD_ID=@INOUT_RECORD_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@INOUT_RECORD_ID", SqlDbType.VarChar,50)          };
            parameters[0].Value = INOUT_RECORD_ID;

            Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model = new Parking.Core.Model.PBA_PARKING_SPACE_MANAGER();
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
        /// <summary>
        /// 是o?否¤?有?D剩o?ê余?¨¤车|ì位?
        /// </summary>
        /// <param name="VEHICLENO"></param>
        /// <returns></returns>
        public bool IsSurplus(string VEHICLENO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from PBA_PARKING_SPACE_MANAGER P LEFT JOIN  dbo.CR_OWNER_SPACE_INFO O ON O.SPACE_CODE = P.SPACE_CODE LEFT JOIN dbo.PBA_OWNER_VEHICLE_INFO V ON V.OWNER_CODE = O.OWNER_CODE ");
            strSql.Append(" where p.SPACE_STATUS=0 and v.VEHICLE_NO=@VEHICLE_NO ");
            SqlParameter[] parameters = {
                    new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,50)};
            parameters[0].Value = VEHICLENO;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  ExtensionMethod
    }
}

