using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class OwnerInfo
    {
        public string OWNER_CODE { get; set; }
        public string OWNER_NAME { get; set; }
        public string OWNER_PICTURE { get; set; }
        public string OWNER_PHONE { get; set; }
        public string OWNER_ADDRESS { get; set; }
        public string ORGANIZATION_CODE { get; set; }
        public string VEHICLE_NO { get; set; }
        public string VEHICLE_COLOR { get; set; }
        public DateTime CREATE_TIME { get; set; }
    }
}