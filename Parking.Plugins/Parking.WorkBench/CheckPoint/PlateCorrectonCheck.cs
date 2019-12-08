using Parking.Core.Interface;
using Parking.Core.Record;
using Parking.Core.Enum;

namespace Parking.WorkBench
{
    /// <summary>
    /// 车牌校正
    /// </summary>
    public class PlateCorrectonCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            var tempChannel = getCurrChannel(recordInfo);
            if (null != tempChannel)
            {
                if (tempChannel.correctParkNo)
                {
                    recordInfo.CheckPointResult = base.TriggerEvent(enumOperaterType.PlateCorrection, recordInfo, true);
                    base.WaitOne(recordInfo);
                }
                else
                    recordInfo.CheckPointResult = true;
            }
            else
                recordInfo.CheckPointResult = false;
        }
    }
}