using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;

namespace Parking.DBService.DAL
{
    public class UP_SEND_MESSAGE
    { 
        public UP_SEND_MESSAGE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UP_SEND_MESSAGE");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                        new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.UP_SEND_MESSAGE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UP_SEND_MESSAGE(");
            strSql.Append("ID,CREATE_DATE,MSG_CONTENT,MSG_SEQ,MSG_STATUS,MSG_TYPE,REMARK,REPLY_MSG_CONTENT,SEND_COUNT,SEND_MSG_DATE)");
            strSql.Append(" values (");
            strSql.Append("@ID,@CREATE_DATE,@MSG_CONTENT,@MSG_SEQ,@MSG_STATUS,@MSG_TYPE,@REMARK,@REPLY_MSG_CONTENT,@SEND_COUNT,@SEND_MSG_DATE)");
            SqlParameter[] parameters = {
                        new SqlParameter("@ID", SqlDbType.VarChar,32),
                        new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
                        new SqlParameter("@MSG_CONTENT", SqlDbType.VarChar,4000),
                        new SqlParameter("@MSG_SEQ", SqlDbType.VarChar,50),
                        new SqlParameter("@MSG_STATUS", SqlDbType.Int,4),
                        new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,50),
                        new SqlParameter("@REMARK", SqlDbType.VarChar,4000),
                        new SqlParameter("@REPLY_MSG_CONTENT", SqlDbType.VarChar,4000),
                        new SqlParameter("@SEND_COUNT", SqlDbType.Int,4),
                        new SqlParameter("@SEND_MSG_DATE", SqlDbType.DateTime)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CREATE_DATE;
            parameters[2].Value = model.MSG_CONTENT;
            parameters[3].Value = model.MSG_SEQ;
            parameters[4].Value = model.MSG_STATUS;
            parameters[5].Value = model.MSG_TYPE;
            parameters[6].Value = model.REMARK;
            parameters[7].Value = model.REPLY_MSG_CONTENT;
            parameters[8].Value = model.SEND_COUNT;
            parameters[9].Value = model.SEND_MSG_DATE;

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
        public bool Update(Parking.Core.Model.UP_SEND_MESSAGE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UP_SEND_MESSAGE set ");
            strSql.Append("CREATE_DATE=@CREATE_DATE,");
            strSql.Append("MSG_CONTENT=@MSG_CONTENT,");
            strSql.Append("MSG_SEQ=@MSG_SEQ,");
            strSql.Append("MSG_STATUS=@MSG_STATUS,");
            strSql.Append("MSG_TYPE=@MSG_TYPE,");
            strSql.Append("REMARK=@REMARK,");
            strSql.Append("REPLY_MSG_CONTENT=@REPLY_MSG_CONTENT,");
            strSql.Append("SEND_COUNT=@SEND_COUNT,");
            strSql.Append("SEND_MSG_DATE=@SEND_MSG_DATE");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                        new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
                        new SqlParameter("@MSG_CONTENT", SqlDbType.VarChar,4000),
                        new SqlParameter("@MSG_SEQ", SqlDbType.VarChar,50),
                        new SqlParameter("@MSG_STATUS", SqlDbType.Int,4),
                        new SqlParameter("@MSG_TYPE", SqlDbType.VarChar,50),
                        new SqlParameter("@REMARK", SqlDbType.VarChar,4000),
                        new SqlParameter("@REPLY_MSG_CONTENT", SqlDbType.VarChar,4000),
                        new SqlParameter("@SEND_COUNT", SqlDbType.Int,4),
                        new SqlParameter("@SEND_MSG_DATE", SqlDbType.DateTime),
                        new SqlParameter("@ID", SqlDbType.VarChar,32)};
            parameters[0].Value = model.CREATE_DATE;
            parameters[1].Value = model.MSG_CONTENT;
            parameters[2].Value = model.MSG_SEQ;
            parameters[3].Value = model.MSG_STATUS;
            parameters[4].Value = model.MSG_TYPE;
            parameters[5].Value = model.REMARK;
            parameters[6].Value = model.REPLY_MSG_CONTENT;
            parameters[7].Value = model.SEND_COUNT;
            parameters[8].Value = model.SEND_MSG_DATE;
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
            strSql.Append("delete from UP_SEND_MESSAGE ");
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
            strSql.Append("delete from UP_SEND_MESSAGE ");
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
        public Parking.Core.Model.UP_SEND_MESSAGE GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CREATE_DATE,MSG_CONTENT,MSG_SEQ,MSG_STATUS,MSG_TYPE,REMARK,REPLY_MSG_CONTENT,SEND_COUNT,SEND_MSG_DATE from UP_SEND_MESSAGE ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                        new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            Parking.Core.Model.UP_SEND_MESSAGE model = new Parking.Core.Model.UP_SEND_MESSAGE();
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
        public Parking.Core.Model.UP_SEND_MESSAGE DataRowToModel(DataRow row)
        {
            Parking.Core.Model.UP_SEND_MESSAGE model = new Parking.Core.Model.UP_SEND_MESSAGE();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["CREATE_DATE"] != null && row["CREATE_DATE"].ToString() != "")
                {
                    model.CREATE_DATE = DateTime.Parse(row["CREATE_DATE"].ToString());
                }
                if (row["MSG_CONTENT"] != null)
                {
                    model.MSG_CONTENT = row["MSG_CONTENT"].ToString();
                }
                if (row["MSG_SEQ"] != null)
                {
                    model.MSG_SEQ = row["MSG_SEQ"].ToString();
                }
                if (row["MSG_STATUS"] != null && row["MSG_STATUS"].ToString() != "")
                {
                    model.MSG_STATUS = int.Parse(row["MSG_STATUS"].ToString());
                }
                if (row["MSG_TYPE"] != null)
                {
                    model.MSG_TYPE = row["MSG_TYPE"].ToString();
                }
                if (row["REMARK"] != null)
                {
                    model.REMARK = row["REMARK"].ToString();
                }
                if (row["REPLY_MSG_CONTENT"] != null)
                {
                    model.REPLY_MSG_CONTENT = row["REPLY_MSG_CONTENT"].ToString();
                }
                if (row["SEND_COUNT"] != null && row["SEND_COUNT"].ToString() != "")
                {
                    model.SEND_COUNT = int.Parse(row["SEND_COUNT"].ToString());
                }
                if (row["SEND_MSG_DATE"] != null && row["SEND_MSG_DATE"].ToString() != "")
                {
                    model.SEND_MSG_DATE = DateTime.Parse(row["SEND_MSG_DATE"].ToString());
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
            strSql.Append("select ID,CREATE_DATE,MSG_CONTENT,MSG_SEQ,MSG_STATUS,MSG_TYPE,REMARK,REPLY_MSG_CONTENT,SEND_COUNT,SEND_MSG_DATE ");
            strSql.Append(" FROM UP_SEND_MESSAGE ");
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
            strSql.Append(" ID,CREATE_DATE,MSG_CONTENT,MSG_SEQ,MSG_STATUS,MSG_TYPE,REMARK,REPLY_MSG_CONTENT,SEND_COUNT,SEND_MSG_DATE ");
            strSql.Append(" FROM UP_SEND_MESSAGE ");
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
            strSql.Append("select count(1) FROM UP_SEND_MESSAGE ");
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
            strSql.Append(")AS Row, T.*  from UP_SEND_MESSAGE T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}