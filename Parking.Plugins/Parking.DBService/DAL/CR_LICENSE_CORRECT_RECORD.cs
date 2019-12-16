/**  版本信息模板在安装目录下，可自行修改。
* CR_LICENSE_CORRECT_RECORD.cs
*
* 功 能： N/A
* 类 名： CR_LICENSE_CORRECT_RECORD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:03   N/A    初版
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
using System.Linq;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;//Please add references
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Oragnization;

namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:CR_LICENSE_CORRECT_RECORD
	/// </summary>
	public partial class CR_LICENSE_CORRECT_RECORD
	{
		public CR_LICENSE_CORRECT_RECORD()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.CR_LICENSE_CORRECT_RECORD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CR_LICENSE_CORRECT_RECORD(");
			strSql.Append("ID,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO,INOUT_RECODE_ID,DEVICEID,CHANNEL_CODE,CHANGE_TIME,CHANGE_NAME,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@ID,@BEFORECHANGE_VEHNO,@AFTERCHANGE_VEHNO,@INOUT_RECODE_ID,@DEVICEID,@CHANNEL_CODE,@CHANGE_TIME,@CHANGE_NAME,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@BEFORECHANGE_VEHNO", SqlDbType.VarChar,20),
					new SqlParameter("@AFTERCHANGE_VEHNO", SqlDbType.VarChar,20),
					new SqlParameter("@INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@DEVICEID", SqlDbType.VarChar,32),
					new SqlParameter("@CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@CHANGE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHANGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.BEFORECHANGE_VEHNO;
			parameters[2].Value = model.AFTERCHANGE_VEHNO;
			parameters[3].Value = model.INOUT_RECODE_ID;
			parameters[4].Value = model.DEVICEID;
			parameters[5].Value = model.CHANNEL_CODE;
			parameters[6].Value = model.CHANGE_TIME;
			parameters[7].Value = model.CHANGE_NAME;
			parameters[8].Value = model.REMARK;

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
		public bool Update(Parking.Core.Model.CR_LICENSE_CORRECT_RECORD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CR_LICENSE_CORRECT_RECORD set ");
			strSql.Append("ID=@ID,");
			strSql.Append("BEFORECHANGE_VEHNO=@BEFORECHANGE_VEHNO,");
			strSql.Append("AFTERCHANGE_VEHNO=@AFTERCHANGE_VEHNO,");
			strSql.Append("INOUT_RECODE_ID=@INOUT_RECODE_ID,");
			strSql.Append("DEVICEID=@DEVICEID,");
			strSql.Append("CHANNEL_CODE=@CHANNEL_CODE,");
			strSql.Append("CHANGE_TIME=@CHANGE_TIME,");
			strSql.Append("CHANGE_NAME=@CHANGE_NAME,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@BEFORECHANGE_VEHNO", SqlDbType.VarChar,20),
					new SqlParameter("@AFTERCHANGE_VEHNO", SqlDbType.VarChar,20),
					new SqlParameter("@INOUT_RECODE_ID", SqlDbType.VarChar,32),
					new SqlParameter("@DEVICEID", SqlDbType.VarChar,32),
					new SqlParameter("@CHANNEL_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@CHANGE_TIME", SqlDbType.DateTime),
					new SqlParameter("@CHANGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.BEFORECHANGE_VEHNO;
			parameters[2].Value = model.AFTERCHANGE_VEHNO;
			parameters[3].Value = model.INOUT_RECODE_ID;
			parameters[4].Value = model.DEVICEID;
			parameters[5].Value = model.CHANNEL_CODE;
			parameters[6].Value = model.CHANGE_TIME;
			parameters[7].Value = model.CHANGE_NAME;
			parameters[8].Value = model.REMARK;

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
			strSql.Append("delete from CR_LICENSE_CORRECT_RECORD ");
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
		public Parking.Core.Model.CR_LICENSE_CORRECT_RECORD GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO,INOUT_RECODE_ID,DEVICEID,CHANNEL_CODE,CHANGE_TIME,CHANGE_NAME,REMARK from CR_LICENSE_CORRECT_RECORD ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Parking.Core.Model.CR_LICENSE_CORRECT_RECORD model=new Parking.Core.Model.CR_LICENSE_CORRECT_RECORD();
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
		public Parking.Core.Model.CR_LICENSE_CORRECT_RECORD DataRowToModel(DataRow row)
		{
			Parking.Core.Model.CR_LICENSE_CORRECT_RECORD model=new Parking.Core.Model.CR_LICENSE_CORRECT_RECORD();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["BEFORECHANGE_VEHNO"]!=null)
				{
					model.BEFORECHANGE_VEHNO=row["BEFORECHANGE_VEHNO"].ToString();
				}
				if(row["AFTERCHANGE_VEHNO"]!=null)
				{
					model.AFTERCHANGE_VEHNO=row["AFTERCHANGE_VEHNO"].ToString();
				}
				if(row["INOUT_RECODE_ID"]!=null)
				{
					model.INOUT_RECODE_ID=row["INOUT_RECODE_ID"].ToString();
				}
				if(row["DEVICEID"]!=null)
				{
					model.DEVICEID=row["DEVICEID"].ToString();
				}
				if(row["CHANNEL_CODE"]!=null)
				{
					model.CHANNEL_CODE=row["CHANNEL_CODE"].ToString();
				}
				if(row["CHANGE_TIME"]!=null && row["CHANGE_TIME"].ToString()!="")
				{
					model.CHANGE_TIME=DateTime.Parse(row["CHANGE_TIME"].ToString());
				}
				if(row["CHANGE_NAME"]!=null)
				{
					model.CHANGE_NAME=row["CHANGE_NAME"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select ID,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO,INOUT_RECODE_ID,DEVICEID,CHANNEL_CODE,CHANGE_TIME,CHANGE_NAME,REMARK ");
			strSql.Append(" FROM CR_LICENSE_CORRECT_RECORD ");
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
			strSql.Append(" ID,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO,INOUT_RECODE_ID,DEVICEID,CHANNEL_CODE,CHANGE_TIME,CHANGE_NAME,REMARK ");
			strSql.Append(" FROM CR_LICENSE_CORRECT_RECORD ");
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
			strSql.Append("select count(1) FROM CR_LICENSE_CORRECT_RECORD ");
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
			strSql.Append(")AS Row, T.*  from CR_LICENSE_CORRECT_RECORD T ");
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
			parameters[0].Value = "CR_LICENSE_CORRECT_RECORD";
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
        ///  初?始o?化?￥设|¨¨备à?统a3计?信?息?é
        /// </summary>
        public void InitRecognitioInfo()
        {
            var eques = GlobalEnvironment.ListOragnization.Where(x => x.channelType == enumChannelType.equ).ToList();

            string strSql = @"SELECT  DEVICEID ,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO,
                                        COUNT(DEVICEID) AS Count 
                                FROM    CR_LICENSE_CORRECT_RECORD
                                GROUP BY deviceid ,BEFORECHANGE_VEHNO,AFTERCHANGE_VEHNO";
            DataSet ds = DbHelperSQL.Query(strSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LicenseCorrect lc = new LicenseCorrect();
                    if (row["BeforeChange_VehNo"] != null)
                    {
                        lc.BeforeChange_VehNo = row["BeforeChange_VehNo"].ToString();
                    }
                    if (row["AfterChange_VehNo"] != null)
                    {
                        lc.AfterChange_VehNo = row["AfterChange_VehNo"].ToString();
                    }
                    if (row["DEVICEID"] != null)
                    {
                        lc.DeviceID = row["DEVICEID"].ToString();
                    }
                    if (row["Count"] != null)
                    {
                        lc.Count = Convert.ToInt32(row["Count"].ToString());
                    }
                    GlobalEnvironment.ListlicenseCorrect.Add(lc);
                }
            }
            foreach (var equ in eques)
            {
                var CurListlicenseCorrect = GlobalEnvironment.ListlicenseCorrect.Where(x => x.DeviceID == equ.ORGANIZATION_CODE).ToList();
                int ErrorCount = 0;
                foreach (var temp in CurListlicenseCorrect)
                {
                    equ.ListlicenseCorrect.Add(temp);
                    ErrorCount += temp.Count;
                }
                equ.ErrorCount = ErrorCount;
            }
        }
        #endregion  ExtensionMethod
    }
}

