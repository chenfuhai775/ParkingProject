/**  版本信息模板在安装目录下，可自行修改。
* CR_PREFERENTIAL_RECORD.cs
*
* 功 能： N/A
* 类 名： CR_PREFERENTIAL_RECORD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-09-16 21:23:05   N/A    初版
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
    /// 优惠记录
    /// </summary>
    [Serializable]
    public partial class CR_PREFERENTIAL_RECORD
    {
        public CR_PREFERENTIAL_RECORD()
        { }
        #region Model
        private string _id;
        private string _inout_record_code;
        private int? _preferential_type;
        private string _preferential_content;
        private decimal _charge_money = 0M;
        private decimal _preferential_money = 0M;
        private string _preferentia_ident;
        private string _charge_id;
        private string _unique_identifier;
        private string _preferential_name;
        private string _order_code;
        /// <summary>
        /// 主键
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 通行记录主键
        /// </summary>
        public string INOUT_RECORD_CODE
        {
            set { _inout_record_code = value; }
            get { return _inout_record_code; }
        }
        /// <summary>
        /// 优惠类型
        /// </summary>
        public int? PREFERENTIAL_TYPE
        {
            set { _preferential_type = value; }
            get { return _preferential_type; }
        }
        /// <summary>
        /// 优惠内容
        /// </summary>
        public string PREFERENTIAL_CONTENT
        {
            set { _preferential_content = value; }
            get { return _preferential_content; }
        }
        /// <summary>
        /// 优惠前金额
        /// </summary>
        public decimal CHARGE_MONEY
        {
            set { _charge_money = value; }
            get { return _charge_money; }
        }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PREFERENTIAL_MONEY
        {
            set { _preferential_money = value; }
            get { return _preferential_money; }
        }
        /// <summary>
        /// 优惠唯一标识
        /// </summary>
        public string PREFERENTIA_IDENT
        {
            set { _preferentia_ident = value; }
            get { return _preferentia_ident; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHARGE_ID
        {
            set { _charge_id = value; }
            get { return _charge_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UNIQUE_IDENTIFIER
        {
            set { _unique_identifier = value; }
            get { return _unique_identifier; }
        }
        /// <summary>
        /// 优惠项目名
        /// </summary>
        public string PREFERENTIAL_NAME
        {
            set { _preferential_name = value; }
            get { return _preferential_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_CODE
        {
            set { _order_code = value; }
            get { return _order_code; }
        }
        #endregion Model

    }
}

