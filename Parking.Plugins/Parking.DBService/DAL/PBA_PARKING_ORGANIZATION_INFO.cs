/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_ORGANIZATION_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_ORGANIZATION_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:14   N/A    初版
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
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
using Parking.Core.Oragnization;
using Parking.Core.Enum;
namespace Parking.DBService.DAL
{
    /// <summary>
    /// 数据访问类:PBA_PARKING_ORGANIZATION_INFO
    /// </summary>
    public partial class PBA_PARKING_ORGANIZATION_INFO
    {
        public PBA_PARKING_ORGANIZATION_INFO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ORGANIZATION_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PBA_PARKING_ORGANIZATION_INFO");
            strSql.Append(" where ORGANIZATION_CODE=@ORGANIZATION_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)           };
            parameters[0].Value = ORGANIZATION_CODE;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PBA_PARKING_ORGANIZATION_INFO(");
            strSql.Append("ORGANIZATION_CODE,CREATE_TIME,CREATE_USERNAME,ORG_LEVEL,ORGANIZATION_NAME,ORGANIZATION_TYPE_CODE,PARENT_CODE,UPDATE_TIME,UPDATE_USERNAME)");
            strSql.Append(" values (");
            strSql.Append("@ORGANIZATION_CODE,@CREATE_TIME,@CREATE_USERNAME,@ORG_LEVEL,@ORGANIZATION_NAME,@ORGANIZATION_TYPE_CODE,@PARENT_CODE,@UPDATE_TIME,@UPDATE_USERNAME)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200),
                    new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERNAME", SqlDbType.VarChar,50),
                    new SqlParameter("@ORG_LEVEL", SqlDbType.Int,4),
                    new SqlParameter("@ORGANIZATION_NAME", SqlDbType.VarChar,100),
                    new SqlParameter("@ORGANIZATION_TYPE_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@PARENT_CODE", SqlDbType.VarChar,255),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERNAME", SqlDbType.VarChar,50)};
            parameters[0].Value = model.ORGANIZATION_CODE;
            parameters[1].Value = model.CREATE_TIME;
            parameters[2].Value = model.CREATE_USERNAME;
            parameters[3].Value = model.ORG_LEVEL;
            parameters[4].Value = model.ORGANIZATION_NAME;
            parameters[5].Value = model.ORGANIZATION_TYPE_CODE;
            parameters[6].Value = model.PARENT_CODE;
            parameters[7].Value = model.UPDATE_TIME;
            parameters[8].Value = model.UPDATE_USERNAME;

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
        public bool Update(Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PBA_PARKING_ORGANIZATION_INFO set ");
            strSql.Append("CREATE_TIME=@CREATE_TIME,");
            strSql.Append("CREATE_USERNAME=@CREATE_USERNAME,");
            strSql.Append("ORG_LEVEL=@ORG_LEVEL,");
            strSql.Append("ORGANIZATION_NAME=@ORGANIZATION_NAME,");
            strSql.Append("ORGANIZATION_TYPE_CODE=@ORGANIZATION_TYPE_CODE,");
            strSql.Append("PARENT_CODE=@PARENT_CODE,");
            strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
            strSql.Append("UPDATE_USERNAME=@UPDATE_USERNAME");
            strSql.Append(" where ORGANIZATION_CODE=@ORGANIZATION_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERNAME", SqlDbType.VarChar,50),
                    new SqlParameter("@ORG_LEVEL", SqlDbType.Int,4),
                    new SqlParameter("@ORGANIZATION_NAME", SqlDbType.VarChar,100),
                    new SqlParameter("@ORGANIZATION_TYPE_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@PARENT_CODE", SqlDbType.VarChar,255),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERNAME", SqlDbType.VarChar,50),
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)};
            parameters[0].Value = model.CREATE_TIME;
            parameters[1].Value = model.CREATE_USERNAME;
            parameters[2].Value = model.ORG_LEVEL;
            parameters[3].Value = model.ORGANIZATION_NAME;
            parameters[4].Value = model.ORGANIZATION_TYPE_CODE;
            parameters[5].Value = model.PARENT_CODE;
            parameters[6].Value = model.UPDATE_TIME;
            parameters[7].Value = model.UPDATE_USERNAME;
            parameters[8].Value = model.ORGANIZATION_CODE;

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
        public bool Delete(string ORGANIZATION_CODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PBA_PARKING_ORGANIZATION_INFO ");
            strSql.Append(" where ORGANIZATION_CODE=@ORGANIZATION_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)           };
            parameters[0].Value = ORGANIZATION_CODE;

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
        public bool DeleteList(string ORGANIZATION_CODElist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PBA_PARKING_ORGANIZATION_INFO ");
            strSql.Append(" where ORGANIZATION_CODE in (" + ORGANIZATION_CODElist + ")  ");
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
        public Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO GetModel(string ORGANIZATION_CODE = "-1")
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ORGANIZATION_CODE,CREATE_TIME,CREATE_USERNAME,ORG_LEVEL,ORGANIZATION_NAME,ORGANIZATION_TYPE_CODE,PARENT_CODE,UPDATE_TIME,UPDATE_USERNAME from PBA_PARKING_ORGANIZATION_INFO ");
            strSql.Append(" where ORGANIZATION_CODE=@ORGANIZATION_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ORGANIZATION_CODE", SqlDbType.VarChar,200)           };
            parameters[0].Value = ORGANIZATION_CODE;

            Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model = new Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO();
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
        /// 得ì?到ì?对?象¨?实o|ì体?? 集?￥合?
        /// </summary>
        public List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> GetModelList(string PARENT_CODE = "-1")
        {
            List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> list = new List<Core.Model.PBA_PARKING_ORGANIZATION_INFO>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ORGANIZATION_CODE,CREATE_TIME,CREATE_USERNAME,ORG_LEVEL,ORGANIZATION_NAME,ORGANIZATION_TYPE_CODE,PARENT_CODE,UPDATE_TIME,UPDATE_USERNAME from PBA_PARKING_ORGANIZATION_INFO ");
            strSql.Append(" where PARENT_CODE=@PARENT_CODE ");
            SqlParameter[] parameters = {
                    new SqlParameter("@PARENT_CODE", SqlDbType.VarChar,200)         };
            parameters[0].Value = PARENT_CODE;

            Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model = new Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    var temp = DataRowToModel(dr);
                    list.Add(temp);
                }
            }
            else
            {
                return null;
            }
            return list;
        }

        /// <summary>
        /// 得ì?到ì?一°?个?对?象¨?实o|ì体??
        /// </summary>
        public Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO DataRowToModel(DataRow row)
        {
            Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO model = new Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO();
            if (row != null)
            {
                if (row["ORGANIZATION_CODE"] != null)
                {
                    model.ORGANIZATION_CODE = row["ORGANIZATION_CODE"].ToString();
                }
                if (row["CREATE_TIME"] != null && row["CREATE_TIME"].ToString() != "")
                {
                    model.CREATE_TIME = DateTime.Parse(row["CREATE_TIME"].ToString());
                }
                if (row["CREATE_USERNAME"] != null)
                {
                    model.CREATE_USERNAME = row["CREATE_USERNAME"].ToString();
                }
                if (row["ORG_LEVEL"] != null && row["ORG_LEVEL"].ToString() != "")
                {
                    model.ORG_LEVEL = int.Parse(row["ORG_LEVEL"].ToString());
                }
                if (row["ORGANIZATION_NAME"] != null)
                {
                    model.ORGANIZATION_NAME = row["ORGANIZATION_NAME"].ToString();
                }
                if (row["ORGANIZATION_TYPE_CODE"] != null)
                {
                    model.ORGANIZATION_TYPE_CODE = row["ORGANIZATION_TYPE_CODE"].ToString();
                }
                if (row["PARENT_CODE"] != null)
                {
                    model.PARENT_CODE = row["PARENT_CODE"].ToString();
                }
                if (row["UPDATE_TIME"] != null && row["UPDATE_TIME"].ToString() != "")
                {
                    model.UPDATE_TIME = DateTime.Parse(row["UPDATE_TIME"].ToString());
                }
                if (row["UPDATE_USERNAME"] != null)
                {
                    model.UPDATE_USERNAME = row["UPDATE_USERNAME"].ToString();
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
            strSql.Append("select ORGANIZATION_CODE,CREATE_TIME,CREATE_USERNAME,ORG_LEVEL,ORGANIZATION_NAME,ORGANIZATION_TYPE_CODE,PARENT_CODE,UPDATE_TIME,UPDATE_USERNAME ");
            strSql.Append(" FROM PBA_PARKING_ORGANIZATION_INFO ");
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
            strSql.Append(" ORGANIZATION_CODE,CREATE_TIME,CREATE_USERNAME,ORG_LEVEL,ORGANIZATION_NAME,ORGANIZATION_TYPE_CODE,PARENT_CODE,UPDATE_TIME,UPDATE_USERNAME ");
            strSql.Append(" FROM PBA_PARKING_ORGANIZATION_INFO ");
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
            strSql.Append("select count(1) FROM PBA_PARKING_ORGANIZATION_INFO ");
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
                strSql.Append("order by T.ORGANIZATION_CODE desc");
            }
            strSql.Append(")AS Row, T.*  from PBA_PARKING_ORGANIZATION_INFO T ");
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
        public List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> GetList(string storedProcName, IDataParameter[] parameters, string TableName)
        {
            List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> list = new List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO>();
            DataSet ds = DbHelperSQL.RunProcedure(storedProcName, parameters, TableName);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO temp = DataRowToModel(dr);
                    list.Add(temp);
                }
            }
            return list;
        }
        /// <summary>
        /// 获?得ì?数oy簓y据Y列￠D表à¨a括¤?§
        /// </summary>
        public DataSet GetType(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT TOP 1 * 
                            FROM    PBA_PARKING_PARAM_SETTINGS t1
                                    INNER JOIN PBA_DEVICE_MANAGER t2 ON t1.DISPLAY_VALUE = convert(varchar,t2.DEVICE_TYPE)
                            WHERE   t1.DISPLAY_KEY = 'deviceid' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获?得ì?数oy簓y据Y列￠D表à¨a括¤?§
        /// </summary>
        public DataSet GetSettingList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM PBA_PARKING_PARAM_SETTINGS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获?取¨?初?始o?化?￥组á¨|织?￥信?息?é
        /// </summary>
        /// <returns></returns>
        public List<Equipment> GetOragnizationInfo()
        {
            List<Equipment> listOrg = new List<Equipment>();
            Equipment Info = new Equipment();
            var Ora = this.GetModelList().FirstOrDefault();
            if (null != Ora)
            {
                Info.OrganizationInfo = Ora;
                Info.ORGANIZATION_CODE = Ora.ORGANIZATION_CODE;
                Info.PARENT_CODE = Ora.PARENT_CODE;
                DataSet Params = GetParamInfo(Ora.ORGANIZATION_CODE);
                InitAttributes(Info, Params);
                listOrg.Add(Info);
                GetChildren(Info, ref listOrg);
            }
            return listOrg;
        }
        /// <summary>
        /// 获?取¨?子á¨?节¨2点ì?信?息?é
        /// </summary>
        /// <param name="org"></param>
        /// <param name="listOrg"></param>
        private void GetChildren(Equipment org, ref List<Equipment> listOrg)
        {
            var Ora = this.GetModelList(org.OrganizationInfo.ORGANIZATION_CODE);
            if (null != Ora)
            {
                foreach (var temp in Ora)
                {
                    Equipment Info = new Equipment();
                    Info.OrganizationInfo = temp;
                    Info.ORGANIZATION_CODE = temp.ORGANIZATION_CODE;
                    Info.PARENT_CODE = temp.PARENT_CODE;
                    DataSet Params = GetParamInfo(temp.ORGANIZATION_CODE);
                    InitAttributes(Info, Params);

                    //关?联￠a设|¨¨备à?类¤¨¤型¨a表à¨a，ê?初?始o?化?￥设|¨¨备à?关?键¨1信?息?é
                    if (Info.channelType == enumChannelType.equ)
                    {
                        string sqlType = string.Format(" t1.ORGANIZATION_CODE='{0}'", Info.OrganizationInfo.ORGANIZATION_CODE);
                        DataSet dsType = GetType(sqlType);
                        if (dsType.Tables[0].Rows.Count > 0)
                        {
                            if (dsType.Tables[0].Columns.Contains("DEVICE_TYPE"))
                                Info.deviceType = (enumDeviceType)Enum.Parse(typeof(enumDeviceType), dsType.Tables[0].Rows[0]["DEVICE_TYPE"].ToString(), false);
                            if (dsType.Tables[0].Columns.Contains("DEVICE_CATEGORIES"))
                                Info.productLine = (enumProductLine)Enum.Parse(typeof(enumProductLine), dsType.Tables[0].Rows[0]["DEVICE_CATEGORIES"].ToString(), false);
                        }
                    }
                    else
                        Info.productLine = enumProductLine.Oragnization;

                    listOrg.Add(Info);
                    //递ìY归¨|查¨|询?￥
                    GetChildren(Info, ref listOrg);
                }
            }
        }
        /// <summary>
        /// 获?取¨?组á¨|织?￥信?息?é
        /// </summary>
        /// <param name="ParentCode"></param>
        /// <returns></returns>
        private DataSet GetParamInfo(string Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM dbo.PBA_PARKING_PARAM_SETTINGS  WHERE ORGANIZATION_CODE = '" + Code + "'");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 加¨?载?属o?性?
        /// </summary>
        /// <param name="dicTemp"></param>
        /// <param name="dsTemp"></param>
        private void InitAttributes(OragnizationBase Ora, DataSet dsTemp)
        {
            if (dsTemp.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drTemp in dsTemp.Tables[0].Rows)
                {
                    if (null != drTemp["DISPLAY_KEY"] && null != drTemp["DISPLAY_VALUE"])
                    {
                        if (!Ora.Attributes.ContainsKey(drTemp["DISPLAY_KEY"].ToString().ToUpper()))
                            Ora.Attributes.Add(drTemp["DISPLAY_KEY"].ToString().ToUpper(), drTemp["DISPLAY_VALUE"].ToString());
                    }
                }
            }
        }
        #endregion  ExtensionMethod
    }
}

