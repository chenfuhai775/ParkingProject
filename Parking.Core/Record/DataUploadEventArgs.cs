namespace Parking.Core.Record
{
    using Parking.Core.Enum;
    using System;
    using System.Runtime.CompilerServices;

    public class DataUploadEventArgs : EventArgs
    {
        public enumReleaseType releaseType { get; set; }

        public DataUploadRecord TempRecordInfo { get; set; }
    }
}

