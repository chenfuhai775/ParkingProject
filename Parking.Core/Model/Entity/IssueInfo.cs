using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Enum;

namespace Parking.Core.Model
{
    public class IssueInfo
    {
        public string ID { get; set; }
        public string PRINTING_NO { get; set; }
        public DateTime TISSUE_TIME { get; set; }
        public int TRAFFIC_PERMIT_STATUS { get; set; }
        public string OWNER_CODE { get; set; }
        public string OWNER_NAME { get; set; }
        public string VEHICLE_NUMBER { get; set; }
        public string INOUT_RECORD_ID { get; set; }
        public enumCardType CARDTYPE { get; set; }
        public int SPACE_STATUS { get; set; }
        public string ACCESS_CHANNEL_CODE { get; set; }
        /// <summary>
        /// 车辆类型
        /// </summary>
        public enumCarType CAR_TYPE { get; set; }
        public string SPACE_CODE { get; set; }
        public string PARTITION_CODE { get; set; }
        public DateTime BEGAIN_TIME { get; set; }
        public DateTime END_TIME { get; set; }
    }
}