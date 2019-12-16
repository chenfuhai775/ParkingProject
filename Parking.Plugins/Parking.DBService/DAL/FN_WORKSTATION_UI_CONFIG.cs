/**  版本信息模板在安装目录下，可自行修改。
* FN_WORKSTATION_UI_CONFIG.cs
*
* 功 能： N/A
* 类 名： FN_WORKSTATION_UI_CONFIG
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
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:FN_WORKSTATION_UI_CONFIG
	/// </summary>
	public partial class FN_WORKSTATION_UI_CONFIG
	{
		public FN_WORKSTATION_UI_CONFIG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FN_WORKSTATION_UI_CONFIG");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FN_WORKSTATION_UI_CONFIG(");
			strSql.Append("ID,WORKSTATION_CODE,FIXED_FLAG,RESOURCE_CODE,RESOLUTION,INITIAL_WIDTH,INITIAL_HEIGHT,INITIAL_LEFT_WIDTH,INITIAL_TOP_HEIGHT,CREATE_TIME,CREATE_USERID,TEMP_NAME,TEMP_CODE,BELONG_USERID,PUBLIC_FLAG)");
			strSql.Append(" values (");
			strSql.Append("@ID,@WORKSTATION_CODE,@FIXED_FLAG,@RESOURCE_CODE,@RESOLUTION,@INITIAL_WIDTH,@INITIAL_HEIGHT,@INITIAL_LEFT_WIDTH,@INITIAL_TOP_HEIGHT,@CREATE_TIME,@CREATE_USERID,@TEMP_NAME,@TEMP_CODE,@BELONG_USERID,@PUBLIC_FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@WORKSTATION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@FIXED_FLAG", SqlDbType.Int,4),
					new SqlParameter("@RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@RESOLUTION", SqlDbType.VarChar,50),
					new SqlParameter("@INITIAL_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEFT_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_TOP_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@TEMP_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TEMP_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@BELONG_USERID", SqlDbType.VarChar,32),
					new SqlParameter("@PUBLIC_FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.WORKSTATION_CODE;
			parameters[2].Value = model.FIXED_FLAG;
			parameters[3].Value = model.RESOURCE_CODE;
			parameters[4].Value = model.RESOLUTION;
			parameters[5].Value = model.INITIAL_WIDTH;
			parameters[6].Value = model.INITIAL_HEIGHT;
			parameters[7].Value = model.INITIAL_LEFT_WIDTH;
			parameters[8].Value = model.INITIAL_TOP_HEIGHT;
			parameters[9].Value = model.CREATE_TIME;
			parameters[10].Value = model.CREATE_USERID;
			parameters[11].Value = model.TEMP_NAME;
			parameters[12].Value = model.TEMP_CODE;
			parameters[13].Value = model.BELONG_USERID;
			parameters[14].Value = model.PUBLIC_FLAG;

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
		public bool Update(Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FN_WORKSTATION_UI_CONFIG set ");
			strSql.Append("WORKSTATION_CODE=@WORKSTATION_CODE,");
			strSql.Append("FIXED_FLAG=@FIXED_FLAG,");
			strSql.Append("RESOURCE_CODE=@RESOURCE_CODE,");
			strSql.Append("RESOLUTION=@RESOLUTION,");
			strSql.Append("INITIAL_WIDTH=@INITIAL_WIDTH,");
			strSql.Append("INITIAL_HEIGHT=@INITIAL_HEIGHT,");
			strSql.Append("INITIAL_LEFT_WIDTH=@INITIAL_LEFT_WIDTH,");
			strSql.Append("INITIAL_TOP_HEIGHT=@INITIAL_TOP_HEIGHT,");
			strSql.Append("CREATE_TIME=@CREATE_TIME,");
			strSql.Append("CREATE_USERID=@CREATE_USERID,");
			strSql.Append("TEMP_NAME=@TEMP_NAME,");
			strSql.Append("TEMP_CODE=@TEMP_CODE,");
			strSql.Append("BELONG_USERID=@BELONG_USERID,");
			strSql.Append("PUBLIC_FLAG=@PUBLIC_FLAG");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKSTATION_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@FIXED_FLAG", SqlDbType.Int,4),
					new SqlParameter("@RESOURCE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@RESOLUTION", SqlDbType.VarChar,50),
					new SqlParameter("@INITIAL_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_LEFT_WIDTH", SqlDbType.Int,4),
					new SqlParameter("@INITIAL_TOP_HEIGHT", SqlDbType.Int,4),
					new SqlParameter("@CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CREATE_USERID", SqlDbType.VarChar,50),
					new SqlParameter("@TEMP_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TEMP_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@BELONG_USERID", SqlDbType.VarChar,32),
					new SqlParameter("@PUBLIC_FLAG", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.WORKSTATION_CODE;
			parameters[1].Value = model.FIXED_FLAG;
			parameters[2].Value = model.RESOURCE_CODE;
			parameters[3].Value = model.RESOLUTION;
			parameters[4].Value = model.INITIAL_WIDTH;
			parameters[5].Value = model.INITIAL_HEIGHT;
			parameters[6].Value = model.INITIAL_LEFT_WIDTH;
			parameters[7].Value = model.INITIAL_TOP_HEIGHT;
			parameters[8].Value = model.CREATE_TIME;
			parameters[9].Value = model.CREATE_USERID;
			parameters[10].Value = model.TEMP_NAME;
			parameters[11].Value = model.TEMP_CODE;
			parameters[12].Value = model.BELONG_USERID;
			parameters[13].Value = model.PUBLIC_FLAG;
			parameters[14].Value = model.ID;

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
			strSql.Append("delete from FN_WORKSTATION_UI_CONFIG ");
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
			strSql.Append("delete from FN_WORKSTATION_UI_CONFIG ");
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
		public Parking.Core.Model.FN_WORKSTATION_UI_CONFIG GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,WORKSTATION_CODE,FIXED_FLAG,RESOURCE_CODE,RESOLUTION,INITIAL_WIDTH,INITIAL_HEIGHT,INITIAL_LEFT_WIDTH,INITIAL_TOP_HEIGHT,CREATE_TIME,CREATE_USERID,TEMP_NAME,TEMP_CODE,BELONG_USERID,PUBLIC_FLAG from FN_WORKSTATION_UI_CONFIG ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model=new Parking.Core.Model.FN_WORKSTATION_UI_CONFIG();
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
		public Parking.Core.Model.FN_WORKSTATION_UI_CONFIG DataRowToModel(DataRow row)
		{
			Parking.Core.Model.FN_WORKSTATION_UI_CONFIG model=new Parking.Core.Model.FN_WORKSTATION_UI_CONFIG();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["WORKSTATION_CODE"]!=null)
				{
					model.WORKSTATION_CODE=row["WORKSTATION_CODE"].ToString();
				}
				if(row["FIXED_FLAG"]!=null && row["FIXED_FLAG"].ToString()!="")
				{
					model.FIXED_FLAG=int.Parse(row["FIXED_FLAG"].ToString());
				}
				if(row["RESOURCE_CODE"]!=null)
				{
					model.RESOURCE_CODE=row["RESOURCE_CODE"].ToString();
				}
				if(row["RESOLUTION"]!=null)
				{
					model.RESOLUTION=row["RESOLUTION"].ToString();
				}
				if(row["INITIAL_WIDTH"]!=null && row["INITIAL_WIDTH"].ToString()!="")
				{
					model.INITIAL_WIDTH=int.Parse(row["INITIAL_WIDTH"].ToString());
				}
				if(row["INITIAL_HEIGHT"]!=null && row["INITIAL_HEIGHT"].ToString()!="")
				{
					model.INITIAL_HEIGHT=int.Parse(row["INITIAL_HEIGHT"].ToString());
				}
				if(row["INITIAL_LEFT_WIDTH"]!=null && row["INITIAL_LEFT_WIDTH"].ToString()!="")
				{
					model.INITIAL_LEFT_WIDTH=int.Parse(row["INITIAL_LEFT_WIDTH"].ToString());
				}
				if(row["INITIAL_TOP_HEIGHT"]!=null && row["INITIAL_TOP_HEIGHT"].ToString()!="")
				{
					model.INITIAL_TOP_HEIGHT=int.Parse(row["INITIAL_TOP_HEIGHT"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["CREATE_USERID"]!=null)
				{
					model.CREATE_USERID=row["CREATE_USERID"].ToString();
				}
				if(row["TEMP_NAME"]!=null)
				{
					model.TEMP_NAME=row["TEMP_NAME"].ToString();
				}
				if(row["TEMP_CODE"]!=null)
				{
					model.TEMP_CODE=row["TEMP_CODE"].ToString();
				}
				if(row["BELONG_USERID"]!=null)
				{
					model.BELONG_USERID=row["BELONG_USERID"].ToString();
				}
				if(row["PUBLIC_FLAG"]!=null && row["PUBLIC_FLAG"].ToString()!="")
				{
					model.PUBLIC_FLAG=int.Parse(row["PUBLIC_FLAG"].ToString());
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
			strSql.Append("select ID,WORKSTATION_CODE,FIXED_FLAG,RESOURCE_CODE,RESOLUTION,INITIAL_WIDTH,INITIAL_HEIGHT,INITIAL_LEFT_WIDTH,INITIAL_TOP_HEIGHT,CREATE_TIME,CREATE_USERID,TEMP_NAME,TEMP_CODE,BELONG_USERID,PUBLIC_FLAG ");
			strSql.Append(" FROM FN_WORKSTATION_UI_CONFIG ");
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
			strSql.Append(" ID,WORKSTATION_CODE,FIXED_FLAG,RESOURCE_CODE,RESOLUTION,INITIAL_WIDTH,INITIAL_HEIGHT,INITIAL_LEFT_WIDTH,INITIAL_TOP_HEIGHT,CREATE_TIME,CREATE_USERID,TEMP_NAME,TEMP_CODE,BELONG_USERID,PUBLIC_FLAG ");
			strSql.Append(" FROM FN_WORKSTATION_UI_CONFIG ");
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
			strSql.Append("select count(1) FROM FN_WORKSTATION_UI_CONFIG ");
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
			strSql.Append(")AS Row, T.*  from FN_WORKSTATION_UI_CONFIG T ");
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
			parameters[0].Value = "FN_WORKSTATION_UI_CONFIG";
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
        public Core.Model.FN_WORKSTATION_UI_CONFIG GetLayOutByIP(string IP)
        {
            string strSQL = @"SELECT TOP 1
                                        *
                                FROM    dbo.FN_WORKSTATION_UI_CONFIG
                                WHERE   WORKSTATION_CODE = ( SELECT ORGANIZATION_CODE
                                                             FROM   dbo.PBA_PARKING_PARAM_SETTINGS
                                                             WHERE  DISPLAY_KEY = 'ip'
                                                                    AND DISPLAY_VALUE = '{0}'
                                                           )";
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format(strSQL, IP));
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

