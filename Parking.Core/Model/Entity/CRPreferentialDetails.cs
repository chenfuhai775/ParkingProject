using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Enum;

namespace Parking.Core.Model
{
    public class CRPreferentialDetails
    {
        /// <summary>
        /// 优惠项目编号
        /// </summary>
        public string PREFERENTIAL_CODE { get; set; }
        /// <summary>
        /// 优惠项目票号
        /// </summary>
        public string PREFERENTIA_IDENT { get; set; }
        /// <summary>
        /// 优惠项目名称
        /// </summary>
        public string PREFERENTIAL_NAME { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PREFERENTIAL_MONEY { get; set; }
        /// <summary>
        /// 优惠类型(0-现金 1-折扣 2-时间)
        /// </summary>
        public enumPreferentialType PREFERENTIAL_TYPE { get; set; }
        /// <summary>
        /// 优惠值
        /// </summary>
        public decimal PREFERENTIAL_CONTENT { get; set; }
        /// <summary>
        /// 优惠类型(字符)
        /// </summary>
        public string MODEL_NAME { get; set; }
        /// <summary>
        /// 优惠策略名称
        /// </summary>
        public string POLICIES_NAME { get; set; }
        /// <summary>
        /// 优惠策略编码
        /// </summary>
        public string POLICIES_CODE { get; set; }
        /// <summary>
        /// 项目类型 (0-组合优惠，1-单独优惠)
        /// </summary>
        public int IS_COMBINATION { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public int CR_LEVEL { get; set; }
        /// <summary>
        /// 操作
        /// </summary>
        public string Operation { get { return "删除"; } }

    }
}