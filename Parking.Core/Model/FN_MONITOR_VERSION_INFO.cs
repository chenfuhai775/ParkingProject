using System;
namespace Parking.Core.Model
{
    /// <summary>
    /// FN_MONITOR_VERSION_INFO:实o|ì体??类¤¨¤(属o?性?说|ì明??自á?动?￥提?¨￠取¨?数oy据Y库a字á?段?的ì?描¨¨述o?信?息?é)
    /// </summary>
    [Serializable]
    public partial class FN_MONITOR_VERSION_INFO
    {
        public FN_MONITOR_VERSION_INFO()
        { }
        #region Model
        private string _id;
        private string _version_number;
        private DateTime? _release_time;
        private DateTime? _upload_time;
        private string _version_desc;
        private string _download_url;
        private string _check_code;
        private decimal? _file_size;
        private string _upload_userid;
        private string _upgrade_desc;
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 版??本à?号?
        /// </summary>
        public string VERSION_NUMBER
        {
            set { _version_number = value; }
            get { return _version_number; }
        }
        /// <summary>
        /// 版??本à?发¤?é布?时o?à间?
        /// </summary>
        public DateTime? RELEASE_TIME
        {
            set { _release_time = value; }
            get { return _release_time; }
        }
        /// <summary>
        /// 版??本à?上|?传??时o?à间?
        /// </summary>
        public DateTime? UPLOAD_TIME
        {
            set { _upload_time = value; }
            get { return _upload_time; }
        }
        /// <summary>
        /// 版??本à?描¨¨述o?
        /// </summary>
        public string VERSION_DESC
        {
            set { _version_desc = value; }
            get { return _version_desc; }
        }
        /// <summary>
        /// 版??本à?下?载?URL
        /// </summary>
        public string DOWNLOAD_URL
        {
            set { _download_url = value; }
            get { return _download_url; }
        }
        /// <summary>
        /// 版??本à?MD5校?ê验¨|码?
        /// </summary>
        public string CHECK_CODE
        {
            set { _check_code = value; }
            get { return _check_code; }
        }
        /// <summary>
        /// 版??本à?大?¨?小?   单ì￡¤位?MB
        /// </summary>
        public decimal? FILE_SIZE
        {
            set { _file_size = value; }
            get { return _file_size; }
        }
        /// <summary>
        /// 上|?传??人¨?ID
        /// </summary>
        public string UPLOAD_USERID
        {
            set { _upload_userid = value; }
            get { return _upload_userid; }
        }
        /// <summary>
        /// 监¨¤控?中D心?版??本à?升|y级?需¨¨要°a的ì?描¨¨述o?内¨2容¨Y
        /// </summary>
        public string UPGRADE_DESC
        {
            set { _upgrade_desc = value; }
            get { return _upgrade_desc; }
        }
        #endregion Model

    }
}