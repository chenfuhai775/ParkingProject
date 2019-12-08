using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;
namespace Parking.DBService.DAL
{
    /// <summary>
    /// 数oy据Y访¤?问¨o类¤¨¤:FN_MONITOR_UPDATE_INFO
    /// </summary>
    public partial class FN_MONITOR_UPDATE_INFO
    {
        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FN_MONITOR_UPDATE_INFO");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.FN_MONITOR_UPDATE_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FN_MONITOR_UPDATE_INFO(");
            strSql.Append("ID,WORKSTATION_CODE,UPDATE_VERSION,CREATE_TIME,CREATE_USERID,UPDATE_STATUS,UPDATE_COMPLETION_TIME,UPDATE_REMARK,UPDATE_METHOD,UPDATE_TIME)");
            strSql.Append(" values (");
            strSql.Append("@ID,@WORKSTATION_CODE,@UPDATE_VERSION,@CREATE_TIME,@CREATE_USERID,@UPDATE_STATUS,@UPDATE_COMPLETION_TIME,@UPDATE_REMARK,@UPDATE_METHOD,@UPDATE_TIME)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32),
                    new SqlParameter("@WORKSTATION_CODE", SqlDbType.VarChar,100),
                    new SqlParameter("@UPDATE_VERSION", SqlDbType.VarChar,32),
                    new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,32),
                    new SqlParameter("@UPDATE_STATUS", SqlDbType.Int,4),
                    new SqlParameter("@UPDATE_COMPLETION_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_REMARK", SqlDbType.VarChar,4000),
                    new SqlParameter("@UPDATE_METHOD", SqlDbType.Int,4),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.WORKSTATION_CODE;
            parameters[2].Value = model.UPDATE_VERSION;
            parameters[3].Value = model.CREATE_TIME;
            parameters[4].Value = model.CREATE_USERID;
            parameters[5].Value = model.UPDATE_STATUS;
            parameters[6].Value = model.UPDATE_COMPLETION_TIME;
            parameters[7].Value = model.UPDATE_REMARK;
            parameters[8].Value = model.UPDATE_METHOD;
            parameters[9].Value = model.UPDATE_TIME;

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
        public bool Update(Parking.Core.Model.FN_MONITOR_UPDATE_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FN_MONITOR_UPDATE_INFO set ");
            strSql.Append("WORKSTATION_CODE=@WORKSTATION_CODE,");
            strSql.Append("UPDATE_VERSION=@UPDATE_VERSION,");
            strSql.Append("CREATE_TIME=@CREATE_TIME,");
            strSql.Append("CREATE_USERID=@CREATE_USERID,");
            strSql.Append("UPDATE_STATUS=@UPDATE_STATUS,");
            strSql.Append("UPDATE_COMPLETION_TIME=@UPDATE_COMPLETION_TIME,");
            strSql.Append("UPDATE_REMARK=@UPDATE_REMARK,");
            strSql.Append("UPDATE_METHOD=@UPDATE_METHOD,");
            strSql.Append("UPDATE_TIME=@UPDATE_TIME");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@WORKSTATION_CODE", SqlDbType.VarChar,100),
                    new SqlParameter("@UPDATE_VERSION", SqlDbType.VarChar,32),
                    new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,32),
                    new SqlParameter("@UPDATE_STATUS", SqlDbType.Int,4),
                    new SqlParameter("@UPDATE_COMPLETION_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPDATE_REMARK", SqlDbType.VarChar,4000),
                    new SqlParameter("@UPDATE_METHOD", SqlDbType.Int,4),
                    new SqlParameter("@UPDATE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.VarChar,32)};
            parameters[0].Value = model.WORKSTATION_CODE;
            parameters[1].Value = model.UPDATE_VERSION;
            parameters[2].Value = model.CREATE_TIME;
            parameters[3].Value = model.CREATE_USERID;
            parameters[4].Value = model.UPDATE_STATUS;
            parameters[5].Value = model.UPDATE_COMPLETION_TIME;
            parameters[6].Value = model.UPDATE_REMARK;
            parameters[7].Value = model.UPDATE_METHOD;
            parameters[8].Value = model.UPDATE_TIME;
            parameters[9].Value = model.ID;

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
            strSql.Append("delete from FN_MONITOR_UPDATE_INFO ");
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
            strSql.Append("delete from FN_MONITOR_UPDATE_INFO ");
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
        public Parking.Core.Model.FN_MONITOR_UPDATE_INFO GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,WORKSTATION_CODE,UPDATE_VERSION,CREATE_TIME,CREATE_USERID,UPDATE_STATUS,UPDATE_COMPLETION_TIME,UPDATE_REMARK,UPDATE_METHOD,UPDATE_TIME from FN_MONITOR_UPDATE_INFO ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            Parking.Core.Model.FN_MONITOR_UPDATE_INFO model = new Parking.Core.Model.FN_MONITOR_UPDATE_INFO();
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
        public Parking.Core.Model.FN_MONITOR_UPDATE_INFO DataRowToModel(DataRow row)
        {
            Parking.Core.Model.FN_MONITOR_UPDATE_INFO model = new Parking.Core.Model.FN_MONITOR_UPDATE_INFO();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["WORKSTATION_CODE"] != null)
                {
                    model.WORKSTATION_CODE = row["WORKSTATION_CODE"].ToString();
                }
                if (row["UPDATE_VERSION"] != null)
                {
                    model.UPDATE_VERSION = row["UPDATE_VERSION"].ToString();
                }
                if (row["CREATE_TIME"] != null && row["CREATE_TIME"].ToString() != "")
                {
                    model.CREATE_TIME = DateTime.Parse(row["CREATE_TIME"].ToString());
                }
                if (row["CREATE_USERID"] != null)
                {
                    model.CREATE_USERID = row["CREATE_USERID"].ToString();
                }
                if (row["UPDATE_STATUS"] != null && row["UPDATE_STATUS"].ToString() != "")
                {
                    model.UPDATE_STATUS = int.Parse(row["UPDATE_STATUS"].ToString());
                }
                if (row["UPDATE_COMPLETION_TIME"] != null && row["UPDATE_COMPLETION_TIME"].ToString() != "")
                {
                    model.UPDATE_COMPLETION_TIME = DateTime.Parse(row["UPDATE_COMPLETION_TIME"].ToString());
                }
                if (row["UPDATE_REMARK"] != null)
                {
                    model.UPDATE_REMARK = row["UPDATE_REMARK"].ToString();
                }
                if (row["UPDATE_METHOD"] != null && row["UPDATE_METHOD"].ToString() != "")
                {
                    model.UPDATE_METHOD = int.Parse(row["UPDATE_METHOD"].ToString());
                }
                if (row["UPDATE_TIME"] != null && row["UPDATE_TIME"].ToString() != "")
                {
                    model.UPDATE_TIME = DateTime.Parse(row["UPDATE_TIME"].ToString());
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
            strSql.Append("select ID,WORKSTATION_CODE,UPDATE_VERSION,CREATE_TIME,CREATE_USERID,UPDATE_STATUS,UPDATE_COMPLETION_TIME,UPDATE_REMARK,UPDATE_METHOD,UPDATE_TIME ");
            strSql.Append(" FROM FN_MONITOR_UPDATE_INFO ");
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
            strSql.Append(" ID,WORKSTATION_CODE,UPDATE_VERSION,CREATE_TIME,CREATE_USERID,UPDATE_STATUS,UPDATE_COMPLETION_TIME,UPDATE_REMARK,UPDATE_METHOD,UPDATE_TIME ");
            strSql.Append(" FROM FN_MONITOR_UPDATE_INFO ");
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
            strSql.Append("select count(1) FROM FN_MONITOR_UPDATE_INFO ");
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
            strSql.Append(")AS Row, T.*  from FN_MONITOR_UPDATE_INFO T ");
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
        /// 获?取¨?工?è作á??站?版??本à?
        /// </summary>
        /// <param name="WorkStationCode"></param>
        /// <returns></returns>
        public Parking.Core.Model.FN_MONITOR_UPDATE_INFO GetByWorkStationCode(string WorkStationCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  * from FN_MONITOR_UPDATE_INFO WHERE WORKSTATION_CODE = '" + WorkStationCode + "' AND UPDATE_STATUS = 0 ");
            Parking.Core.Model.FN_MONITOR_UPDATE_INFO model = new Parking.Core.Model.FN_MONITOR_UPDATE_INFO();
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
