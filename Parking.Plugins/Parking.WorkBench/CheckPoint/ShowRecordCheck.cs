using Parking.Core.Interface;
using Parking.Core.Record;
using Parking.Core.Enum;

namespace Parking.WorkBench
{
    public class ShowRecordCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            base.TriggerEvent(enumOperaterType.ShowRecord, recordInfo);
        }
    }
}