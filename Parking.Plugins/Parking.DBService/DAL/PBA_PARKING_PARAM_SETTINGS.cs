/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_PARAM_SETTINGS.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_PARAM_SETTINGS
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
    /// 数据访问类:PBA_PARKING_PARAM_SETTINGS
    /// </summary>
    public partial class PBA_PARKING_PARAM_SETTINGS
    {
        public PBA_PARKING_PARAM_SETTINGS()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PBA_PARKING_PARAM_SETTINGS");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PBA_PARKING_PARAM_SETTINGS(");
            strSql.Append("ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE)");
            strSql.Append(" values (");
            strSql.Append("@ID,@DISPLAY_KEY,@DISPLAY_VALUE,@PARAM_SETTINGS_GROUP,@GROUPING_CODE,@UPDATE_TIME,@UPDATE_USERID,@ORGANIZATION_CODE)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32),
                    new SqlParameter("@DISPLAY_KEY", SqlDbType.VarChar,50),
                    new SqlParameter("@DISPLAY_VALUE", SqlDbType.VarChar,4000),
                    new SqlParameter("@PARAM_SETTINGS_GROUP", SqlDbType.VarChar,50),
                    new SqlParameter("@GROUPING_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DISPLAY_KEY;
            parameters[2].Value = model.DISPLAY_VALUE;
            parameters[3].Value = model.PARAM_SETTINGS_GROUP;
            parameters[4].Value = model.GROUPING_CODE;
            parameters[5].Value = model.UPDATE_TIME;
            parameters[6].Value = model.UPDATE_USERID;
            parameters[7].Value = model.ORGANIZATION_CODE;

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
        /// <summary>
        /// 更¨1新?一°?条??数oy据Y
        /// </summary>
        public bool Update(Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PBA_PARKING_PARAM_SETTINGS set ");
            strSql.Append("DISPLAY_KEY=@DISPLAY_KEY,");
            strSql.Append("DISPLAY_VALUE=@DISPLAY_VALUE,");
            strSql.Append("PARAM_SETTINGS_GROUP=@PARAM_SETTINGS_GROUP,");
            strSql.Append("GROUPING_CODE=@GROUPING_CODE,");
            strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
            strSql.Append("UPDATE_USERID=@UPDATE_USERID,");
            strSql.Append("ORGANIZATION_CODE=@ORGANIZATION_CODE");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@DISPLAY_KEY", SqlDbType.VarChar,50),
                    new SqlParameter("@DISPLAY_VALUE", SqlDbType.VarChar,4000),
                    new SqlParameter("@PARAM_SETTINGS_GROUP", SqlDbType.VarChar,50),
                    new SqlParameter("@GROUPING_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200),
                    new SqlParameter("@ID", SqlDbType.VarChar,32)};
            parameters[0].Value = model.DISPLAY_KEY;
            parameters[1].Value = model.DISPLAY_VALUE;
            parameters[2].Value = model.PARAM_SETTINGS_GROUP;
            parameters[3].Value = model.GROUPING_CODE;
            parameters[4].Value = model.UPDATE_TIME;
            parameters[5].Value = model.UPDATE_USERID;
            parameters[6].Value = model.ORGANIZATION_CODE;
            parameters[7].Value = model.ID;

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

        /// <summary>
        /// 删|?除y一°?条??数oy据Y
        /// </summary>
        public bool Delete(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PBA_PARKING_PARAM_SETTINGS ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

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
        /// <summary>
        /// 批¨2量￠?删|?除y数oy据Y
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PBA_PARKING_PARAM_SETTINGS ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 得ì?到ì?一°?个?对?象¨?实o|ì体??
        /// </summary>
        public Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE from PBA_PARKING_PARAM_SETTINGS ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model = new Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS();
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
        /// 得ì?到ì?一°?个?对?象¨?实o|ì体??
        /// </summary>
        public Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS DataRowToModel(DataRow row)
        {
            Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model = new Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["DISPLAY_KEY"] != null)
                {
                    model.DISPLAY_KEY = row["DISPLAY_KEY"].ToString();
                }
                if (row["DISPLAY_VALUE"] != null)
                {
                    model.DISPLAY_VALUE = row["DISPLAY_VALUE"].ToString();
                }
                if (row["PARAM_SETTINGS_GROUP"] != null)
                {
                    model.PARAM_SETTINGS_GROUP = row["PARAM_SETTINGS_GROUP"].ToString();
                }
                if (row["GROUPING_CODE"] != null)
                {
                    model.GROUPING_CODE = row["GROUPING_CODE"].ToString();
                }
                if (row["UPDATE_TIME"] != null && row["UPDATE_TIME"].ToString() != "")
                {
                    model.UPDATE_TIME = DateTime.Parse(row["UPDATE_TIME"].ToString());
                }
                if (row["UPDATE_USERID"] != null)
                {
                    model.UPDATE_USERID = row["UPDATE_USERID"].ToString();
                }
                if (row["ORGANIZATION_CODE"] != null)
                {
                    model.ORGANIZATION_CODE = row["ORGANIZATION_CODE"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE ");
            strSql.Append(" FROM PBA_PARKING_PARAM_SETTINGS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获?得ì?前??几?行D数oy据Y
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE ");
            strSql.Append(" FROM PBA_PARKING_PARAM_SETTINGS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获?取¨?记?录?总á¨1数oy
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM PBA_PARKING_PARAM_SETTINGS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        /// 分¤?页°3获?取¨?数oy据Y列￠D表à¨a
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from PBA_PARKING_PARAM_SETTINGS T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region  ExtensionMethod
        /// <summary>
        /// 得ì?到ì?一°?个?对?象¨?实o|ì体??
        /// </summary>
        public Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS GetParkingParamByIP(string IP)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE from PBA_PARKING_PARAM_SETTINGS ");
            strSql.Append(" where DISPLAY_VALUE=@DISPLAY_VALUE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@DISPLAY_VALUE", SqlDbType.VarChar,32)
                                        };
            parameters[0].Value = IP;

            Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model = new Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS();
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
        public Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS GetVersionInfo(string organizationCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DISPLAY_KEY,DISPLAY_VALUE,PARAM_SETTINGS_GROUP,GROUPING_CODE,UPDATE_TIME,UPDATE_USERID,ORGANIZATION_CODE from PBA_PARKING_PARAM_SETTINGS ");
            strSql.Append(" where DISPLAY_KEY=@DISPLAY_KEY AND ORGANIZATION_CODE=@ORGANIZATION_CODE");
            SqlParameter[] parameters = {
                    new SqlParameter("@DISPLAY_KEY", SqlDbType.VarChar,4000),
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)};
            parameters[0].Value = "wkVesionNumber";
            parameters[1].Value = organizationCode;
            Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model = new Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS();
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