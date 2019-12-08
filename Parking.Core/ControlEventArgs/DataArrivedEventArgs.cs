namespace Parking.Core.ControlEventArgs
{
    using Parking.Core.Structs;
    using System;

    public class DataArrivedEventArgs : EventArgs
    {
        private Parking.Core.Structs.ROADGATE_INFO_STRUCT rOADGATE_INFO_STRUCT = new Parking.Core.Structs.ROADGATE_INFO_STRUCT();

        public DataArrivedEventArgs(Parking.Core.Structs.ROADGATE_INFO_STRUCT m_ROADGATE_INFO_STRUCT)
        {
            this.rOADGATE_INFO_STRUCT = m_ROADGATE_INFO_STRUCT;
        }

        public Parking.Core.Structs.ROADGATE_INFO_STRUCT ROADGATE_INFO_STRUCT
        {
            get
            {
                return this.rOADGATE_INFO_STRUCT;
            }
            set
            {
                this.rOADGATE_INFO_STRUCT = value;
            }
        }
    }
}

