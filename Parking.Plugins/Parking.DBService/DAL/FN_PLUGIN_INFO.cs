/**  版本信息模板在安装目录下，可自行修改。
* FN_PLUGIN_INFO.cs
*
* 功 能： N/A
* 类 名： FN_PLUGIN_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:08   N/A    初版
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
using System.Collections.Generic;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:FN_PLUGIN_INFO
	/// </summary>
	public partial class FN_PLUGIN_INFO
	{
		public FN_PLUGIN_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FN_PLUGIN_INFO");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.FN_PLUGIN_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FN_PLUGIN_INFO(");
			strSql.Append("ID,WORKSTATION_ID,PLUGIN_TYPE_CODE,PLUGIN_NAME,PARENT_ID,INITIAL_HEIGHT,INITIAL_WIDTH,INITIAL_TOP_HEIGHT,INITIAL_LEFT_WIDTH,ENABLE,ABSOLUTE,CREATE_TIME,CREATE_USERID)");
			strSql.Append(" values (");
			strSql.Append("@ID,@WORKSTATION_ID,@PLUGIN_TYPE_CODE,@PLUGIN_NAME,@PARENT_ID,@INITIAL_HEIGHT,@INITIAL_WIDTH,@INITIAL_TOP_HEIGHT,@INITIAL_LEFT_WIDTH,@ENABLE,@ABSOLUTE,@CREATE_TIME,@CREATE_USERID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@WORKSTATION_ID", SqlDbType.VarChar,32),
					new SqlParameter("@PLUGIN_TYPE_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@PLUGIN_NAME", SqlDbType.VarChar,32),
					new SqlParameter("@PARENT_ID", SqlDbType.VarChar,32),
					new SqlParameter("@INITIAL_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_TOP_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEFT_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@ENABLE", SqlDbType.Bit,1),
					new SqlParameter("@ABSOLUTE", SqlDbType.Bit,1),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.WORKSTATION_ID;
			parameters[2].Value = model.PLUGIN_TYPE_CODE;
			parameters[3].Value = model.PLUGIN_NAME;
			parameters[4].Value = model.PARENT_ID;
			parameters[5].Value = model.INITIAL_HEIGHT;
			parameters[6].Value = model.INITIAL_WIDTH;
			parameters[7].Value = model.INITIAL_TOP_HEIGHT;
			parameters[8].Value = model.INITIAL_LEFT_WIDTH;
			parameters[9].Value = model.ENABLE;
			parameters[10].Value = model.ABSOLUTE;
			parameters[11].Value = model.CREATE_TIME;
			parameters[12].Value = model.CREATE_USERID;

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
		public bool Update(Parking.Core.Model.FN_PLUGIN_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FN_PLUGIN_INFO set ");
			strSql.Append("WORKSTATION_ID=@WORKSTATION_ID,");
			strSql.Append("PLUGIN_TYPE_CODE=@PLUGIN_TYPE_CODE,");
			strSql.Append("PLUGIN_NAME=@PLUGIN_NAME,");
			strSql.Append("PARENT_ID=@PARENT_ID,");
			strSql.Append("INITIAL_HEIGHT=@INITIAL_HEIGHT,");
			strSql.Append("INITIAL_WIDTH=@INITIAL_WIDTH,");
			strSql.Append("INITIAL_TOP_HEIGHT=@INITIAL_TOP_HEIGHT,");
			strSql.Append("INITIAL_LEFT_WIDTH=@INITIAL_LEFT_WIDTH,");
			strSql.Append("ENABLE=@ENABLE,");
			strSql.Append("ABSOLUTE=@ABSOLUTE,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKSTATION_ID", SqlDbType.VarChar,32),
					new SqlParameter("@PLUGIN_TYPE_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@PLUGIN_NAME", SqlDbType.VarChar,32),
					new SqlParameter("@PARENT_ID", SqlDbType.VarChar,32),
					new SqlParameter("@INITIAL_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_TOP_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEFT_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@ENABLE", SqlDbType.Bit,1),
					new SqlParameter("@ABSOLUTE", SqlDbType.Bit,1),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,32),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.WORKSTATION_ID;
			parameters[1].Value = model.PLUGIN_TYPE_CODE;
			parameters[2].Value = model.PLUGIN_NAME;
			parameters[3].Value = model.PARENT_ID;
			parameters[4].Value = model.INITIAL_HEIGHT;
			parameters[5].Value = model.INITIAL_WIDTH;
			parameters[6].Value = model.INITIAL_TOP_HEIGHT;
			parameters[7].Value = model.INITIAL_LEFT_WIDTH;
			parameters[8].Value = model.ENABLE;
			parameters[9].Value = model.ABSOLUTE;
			parameters[10].Value = model.CREATE_TIME;
			parameters[11].Value = model.CREATE_USERID;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from FN_PLUGIN_INFO ");
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
			strSql.Append("delete from FN_PLUGIN_INFO ");
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
		public Parking.Core.Model.FN_PLUGIN_INFO GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,WORKSTATION_ID,PLUGIN_TYPE_CODE,PLUGIN_NAME,PARENT_ID,INITIAL_HEIGHT,INITIAL_WIDTH,INITIAL_TOP_HEIGHT,INITIAL_LEFT_WIDTH,ENABLE,ABSOLUTE,CREATE_TIME,CREATE_USERID from FN_PLUGIN_INFO ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.FN_PLUGIN_INFO model=new Parking.Core.Model.FN_PLUGIN_INFO();
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
		public Parking.Core.Model.FN_PLUGIN_INFO DataRowToModel(DataRow row)
		{
			Parking.Core.Model.FN_PLUGIN_INFO model=new Parking.Core.Model.FN_PLUGIN_INFO();
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
				if(row["PLUGIN_TYPE_CODE"]!=null)
				{
					model.PLUGIN_TYPE_CODE=row["PLUGIN_TYPE_CODE"].ToString();
				}
				if(row["PLUGIN_NAME"]!=null)
				{
					model.PLUGIN_NAME=row["PLUGIN_NAME"].ToString();
				}
				if(row["PARENT_ID"]!=null)
				{
					model.PARENT_ID=row["PARENT_ID"].ToString();
				}
				if(row["INITIAL_HEIGHT"]!=null && row["INITIAL_HEIGHT"].ToString()!="")
				{
					model.INITIAL_HEIGHT=int.Parse(row["INITIAL_HEIGHT"].ToString());
				}
				if(row["INITIAL_WIDTH"]!=null && row["INITIAL_WIDTH"].ToString()!="")
				{
					model.INITIAL_WIDTH=int.Parse(row["INITIAL_WIDTH"].ToString());
				}
				if(row["INITIAL_TOP_HEIGHT"]!=null && row["INITIAL_TOP_HEIGHT"].ToString()!="")
				{
					model.INITIAL_TOP_HEIGHT=int.Parse(row["INITIAL_TOP_HEIGHT"].ToString());
				}
				if(row["INITIAL_LEFT_WIDTH"]!=null && row["INITIAL_LEFT_WIDTH"].ToString()!="")
				{
					model.INITIAL_LEFT_WIDTH=int.Parse(row["INITIAL_LEFT_WIDTH"].ToString());
				}
				if(row["ENABLE"]!=null && row["ENABLE"].ToString()!="")
				{
					if((row["ENABLE"].ToString()=="1")||(row["ENABLE"].ToString().ToLower()=="true"))
					{
						model.ENABLE=true;
					}
					else
					{
						model.ENABLE=false;
					}
				}
				if(row["ABSOLUTE"]!=null && row["ABSOLUTE"].ToString()!="")
				{
					if((row["ABSOLUTE"].ToString()=="1")||(row["ABSOLUTE"].ToString().ToLower()=="true"))
					{
						model.ABSOLUTE=true;
					}
					else
					{
						model.ABSOLUTE=false;
					}
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
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
			strSql.Append("select ID,WORKSTATION_ID,PLUGIN_TYPE_CODE,PLUGIN_NAME,PARENT_ID,INITIAL_HEIGHT,INITIAL_WIDTH,INITIAL_TOP_HEIGHT,INITIAL_LEFT_WIDTH,ENABLE,ABSOLUTE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM FN_PLUGIN_INFO ");
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
			strSql.Append(" ID,WORKSTATION_ID,PLUGIN_TYPE_CODE,PLUGIN_NAME,PARENT_ID,INITIAL_HEIGHT,INITIAL_WIDTH,INITIAL_TOP_HEIGHT,INITIAL_LEFT_WIDTH,ENABLE,ABSOLUTE,CREATE_TIME,CREATE_USERID ");
			strSql.Append(" FROM FN_PLUGIN_INFO ");
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
			strSql.Append("select count(1) FROM FN_PLUGIN_INFO ");
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
			strSql.Append(")AS Row, T.*  from FN_PLUGIN_INFO T ");
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
			parameters[0].Value = "FN_PLUGIN_INFO";
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
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public List<Parking.Core.Model.FN_PLUGIN_INFO> GetListTree(string WorkStationIP)
        {
            string strSql = @"WITH    cteTree
                                  AS ( SELECT   *
                                       FROM     FN_PLUGIN_INFO
                                       WHERE    WORKSTATION_ID = '{0}'
                                       UNION ALL
                                       SELECT   FN_PLUGIN_INFO.*     
                                       FROM     cteTree
                                                INNER JOIN FN_PLUGIN_INFO ON cteTree.ID = FN_PLUGIN_INFO.PARENT_ID
                                     )
                            SELECT  *
                            FROM    cteTree ";
            strSql = string.Format(strSql, WorkStationIP);
            List<Parking.Core.Model.FN_PLUGIN_INFO> list = new List<Core.Model.FN_PLUGIN_INFO>();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }
            return list;
        }
        public List<Parking.Core.Model.FN_PLUGIN_INFO> GetPlugins(string PluginName, string WorkStationIP)
        {
            string strSql = @"SELECT  * FROM  dbo.FN_PLUGIN_INFO
                                WHERE   PARENT_ID = ( SELECT TOP 1
                                                                ID
                                                      FROM      FN_PLUGIN_INFO
                                                      WHERE     PLUGIN_NAME = '{0}'
                                                                AND WORKSTATION_ID = {1}
                                                    )  AND dbo.FN_PLUGIN_INFO.WORKSTATION_ID = {2} ";
            strSql = string.Format(strSql, PluginName, WorkStationIP, WorkStationIP);
            List<Parking.Core.Model.FN_PLUGIN_INFO> list = new List<Core.Model.FN_PLUGIN_INFO>();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }
            return list;
        }
        #endregion  ExtensionMethod
    }
}

