/**  版本信息模板在安装目录下，可自行修改。
* WF_ProcessNode.cs
*
* 功 能： N/A
* 类 名： WF_ProcessNode
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:27   N/A    初版
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
using Parking.Core.Enum;
namespace Parking.DBService.DAL
{
	/// <summary>
	/// 数据访问类:WF_ProcessNode
	/// </summary>
	public partial class WF_ProcessNode
	{
		public WF_ProcessNode()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_ProcessNode");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Parking.Core.Model.WF_ProcessNode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_ProcessNode(");
			strSql.Append("ID,NodeName,NodeCode,FlowID,PreviousNode,NextNode,JumpNode,DeterMine,IsModel,PN_Flag,PN_Sort,Remark,POSITION_X,POSITION_Y)");
			strSql.Append(" values (");
			strSql.Append("@ID,@NodeName,@NodeCode,@FlowID,@PreviousNode,@NextNode,@JumpNode,@DeterMine,@IsModel,@PN_Flag,@PN_Sort,@Remark,@POSITION_X,@POSITION_Y)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32),
					new SqlParameter("@NodeName", SqlDbType.VarChar,32),
					new SqlParameter("@NodeCode", SqlDbType.VarChar,32),
					new SqlParameter("@FlowID", SqlDbType.VarChar,32),
					new SqlParameter("@PreviousNode", SqlDbType.VarChar,32),
					new SqlParameter("@NextNode", SqlDbType.VarChar,32),
					new SqlParameter("@JumpNode", SqlDbType.VarChar,32),
					new SqlParameter("@DeterMine", SqlDbType.Bit,1),
					new SqlParameter("@IsModel", SqlDbType.Bit,1),
					new SqlParameter("@PN_Flag", SqlDbType.Bit,1),
					new SqlParameter("@PN_Sort", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@POSITION_X", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION_Y", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NodeName;
			parameters[2].Value = model.NodeCode;
			parameters[3].Value = model.FlowID;
			parameters[4].Value = model.PreviousNode;
			parameters[5].Value = model.NextNode;
			parameters[6].Value = model.JumpNode;
			parameters[7].Value = model.DeterMine;
			parameters[8].Value = model.IsModel;
			parameters[9].Value = model.PN_Flag;
			parameters[10].Value = model.PN_Sort;
			parameters[11].Value = model.Remark;
			parameters[12].Value = model.POSITION_X;
			parameters[13].Value = model.POSITION_Y;

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
		public bool Update(Parking.Core.Model.WF_ProcessNode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_ProcessNode set ");
			strSql.Append("NodeName=@NodeName,");
			strSql.Append("NodeCode=@NodeCode,");
			strSql.Append("FlowID=@FlowID,");
			strSql.Append("PreviousNode=@PreviousNode,");
			strSql.Append("NextNode=@NextNode,");
			strSql.Append("JumpNode=@JumpNode,");
			strSql.Append("DeterMine=@DeterMine,");
			strSql.Append("IsModel=@IsModel,");
			strSql.Append("PN_Flag=@PN_Flag,");
			strSql.Append("PN_Sort=@PN_Sort,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("POSITION_X=@POSITION_X,");
			strSql.Append("POSITION_Y=@POSITION_Y");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NodeName", SqlDbType.VarChar,32),
					new SqlParameter("@NodeCode", SqlDbType.VarChar,32),
					new SqlParameter("@FlowID", SqlDbType.VarChar,32),
					new SqlParameter("@PreviousNode", SqlDbType.VarChar,32),
					new SqlParameter("@NextNode", SqlDbType.VarChar,32),
					new SqlParameter("@JumpNode", SqlDbType.VarChar,32),
					new SqlParameter("@DeterMine", SqlDbType.Bit,1),
					new SqlParameter("@IsModel", SqlDbType.Bit,1),
					new SqlParameter("@PN_Flag", SqlDbType.Bit,1),
					new SqlParameter("@PN_Sort", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@POSITION_X", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION_Y", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.VarChar,32)};
			parameters[0].Value = model.NodeName;
			parameters[1].Value = model.NodeCode;
			parameters[2].Value = model.FlowID;
			parameters[3].Value = model.PreviousNode;
			parameters[4].Value = model.NextNode;
			parameters[5].Value = model.JumpNode;
			parameters[6].Value = model.DeterMine;
			parameters[7].Value = model.IsModel;
			parameters[8].Value = model.PN_Flag;
			parameters[9].Value = model.PN_Sort;
			parameters[10].Value = model.Remark;
			parameters[11].Value = model.POSITION_X;
			parameters[12].Value = model.POSITION_Y;
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
			strSql.Append("delete from WF_ProcessNode ");
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
			strSql.Append("delete from WF_ProcessNode ");
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
		public Parking.Core.Model.WF_ProcessNode GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,NodeName,NodeCode,FlowID,PreviousNode,NextNode,JumpNode,DeterMine,IsModel,PN_Flag,PN_Sort,Remark,POSITION_X,POSITION_Y from WF_ProcessNode ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.VarChar,32)			};
			parameters[0].Value = ID;

			Parking.Core.Model.WF_ProcessNode model=new Parking.Core.Model.WF_ProcessNode();
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
		public Parking.Core.Model.WF_ProcessNode DataRowToModel(DataRow row)
		{
			Parking.Core.Model.WF_ProcessNode model=new Parking.Core.Model.WF_ProcessNode();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["NodeName"]!=null)
				{
					model.NodeName=row["NodeName"].ToString();
				}
				if(row["NodeCode"]!=null)
				{
					model.NodeCode=row["NodeCode"].ToString();
				}
				if(row["FlowID"]!=null)
				{
					model.FlowID=row["FlowID"].ToString();
				}
				if(row["PreviousNode"]!=null)
				{
					model.PreviousNode=row["PreviousNode"].ToString();
				}
				if(row["NextNode"]!=null)
				{
					model.NextNode=row["NextNode"].ToString();
				}
				if(row["JumpNode"]!=null)
				{
					model.JumpNode=row["JumpNode"].ToString();
				}
				if(row["DeterMine"]!=null && row["DeterMine"].ToString()!="")
				{
					if((row["DeterMine"].ToString()=="1")||(row["DeterMine"].ToString().ToLower()=="true"))
					{
						model.DeterMine=true;
					}
					else
					{
						model.DeterMine=false;
					}
				}
				if(row["IsModel"]!=null && row["IsModel"].ToString()!="")
				{
					if((row["IsModel"].ToString()=="1")||(row["IsModel"].ToString().ToLower()=="true"))
					{
						model.IsModel=true;
					}
					else
					{
						model.IsModel=false;
					}
				}
				if(row["PN_Flag"]!=null && row["PN_Flag"].ToString()!="")
				{
					if((row["PN_Flag"].ToString()=="1")||(row["PN_Flag"].ToString().ToLower()=="true"))
					{
						model.PN_Flag=true;
					}
					else
					{
						model.PN_Flag=false;
					}
				}
				if(row["PN_Sort"]!=null && row["PN_Sort"].ToString()!="")
				{
					model.PN_Sort=int.Parse(row["PN_Sort"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["POSITION_X"]!=null && row["POSITION_X"].ToString()!="")
				{
					model.POSITION_X=decimal.Parse(row["POSITION_X"].ToString());
				}
				if(row["POSITION_Y"]!=null && row["POSITION_Y"].ToString()!="")
				{
					model.POSITION_Y=decimal.Parse(row["POSITION_Y"].ToString());
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
			strSql.Append("select ID,NodeName,NodeCode,FlowID,PreviousNode,NextNode,JumpNode,DeterMine,IsModel,PN_Flag,PN_Sort,Remark,POSITION_X,POSITION_Y ");
			strSql.Append(" FROM WF_ProcessNode ");
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
			strSql.Append(" ID,NodeName,NodeCode,FlowID,PreviousNode,NextNode,JumpNode,DeterMine,IsModel,PN_Flag,PN_Sort,Remark,POSITION_X,POSITION_Y ");
			strSql.Append(" FROM WF_ProcessNode ");
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
			strSql.Append("select count(1) FROM WF_ProcessNode ");
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
			strSql.Append(")AS Row, T.*  from WF_ProcessNode T ");
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
			parameters[0].Value = "WF_ProcessNode";
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
        public DataSet GetNodesByWFType(enumFlowType flowType)
        {
            string strSql = @"SELECT  * FROM    dbo.WF_ProcessNode a
                                        WHERE   FlowID IN ( SELECT  id
                                                            FROM    dbo.WF_FlowChart
                                                            WHERE   FlowType = {0} )
                                        ORDER BY PN_Sort ASC";
            strSql = string.Format(strSql, (int)flowType);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

