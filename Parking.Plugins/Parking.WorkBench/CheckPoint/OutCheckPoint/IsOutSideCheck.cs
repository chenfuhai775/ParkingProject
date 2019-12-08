using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Parking.DBService.IBLL;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Model;
using Parking.Core.Log4Net;
using Parking.Core.Common;
using Parking.Core.Oragnization;

namespace Parking.WorkBench
{
    /// <summary>
    /// 出场时候校验车辆是否已经入场
    /// </summary>
    public class IsOutSideCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            try
            {
                recordInfo.CheckPointResult = true;
                CR_INOUT_RECODE recordTemp = new CR_INOUT_RECODE();
                //如¨?果?是o?贵¨?宾à?车|ì，ê?不?用??校?ê验¨|是o?否¤?场?外aa车|ì
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    return;
                //保à?ê存??数oy据Y库a
                var temp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                recordTemp = temp.GetInSideCarNo(recordInfo.INOUT_RECODE);
                if (null == recordTemp && recordInfo.CARD_TYPE != enumCardType.CAR_TYPE_MONTH)
                {
                    //播￡¤报à?§语??音°?，ê?此??卡?§已°?出?场?
                    recordInfo.SpeechType = enumSpeechType.CarOutSide;
                    Sound(recordInfo);
                    recordInfo.CheckPointResult = false;
                    //base.TriggerEvent(enumOperaterType.ShowInSideForm, recordInfo);
                }
                else
                {
                    if (null != recordTemp)
                        recordInfo.INOUT_RECODE = recordTemp;
                    recordInfo.INOUT_RECODE.OUT_TIME = recordInfo.REPORTIMG_TIME;
                    recordInfo.INOUT_RECODE.OUT_FIELD_CODE = recordInfo.FIELD_CODE;
                    recordInfo.INOUT_RECODE.OUT_PARTITION_CODE = recordInfo.PARTITION_CODE;
                    recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE = recordInfo.CHN_CODE;
                    recordInfo.INOUT_RECODE.OUT_DEV_ID = recordInfo.DEV_CODE;
                    recordInfo.INOUT_RECODE.OUT_OPERATOR_ID = recordInfo.OPERATOR_ID;
                    recordInfo.INOUT_RECODE.OUT_PARK_TYPE = recordInfo.PARK_TYPE;
                    recordInfo.INOUT_RECODE.RECODE_STATUS = 1;
                }
                CommHelper.getSoundByCardType(recordInfo);
            }
            catch (Exception ex)
            {
                recordInfo.CheckPointResult = false;
                LogHelper.Log.Error(ex.Message);
            }
        }
    }
}