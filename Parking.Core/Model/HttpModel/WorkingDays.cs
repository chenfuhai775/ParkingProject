using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class WorkingDays
    {
        /// <summary>
        /// 0 失败 1 成功
        /// </summary>
        public int resStatus { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string resRemark { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public CalendarInfo calendarInfo { get; set; }
    }
}