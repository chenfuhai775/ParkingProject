/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_PARAM_SETTINGS.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_PARAM_SETTINGS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:15   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
namespace Parking.Core.Model
{
	/// <summary>
	/// 车场参数设置   如： 车场名称，车场位置，车场设备接入参数等等
	/// </summary>
	[Serializable]
	public partial class PBA_PARKING_PARAM_SETTINGS
	{
		public PBA_PARKING_PARAM_SETTINGS()
		{}
        #region Model
        private string _id;
        private string _display_key;
        private string _display_value;
        private string _param_settings_group;
        private string _grouping_code;
        private DateTime? _update_time;
        private string _update_userid;
        private string _organization_code;
        /// <summary>
        /// 主??键¨1
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 显?示o?字á?段?
        /// </summary>
        public string DISPLAY_KEY
        {
            set { _display_key = value; }
            get { return _display_key; }
        }
        /// <summary>
        /// 显?示o?值|ì
        /// </summary>
        public string DISPLAY_VALUE
        {
            set { _display_value = value; }
            get { return _display_value; }
        }
        /// <summary>
        /// 收o?费¤?标à¨o准á?分¤?组á¨|
        /// </summary>
        public string PARAM_SETTINGS_GROUP
        {
            set { _param_settings_group = value; }
            get { return _param_settings_group; }
        }
        /// <summary>
        /// 收o?费¤?标à¨o准á?组á¨|内¨2分¤?组á¨| 如¨?：êo收o?费¤?标à¨o准á?A中D包?¨1含? 键¨1值|ì对?，ê?并?é包?¨1含?grid列￠D表à¨a值|ì则¨° 键¨1值|ì对?为a一°?组á¨|，ê?grid列￠D表à¨a值|ì为a一°?组á¨|
        /// </summary>
        public string GROUPING_CODE
        {
            set { _grouping_code = value; }
            get { return _grouping_code; }
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
        /// 
        /// </summary>
        public string ORGANIZATION_CODE
        {
            set { _organization_code = value; }
            get { return _organization_code; }
        }
        #endregion Model

    }
}

