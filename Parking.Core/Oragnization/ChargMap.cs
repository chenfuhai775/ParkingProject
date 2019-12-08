namespace Parking.Core.Oragnization
{
    using System;
    using System.Runtime.CompilerServices;

    public class ChargMap
    {
        public int carType { get; set; }

        public string chargeNo { get; set; }

        public string gateType { get; set; }

        public string holiday { get; set; }

        public string mtCharge { get; set; }

        public int[] roadGateType
        {
            get
            {
                if (!this.gateType.Contains("A") || this.gateType.Contains("B"))
                {
                    if (!(this.gateType.Contains("A") || !this.gateType.Contains("B")))
                    {
                        return new int[] { 1 };
                    }
                    if (this.gateType.Contains("A") && this.gateType.Contains("B"))
                    {
                        int[] numArray2 = new int[2];
                        numArray2[1] = 1;
                        return numArray2;
                    }
                }
                return new int[1];
            }
        }

        public string working { get; set; }
    }
}

