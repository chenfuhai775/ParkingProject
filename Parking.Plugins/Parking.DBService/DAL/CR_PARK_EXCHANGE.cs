/**  版本信息模板在安装目录下，可自行修改。
* CR_PARK_EXCHANGE.cs
*
* 功 能： N/A
* 类 名： CR_PARK_EXCHANGE
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
	/// 数据访问类:CR_PARK_EXCHANGE
	/// </summary>
	public partial class CR_PARK_EXCHANGE
	{
		public CR_PARK_EXCHANGE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CR_PARK_EXCHANGE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_PARK_EXCHANGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_PARK_EXCHANGE(");
			strSql.Append("ID,USER_ID,USER_ACCOUNT,USER_NAME,LOGIN_TIME,EIXT_TIME,ENTER_NUM,EIXT_NUM,DUE_MONEY,PER_MONEY,WORK_STATUS,WORKSTATION_NO)");
			strSql.Append(" values (");
			strSql.Append("@ID,@USER_ID,@USER_ACCOUNT,@USER_NAME,@LOGIN_TIME,@EIXT_TIME,@ENTER_NUM,@EIXT_NUM,@DUE_MONEY,@PER_MONEY,@WORK_STATUS,@WORKSTATION_NO)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@EIXT_TIME", SqlDbType.DateTime),
					new SqlParameter("@ENTER_NUM", SqlDbType.Int,4),
					new SqlParameter("@EIXT_NUM", SqlDbType.Int,4),
					new SqlParameter("@DUE_MONEY", SqlDbType.Money,8),
					new SqlParameter("@PER_MONEY", SqlDbType.Money,8),
					new SqlParameter("@WORK_STATUS", SqlDbType.Int,4),
					new SqlParameter("@WORKSTATION_NO", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.USER_ID;
			parameters[2].Value = model.USER_ACCOUNT;
			parameters[3].Value = model.USER_NAME;
			parameters[4].Value = model.LOGIN_TIME;
			parameters[5].Value = model.EIXT_TIME;
			parameters[6].Value = model.ENTER_NUM;
			parameters[7].Value = model.EIXT_NUM;
			parameters[8].Value = model.DUE_MONEY;
			parameters[9].Value = model.PER_MONEY;
			parameters[10].Value = model.WORK_STATUS;
			parameters[11].Value = model.WORKSTATION_NO;

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
		public bool Update(Parking.Core.Model.CR_PARK_EXCHANGE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_PARK_EXCHANGE set ");
			strSql.Append("USER_ID=@USER_ID,");
			strSql.Append("USER_ACCOUNT=@USER_ACCOUNT,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("LOGIN_TIME=@LOGIN_TIME,");
			strSql.Append("EIXT_TIME=@EIXT_TIME,");
			strSql.Append("ENTER_NUM=@ENTER_NUM,");
			strSql.Append("EIXT_NUM=@EIXT_NUM,");
			strSql.Append("DUE_MONEY=@DUE_MONEY,");
			strSql.Append("PER_MONEY=@PER_MONEY,");
			strSql.Append("WORK_STATUS=@WORK_STATUS,");
			strSql.Append("WORKSTATION_NO=@WORKSTATION_NO");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.VarChar,50),
					new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@EIXT_TIME", SqlDbType.DateTime),
					new SqlParameter("@ENTER_NUM", SqlDbType.Int,4),
					new SqlParameter("@EIXT_NUM", SqlDbType.Int,4),
					new SqlParameter("@DUE_MONEY", SqlDbType.Money,8),
					new SqlParameter("@PER_MONEY", SqlDbType.Money,8),
					new SqlParameter("@WORK_STATUS", SqlDbType.Int,4),
					new SqlParameter("@WORKSTATION_NO", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.USER_ID;
			parameters[1].Value = model.USER_ACCOUNT;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.LOGIN_TIME;
			parameters[4].Value = model.EIXT_TIME;
			parameters[5].Value = model.ENTER_NUM;
			parameters[6].Value = model.EIXT_NUM;
			parameters[7].Value = model.DUE_MONEY;
			parameters[8].Value = model.PER_MONEY;
			parameters[9].Value = model.WORK_STATUS;
			parameters[10].Value = model.WORKSTATION_NO;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from CR_PARK_EXCHANGE ");
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
			strSql.Append("delete from CR_PARK_EXCHANGE ");
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
		public Parking.Core.Model.CR_PARK_EXCHANGE GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,USER_ID,USER_ACCOUNT,USER_NAME,LOGIN_TIME,EIXT_TIME,ENTER_NUM,EIXT_NUM,DUE_MONEY,PER_MONEY,WORK_STATUS,WORKSTATION_NO from CR_PARK_EXCHANGE ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.CR_PARK_EXCHANGE model=new Parking.Core.Model.CR_PARK_EXCHANGE();
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
		public Parking.Core.Model.CR_PARK_EXCHANGE DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_PARK_EXCHANGE model=new Parking.Core.Model.CR_PARK_EXCHANGE();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["USER_ID"]!=null)
				{
					model.USER_ID=row["USER_ID"].ToString();
				}
				if(row["USER_ACCOUNT"]!=null)
				{
					model.USER_ACCOUNT=row["USER_ACCOUNT"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
				}
				if(row["LOGIN_TIME"]!=null && row["LOGIN_TIME"].ToString()!="")
				{
					model.LOGIN_TIME=DateTime.Parse(row["LOGIN_TIME"].ToString());
				}
				if(row["EIXT_TIME"]!=null && row["EIXT_TIME"].ToString()!="")
				{
					model.EIXT_TIME=DateTime.Parse(row["EIXT_TIME"].ToString());
				}
				if(row["ENTER_NUM"]!=null && row["ENTER_NUM"].ToString()!="")
				{
					model.ENTER_NUM=int.Parse(row["ENTER_NUM"].ToString());
				}
				if(row["EIXT_NUM"]!=null && row["EIXT_NUM"].ToString()!="")
				{
					model.EIXT_NUM=int.Parse(row["EIXT_NUM"].ToString());
				}
				if(row["DUE_MONEY"]!=null && row["DUE_MONEY"].ToString()!="")
				{
					model.DUE_MONEY=decimal.Parse(row["DUE_MONEY"].ToString());
				}
				if(row["PER_MONEY"]!=null && row["PER_MONEY"].ToString()!="")
				{
					model.PER_MONEY=decimal.Parse(row["PER_MONEY"].ToString());
				}
				if(row["WORK_STATUS"]!=null && row["WORK_STATUS"].ToString()!="")
				{
					model.WORK_STATUS=int.Parse(row["WORK_STATUS"].ToString());
				}
				if(row["WORKSTATION_NO"]!=null)
				{
					model.WORKSTATION_NO=row["WORKSTATION_NO"].ToString();
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
			strSql.Append("select ID,USER_ID,USER_ACCOUNT,USER_NAME,LOGIN_TIME,EIXT_TIME,ENTER_NUM,EIXT_NUM,DUE_MONEY,PER_MONEY,WORK_STATUS,WORKSTATION_NO ");
			strSql.Append(" FROM CR_PARK_EXCHANGE ");
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
			strSql.Append(" ID,USER_ID,USER_ACCOUNT,USER_NAME,LOGIN_TIME,EIXT_TIME,ENTER_NUM,EIXT_NUM,DUE_MONEY,PER_MONEY,WORK_STATUS,WORKSTATION_NO ");
			strSql.Append(" FROM CR_PARK_EXCHANGE ");
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
			strSql.Append("select count(1) FROM CR_PARK_EXCHANGE ");
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
			strSql.Append(")AS Row, T.*  from CR_PARK_EXCHANGE T ");
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
			parameters[0].Value = "CR_PARK_EXCHANGE";
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
        public Parking.Core.Model.CR_PARK_EXCHANGE GetModelByAccount(string USER_ACCOUNT, string WORKSTATION_NO)
        {
            //该?表à¨a无T主??键¨1信?息?é，ê?请?自á?定?§义°?主??键¨1/条??件t字á?段?
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,USER_ID,USER_ACCOUNT,USER_NAME,LOGIN_TIME,EIXT_TIME,ENTER_NUM,EIXT_NUM,DUE_MONEY,PER_MONEY,WORK_STATUS,WORKSTATION_NO from CR_PARK_EXCHANGE ");
            strSql.Append(" where USER_ACCOUNT=@USER_ACCOUNT and WORK_STATUS = 0 and WORKSTATION_NO=@WORKSTATION_NO");
            SqlParameter[] parameters = {
                    new SqlParameter("@USER_ACCOUNT", SqlDbType.VarChar,32),new SqlParameter("@WORKSTATION_NO", SqlDbType.VarChar,32)               };
            parameters[0].Value = USER_ACCOUNT;
            parameters[1].Value = WORKSTATION_NO;
            Parking.Core.Model.CR_PARK_EXCHANGE model = new Parking.Core.Model.CR_PARK_EXCHANGE();
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

