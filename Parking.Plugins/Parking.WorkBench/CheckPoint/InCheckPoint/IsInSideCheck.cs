using System;
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
    ///  入场时候校验车辆是否已经出场
    /// </summary>
    public class IsInSideCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            try
            {
                recordInfo.CheckPointResult = true;
                CR_INOUT_RECODE recordTemp = new CR_INOUT_RECODE();
                //如¨?果?是o?贵¨?宾à?车|ì，ê?不?用??校?ê验¨|是o?否¤?场?内¨2车|ì
                if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    return;
                Equipment parentArea = null;
                var parent = CommHelper.GetOrgInfos(recordInfo.CHN_CODE, false).OrderBy(x => x.ORG_LEVEL);
                if (null != parent)
                    parentArea = parent.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                var temp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                recordTemp = temp.GetInSideCarNo(recordInfo.INOUT_RECODE);
                //区?域?¨°编à¨¤号?相¨¤同a?时o?à为a同a?一°?车|ì场?，ê?否¤?则¨°可¨|能¨1为a大?¨?套??á小?模?ê式o?
                if (null != recordTemp && recordInfo.PARTITION_CODE == recordTemp.IN_PARTITION_CODE)
                {
                    if (!parentArea.ckRepeatIE.Contains(((int)recordInfo.CARD_TYPE).ToString()))
                    {
                        //一°?进?一°?出?模?ê式o?，ê?此??卡?§已°?经-入¨?场?时o?à，ê?播￡¤报à?§语??音°?，ê?不?允¨o许¨a再¨′次??入¨?场?
                        recordInfo.SpeechType = enumSpeechType.CarInSide;
                        Sound(recordInfo);
                        recordInfo.CheckPointResult = false;
                        return;
                    }
                    else
                    {
                        //多¨¤进?多¨¤出?模?ê式o?下?，ê?删|?除y原-入¨?场?记?录?，ê?重?新?入¨?场?
                        //temp.Delete(recordTemp.ID);
                        var spaceBllTemp = EngineContext.Current.Resolve<IPBA_PARKING_SPACE_MANAGER>();
                        var spaceModel = spaceBllTemp.GetModelByINOUTID(recordTemp.ID);
                        if (null != spaceModel)
                        {
                            spaceModel.INOUT_RECORD_ID = string.Empty;
                            spaceModel.SPACE_STATUS = 0;
                            spaceBllTemp.Update(spaceModel);
                        }
                        temp.DelInSideRecord(recordInfo.INOUT_RECODE.VEHICLE_NO);
                    }
                }
                recordInfo.INOUT_RECODE.ID = Guid.NewGuid().ToString("N");
                recordInfo.INOUT_RECODE.IN_TIME = recordInfo.REPORTIMG_TIME;
                recordInfo.INOUT_RECODE.OUT_TIME = recordInfo.REPORTIMG_TIME;
                recordInfo.INOUT_RECODE.IN_FIELD_CODE = recordInfo.FIELD_CODE;
                recordInfo.INOUT_RECODE.IN_PARTITION_CODE = recordInfo.PARTITION_CODE;
                recordInfo.INOUT_RECODE.IN_CHANNEL_CODE = recordInfo.CHN_CODE;
                recordInfo.INOUT_RECODE.IN_DEV_ID = recordInfo.DEV_CODE;
                recordInfo.INOUT_RECODE.IN_OPERATOR_ID = recordInfo.OPERATOR_ID;
                recordInfo.INOUT_RECODE.IN_PARK_TYPE = recordInfo.PARK_TYPE;
                recordInfo.INOUT_RECODE.RECODE_STATUS = 0;
            }
            catch (Exception ex)
            {
                recordInfo.CheckPointResult = false;
                LogHelper.Log.Error(ex.Message);
            }
        }
    }
}