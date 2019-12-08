using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.ChargeStandard
{
    /// <summary>
    /// 按单位时段收费子项
    /// </summary>
    public class SubsectionUnitTime
    {
        public DateTime beginTime { get; set; }
        public DateTime endTime { get; set; }
        public int intervalChargingMoney { get; set; }
        public int intervalChargingTime { get; set; }
    }
    /// <summary>
    /// 按总时长收费
    /// </summary>
    public class SubsectionTotalLength
    {
        public int beginTime { get; set; }
        public int endTime { get; set; }
        public decimal payMoney { get; set; }
    }

}
