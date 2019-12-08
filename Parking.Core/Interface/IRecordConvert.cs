namespace Parking.Core.Interface
{
    using Parking.Core.Record;

    public interface IRecordConvert
    {
        ProcessRecord ConvertRecord(DataUploadEventArgs data);
    }
}

