using System;
namespace Parking.Core.Model
{
    /// <summary>
    /// UP_LOG_FlowingWater:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class UP_LOG_FlowingWater
    {
        public UP_LOG_FlowingWater()
        { }
        #region Model
        private string _id;
        private string _checkpointName;
        private string _recordid;
        private DateTime? _create_time = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CheckPointName
        {
            set { _checkpointName = value; }
            get { return _checkpointName; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RECORDID
        {
            set { _recordid = value; }
            get { return _recordid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        #endregion Model

    }
}