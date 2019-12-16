/**  版本信息模板在安装目录下，可自行修改。
* BAS_SYSTEM_USER.cs
*
* 功 能： N/A
* 类 名： BAS_SYSTEM_USER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:22:59   N/A    初版
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
	/// 数据访问类:BAS_SYSTEM_USER
	/// </summary>
	public partial class BAS_SYSTEM_USER
	{
		public BAS_SYSTEM_USER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_SYSTEM_USER");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.BAS_SYSTEM_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_SYSTEM_USER(");
			strSql.Append("ID,USER_ACCOUNT,USER_NAME,PWD,USER_TYPE,STATUS,MOBILE,EMAIL,ADDR,USER_LOGO,REMARK,ORG_ID,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,CREATE_USER_IDS)");
			strSql.Append(" values (");
			strSql.Append("@ID,@USER_ACCOUNT,@USER_NAME,@PWD,@USER_TYPE,@STATUS,@MOBILE,@EMAIL,@ADDR,@USER_LOGO,@REMARK,@ORG_ID,@CREATE_BY,@CREATE_TIME,@LAST_UPDATE_BY,@LAST_UPDATE_TIME,@CREATE_USER_IDS)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,40),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,40),
					new SqlParameter("@PWD", SqlDbType.VarChar,40),
					new SqlParameter("@USER_TYPE", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@MOBILE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@ADDR", SqlDbType.VarChar,200),
					new SqlParameter("@USER_LOGO", SqlDbType.VarChar,200),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@ORG_ID", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@LAST_UPDATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER_IDS", SqlDbType.VarChar,2000)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.USER_ACCOUNT;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.PWD;
			parameters[4].Value = model.USER_TYPE;
			parameters[5].Value = model.STATUS;
			parameters[6].Value = model.MOBILE;
			parameters[7].Value = model.EMAIL;
			parameters[8].Value = model.ADDR;
			parameters[9].Value = model.USER_LOGO;
			parameters[10].Value = model.REMARK;
			parameters[11].Value = model.ORG_ID;
			parameters[12].Value = model.CREATE_BY;
			parameters[13].Value = model.CREATE_TIME;
			parameters[14].Value = model.LAST_UPDATE_BY;
			parameters[15].Value = model.LAST_UPDATE_TIME;
			parameters[16].Value = model.CREATE_USER_IDS;

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
		public bool Update(Parking.Core.Model.BAS_SYSTEM_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_SYSTEM_USER set ");
			strSql.Append("USER_ACCOUNT=@USER_ACCOUNT,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("PWD=@PWD,");
			strSql.Append("USER_TYPE=@USER_TYPE,");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("MOBILE=@MOBILE,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("ADDR=@ADDR,");
			strSql.Append("USER_LOGO=@USER_LOGO,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("ORG_ID=@ORG_ID,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("LAST_UPDATE_BY=@LAST_UPDATE_BY,");
			strSql.Append("LAST_UPDATE_TIME=@LAST_UPDATE_TIME,");
			strSql.Append("CREATE_USER_IDS=@CREATE_USER_IDS");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,40),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,40),
					new SqlParameter("@PWD", SqlDbType.VarChar,40),
					new SqlParameter("@USER_TYPE", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@MOBILE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@ADDR", SqlDbType.VarChar,200),
					new SqlParameter("@USER_LOGO", SqlDbType.VarChar,200),
					new SqlParameter("@REMARK", SqlDbType.VarChar,1000),
					new SqlParameter("@ORG_ID", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@LAST_UPDATE_BY", SqlDbType.VarChar,40),
					new SqlParameter("@LAST_UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USER_IDS", SqlDbType.VarChar,2000),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.USER_ACCOUNT;
			parameters[1].Value = model.USER_NAME;
			parameters[2].Value = model.PWD;
			parameters[3].Value = model.USER_TYPE;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.MOBILE;
			parameters[6].Value = model.EMAIL;
			parameters[7].Value = model.ADDR;
			parameters[8].Value = model.USER_LOGO;
			parameters[9].Value = model.REMARK;
			parameters[10].Value = model.ORG_ID;
			parameters[11].Value = model.CREATE_BY;
			parameters[12].Value = model.CREATE_TIME;
			parameters[13].Value = model.LAST_UPDATE_BY;
			parameters[14].Value = model.LAST_UPDATE_TIME;
			parameters[15].Value = model.CREATE_USER_IDS;
			parameters[16].Value = model.ID;

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
			strSql.Append("delete from BAS_SYSTEM_USER ");
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
			strSql.Append("delete from BAS_SYSTEM_USER ");
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
		public Parking.Core.Model.BAS_SYSTEM_USER GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,USER_ACCOUNT,USER_NAME,PWD,USER_TYPE,STATUS,MOBILE,EMAIL,ADDR,USER_LOGO,REMARK,ORG_ID,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,CREATE_USER_IDS from BAS_SYSTEM_USER ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.BAS_SYSTEM_USER model=new Parking.Core.Model.BAS_SYSTEM_USER();
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
		public Parking.Core.Model.BAS_SYSTEM_USER DataRowToModel(DataRow row)
		{
			Parking.Core.Model.BAS_SYSTEM_USER model=new Parking.Core.Model.BAS_SYSTEM_USER();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["USER_ACCOUNT"]!=null)
				{
					model.USER_ACCOUNT=row["USER_ACCOUNT"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
				}
				if(row["PWD"]!=null)
				{
					model.PWD=row["PWD"].ToString();
				}
				if(row["USER_TYPE"]!=null && row["USER_TYPE"].ToString()!="")
				{
					model.USER_TYPE=int.Parse(row["USER_TYPE"].ToString());
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(row["STATUS"].ToString());
				}
				if(row["MOBILE"]!=null)
				{
					model.MOBILE=row["MOBILE"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["ADDR"]!=null)
				{
					model.ADDR=row["ADDR"].ToString();
				}
				if(row["USER_LOGO"]!=null)
				{
					model.USER_LOGO=row["USER_LOGO"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["ORG_ID"]!=null)
				{
					model.ORG_ID=row["ORG_ID"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["LAST_UPDATE_BY"]!=null)
				{
					model.LAST_UPDATE_BY=row["LAST_UPDATE_BY"].ToString();
				}
				if(row["LAST_UPDATE_TIME"]!=null && row["LAST_UPDATE_TIME"].ToString()!="")
				{
					model.LAST_UPDATE_TIME=DateTime.Parse(row["LAST_UPDATE_TIME"].ToString());
				}
				if(row["CREATE_USER_IDS"]!=null)
				{
					model.CREATE_USER_IDS=row["CREATE_USER_IDS"].ToString();
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
			strSql.Append("select ID,USER_ACCOUNT,USER_NAME,PWD,USER_TYPE,STATUS,MOBILE,EMAIL,ADDR,USER_LOGO,REMARK,ORG_ID,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,CREATE_USER_IDS ");
			strSql.Append(" FROM BAS_SYSTEM_USER ");
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
			strSql.Append(" ID,USER_ACCOUNT,USER_NAME,PWD,USER_TYPE,STATUS,MOBILE,EMAIL,ADDR,USER_LOGO,REMARK,ORG_ID,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,CREATE_USER_IDS ");
			strSql.Append(" FROM BAS_SYSTEM_USER ");
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
			strSql.Append("select count(1) FROM BAS_SYSTEM_USER ");
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
			strSql.Append(")AS Row, T.*  from BAS_SYSTEM_USER T ");
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
			parameters[0].Value = "BAS_SYSTEM_USER";
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
        public Parking.Core.Model.BAS_SYSTEM_USER Login(string userName, string Pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,USER_ACCOUNT,USER_NAME,PWD,USER_TYPE,STATUS,MOBILE,EMAIL,ADDR,USER_LOGO,REMARK,ORG_ID,CREATE_BY,CREATE_TIME,LAST_UPDATE_BY,LAST_UPDATE_TIME,CREATE_USER_IDS from BAS_SYSTEM_USER ");
            strSql.Append(" where USER_ACCOUNT=@USER_ACCOUNT  AND PWD = @PWD");
            SqlParameter[] parameters = {
                    new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,32),
                    new SqlParameter("@PWD", SqlDbType.VarChar,32)              };
            parameters[0].Value = userName;
            parameters[1].Value = Pwd;
            Parking.Core.Model.BAS_SYSTEM_USER model = new Parking.Core.Model.BAS_SYSTEM_USER();
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

