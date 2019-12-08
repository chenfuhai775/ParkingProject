/**  版本信息模板在安装目录下，可自行修改。
* PBA_PARKING_ORGANIZATION_INFO.cs
*
* 功 能： N/A
* 类 名： PBA_PARKING_ORGANIZATION_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:14   N/A    初版
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
	/// 车主车辆信息
	/// </summary>
	[Serializable]
	public partial class PBA_PARKING_ORGANIZATION_INFO
	{
		public PBA_PARKING_ORGANIZATION_INFO()
		{}
        #region Model
        private string _organization_code;
        private DateTime? _create_time;
        private string _create_username;
        private int? _org_level;
        private string _organization_name;
        private string _organization_type_code;
        private string _parent_code;
        private DateTime? _update_time;
        private string _update_username;
        /// <summary>
        /// 
        /// </summary>
        public string ORGANIZATION_CODE
        {
            set { _organization_code = value; }
            get { return _organization_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_TIME
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CREATE_USERNAME
        {
            set { _create_username = value; }
            get { return _create_username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ORG_LEVEL
        {
            set { _org_level = value; }
            get { return _org_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORGANIZATION_NAME
        {
            set { _organization_name = value; }
            get { return _organization_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORGANIZATION_TYPE_CODE
        {
            set { _organization_type_code = value; }
            get { return _organization_type_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PARENT_CODE
        {
            set { _parent_code = value; }
            get { return _parent_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATE_TIME
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPDATE_USERNAME
        {
            set { _update_username = value; }
            get { return _update_username; }
        }
        public List<PBA_PARKING_PARAM_SETTINGS> ParamSettings { get; set; }
        #endregion Model

    }
}

