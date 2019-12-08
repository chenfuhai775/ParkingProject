using System;
namespace Parking.Core.Model
{
    /// <summary>
    /// UP_SEND_MESSAGE:实o|ì体??类¤¨¤(属o?性?说|ì明??自á?动?￥提?¨￠取¨?数oy据Y库a字á?段?的ì?描¨¨述o?信?息?é)
    /// </summary>
    [Serializable]
    public partial class UP_SEND_MESSAGE
    {
        public UP_SEND_MESSAGE()
        { }
        #region Model
        private string _id;
        private DateTime? _create_date;
        private string _msg_content;
        private string _msg_seq;
        private int? _msg_status;
        private string _msg_type;
        private string _remark;
        private string _reply_msg_content;
        private int? _send_count = 0;
        private DateTime? _send_msg_date;
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 创???建?§时o?à间?
        /// </summary>
        public DateTime? CREATE_DATE
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 消?息?é内¨2容¨Y json格?式o?
        /// </summary>
        public string MSG_CONTENT
        {
            set { _msg_content = value; }
            get { return _msg_content; }
        }
        /// <summary>
        /// 报à?§文?流￠??水?号?
        /// </summary>
        public string MSG_SEQ
        {
            set { _msg_seq = value; }
            get { return _msg_seq; }
        }
        /// <summary>
        /// 报à?§文?状á??态?? 0 未??发¤?é送¨a  1已°?发¤?é送¨a 2数oy据Y异°¨?常?ê
        /// </summary>
        public int? MSG_STATUS
        {
            set { _msg_status = value; }
            get { return _msg_status; }
        }
        /// <summary>
        /// 报à?§文?类¤¨¤型¨a
        /// </summary>
        public string MSG_TYPE
        {
            set { _msg_type = value; }
            get { return _msg_type; }
        }
        /// <summary>
        /// 报à?§文?备à?注á?é
        /// </summary>
        public string REMARK
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 报à?§文?回?复??内¨2容¨Y
        /// </summary>
        public string REPLY_MSG_CONTENT
        {
            set { _reply_msg_content = value; }
            get { return _reply_msg_content; }
        }
        /// <summary>
        /// 发¤?é送¨a次??数oy
        /// </summary>
        public int? SEND_COUNT
        {
            set { _send_count = value; }
            get { return _send_count; }
        }
        /// <summary>
        /// 最á?后¨?发¤?é送¨a时o?à间?
        /// </summary>
        public DateTime? SEND_MSG_DATE
        {
            set { _send_msg_date = value; }
            get { return _send_msg_date; }
        }
        #endregion Model

    }
}