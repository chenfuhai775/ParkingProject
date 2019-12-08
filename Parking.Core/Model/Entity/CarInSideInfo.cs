using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class CarInSideInfo
    {
        public string ID { get; set; }
        public string VEHICLE_NO { get; set; }
        public int Credentials_Type { get; set; }
        public string CurrPartitionCode { get; set; }
        public string IN_CHANNEL_CODE { get; set; }
        public DateTime IN_TIME { get; set; }
        public string IMG_URL { get; set; }
    }
}