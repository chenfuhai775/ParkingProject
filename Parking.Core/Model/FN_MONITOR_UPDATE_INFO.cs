using System;
namespace Parking.Core.Model
{
    /// <summary>
    /// FN_MONITOR_UPDATE_INFO:实o|ì体??类¤¨¤(属o?性?说|ì明??自á?动?￥提?¨￠取¨?数oy据Y库a字á?段?的ì?描¨¨述o?信?息?é)
    /// </summary>
    [Serializable]
    public partial class FN_MONITOR_UPDATE_INFO
    {
        public FN_MONITOR_UPDATE_INFO()
        { }
        #region Model
        private string _id;
        private string _workstation_code;
        private string _update_version;
        private DateTime? _create_time;
        private string _create_userid;
        private int? _update_status;
        private DateTime? _update_completion_time;
        private string _update_remark;
        private int? _update_method;
        private DateTime? _update_time;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 工?è作á??站?编à¨¤号?
        /// </summary>
        public string WORKSTATION_CODE
        {
            set { _workstation_code = value; }
            get { return _workstation_code; }
        }
        /// <summary>
        /// 更¨1新?版??本à?
        /// </summary>
        public string UPDATE_VERSION
        {
            set { _update_version = value; }
            get { return _update_version; }
        }
        /// <summary>
        /// 创???建?§时o?à间?
        /// </summary>
        public DateTime? CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 创???建?§人¨?
        /// </summary>
        public string CREATE_USERID
        {
            set { _create_userid = value; }
            get { return _create_userid; }
        }
        /// <summary>
        /// 更¨1新?状á??态??:  0 未??更¨1新?  1更¨1新?成¨|功|  2更¨1新?失o?ì败?¨1
        /// </summary>
        public int? UPDATE_STATUS
        {
            set { _update_status = value; }
            get { return _update_status; }
        }
        /// <summary>
        /// 更¨1新?完a¨o成¨|时o?à间?
        /// </summary>
        public DateTime? UPDATE_COMPLETION_TIME
        {
            set { _update_completion_time = value; }
            get { return _update_completion_time; }
        }
        /// <summary>
        /// 更¨1新?备à?注á?é
        /// </summary>
        public string UPDATE_REMARK
        {
            set { _update_remark = value; }
            get { return _update_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? UPDATE_METHOD
        {
            set { _update_method = value; }
            get { return _update_method; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATE_TIME
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        #endregion Model

    }
}