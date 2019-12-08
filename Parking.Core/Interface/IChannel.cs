namespace Parking.Core.Interface
{
    using Parking.Core.Record;
    using System;

    public interface IChannel
    {
        void Process(ProcessRecord record);
    }
}

