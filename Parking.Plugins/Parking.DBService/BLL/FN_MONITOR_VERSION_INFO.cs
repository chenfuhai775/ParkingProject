using System;
using System.Data;
using System.Collections.Generic;
using Parking.Core.Model;
using Parking.DBService.IBLL;

namespace Parking.DBService.BLL
{
    public partial class FN_MONITOR_VERSION_INFO : IFN_MONITOR_VERSION_INFO
    {
        private readonly Parking.DBService.DAL.FN_MONITOR_VERSION_INFO dal = new Parking.DBService.DAL.FN_MONITOR_VERSION_INFO();
        public FN_MONITOR_VERSION_INFO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是o?否¤?存??在¨2该?记?录?
        /// </summary>
        public bool Exists(string ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增?加¨?一°?条??数oy据Y
        /// </summary>
        public bool Add(Parking.Core.Model.FN_MONITOR_VERSION_INFO model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更¨1新?一°?条??数oy据Y
        /// </summary>
        public bool Update(Parking.Core.Model.FN_MONITOR_VERSION_INFO model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删|?除y一°?条??数oy据Y
        /// </summary>
        public bool Delete(string ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 删|?除y一°?条??数oy据Y
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得ì?到ì?一°?个?对?象¨?实o|ì体??
        /// </summary>
        public Parking.Core.Model.FN_MONITOR_VERSION_INFO GetModel(string ID)
        {

            return dal.GetModel(ID);
        }
        /// <summary>
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获?得ì?前??几?行D数oy据Y
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public List<Parking.Core.Model.FN_MONITOR_VERSION_INFO> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public List<Parking.Core.Model.FN_MONITOR_VERSION_INFO> DataTableToList(DataTable dt)
        {
            List<Parking.Core.Model.FN_MONITOR_VERSION_INFO> modelList = new List<Parking.Core.Model.FN_MONITOR_VERSION_INFO>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Parking.Core.Model.FN_MONITOR_VERSION_INFO model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获?得ì?数oy据Y列￠D表à¨a
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分¤?页°3获?取¨?数oy据Y列￠D表à¨a
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分¤?页°3获?取¨?数oy据Y列￠D表à¨a
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分¤?页°3获?取¨?数oy据Y列￠D表à¨a
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public Parking.Core.Model.FN_MONITOR_VERSION_INFO GetByVersion(string Version)
        {
            return dal.GetByVersion(Version);
        }
        #endregion  ExtensionMethod
    }
}
