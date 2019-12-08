namespace Parking.Core.Oragnization
{
    using Parking.Core.Record;
    using System;
    using System.Runtime.CompilerServices;

    public class RecognitioResult
    {
        public DataUploadEventArgs args { get; set; }

        public string CarNo { get; set; }

        public int Count { get; set; }
    }
}

