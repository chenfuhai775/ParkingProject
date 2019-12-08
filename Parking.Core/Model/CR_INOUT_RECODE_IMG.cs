/**  版本信息模板在安装目录下，可自行修改。
* CR_INOUT_RECODE_IMG.cs
*
* 功 能： N/A
* 类 名： CR_INOUT_RECODE_IMG
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:02   N/A    初版
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
	/// 通行记录图片
	/// </summary>
	[Serializable]
	public partial class CR_INOUT_RECODE_IMG
	{
		public CR_INOUT_RECODE_IMG()
		{}
        #region Model
        private string _id;
        private string _recode_id;
        private string _vehicle_no;
        private string _dev_id;
        private string _img_url;
        private int? _img_type;
        private DateTime _create_time;
        private string _channel_type;
        private string _channel_code;
        private int? _issend;
        /// <summary>
        /// 主键
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 记录ID
        /// </summary>
        public string RECODE_ID
        {
            set { _recode_id = value; }
            get { return _recode_id; }
        }
        /// <summary>
        /// 入口设备ID
        /// </summary>
        public string VEHICLE_NO
        {
            set { _vehicle_no = value; }
            get { return _vehicle_no; }
        }
        /// <summary>
        /// 入口设备ID
        /// </summary>
        public string DEV_ID
        {
            set { _dev_id = value; }
            get { return _dev_id; }
        }
        /// <summary>
        /// 图片
        /// </summary>
        public string IMG_URL
        {
            set { _img_url = value; }
            get { return _img_url; }
        }
        /// <summary>
        /// 图片类型
        /// </summary>
        public int? IMG_TYPE
        {
            set { _img_type = value; }
            get { return _img_type; }
        }
        /// <summary>
        /// 抓拍时间
        /// </summary>
        public DateTime CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 通道类型  I 进场  E出场
        /// </summary>
        public string CHANNEL_TYPE
        {
            set { _channel_type = value; }
            get { return _channel_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHANNEL_CODE
        {
            set { _channel_code = value; }
            get { return _channel_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ISSEND
        {
            set { _issend = value; }
            get { return _issend; }
        }
        #endregion Model

    }
}

