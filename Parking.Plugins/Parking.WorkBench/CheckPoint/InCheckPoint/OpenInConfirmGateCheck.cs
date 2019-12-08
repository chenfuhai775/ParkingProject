using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.DBService.IBLL;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Model;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    /// <summary>
    /// 确认开闸
    /// </summary>
    public class OpenInConfirmGateCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            var tempChannel = getCurrChannel(recordInfo);
            if (null != tempChannel)
            {
                if (tempChannel.autoGate || recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_STORED || recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP || recordInfo.authenticationType == enumAuthenticationType.TEMP_VISITOR)
                {
                    recordInfo.CheckPointResult = true;
                }
                else
                {
                    if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_TEMP)
                    {
                        Sound(recordInfo);
                        base.TriggerEvent(enumOperaterType.OpenInConfirmGate, recordInfo, true);
                        base.WaitOne(recordInfo);
                    }
                    else if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                    {
                        recordInfo.CheckPointResult = true;
                    }
                }
            }
            else
                recordInfo.CheckPointResult = false;
        }
    }
}
