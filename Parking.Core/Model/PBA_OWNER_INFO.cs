/**  版本信息模板在安装目录下，可自行修改。
* PBA_OWNER_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_OWNER_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:12   N/A    初版
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
	/// 车主信息管理
	/// </summary>
	[Serializable]
	public partial class PBA_OWNER_INFO
	{
		public PBA_OWNER_INFO()
		{}
        #region Model
        private string _owner_code;
        private string _owner_name;
        private string _owner_phone;
        private string _owner_address;
        private string _owner_picture;
        private int? _owner_status;
        private string _organization_code;
        private string _remark;
        private DateTime? _create_time;
        private string _create_username;
        private DateTime? _update_time;
        private string _update_username;
        private string _permission_codes;
        private string _diy_str;
        private decimal? _balance;
        private decimal? _deposit;
        /// <summary>
        /// 业°|ì主??编à¨¤号?
        /// </summary>
        public string OWNER_CODE
        {
            set { _owner_code = value; }
            get { return _owner_code; }
        }
        /// <summary>
        /// 业°|ì主??名?称?
        /// </summary>
        public string OWNER_NAME
        {
            set { _owner_name = value; }
            get { return _owner_name; }
        }
        /// <summary>
        /// 联￠a系|ì电ì?话??
        /// </summary>
        public string OWNER_PHONE
        {
            set { _owner_phone = value; }
            get { return _owner_phone; }
        }
        /// <summary>
        /// 联￠a系|ì地ì?址?¤
        /// </summary>
        public string OWNER_ADDRESS
        {
            set { _owner_address = value; }
            get { return _owner_address; }
        }
        /// <summary>
        /// 业°|ì主??相¨¤片?
        /// </summary>
        public string OWNER_PICTURE
        {
            set { _owner_picture = value; }
            get { return _owner_picture; }
        }
        /// <summary>
        /// 0 正y常?ê  1注á?é销¨2
        /// </summary>
        public int? OWNER_STATUS
        {
            set { _owner_status = value; }
            get { return _owner_status; }
        }
        /// <summary>
        /// 组á¨|织?￥管¨1理¤¨aID
        /// </summary>
        public string ORGANIZATION_CODE
        {
            set { _organization_code = value; }
            get { return _organization_code; }
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
        public DateTime? CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 创???建?§人¨?
        /// </summary>
        public string CREATE_USERNAME
        {
            set { _create_username = value; }
            get { return _create_username; }
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
        public string UPDATE_USERNAME
        {
            set { _update_username = value; }
            get { return _update_username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERMISSION_CODES
        {
            set { _permission_codes = value; }
            get { return _permission_codes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DIY_STR
        {
            set { _diy_str = value; }
            get { return _diy_str; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? deposit
        {
            set { _deposit = value; }
            get { return _deposit; }
        }
        #endregion Model 
    }
}

