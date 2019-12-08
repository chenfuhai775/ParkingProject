using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;
namespace Parking.DBService.DAL
{
    /// <summary>
    /// 数oy据Y访¤?问¨o类¤¨¤:FN_MONITOR_VERSION_INFO
    /// </summary>
    public partial class FN_MONITOR_VERSION_INFO
    {
        public FN_MONITOR_VERSION_INFO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FN_MONITOR_VERSION_INFO");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.FN_MONITOR_VERSION_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FN_MONITOR_VERSION_INFO(");
            strSql.Append("ID,VERSION_NUMBER,RELEASE_TIME,UPLOAD_TIME,VERSION_DESC,DOWNLOAD_URL,CHECK_CODE,FILE_SIZE,UPLOAD_USERID,UPGRADE_DESC)");
            strSql.Append(" values (");
            strSql.Append("@ID,@VERSION_NUMBER,@RELEASE_TIME,@UPLOAD_TIME,@VERSION_DESC,@DOWNLOAD_URL,@CHECK_CODE,@FILE_SIZE,@UPLOAD_USERID,@UPGRADE_DESC)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32),
                    new SqlParameter("@VERSION_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@RELEASE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPLOAD_TIME", SqlDbType.DateTime),
                    new SqlParameter("@VERSION_DESC", SqlDbType.VarChar,4000),
                    new SqlParameter("@DOWNLOAD_URL", SqlDbType.VarChar,4000),
                    new SqlParameter("@CHECK_CODE", SqlDbType.VarChar,100),
                    new SqlParameter("@FILE_SIZE", SqlDbType.Decimal,9),
                    new SqlParameter("@UPLOAD_USERID", SqlDbType.VarChar,32),
                    new SqlParameter("@UPGRADE_DESC", SqlDbType.Text)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.VERSION_NUMBER;
            parameters[2].Value = model.RELEASE_TIME;
            parameters[3].Value = model.UPLOAD_TIME;
            parameters[4].Value = model.VERSION_DESC;
            parameters[5].Value = model.DOWNLOAD_URL;
            parameters[6].Value = model.CHECK_CODE;
            parameters[7].Value = model.FILE_SIZE;
            parameters[8].Value = model.UPLOAD_USERID;
            parameters[9].Value = model.UPGRADE_DESC;

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
        public bool Update(Parking.Core.Model.FN_MONITOR_VERSION_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FN_MONITOR_VERSION_INFO set ");
            strSql.Append("VERSION_NUMBER=@VERSION_NUMBER,");
            strSql.Append("RELEASE_TIME=@RELEASE_TIME,");
            strSql.Append("UPLOAD_TIME=@UPLOAD_TIME,");
            strSql.Append("VERSION_DESC=@VERSION_DESC,");
            strSql.Append("DOWNLOAD_URL=@DOWNLOAD_URL,");
            strSql.Append("CHECK_CODE=@CHECK_CODE,");
            strSql.Append("FILE_SIZE=@FILE_SIZE,");
            strSql.Append("UPLOAD_USERID=@UPLOAD_USERID,");
            strSql.Append("UPGRADE_DESC=@UPGRADE_DESC");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@VERSION_NUMBER", SqlDbType.VarChar,100),
                    new SqlParameter("@RELEASE_TIME", SqlDbType.DateTime),
                    new SqlParameter("@UPLOAD_TIME", SqlDbType.DateTime),
                    new SqlParameter("@VERSION_DESC", SqlDbType.VarChar,4000),
                    new SqlParameter("@DOWNLOAD_URL", SqlDbType.VarChar,4000),
                    new SqlParameter("@CHECK_CODE", SqlDbType.VarChar,100),
                    new SqlParameter("@FILE_SIZE", SqlDbType.Decimal,9),
                    new SqlParameter("@UPLOAD_USERID", SqlDbType.VarChar,32),
                    new SqlParameter("@UPGRADE_DESC", SqlDbType.Text),
                    new SqlParameter("@ID", SqlDbType.VarChar,32)};
            parameters[0].Value = model.VERSION_NUMBER;
            parameters[1].Value = model.RELEASE_TIME;
            parameters[2].Value = model.UPLOAD_TIME;
            parameters[3].Value = model.VERSION_DESC;
            parameters[4].Value = model.DOWNLOAD_URL;
            parameters[5].Value = model.CHECK_CODE;
            parameters[6].Value = model.FILE_SIZE;
            parameters[7].Value = model.UPLOAD_USERID;
            parameters[8].Value = model.UPGRADE_DESC;
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
            strSql.Append("delete from FN_MONITOR_VERSION_INFO ");
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
            strSql.Append("delete from FN_MONITOR_VERSION_INFO ");
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
        public Parking.Core.Model.FN_MONITOR_VERSION_INFO GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,VERSION_NUMBER,RELEASE_TIME,UPLOAD_TIME,VERSION_DESC,DOWNLOAD_URL,CHECK_CODE,FILE_SIZE,UPLOAD_USERID,UPGRADE_DESC from FN_MONITOR_VERSION_INFO ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,32)           };
            parameters[0].Value = ID;

            Parking.Core.Model.FN_MONITOR_VERSION_INFO model = new Parking.Core.Model.FN_MONITOR_VERSION_INFO();
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
        public Parking.Core.Model.FN_MONITOR_VERSION_INFO DataRowToModel(DataRow row)
        {
            Parking.Core.Model.FN_MONITOR_VERSION_INFO model = new Parking.Core.Model.FN_MONITOR_VERSION_INFO();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["VERSION_NUMBER"] != null)
                {
                    model.VERSION_NUMBER = row["VERSION_NUMBER"].ToString();
                }
                if (row["RELEASE_TIME"] != null && row["RELEASE_TIME"].ToString() != "")
                {
                    model.RELEASE_TIME = DateTime.Parse(row["RELEASE_TIME"].ToString());
                }
                if (row["UPLOAD_TIME"] != null && row["UPLOAD_TIME"].ToString() != "")
                {
                    model.UPLOAD_TIME = DateTime.Parse(row["UPLOAD_TIME"].ToString());
                }
                if (row["VERSION_DESC"] != null)
                {
                    model.VERSION_DESC = row["VERSION_DESC"].ToString();
                }
                if (row["DOWNLOAD_URL"] != null)
                {
                    model.DOWNLOAD_URL = row["DOWNLOAD_URL"].ToString();
                }
                if (row["CHECK_CODE"] != null)
                {
                    model.CHECK_CODE = row["CHECK_CODE"].ToString();
                }
                if (row["FILE_SIZE"] != null && row["FILE_SIZE"].ToString() != "")
                {
                    model.FILE_SIZE = decimal.Parse(row["FILE_SIZE"].ToString());
                }
                if (row["UPLOAD_USERID"] != null)
                {
                    model.UPLOAD_USERID = row["UPLOAD_USERID"].ToString();
                }
                if (row["UPGRADE_DESC"] != null)
                {
                    model.UPGRADE_DESC = row["UPGRADE_DESC"].ToString();
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
            strSql.Append("select ID,VERSION_NUMBER,RELEASE_TIME,UPLOAD_TIME,VERSION_DESC,DOWNLOAD_URL,CHECK_CODE,FILE_SIZE,UPLOAD_USERID,UPGRADE_DESC ");
            strSql.Append(" FROM FN_MONITOR_VERSION_INFO ");
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
            strSql.Append(" ID,VERSION_NUMBER,RELEASE_TIME,UPLOAD_TIME,VERSION_DESC,DOWNLOAD_URL,CHECK_CODE,FILE_SIZE,UPLOAD_USERID,UPGRADE_DESC ");
            strSql.Append(" FROM FN_MONITOR_VERSION_INFO ");
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
            strSql.Append("select count(1) FROM FN_MONITOR_VERSION_INFO ");
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
            strSql.Append(")AS Row, T.*  from FN_MONITOR_VERSION_INFO T ");
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
		/// 分¤?页°3获?取¨?数oy据Y列￠D表à¨a
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
			parameters[0].Value = "FN_MONITOR_VERSION_INFO";
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
        public Parking.Core.Model.FN_MONITOR_VERSION_INFO GetByVersion(string Version)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  * from FN_MONITOR_VERSION_INFO WHERE VERSION_NUMBER = '" + Version + "'");
            Parking.Core.Model.FN_MONITOR_VERSION_INFO model = new Parking.Core.Model.FN_MONITOR_VERSION_INFO();
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