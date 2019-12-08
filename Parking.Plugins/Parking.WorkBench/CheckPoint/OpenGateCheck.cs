using System.Collections.Generic;
using System.Linq;
using Parking.Core;
using Parking.DBService.IBLL;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Common;
using Parking.Core.Model;
using Parking.Core.DataProcessing;
using Parking.Core.Interface;
using Parking.Core.Caching;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    public class OpenGateCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            #region ___组á¨|装á??语??音°?___
            var voiceBllTemp = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
            PBA_VOICE_TEMPLATE voiceModel = null;
            List<string> strArr = new List<string>();
            voiceModel = voiceBllTemp.GetModelByType((int)enumTemplateType.MODEL_TYPE_VOICE, (int)recordInfo.SpeechType);
            if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                UpdateAllOrders(recordInfo);
            #endregion

            #region ___清?除y出?入¨?口¨2缓o存??数oy据Y___
            if (null != recordInfo.CHN_CODE)
            {
                var channelInfo = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.CHN_CODE).FirstOrDefault();
                if (null != channelInfo)
                    channelInfo.ListRecognitioResult.Clear();
                var cache = EngineContext.Current.Resolve<ICacheManager>();
                cache.Set(recordInfo.INOUT_RECODE.VEHICLE_NO + recordInfo.CHN_CODE, recordInfo.IP, ConfigHelper.CarRecognitionInterval);
            }
            #endregion

            #region ____报à?§语??音°?/开a闸?é/LED显?示o?____
            ///////////////////////////////////开a闸?é///////////////////////////////
            Parking.Core.Common.CommHelper.OpenGate(recordInfo);
            ///////////////////////////////////播￡¤报à?§语??音°?///////////////////////////////
            if (null != voiceModel)
            {
                strArr.Add(CommHelper.VoiceContent(voiceModel.CUSTOM_MODEL, recordInfo));
                Parking.Core.Common.CommHelper.Sound(recordInfo, strArr.ToArray());
            }
            recordInfo.OPERATER_TYPE = enumOperaterType.OpenGate;
            ThreadMessageTransact.Instance.triggerEvent(recordInfo, false);
            #endregion

            #region ___月?卡?§车|ì锁?定?§车|ì位?___
            //if (GlobalEnvironment.MVMP)
            {
                ///////////////月?卡?§车|ì锁?定?§车|ì位?//////////////////
                if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH || recordInfo.IsMonthToTemp)
                {
                    if (!string.IsNullOrEmpty(recordInfo.SPACE_CODE))
                    {
                        var spaceBllTemp = EngineContext.Current.Resolve<IPBA_PARKING_SPACE_MANAGER>();
                        if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                        {
                            string InOutRecord = string.Empty;
                            int Status = 0;
                            spaceBllTemp.UpdateStatus(recordInfo.SPACE_CODE, Status, InOutRecord);
                        }
                        else
                        {
                            if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH)
                            {
                                string InOutRecord = recordInfo.INOUT_RECODE.ID;
                                int Status = 1;
                                spaceBllTemp.UpdateStatus(recordInfo.SPACE_CODE, Status, InOutRecord);
                            }
                        }
                    }
                }
                recordInfo.CheckPointResult = true;
            }
            #endregion

            #region ___储??é值|ì卡?§缴¨|费¤?___
            if (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_STORED && recordInfo.CurrNeedPay > 0)
            {
                var ownerInfoBll = EngineContext.Current.Resolve<IPBA_OWNER_INFO>();
                if (null != recordInfo.OwnerInfo)
                {
                    var ownerInfo = recordInfo.OwnerInfo;
                    if (ownerInfo.balance >= recordInfo.CurrNeedPay)
                    {
                        ownerInfo.balance -= recordInfo.CurrNeedPay;
                        ownerInfoBll.Update(ownerInfo);
                    }
                }
            }
            #endregion

            #region __发¤?é送¨a余?¨¤位?信?息?é__
            base.ShowMoreThanInfo(recordInfo);
            #endregion
        }
    }
}