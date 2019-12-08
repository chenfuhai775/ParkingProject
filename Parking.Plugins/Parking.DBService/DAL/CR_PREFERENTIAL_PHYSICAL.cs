/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_PHYSICAL.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_PHYSICAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:04   N/A    初版
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
	/// 数据访问类:CR_PREFERENTIAL_PHYSICAL
	/// </summary>
	public partial class CR_PREFERENTIAL_PHYSICAL
	{
		public CR_PREFERENTIAL_PHYSICAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PREFERENTIAL_PHYSICAL");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PREFERENTIAL_PHYSICAL(");
			strSql.Append("ID,PREFERENTIAL_CODE,PREFERENTIA_IDENT,CR_PREFERENTIAL_TYPE,EMPLOY_TYPE,EMPLOY_TIME,CREATE_TIME,CREATE_USER_ID)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012PREFERENTIAL_CODE,SQL2012PREFERENTIA_IDENT,SQL2012CR_PREFERENTIAL_TYPE,SQL2012EMPLOY_TYPE,SQL2012EMPLOY_TIME,SQL2012CREATE_TIME,SQL2012CREATE_USER_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012PREFERENTIAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PREFERENTIA_IDENT", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CR_PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012EMPLOY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012EMPLOY_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USER_ID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PREFERENTIAL_CODE;
			parameters[2].Value = model.PREFERENTIA_IDENT;
			parameters[3].Value = model.CR_PREFERENTIAL_TYPE;
			parameters[4].Value = model.EMPLOY_TYPE;
			parameters[5].Value = model.EMPLOY_TIME;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.CREATE_USER_ID;

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
		public bool Update(Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PREFERENTIAL_PHYSICAL set ");
			strSql.Append("PREFERENTIAL_CODE=SQL2012PREFERENTIAL_CODE,");
			strSql.Append("PREFERENTIA_IDENT=SQL2012PREFERENTIA_IDENT,");
			strSql.Append("CR_PREFERENTIAL_TYPE=SQL2012CR_PREFERENTIAL_TYPE,");
			strSql.Append("EMPLOY_TYPE=SQL2012EMPLOY_TYPE,");
			strSql.Append("EMPLOY_TIME=SQL2012EMPLOY_TIME,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("CREATE_USER_ID=SQL2012CREATE_USER_ID");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012PREFERENTIAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PREFERENTIA_IDENT", SqlDbType.VarChar,200),
					new SqlParameter("SQL2012CR_PREFERENTIAL_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012EMPLOY_TYPE", SqlDbType.Int,4),
					new SqlParameter("SQL2012EMPLOY_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012CREATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.PREFERENTIAL_CODE;
			parameters[1].Value = model.PREFERENTIA_IDENT;
			parameters[2].Value = model.CR_PREFERENTIAL_TYPE;
			parameters[3].Value = model.EMPLOY_TYPE;
			parameters[4].Value = model.EMPLOY_TIME;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CREATE_USER_ID;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from CR_PREFERENTIAL_PHYSICAL ");
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
			strSql.Append("delete from CR_PREFERENTIAL_PHYSICAL ");
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
		public Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PREFERENTIAL_CODE,PREFERENTIA_IDENT,CR_PREFERENTIAL_TYPE,EMPLOY_TYPE,EMPLOY_TIME,CREATE_TIME,CREATE_USER_ID from CR_PREFERENTIAL_PHYSICAL ");
			strSql.Append(" where ID=SQL2012ID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model=new Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL();
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
		public Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL model=new Parking.Core.Model.CR_PREFERENTIAL_PHYSICAL();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["PREFERENTIAL_CODE"]!=null)
				{
					model.PREFERENTIAL_CODE=row["PREFERENTIAL_CODE"].ToString();
				}
				if(row["PREFERENTIA_IDENT"]!=null)
				{
					model.PREFERENTIA_IDENT=row["PREFERENTIA_IDENT"].ToString();
				}
				if(row["CR_PREFERENTIAL_TYPE"]!=null && row["CR_PREFERENTIAL_TYPE"].ToString()!="")
				{
					model.CR_PREFERENTIAL_TYPE=int.Parse(row["CR_PREFERENTIAL_TYPE"].ToString());
				}
				if(row["EMPLOY_TYPE"]!=null && row["EMPLOY_TYPE"].ToString()!="")
				{
					model.EMPLOY_TYPE=int.Parse(row["EMPLOY_TYPE"].ToString());
				}
				if(row["EMPLOY_TIME"]!=null && row["EMPLOY_TIME"].ToString()!="")
				{
					model.EMPLOY_TIME=DateTime.Parse(row["EMPLOY_TIME"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USER_ID"]!=null)
				{
					model.CREATE_USER_ID=row["CREATE_USER_ID"].ToString();
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
			strSql.Append("select ID,PREFERENTIAL_CODE,PREFERENTIA_IDENT,CR_PREFERENTIAL_TYPE,EMPLOY_TYPE,EMPLOY_TIME,CREATE_TIME,CREATE_USER_ID ");
			strSql.Append(" FROM CR_PREFERENTIAL_PHYSICAL ");
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
			strSql.Append(" ID,PREFERENTIAL_CODE,PREFERENTIA_IDENT,CR_PREFERENTIAL_TYPE,EMPLOY_TYPE,EMPLOY_TIME,CREATE_TIME,CREATE_USER_ID ");
			strSql.Append(" FROM CR_PREFERENTIAL_PHYSICAL ");
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
			strSql.Append("select count(1) FROM CR_PREFERENTIAL_PHYSICAL ");
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
			strSql.Append(")AS Row, T.*  from CR_PREFERENTIAL_PHYSICAL T ");
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
			parameters[0].Value = "CR_PREFERENTIAL_PHYSICAL";
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
        /// 获?取¨?优??惠Y券¨?￥号?码?
        /// </summary>
        /// <returns></returns>
        public DataSet GetPhysicalByCodeNo(string Preferentia_Ident)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  a.PREFERENTIAL_CODE ,
                                    a.PREFERENTIA_IDENT ,
                                    b.PREFERENTIAL_NAME ,
                                    b.PREFERENTIAL_TYPE ,
                                    b.PREFERENTIAL_CONTENT,
                                    c.MODEL_NAME,
                                    d.POLICIES_CODE,
                                    d.IS_COMBINATION,
                                    d.CR_LEVEL,
                                    e.POLICIES_NAME
                            FROM    dbo.CR_PREFERENTIAL_PHYSICAL a 
                                    LEFT JOIN dbo.CR_PREFERENTIAL_INFO b ON a.PREFERENTIAL_CODE = b.PREFERENTIAL_CODE
                                    LEFT JOIN (SELECT * FROM dbo.BAS_SYSTEM_DATA_DICT WHERE PARENT_MODEL_KEY ='PREFERENTIAL_TYPE') c ON b.PREFERENTIAL_TYPE = c.MODEL_VALUE
                                    LEFT JOIN CR_PREFERENTIAL_POLICIES_DETAIL d ON b.PREFERENTIAL_CODE = d.CR_PREFERENTIAL_ID
                                    LEFT JOIN CR_PREFERENTIAL_POLICIES e ON d.POLICIES_CODE = e.POLICIES_CODE
                            WHERE   a.EMPLOY_TYPE = 0 AND PREFERENTIA_IDENT = '{0}' ");
            return DbHelperSQL.Query(string.Format(strSql.ToString(), Preferentia_Ident));
        }
        /// <summary>
        /// 获?取¨?优??惠Y券¨?￥号?码?
        /// </summary>
        /// <returns></returns>
        public DataSet GetPhysicalByVehicleNo(string Vehicle_No)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  a.PREFERENTIAL_CODE ,
                                    a.PREFERENTIA_IDENT ,
                                    b.PREFERENTIAL_NAME ,
                                    b.PREFERENTIAL_TYPE ,
                                    b.PREFERENTIAL_CONTENT,
                                    c.MODEL_NAME,
                                    d.POLICIES_CODE,
                                    d.IS_COMBINATION,
                                    d.CR_LEVEL,
                                    e.POLICIES_NAME
                            FROM    dbo.CR_PREFERENTIAL_PHYSICAL a 
                                    LEFT JOIN dbo.CR_PREFERENTIAL_INFO b ON a.PREFERENTIAL_CODE = b.PREFERENTIAL_CODE
                                    LEFT JOIN (SELECT * FROM dbo.BAS_SYSTEM_DATA_DICT WHERE PARENT_MODEL_KEY ='PREFERENTIAL_TYPE') c ON b.PREFERENTIAL_TYPE = c.MODEL_VALUE
                                    LEFT JOIN CR_PREFERENTIAL_POLICIES_DETAIL d ON b.PREFERENTIAL_CODE = d.CR_PREFERENTIAL_ID
                                    LEFT JOIN CR_PREFERENTIAL_POLICIES e ON d.POLICIES_CODE = e.POLICIES_CODE
                            WHERE   a.EMPLOY_TYPE = 0 AND PERMIT_NO ='{0}' ");
            return DbHelperSQL.Query(string.Format(strSql.ToString(), Vehicle_No));
        }
        /// <summary>
        /// 修T改?优??惠Y劵?状á??态??
        /// </summary>
        /// <param name="idEnt"></param>
        /// <returns></returns>
        public bool update(string idEnt, int statues)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CR_PREFERENTIAL_PHYSICAL set EMPLOY_TYPE=@EMPLOY_TYPE");
            strSql.Append(" where PREFERENTIA_IDENT=@PREFERENTIA_IDENT ");
            SqlParameter[] parameters = {
                                            new SqlParameter("@EMPLOY_TYPE", SqlDbType.Int,32),
                                            new SqlParameter("@PREFERENTIA_IDENT", SqlDbType.VarChar,32)
                                        };
            parameters[0].Value = statues;
            parameters[1].Value = idEnt;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
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

