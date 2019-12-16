/**  版本信息模板在安装目录下，可自行修改。
* FN_LAYOUT_SUBJECT.cs
*
* 功 能： N/A
* 类 名： FN_LAYOUT_SUBJECT
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:07   N/A    初版
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
	/// 数据访问类:FN_LAYOUT_SUBJECT
	/// </summary>
	public partial class FN_LAYOUT_SUBJECT
	{
		public FN_LAYOUT_SUBJECT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FN_LAYOUT_SUBJECT");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.FN_LAYOUT_SUBJECT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FN_LAYOUT_SUBJECT(");
			strSql.Append("ID,MAIN_ID,CLIENT_TYPE,WIDTH,HEIGHT,LEEF_X,LEEF_Y,PARENT_ID,CSS_INFO,DEVICE_ID,TITLE,NAME,HTML_TAG,PANEL_FLAG)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MAIN_ID,@CLIENT_TYPE,@WIDTH,@HEIGHT,@LEEF_X,@LEEF_Y,@PARENT_ID,@CSS_INFO,@DEVICE_ID,@TITLE,@NAME,@HTML_TAG,@PANEL_FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@MAIN_ID", SqlDbType.VarChar,32),
					new SqlParameter("@CLIENT_TYPE", SqlDbType.VarChar,255),
					new SqlParameter("@WIDTH", SqlDbType.Decimal,9),
					new SqlParameter("@HEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@LEEF_X", SqlDbType.Decimal,9),
					new SqlParameter("@LEEF_Y", SqlDbType.Decimal,9),
					new SqlParameter("@PARENT_ID", SqlDbType.VarChar,32),
					new SqlParameter("@CSS_INFO", SqlDbType.Text),
					new SqlParameter("@DEVICE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@TITLE", SqlDbType.VarChar,255),
					new SqlParameter("@NAME", SqlDbType.VarChar,255),
					new SqlParameter("@HTML_TAG", SqlDbType.VarChar,255),
					new SqlParameter("@PANEL_FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MAIN_ID;
			parameters[2].Value = model.CLIENT_TYPE;
			parameters[3].Value = model.WIDTH;
			parameters[4].Value = model.HEIGHT;
			parameters[5].Value = model.LEEF_X;
			parameters[6].Value = model.LEEF_Y;
			parameters[7].Value = model.PARENT_ID;
			parameters[8].Value = model.CSS_INFO;
			parameters[9].Value = model.DEVICE_ID;
			parameters[10].Value = model.TITLE;
			parameters[11].Value = model.NAME;
			parameters[12].Value = model.HTML_TAG;
			parameters[13].Value = model.PANEL_FLAG;

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
		public bool Update(Parking.Core.Model.FN_LAYOUT_SUBJECT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FN_LAYOUT_SUBJECT set ");
			strSql.Append("MAIN_ID=@MAIN_ID,");
			strSql.Append("CLIENT_TYPE=@CLIENT_TYPE,");
			strSql.Append("WIDTH=@WIDTH,");
			strSql.Append("HEIGHT=@HEIGHT,");
			strSql.Append("LEEF_X=@LEEF_X,");
			strSql.Append("LEEF_Y=@LEEF_Y,");
			strSql.Append("PARENT_ID=@PARENT_ID,");
			strSql.Append("CSS_INFO=@CSS_INFO,");
			strSql.Append("DEVICE_ID=@DEVICE_ID,");
			strSql.Append("TITLE=@TITLE,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("HTML_TAG=@HTML_TAG,");
			strSql.Append("PANEL_FLAG=@PANEL_FLAG");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAIN_ID", SqlDbType.VarChar,32),
					new SqlParameter("@CLIENT_TYPE", SqlDbType.VarChar,255),
					new SqlParameter("@WIDTH", SqlDbType.Decimal,9),
					new SqlParameter("@HEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@LEEF_X", SqlDbType.Decimal,9),
					new SqlParameter("@LEEF_Y", SqlDbType.Decimal,9),
					new SqlParameter("@PARENT_ID", SqlDbType.VarChar,32),
					new SqlParameter("@CSS_INFO", SqlDbType.Text),
					new SqlParameter("@DEVICE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@TITLE", SqlDbType.VarChar,255),
					new SqlParameter("@NAME", SqlDbType.VarChar,255),
					new SqlParameter("@HTML_TAG", SqlDbType.VarChar,255),
					new SqlParameter("@PANEL_FLAG", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.MAIN_ID;
			parameters[1].Value = model.CLIENT_TYPE;
			parameters[2].Value = model.WIDTH;
			parameters[3].Value = model.HEIGHT;
			parameters[4].Value = model.LEEF_X;
			parameters[5].Value = model.LEEF_Y;
			parameters[6].Value = model.PARENT_ID;
			parameters[7].Value = model.CSS_INFO;
			parameters[8].Value = model.DEVICE_ID;
			parameters[9].Value = model.TITLE;
			parameters[10].Value = model.NAME;
			parameters[11].Value = model.HTML_TAG;
			parameters[12].Value = model.PANEL_FLAG;
			parameters[13].Value = model.ID;

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
			strSql.Append("delete from FN_LAYOUT_SUBJECT ");
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
			strSql.Append("delete from FN_LAYOUT_SUBJECT ");
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
		public Parking.Core.Model.FN_LAYOUT_SUBJECT GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MAIN_ID,CLIENT_TYPE,WIDTH,HEIGHT,LEEF_X,LEEF_Y,PARENT_ID,CSS_INFO,DEVICE_ID,TITLE,NAME,HTML_TAG,PANEL_FLAG from FN_LAYOUT_SUBJECT ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.FN_LAYOUT_SUBJECT model=new Parking.Core.Model.FN_LAYOUT_SUBJECT();
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
		public Parking.Core.Model.FN_LAYOUT_SUBJECT DataRowToModel(DataRow row)
		{
			Parking.Core.Model.FN_LAYOUT_SUBJECT model=new Parking.Core.Model.FN_LAYOUT_SUBJECT();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MAIN_ID"]!=null)
				{
					model.MAIN_ID=row["MAIN_ID"].ToString();
				}
				if(row["CLIENT_TYPE"]!=null)
				{
					model.CLIENT_TYPE=row["CLIENT_TYPE"].ToString();
				}
				if(row["WIDTH"]!=null && row["WIDTH"].ToString()!="")
				{
					model.WIDTH=decimal.Parse(row["WIDTH"].ToString());
				}
				if(row["HEIGHT"]!=null && row["HEIGHT"].ToString()!="")
				{
					model.HEIGHT=decimal.Parse(row["HEIGHT"].ToString());
				}
				if(row["LEEF_X"]!=null && row["LEEF_X"].ToString()!="")
				{
					model.LEEF_X=decimal.Parse(row["LEEF_X"].ToString());
				}
				if(row["LEEF_Y"]!=null && row["LEEF_Y"].ToString()!="")
				{
					model.LEEF_Y=decimal.Parse(row["LEEF_Y"].ToString());
				}
				if(row["PARENT_ID"]!=null)
				{
					model.PARENT_ID=row["PARENT_ID"].ToString();
				}
				if(row["CSS_INFO"]!=null)
				{
					model.CSS_INFO=row["CSS_INFO"].ToString();
				}
				if(row["DEVICE_ID"]!=null)
				{
					model.DEVICE_ID=row["DEVICE_ID"].ToString();
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["HTML_TAG"]!=null)
				{
					model.HTML_TAG=row["HTML_TAG"].ToString();
				}
				if(row["PANEL_FLAG"]!=null && row["PANEL_FLAG"].ToString()!="")
				{
					model.PANEL_FLAG=int.Parse(row["PANEL_FLAG"].ToString());
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
			strSql.Append("select ID,MAIN_ID,CLIENT_TYPE,WIDTH,HEIGHT,LEEF_X,LEEF_Y,PARENT_ID,CSS_INFO,DEVICE_ID,TITLE,NAME,HTML_TAG,PANEL_FLAG ");
			strSql.Append(" FROM FN_LAYOUT_SUBJECT ");
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
			strSql.Append(" ID,MAIN_ID,CLIENT_TYPE,WIDTH,HEIGHT,LEEF_X,LEEF_Y,PARENT_ID,CSS_INFO,DEVICE_ID,TITLE,NAME,HTML_TAG,PANEL_FLAG ");
			strSql.Append(" FROM FN_LAYOUT_SUBJECT ");
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
			strSql.Append("select count(1) FROM FN_LAYOUT_SUBJECT ");
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
			strSql.Append(")AS Row, T.*  from FN_LAYOUT_SUBJECT T ");
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
			parameters[0].Value = "FN_LAYOUT_SUBJECT";
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
        public List<Parking.Core.Model.FN_LAYOUT_SUBJECT> GetPlugins(string WorkStationID, string ParentID = "1")
        {
            string strSql = @"SELECT  *  FROM    dbo.FN_LAYOUT_SUBJECT  WHERE   PARENT_ID = '{0}'  AND MAIN_ID = '{1}' ";
            strSql = string.Format(strSql, ParentID, WorkStationID);

            List<Parking.Core.Model.FN_LAYOUT_SUBJECT> list = new List<Core.Model.FN_LAYOUT_SUBJECT>();
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

