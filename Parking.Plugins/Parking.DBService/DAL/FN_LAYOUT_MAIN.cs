/**  版本信息模板在安装目录下，可自行修改。
* FN_LAYOUT_MAIN.cs
*
* 功 能： N/A
* 类 名： FN_LAYOUT_MAIN
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:07   N/A    初版
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
using Parking.Core;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:FN_LAYOUT_MAIN
	/// </summary>
	public partial class FN_LAYOUT_MAIN
	{
		public FN_LAYOUT_MAIN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FN_LAYOUT_MAIN");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.FN_LAYOUT_MAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FN_LAYOUT_MAIN(");
			strSql.Append("ID,WORKSTATION_ID,RESOLUTION,INITIAL_LEEF_WIDTH,INITIAL_LEEF_HEIGHT,CREATE_TIME,CREATE_USER_ID,PUBLIC_FLAG,BELONG_USER,SELECT_FLAG,WORKSTATION_NAME)");
			strSql.Append(" values (");
			strSql.Append("@ID,@WORKSTATION_ID,@RESOLUTION,@INITIAL_LEEF_WIDTH,@INITIAL_LEEF_HEIGHT,@CREATE_TIME,@CREATE_USER_ID,@PUBLIC_FLAG,@BELONG_USER,@SELECT_FLAG,@WORKSTATION_NAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@WORKSTATION_ID", SqlDbType.VarChar,32),
					new SqlParameter("@RESOLUTION", SqlDbType.VarChar,100),
					new SqlParameter("@INITIAL_LEEF_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEEF_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("@PUBLIC_FLAG", SqlDbType.Int,4),
					new SqlParameter("@BELONG_USER", SqlDbType.VarChar,255),
					new SqlParameter("@SELECT_FLAG", SqlDbType.Int,4),
					new SqlParameter("@WORKSTATION_NAME", SqlDbType.VarChar,255)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.WORKSTATION_ID;
			parameters[2].Value = model.RESOLUTION;
			parameters[3].Value = model.INITIAL_LEEF_WIDTH;
			parameters[4].Value = model.INITIAL_LEEF_HEIGHT;
			parameters[5].Value = model.CREATE_TIME;
			parameters[6].Value = model.CREATE_USER_ID;
			parameters[7].Value = model.PUBLIC_FLAG;
			parameters[8].Value = model.BELONG_USER;
			parameters[9].Value = model.SELECT_FLAG;
			parameters[10].Value = model.WORKSTATION_NAME;

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
		public bool Update(Parking.Core.Model.FN_LAYOUT_MAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FN_LAYOUT_MAIN set ");
			strSql.Append("WORKSTATION_ID=@WORKSTATION_ID,");
			strSql.Append("RESOLUTION=@RESOLUTION,");
			strSql.Append("INITIAL_LEEF_WIDTH=@INITIAL_LEEF_WIDTH,");
			strSql.Append("INITIAL_LEEF_HEIGHT=@INITIAL_LEEF_HEIGHT,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USER_ID=@CREATE_USER_ID,");
			strSql.Append("PUBLIC_FLAG=@PUBLIC_FLAG,");
			strSql.Append("BELONG_USER=@BELONG_USER,");
			strSql.Append("SELECT_FLAG=@SELECT_FLAG,");
			strSql.Append("WORKSTATION_NAME=@WORKSTATION_NAME");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKSTATION_ID", SqlDbType.VarChar,32),
					new SqlParameter("@RESOLUTION", SqlDbType.VarChar,100),
					new SqlParameter("@INITIAL_LEEF_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEEF_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("@PUBLIC_FLAG", SqlDbType.Int,4),
					new SqlParameter("@BELONG_USER", SqlDbType.VarChar,255),
					new SqlParameter("@SELECT_FLAG", SqlDbType.Int,4),
					new SqlParameter("@WORKSTATION_NAME", SqlDbType.VarChar,255),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.WORKSTATION_ID;
			parameters[1].Value = model.RESOLUTION;
			parameters[2].Value = model.INITIAL_LEEF_WIDTH;
			parameters[3].Value = model.INITIAL_LEEF_HEIGHT;
			parameters[4].Value = model.CREATE_TIME;
			parameters[5].Value = model.CREATE_USER_ID;
			parameters[6].Value = model.PUBLIC_FLAG;
			parameters[7].Value = model.BELONG_USER;
			parameters[8].Value = model.SELECT_FLAG;
			parameters[9].Value = model.WORKSTATION_NAME;
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
			strSql.Append("delete from FN_LAYOUT_MAIN ");
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
			strSql.Append("delete from FN_LAYOUT_MAIN ");
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
		public Parking.Core.Model.FN_LAYOUT_MAIN GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,WORKSTATION_ID,RESOLUTION,INITIAL_LEEF_WIDTH,INITIAL_LEEF_HEIGHT,CREATE_TIME,CREATE_USER_ID,PUBLIC_FLAG,BELONG_USER,SELECT_FLAG,WORKSTATION_NAME from FN_LAYOUT_MAIN ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.FN_LAYOUT_MAIN model=new Parking.Core.Model.FN_LAYOUT_MAIN();
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
		public Parking.Core.Model.FN_LAYOUT_MAIN DataRowToModel(DataRow row)
		{
			Parking.Core.Model.FN_LAYOUT_MAIN model=new Parking.Core.Model.FN_LAYOUT_MAIN();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["WORKSTATION_ID"]!=null)
				{
					model.WORKSTATION_ID=row["WORKSTATION_ID"].ToString();
				}
				if(row["RESOLUTION"]!=null)
				{
					model.RESOLUTION=row["RESOLUTION"].ToString();
				}
				if(row["INITIAL_LEEF_WIDTH"]!=null && row["INITIAL_LEEF_WIDTH"].ToString()!="")
				{
					model.INITIAL_LEEF_WIDTH=int.Parse(row["INITIAL_LEEF_WIDTH"].ToString());
				}
				if(row["INITIAL_LEEF_HEIGHT"]!=null && row["INITIAL_LEEF_HEIGHT"].ToString()!="")
				{
					model.INITIAL_LEEF_HEIGHT=int.Parse(row["INITIAL_LEEF_HEIGHT"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USER_ID"]!=null)
				{
					model.CREATE_USER_ID=row["CREATE_USER_ID"].ToString();
				}
				if(row["PUBLIC_FLAG"]!=null && row["PUBLIC_FLAG"].ToString()!="")
				{
					model.PUBLIC_FLAG=int.Parse(row["PUBLIC_FLAG"].ToString());
				}
				if(row["BELONG_USER"]!=null)
				{
					model.BELONG_USER=row["BELONG_USER"].ToString();
				}
				if(row["SELECT_FLAG"]!=null && row["SELECT_FLAG"].ToString()!="")
				{
					model.SELECT_FLAG=int.Parse(row["SELECT_FLAG"].ToString());
				}
				if(row["WORKSTATION_NAME"]!=null)
				{
					model.WORKSTATION_NAME=row["WORKSTATION_NAME"].ToString();
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
			strSql.Append("select ID,WORKSTATION_ID,RESOLUTION,INITIAL_LEEF_WIDTH,INITIAL_LEEF_HEIGHT,CREATE_TIME,CREATE_USER_ID,PUBLIC_FLAG,BELONG_USER,SELECT_FLAG,WORKSTATION_NAME ");
			strSql.Append(" FROM FN_LAYOUT_MAIN ");
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
			strSql.Append(" ID,WORKSTATION_ID,RESOLUTION,INITIAL_LEEF_WIDTH,INITIAL_LEEF_HEIGHT,CREATE_TIME,CREATE_USER_ID,PUBLIC_FLAG,BELONG_USER,SELECT_FLAG,WORKSTATION_NAME ");
			strSql.Append(" FROM FN_LAYOUT_MAIN ");
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
			strSql.Append("select count(1) FROM FN_LAYOUT_MAIN ");
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
			strSql.Append(")AS Row, T.*  from FN_LAYOUT_MAIN T ");
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
			parameters[0].Value = "FN_LAYOUT_MAIN";
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
        /// 获?取¨?配?置?信?息?é
        /// </summary>
        /// <param name="strIP"></param>
        /// <returns></returns>
        public Parking.Core.Model.FN_LAYOUT_MAIN GetLayOutByIP(string strIP)
        {
            string strSQL = @"SELECT TOP 1  *
                                FROM    dbo.FN_LAYOUT_MAIN
                                WHERE   WORKSTATION_ID = ( SELECT TOP 1 ORGANIZATION_CODE
                                                             FROM   dbo.PBA_PARKING_PARAM_SETTINGS
                                                             WHERE  DISPLAY_KEY = 'ip'
                                                                    AND DISPLAY_VALUE = '{0}'
                                                           ) AND SELECT_FLAG = 1 AND BELONG_USER = '{1}' ";
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format(strSQL, strIP, GlobalEnvironment.LocalUserInfo.USER_ID));
            Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model = new Parking.Core.Model.FN_WORKSTATION_UI_CONFIG();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());

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
        /// 获?取¨?配?置?信?息?é
        /// </summary>
        /// <param name="strIP"></param>
        /// <returns></returns>
        public Parking.Core.Model.FN_LAYOUT_MAIN GetLayOutByWORKSTATION(string strIP)
        {
            string strSQL = @"SELECT TOP 1  *
                                FROM    dbo.FN_LAYOUT_MAIN
                                WHERE   WORKSTATION_ID = ( SELECT ORGANIZATION_CODE
                                                             FROM   dbo.PBA_PARKING_PARAM_SETTINGS
                                                             WHERE  DISPLAY_KEY = 'ip'
                                                                    AND DISPLAY_VALUE = '{0}'
                                                           ) AND SELECT_FLAG = 1 AND BELONG_USER IS NULL";
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format(strSQL, strIP, GlobalEnvironment.LocalUserInfo.USER_ID));
            Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model = new Parking.Core.Model.FN_WORKSTATION_UI_CONFIG();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());

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

