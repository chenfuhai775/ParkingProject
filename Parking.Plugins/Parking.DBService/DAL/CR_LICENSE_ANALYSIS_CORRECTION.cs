/**  版本信息模板在安装目录下，可自行修改。
* CR_LICENSE_ANALYSIS_CORRECTION.cs
*
* 功 能： N/A
* 类 名： CR_LICENSE_ANALYSIS_CORRECTION
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	/// 数据访问类:CR_LICENSE_ANALYSIS_CORRECTION
	/// </summary>
	public partial class CR_LICENSE_ANALYSIS_CORRECTION
	{
		public CR_LICENSE_ANALYSIS_CORRECTION()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_LICENSE_ANALYSIS_CORRECTION(");
			strSql.Append("ID,VEH_NO_ERROR,VEH_NO_CORRECT,PASSAGE_COUNT,ERROR_COUNT,CORRECT_FLAG,CREATE_TIME,UPDATE_TIME,UPDATE_USERNAME)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ID,SQL2012VEH_NO_ERROR,SQL2012VEH_NO_CORRECT,SQL2012PASSAGE_COUNT,SQL2012ERROR_COUNT,SQL2012CORRECT_FLAG,SQL2012CREATE_TIME,SQL2012UPDATE_TIME,SQL2012UPDATE_USERNAME)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012VEH_NO_ERROR", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEH_NO_CORRECT", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PASSAGE_COUNT", SqlDbType.Int,4),
					new SqlParameter("SQL2012ERROR_COUNT", SqlDbType.Int,4),
					new SqlParameter("SQL2012CORRECT_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.VEH_NO_ERROR;
			parameters[2].Value = model.VEH_NO_CORRECT;
			parameters[3].Value = model.PASSAGE_COUNT;
			parameters[4].Value = model.ERROR_COUNT;
			parameters[5].Value = model.CORRECT_FLAG;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.UPDATE_TIME;
			parameters[8].Value = model.UPDATE_USERNAME;

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
		public bool Update(Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_LICENSE_ANALYSIS_CORRECTION set ");
			strSql.Append("ID=SQL2012ID,");
			strSql.Append("VEH_NO_ERROR=SQL2012VEH_NO_ERROR,");
			strSql.Append("VEH_NO_CORRECT=SQL2012VEH_NO_CORRECT,");
			strSql.Append("PASSAGE_COUNT=SQL2012PASSAGE_COUNT,");
			strSql.Append("ERROR_COUNT=SQL2012ERROR_COUNT,");
			strSql.Append("CORRECT_FLAG=SQL2012CORRECT_FLAG,");
			strSql.Append("CREATE_TIME=SQL2012CREATE_TIME,");
			strSql.Append("UPDATE_TIME=SQL2012UPDATE_TIME,");
			strSql.Append("UPDATE_USERNAME=SQL2012UPDATE_USERNAME");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.VarChar,32),
					new SqlParameter("SQL2012VEH_NO_ERROR", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012VEH_NO_CORRECT", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012PASSAGE_COUNT", SqlDbType.Int,4),
					new SqlParameter("SQL2012ERROR_COUNT", SqlDbType.Int,4),
					new SqlParameter("SQL2012CORRECT_FLAG", SqlDbType.Int,4),
					new SqlParameter("SQL2012CREATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_TIME", SqlDbType.DateTime),
					new SqlParameter("SQL2012UPDATE_USERNAME", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.VEH_NO_ERROR;
			parameters[2].Value = model.VEH_NO_CORRECT;
			parameters[3].Value = model.PASSAGE_COUNT;
			parameters[4].Value = model.ERROR_COUNT;
			parameters[5].Value = model.CORRECT_FLAG;
			parameters[6].Value = model.CREATE_TIME;
			parameters[7].Value = model.UPDATE_TIME;
			parameters[8].Value = model.UPDATE_USERNAME;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CR_LICENSE_ANALYSIS_CORRECTION ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,VEH_NO_ERROR,VEH_NO_CORRECT,PASSAGE_COUNT,ERROR_COUNT,CORRECT_FLAG,CREATE_TIME,UPDATE_TIME,UPDATE_USERNAME from CR_LICENSE_ANALYSIS_CORRECTION ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION model=new Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION();
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
		public Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION model=new Parking.Core.Model.CR_LICENSE_ANALYSIS_CORRECTION();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["VEH_NO_ERROR"]!=null)
				{
					model.VEH_NO_ERROR=row["VEH_NO_ERROR"].ToString();
				}
				if(row["VEH_NO_CORRECT"]!=null)
				{
					model.VEH_NO_CORRECT=row["VEH_NO_CORRECT"].ToString();
				}
				if(row["PASSAGE_COUNT"]!=null && row["PASSAGE_COUNT"].ToString()!="")
				{
					model.PASSAGE_COUNT=int.Parse(row["PASSAGE_COUNT"].ToString());
				}
				if(row["ERROR_COUNT"]!=null && row["ERROR_COUNT"].ToString()!="")
				{
					model.ERROR_COUNT=int.Parse(row["ERROR_COUNT"].ToString());
				}
				if(row["CORRECT_FLAG"]!=null && row["CORRECT_FLAG"].ToString()!="")
				{
					model.CORRECT_FLAG=int.Parse(row["CORRECT_FLAG"].ToString());
				}
				if(row["CREATE_TIME"]!=null && row["CREATE_TIME"].ToString()!="")
				{
					model.CREATE_TIME=DateTime.Parse(row["CREATE_TIME"].ToString());
				}
				if(row["UPDATE_TIME"]!=null && row["UPDATE_TIME"].ToString()!="")
				{
					model.UPDATE_TIME=DateTime.Parse(row["UPDATE_TIME"].ToString());
				}
				if(row["UPDATE_USERNAME"]!=null)
				{
					model.UPDATE_USERNAME=row["UPDATE_USERNAME"].ToString();
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
			strSql.Append("select ID,VEH_NO_ERROR,VEH_NO_CORRECT,PASSAGE_COUNT,ERROR_COUNT,CORRECT_FLAG,CREATE_TIME,UPDATE_TIME,UPDATE_USERNAME ");
			strSql.Append(" FROM CR_LICENSE_ANALYSIS_CORRECTION ");
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
			strSql.Append(" ID,VEH_NO_ERROR,VEH_NO_CORRECT,PASSAGE_COUNT,ERROR_COUNT,CORRECT_FLAG,CREATE_TIME,UPDATE_TIME,UPDATE_USERNAME ");
			strSql.Append(" FROM CR_LICENSE_ANALYSIS_CORRECTION ");
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
			strSql.Append("select count(1) FROM CR_LICENSE_ANALYSIS_CORRECTION ");
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
			strSql.Append(")AS Row, T.*  from CR_LICENSE_ANALYSIS_CORRECTION T ");
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
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "CR_LICENSE_ANALYSIS_CORRECTION";
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

		#endregion  ExtensionMethod
	}
}

