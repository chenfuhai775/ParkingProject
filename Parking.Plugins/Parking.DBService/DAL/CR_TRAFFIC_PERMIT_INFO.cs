/**  版本信息模板在安装目录下，可自行修改。
* CR_TRAFFIC_PERMIT_INFO.cs
*
* 功 能： N/A
* 类 名： CR_TRAFFIC_PERMIT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
*
* Copyright (c) 2012 Parking.DBService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
using Parking.Core.Enum;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:CR_TRAFFIC_PERMIT_INFO
	/// </summary>
	public partial class CR_TRAFFIC_PERMIT_INFO
	{
		public CR_TRAFFIC_PERMIT_INFO()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CR_TRAFFIC_PERMIT_INFO");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,100)          };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CR_TRAFFIC_PERMIT_INFO(");
            strSql.Append("ID,LOGIC_NUMBER,TRAFFIC_PERMIT_STATUS,PRINTING_NO,OWNER_CODE,BEGIN_TIME,END_TIME,BALANCE,REMARK,TISSUE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,PHYSIC_NUMBER,ACCESS_PERMISSION,TRAFFIC_TYPE,VEHICLE_NO)");
            strSql.Append(" values (");
            strSql.Append("@ID,@LOGIC_NUMBER,@TRAFFIC_PERMIT_STATUS,@PRINTING_NO,@OWNER_CODE,@BEGIN_TIME,@END_TIME,@BALANCE,@REMARK,@TISSUE_TIME,@CREATE_USERID,@UPDATE_TIME,@UPDATE_USERID,@PHYSIC_NUMBER,@ACCESS_PERMISSION,@TRAFFIC_TYPE,@VEHICLE_NO)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,100),
                    new SqlParameter("@LOGIC_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@TRAFFIC_PERMIT_STATUS", SqlDbType.Int,4),
                    new SqlParameter("@PRINTING_NO", SqlDbType.VarChar,100),
                    new SqlParameter("@OWNER_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
                    new SqlParameter("@END_TIME", SqlDbType.DateTime),
                    new SqlParameter("@BALANCE", SqlDbType.Decimal,9),
                    new SqlParameter("@REMARK", SqlDbType.VarChar,500),
                    new SqlParameter("@TISSUE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@PHYSIC_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@ACCESS_PERMISSION", SqlDbType.VarChar,32),
                    new SqlParameter("@TRAFFIC_TYPE", SqlDbType.Int,4),
                    new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.LOGIC_NUMBER;
            parameters[2].Value = model.TRAFFIC_PERMIT_STATUS;
            parameters[3].Value = model.PRINTING_NO;
            parameters[4].Value = model.OWNER_CODE;
            parameters[5].Value = model.BEGIN_TIME;
            parameters[6].Value = model.END_TIME;
            parameters[7].Value = model.BALANCE;
            parameters[8].Value = model.REMARK;
            parameters[9].Value = model.TISSUE_TIME;
            parameters[10].Value = model.CREATE_USERID;
            parameters[11].Value = model.UPDATE_TIME;
            parameters[12].Value = model.UPDATE_USERID;
            parameters[13].Value = model.PHYSIC_NUMBER;
            parameters[14].Value = model.ACCESS_PERMISSION;
            parameters[15].Value = model.TRAFFIC_TYPE;
            parameters[16].Value = model.VEHICLE_NO;

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
        public bool Update(Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CR_TRAFFIC_PERMIT_INFO set ");
            strSql.Append("LOGIC_NUMBER=@LOGIC_NUMBER,");
            strSql.Append("TRAFFIC_PERMIT_STATUS=@TRAFFIC_PERMIT_STATUS,");
            strSql.Append("PRINTING_NO=@PRINTING_NO,");
            strSql.Append("OWNER_CODE=@OWNER_CODE,");
            strSql.Append("BEGIN_TIME=@BEGIN_TIME,");
            strSql.Append("END_TIME=@END_TIME,");
            strSql.Append("BALANCE=@BALANCE,");
            strSql.Append("REMARK=@REMARK,");
            strSql.Append("TISSUE_TIME=@TISSUE_TIME,");
            strSql.Append("CREATE_USERID=@CREATE_USERID,");
            strSql.Append("UPDATE_TIME=@UPDATE_TIME,");
            strSql.Append("UPDATE_USERID=@UPDATE_USERID,");
            strSql.Append("PHYSIC_NUMBER=@PHYSIC_NUMBER,");
            strSql.Append("ACCESS_PERMISSION=@ACCESS_PERMISSION,");
            strSql.Append("TRAFFIC_TYPE=@TRAFFIC_TYPE,");
            strSql.Append("VEHICLE_NO=@VEHICLE_NO");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@LOGIC_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@TRAFFIC_PERMIT_STATUS", SqlDbType.Int,4),
                    new SqlParameter("@PRINTING_NO", SqlDbType.VarChar,100),
                    new SqlParameter("@OWNER_CODE", SqlDbType.VarChar,50),
                    new SqlParameter("@BEGIN_TIME", SqlDbType.DateTime),
                    new SqlParameter("@END_TIME", SqlDbType.DateTime),
                    new SqlParameter("@BALANCE", SqlDbType.Decimal,9),
                    new SqlParameter("@REMARK", SqlDbType.VarChar,500),
                    new SqlParameter("@TISSUE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_USERID", SqlDbType.VarChar,50),
                    new SqlParameter("@PHYSIC_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@ACCESS_PERMISSION", SqlDbType.VarChar,32),
                    new SqlParameter("@TRAFFIC_TYPE", SqlDbType.Int,4),
                    new SqlParameter("@VEHICLE_NO", SqlDbType.VarChar,20),
                    new SqlParameter("@ID", SqlDbType.VarChar,100)};
            parameters[0].Value = model.LOGIC_NUMBER;
            parameters[1].Value = model.TRAFFIC_PERMIT_STATUS;
            parameters[2].Value = model.PRINTING_NO;
            parameters[3].Value = model.OWNER_CODE;
            parameters[4].Value = model.BEGIN_TIME;
            parameters[5].Value = model.END_TIME;
            parameters[6].Value = model.BALANCE;
            parameters[7].Value = model.REMARK;
            parameters[8].Value = model.TISSUE_TIME;
            parameters[9].Value = model.CREATE_USERID;
            parameters[10].Value = model.UPDATE_TIME;
            parameters[11].Value = model.UPDATE_USERID;
            parameters[12].Value = model.PHYSIC_NUMBER;
            parameters[13].Value = model.ACCESS_PERMISSION;
            parameters[14].Value = model.TRAFFIC_TYPE;
            parameters[15].Value = model.VEHICLE_NO;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from CR_TRAFFIC_PERMIT_INFO ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,100)          };
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
            strSql.Append("delete from CR_TRAFFIC_PERMIT_INFO ");
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
        public Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,LOGIC_NUMBER,TRAFFIC_PERMIT_STATUS,PRINTING_NO,OWNER_CODE,BEGIN_TIME,END_TIME,BALANCE,REMARK,TISSUE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,PHYSIC_NUMBER,ACCESS_PERMISSION,TRAFFIC_TYPE,VEHICLE_NO from CR_TRAFFIC_PERMIT_INFO ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,100)          };
            parameters[0].Value = ID;

            Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO model = new Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO();
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
        public Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO DataRowToModel(DataRow row)
        {
            Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO model = new Parking.Core.Model.CR_TRAFFIC_PERMIT_INFO();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["LOGIC_NUMBER"] != null)
                {
                    model.LOGIC_NUMBER = row["LOGIC_NUMBER"].ToString();
                }
                if (row["TRAFFIC_PERMIT_STATUS"] != null && row["TRAFFIC_PERMIT_STATUS"].ToString() != "")
                {
                    model.TRAFFIC_PERMIT_STATUS = int.Parse(row["TRAFFIC_PERMIT_STATUS"].ToString());
                }
                if (row["PRINTING_NO"] != null)
                {
                    model.PRINTING_NO = row["PRINTING_NO"].ToString();
                }
                if (row["OWNER_CODE"] != null)
                {
                    model.OWNER_CODE = row["OWNER_CODE"].ToString();
                }
                if (row["BEGIN_TIME"] != null && row["BEGIN_TIME"].ToString() != "")
                {
                    model.BEGIN_TIME = DateTime.Parse(row["BEGIN_TIME"].ToString());
                }
                if (row["END_TIME"] != null && row["END_TIME"].ToString() != "")
                {
                    model.END_TIME = DateTime.Parse(row["END_TIME"].ToString());
                }
                if (row["BALANCE"] != null && row["BALANCE"].ToString() != "")
                {
                    model.BALANCE = decimal.Parse(row["BALANCE"].ToString());
                }
                if (row["REMARK"] != null)
                {
                    model.REMARK = row["REMARK"].ToString();
                }
                if (row["TISSUE_TIME"] != null && row["TISSUE_TIME"].ToString() != "")
                {
                    model.TISSUE_TIME = DateTime.Parse(row["TISSUE_TIME"].ToString());
                }
                if (row["CREATE_USERID"] != null)
                {
                    model.CREATE_USERID = row["CREATE_USERID"].ToString();
                }
                if (row["UPDATE_TIME"] != null && row["UPDATE_TIME"].ToString() != "")
                {
                    model.UPDATE_TIME = DateTime.Parse(row["UPDATE_TIME"].ToString());
                }
                if (row["UPDATE_USERID"] != null)
                {
                    model.UPDATE_USERID = row["UPDATE_USERID"].ToString();
                }
                if (row["PHYSIC_NUMBER"] != null)
                {
                    model.PHYSIC_NUMBER = row["PHYSIC_NUMBER"].ToString();
                }
                if (row["ACCESS_PERMISSION"] != null)
                {
                    model.ACCESS_PERMISSION = row["ACCESS_PERMISSION"].ToString();
                }
                if (row["TRAFFIC_TYPE"] != null && row["TRAFFIC_TYPE"].ToString() != "")
                {
                    model.TRAFFIC_TYPE = int.Parse(row["TRAFFIC_TYPE"].ToString());
                }
                if (row["VEHICLE_NO"] != null)
                {
                    model.VEHICLE_NO = row["VEHICLE_NO"].ToString();
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
            strSql.Append("select ID,LOGIC_NUMBER,TRAFFIC_PERMIT_STATUS,PRINTING_NO,OWNER_CODE,BEGIN_TIME,END_TIME,BALANCE,REMARK,TISSUE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,PHYSIC_NUMBER,ACCESS_PERMISSION,TRAFFIC_TYPE,VEHICLE_NO ");
            strSql.Append(" FROM CR_TRAFFIC_PERMIT_INFO ");
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
            strSql.Append(" ID,LOGIC_NUMBER,TRAFFIC_PERMIT_STATUS,PRINTING_NO,OWNER_CODE,BEGIN_TIME,END_TIME,BALANCE,REMARK,TISSUE_TIME,CREATE_USERID,UPDATE_TIME,UPDATE_USERID,PHYSIC_NUMBER,ACCESS_PERMISSION,TRAFFIC_TYPE,VEHICLE_NO ");
            strSql.Append(" FROM CR_TRAFFIC_PERMIT_INFO ");
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
            strSql.Append("select count(1) FROM CR_TRAFFIC_PERMIT_INFO ");
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
            strSql.Append(")AS Row, T.*  from CR_TRAFFIC_PERMIT_INFO T ");
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
        public List<Parking.Core.Model.IssueInfo> DataRowToModel(DataSet ds)
        {
            List<Parking.Core.Model.IssueInfo> modelList = new List<Core.Model.IssueInfo>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Parking.Core.Model.IssueInfo model = new Core.Model.IssueInfo();
                if (row != null)
                {
                    if (row["ID"] != null)
                    {
                        model.ID = row["ID"].ToString();
                    }
                    if (row["PRINTING_NO"] != null)
                    {
                        model.PRINTING_NO = row["PRINTING_NO"].ToString();
                    }
                    if (row["TISSUE_TIME"] != null && row["TISSUE_TIME"].ToString() != "")
                    {
                        model.TISSUE_TIME = DateTime.Parse(row["TISSUE_TIME"].ToString());
                    }
                    if (row["VEHICLE_NUMBER"] != null)
                    {
                        model.VEHICLE_NUMBER = row["VEHICLE_NUMBER"].ToString();
                    }
                    if (row["TRAFFIC_TYPE"] != null)
                    {
                        model.CARDTYPE = (enumCardType)(Enum.Parse(typeof(enumCardType), row["TRAFFIC_TYPE"].ToString()));
                    }
                    if (row["TRAFFIC_PERMIT_STATUS"] != null && row["TRAFFIC_PERMIT_STATUS"].ToString() != "")
                    {
                        model.TRAFFIC_PERMIT_STATUS = int.Parse(row["TRAFFIC_PERMIT_STATUS"].ToString());
                    }
                    if (row["VEHICLE_TYPE"] != null)
                    {
                        model.CAR_TYPE = (enumCarType)(Enum.Parse(typeof(enumCarType), row["VEHICLE_TYPE"].ToString()));
                    }
                    if (row["OWNER_CODE"] != null)
                    {
                        model.OWNER_CODE = row["OWNER_CODE"].ToString();
                    }
                    if (row["OWNER_NAME"] != null)
                    {
                        model.PRINTING_NO = row["OWNER_NAME"].ToString();
                    }
                    if (row["ACCESS_CHANNEL_CODE"] != null)
                    {
                        model.ACCESS_CHANNEL_CODE = row["ACCESS_CHANNEL_CODE"].ToString();
                    }
                    if (row["INOUT_RECORD_ID"] != null)
                    {
                        model.INOUT_RECORD_ID = row["INOUT_RECORD_ID"].ToString();
                    }
                    if (row["SPACE_CODE"] != null)
                    {
                        model.SPACE_CODE = row["SPACE_CODE"].ToString();
                    }
                    if (row["SPACE_STATUS"] != null && row["SPACE_STATUS"].ToString() != "")
                    {
                        model.SPACE_STATUS = int.Parse(row["SPACE_STATUS"].ToString());
                    }
                    if (row["PARTITION_CODE"] != null)
                    {
                        model.PARTITION_CODE = row["PARTITION_CODE"].ToString();
                    }
                    if (row["BEGIN_TIME"] != null && row["BEGIN_TIME"].ToString() != "")
                    {
                        model.BEGAIN_TIME = DateTime.Parse(row["BEGIN_TIME"].ToString());
                    }
                    if (row["END_TIME"] != null && row["END_TIME"].ToString() != "")
                    {
                        model.END_TIME = DateTime.Parse(row["END_TIME"].ToString());
                    }
                }
                modelList.Add(model);
            }
            return modelList;
        }
        /// <summary>
        /// 查¨|询?￥发¤?é行D记?录?
        /// </summary>
        /// <returns></returns>
        public List<Parking.Core.Model.IssueInfo> GetIssueInfo(string VEHICLE_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  a.ID ,
                                    a.PRINTING_NO ,
                                    a.TISSUE_TIME ,
                                    a.VEHICLE_NUMBER ,
                                    a.TRAFFIC_TYPE ,
                                    a.TRAFFIC_PERMIT_STATUS ,
                                    b.SPACE_CODE ,
                                    c.VEHICLE_TYPE ,
                                    d.OWNER_NAME ,
                                    d.OWNER_CODE ,
                                    d.OWNER_STATUS,
                                    e.ACCESS_CHANNEL_CODE,
                                    f.INOUT_RECORD_ID ,
                                    f.SPACE_STATUS ,
                                    f.PARTITION_CODE ,
                                    f.BEGIN_TIME ,
                                    f.END_TIME
                            FROM    dbo.CR_TRAFFIC_PERMIT_INFO a
                                    LEFT JOIN CR_PARKING_SPACE_AND_VEHICLE_AND_TRAFFIC_RELATION b ON a.ID = b.TRAFFIC_PERMIT_CODE
                                    LEFT JOIN PBA_OWNER_VEHICLE_INFO c ON a.VEHICLE_NUMBER = c.VEHICLE_NO
                                    LEFT JOIN PBA_OWNER_INFO d ON c.OWNER_CODE = d.OWNER_CODE
                                    LEFT JOIN CR_ACCESS_PERMISSION_INFO e ON a.ACCESS_PERMISSION = e.ID
                                    LEFT JOIN PBA_PARKING_SPACE_MANAGER f ON b.SPACE_CODE = f.SPACE_CODE
                            WHERE   d.OWNER_STATUS = 1 AND a.VEHICLE_NUMBER = '{0}' AND b.SPACE_CODE <> '' ");
            string Sql = string.Format(strSql.ToString(), VEHICLE_NO);
            return DataRowToModel(DbHelperSQL.Query(Sql));
        }

        /// <summary>
        /// 查¨|询?￥发¤?é行D记?录?
        /// </summary>
        /// <returns></returns>
        public List<Parking.Core.Model.IssueInfo> GetLostIssueInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  a.ID ,
                                    a.PRINTING_NO ,
                                    a.TISSUE_TIME ,
                                    a.VEHICLE_NUMBER ,
                                    a.TRAFFIC_TYPE ,
                                    a.TRAFFIC_PERMIT_STATUS ,
                                    b.SPACE_CODE ,
                                    c.VEHICLE_TYPE ,
                                    d.OWNER_NAME ,
                                    d.OWNER_CODE ,
                                    d.OWNER_STATUS,
                                    e.ACCESS_CHANNEL_CODE,
                                    f.INOUT_RECORD_ID ,
                                    f.SPACE_STATUS ,
                                    f.PARTITION_CODE ,
                                    f.BEGIN_TIME ,
                                    f.END_TIME
                            FROM    dbo.CR_TRAFFIC_PERMIT_INFO a
                      LEFT JOIN CR_PARKING_SPACE_AND_VEHICLE_AND_TRAFFIC_RELATION b ON a.ID = b.TRAFFIC_PERMIT_CODE
                                    LEFT JOIN PBA_OWNER_VEHICLE_INFO c ON a.VEHICLE_NUMBER = c.VEHICLE_NO
                                    LEFT JOIN PBA_OWNER_INFO d ON c.OWNER_CODE = d.OWNER_CODE
                                    LEFT JOIN CR_ACCESS_PERMISSION_INFO e ON a.ACCESS_PERMISSION = e.ID
                                    LEFT JOIN PBA_PARKING_SPACE_MANAGER f ON b.SPACE_CODE = f.SPACE_CODE
                           WHERE     a.TRAFFIC_PERMIT_STATUS = 0 ");
            string Sql = strSql.Append(strWhere).ToString();
            return DataRowToModel(DbHelperSQL.Query(Sql));
        }
        #endregion  ExtensionMethod
    }
}

