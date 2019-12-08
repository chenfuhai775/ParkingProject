using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class CalendarInfo
    {
        /// <summary>
        /// 1--节假日，2--工作日
        /// </summary>
        public int calType { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public string dateTime { get; set; }
        /// <summary>
        /// 0 整天  1 非整天
        /// </summary>
        public int dayFlag { get; set; }
        /// <summary>
        /// 非整天开始时间
        /// </summary>
        public string beginTime { get; set; }
        /// <summary>
        /// 非整天结束时间
        /// </summary>
        public string endTime { get; set; }
    }
}
