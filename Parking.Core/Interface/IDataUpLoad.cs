using Parking.Core.Record;

namespace Parking.Core.Interface
{
    public interface IDataUpLoad
    {
        RecordBase recordBase { get; set; }
        bool DataPush();
    }
}
