namespace Parking.Core.Interface
{
    using Parking.Core.Model;
    using Parking.Core.Record;
    using System;

    public interface ICheck
    {
        void Process(ProcessRecord recordInfo);
        void SaveCheckPointFlowingWater(WF_ProcessNode node, ProcessRecord recordInfo, bool result);
    }
}

