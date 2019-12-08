/**  版本信息模板在安装目录下，可自行修改。
* CR_TRAFFIC_PERMIT_INFO.cs
*
* 功 能： N/A
* 类 名： CR_TRAFFIC_PERMIT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:06   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Parking.Core.Model
{
	/// <summary>
	/// 通行证信息
	/// </summary>
	[Serializable]
	public partial class CR_TRAFFIC_PERMIT_INFO
	{
		public CR_TRAFFIC_PERMIT_INFO()
		{}
        #region Model
        private string _id;
        private string _logic_number;
        private int? _traffic_permit_status;
        private string _printing_no;
        private string _owner_code;
        private DateTime? _begin_time;
        private DateTime? _end_time;
        private decimal? _balance;
        private string _remark;
        private DateTime? _tissue_time;
        private string _create_userid;
        private DateTime? _update_time;
        private string _update_userid;
        private string _physic_number;
        private string _access_permission;
        private int? _traffic_type;
        private string _vehicle_no;
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 逻?辑-卡?§号?
        /// </summary>
        public string LOGIC_NUMBER
        {
            set { _logic_number = value; }
            get { return _logic_number; }
        }
        /// <summary>
        /// 通a?§行D证?è状á??态??:    0停a?ê用??  1启?用??   2挂¨°失o?ì  3注á?é销¨2 
        /// </summary>
        public int? TRAFFIC_PERMIT_STATUS
        {
            set { _traffic_permit_status = value; }
            get { return _traffic_permit_status; }
        }
        /// <summary>
        /// 印??刷?é卡?§号?
        /// </summary>
        public string PRINTING_NO
        {
            set { _printing_no = value; }
            get { return _printing_no; }
        }
        /// <summary>
        /// 业°|ì主??ID
        /// </summary>
        public string OWNER_CODE
        {
            set { _owner_code = value; }
            get { return _owner_code; }
        }
        /// <summary>
        /// 有?D效?ì开a始o?时o?à间?
        /// </summary>
        public DateTime? BEGIN_TIME
        {
            set { _begin_time = value; }
            get { return _begin_time; }
        }
        /// <summary>
        /// 有?D效?ì结¨￠束o?时o?à间?
        /// </summary>
        public DateTime? END_TIME
        {
            set { _end_time = value; }
            get { return _end_time; }
        }
        /// <summary>
        /// 余?¨¤额?
        /// </summary>
        public decimal? BALANCE
        {
            set { _balance = value; }
            get { return _balance; }
        }
        /// <summary>
        /// 备à?注á?é
        /// </summary>
        public string REMARK
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 创???建?§时o?à间?
        /// </summary>
        public DateTime? TISSUE_TIME
        {
            set { _tissue_time = value; }
            get { return _tissue_time; }
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
        /// 修T改?时o?à间?
        /// </summary>
        public DateTime? UPDATE_TIME
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 修T改?人¨?
        /// </summary>
        public string UPDATE_USERID
        {
            set { _update_userid = value; }
            get { return _update_userid; }
        }
        /// <summary>
        /// 物?理¤¨a卡?§号?
        /// </summary>
        public string PHYSIC_NUMBER
        {
            set { _physic_number = value; }
            get { return _physic_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ACCESS_PERMISSION
        {
            set { _access_permission = value; }
            get { return _access_permission; }
        }
        /// <summary>
        /// 0临￠¨′时o?à卡?§  1月?卡?§    2储??é值|ì卡?§
        /// </summary>
        public int? TRAFFIC_TYPE
        {
            set { _traffic_type = value; }
            get { return _traffic_type; }
        }
        /// <summary>
        /// 车|ì牌?号?
        /// </summary>
        public string VEHICLE_NO
        {
            set { _vehicle_no = value; }
            get { return _vehicle_no; }
        }
        #endregion Model
    }
}

