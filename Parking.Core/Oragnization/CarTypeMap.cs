namespace Parking.Core.Oragnization
{
    using System;
    using System.Runtime.CompilerServices;

    public class CarTypeMap
    {
        public string AreaCode { get; set; }

        public string AreaName { get; set; }

        public int carType { get; set; }

        public string carTypeName
        {
            get
            {
                if (this.carType == 3)
                {
                    return "买断车位";
                }
                if (this.carType == 1)
                {
                    return "月租车位";
                }
                if (this.carType == 2)
                {
                    return "预约车位";
                }
                if (this.carType == 0)
                {
                    return "临时车位";
                }
                return "临时车位";
            }
        }

        public int countFlag { get; set; }

        public int parkingNumber { get; set; }

        public int remainderFlag { get; set; }

        public int tempParking { get; set; }
    }
}

