using System;
using System.Collections.Generic;
using Parking.Core.Enum;
using Parking.Core.Model;
using Parking.Core.Interface;

namespace Parking.Core.Record
{
    public class ProcessRecord
    {
        private CR_INOUT_RECODE _INOUT_RECODE = new CR_INOUT_RECODE();
        public CR_INOUT_RECODE INOUT_RECODE { get { return _INOUT_RECODE; } set { _INOUT_RECODE = value; } }
        readonly string _chargeFlowing = Guid.NewGuid().ToString("N");
        /// <summary>
        /// 出?入¨?场?流￠??水?
        /// </summary>
        public string chargeFlowing
        {
            get
            {
                return _chargeFlowing;
            }
        }
        /// <summary>
        /// 车|ì牌?号?码?
        /// </summary>
        public string VEHICLE_NO { get; set; }
        /// <summary>
        /// 工?è作á??站?名?称?
        /// </summary>
        public string FIELD_NAME { get; set; }
        /// <summary>
        /// 工?è作á??站?编à¨¤号?
        /// </summary>
        public string FIELD_CODE { get; set; }
        /// <summary>
        /// 分¤?区?编à¨¤号?
        /// </summary>
        public string PARTITION_CODE { get; set; }
        /// <summary>
        /// 分¤?区?名?称?
        /// </summary>
        public string PARTITION_NAME { get; set; }
        /// <summary>
        /// 岗¨2亭a?è编à¨¤号?
        /// </summary>
        public string CHN_CODE { get; set; }
        /// <summary>
        /// 岗¨2亭a?è名?称?
        /// </summary>
        public string CHN_NAME { get; set; }
        /// <summary>
        /// 设|¨¨备à?编à¨¤号?
        /// </summary>
        public string DEV_CODE { get; set; }
        /// <summary>
        /// 设|¨¨备à?地ì?址?¤
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 设|¨¨备à?名?称?
        /// </summary>
        public string DEV_NAME { get; set; }
        /// <summary>
        /// 卡?§类¤¨¤型¨a
        /// </summary>
        public enumCardType CARD_TYPE { get; set; }
        /// <summary>
        /// 出?入¨?口¨2类¤¨¤型¨a
        /// </summary>
        public enumChannelType CHANNEL_TYPE { get; set; }
        /// <summary>
        /// 操¨′作á??员?à编à¨¤号?
        /// </summary>
        public string OPERATOR_ID { get; set; }
        /// <summary>
        /// 操¨′作á??员?à信?息?é
        /// </summary>
        public string OPERATOR_NAME { get; set; }
        /// <summary>
        /// 上|?报à?§时o?à间?
        /// </summary>
        public DateTime REPORTIMG_TIME { get; set; }
        /// <summary>
        /// 节¨2点ì?逻?辑-事o?件t类¤¨¤型¨a
        /// </summary>
        public enumOperaterType OPERATER_TYPE { get; set; }
        /// <summary>
        /// 界?面?显?示o?事o?件t类¤¨¤型¨a
        /// </summary>
        public enumEventType EVENT_TYPE { get; set; }
        /// <summary>
        /// 放¤?行D类¤¨¤型¨a
        /// </summary>
        public string PARK_TYPE { get; set; }
        /// <summary>
        /// 收o?费¤?标à¨o准á?类¤¨¤型¨a
        /// </summary>
        public enumChargeStandardType chargeStandardType { get; set; }
        /// <summary>
        /// 是o?否¤?发¤?é送¨a手o?机¨2短¨?信?
        /// </summary>
        public bool SendSMS { get; set; }
        /// <summary>
        /// 手o?机¨2号?码?
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        ///  身|¨a份¤Y鉴?权¨?§
        /// </summary>
        public enumAuthenticationType authenticationType { get; set; }
        /// <summary>
        /// 车|ì型¨a
        /// </summary>
        public enumCarType CarType { get; set; }
        /// <summary>
        /// 是o?否¤?月?转áa临￠¨′卡?§
        /// </summary>
        public bool IsMonthToTemp { get; set; }
        /// <summary>
        /// 权¨?§限T集?￥合?
        /// </summary>
        public string ACCESS_CHANNEL_CODE { get; set; }
        /// <summary>
        /// 虚¨|拟a车|ì位?编à¨¤号?
        /// </summary>
        public string SPACE_CODE { get; set; }
        /// <summary>
        /// 图a?片?抓á￡¤拍?文?件t
        /// </summary>
        public byte[] FullPicData { get; set; }
        /// <summary>
        /// 抓á￡¤拍?图a?片?
        /// </summary>
        public string PicFullName { get; set; }
        /// <summary>
        /// 检¨?查¨|点ì?执??行D结¨￠果?
        /// </summary>
        public bool CheckPointResult { get; set; }
        /// <summary>
        /// 自á?动?￥开a闸?é时o?à不?增?加¨?收o?费¤?金e额?
        /// </summary>
        public bool AutoOpenGate { get; set; }
        /// <summary>
        /// 订?单ì￡¤信?息?é
        /// </summary>
        public CR_ORDER_RECORD_INFO Order { get; set; }
        /// <summary>
        /// 所¨′有?D订?单ì￡¤信?息?é
        /// </summary>
        public List<CR_ORDER_RECORD_INFO> ListOrder { get; set; }
        /// <summary>
        /// 优??惠Y券¨?￥信?息?é
        /// </summary>
        public List<CRPreferentialDetails> ListDiscount { get; set; }
        /// <summary>
        /// 月?卡?§有?D效?ì期¨2
        /// </summary>
        public double Validity { get; set; }
        /// <summary>
        /// 剩o?ê余?¨¤车|ì位?数oy
        /// </summary>
        public double ParkingNumber { get; set; }
        /// <summary>
        /// 是o?否¤?中D央?缴¨|费¤?
        /// </summary>
        public bool IsCenterPay { get; set; }
        /// <summary>
        /// 是o?否¤?免a费¤?
        /// </summary>
        public bool IsFree { get; set; }
        /// <summary>
        /// 本à?次??交?易°?á产¨2生|¨2的ì?订?单ì￡¤详¨o细?
        /// </summary>
        public CR_ORDER_RECORD_DETAILS currPartitionOrderDetails { get; set; }
        /// <summary>
        /// 临￠¨′时o?à授o¨2权¨?§计?费¤?
        /// </summary>
        public enumTemporaryBilling temporaryBilling { get; set; }
        /// <summary>
        /// 临￠¨′时o?à授o¨2权¨?§结¨￠束o?时o?à间?
        /// </summary>
        public DateTime TemporaryEndTime { get; set; }

        private DateTime _chargingStartTime = DateTime.MinValue;
        public DateTime ChargingStartTime
        {
            get
            {
                if (_chargingStartTime == DateTime.MinValue)
                    return this.INOUT_RECODE.IN_TIME;
                return _chargingStartTime;
            }
            set { this._chargingStartTime = value; }
        }
        /// <summary>
        /// 当ì?à前??语??音°?
        /// </summary>
        public enumSpeechType SpeechType { get; set; }
        /// <summary>
        /// 业°|ì主??编à¨¤号?
        /// </summary>
        public string OWNER_CODE { get; set; }
        /// <summary>
        /// 用??户?ì信?息?é
        /// </summary>
        public PBA_OWNER_INFO OwnerInfo { get; set; }
        /// <summary>
        /// 支?ì付?方¤?式o?
        /// </summary>
        public enumPayMethod PayMethod { get; set; }
        /// <summary>
        /// 收o?费¤?标à¨o准á?
        /// </summary>
        public IChargeStandard ChargeStandard { get; set; }
        /// <summary>
        /// 本à?次??需¨¨要°a缴¨|费¤?
        /// </summary>
        decimal currNeedPay = 0;
        public decimal CurrNeedPay { get { return currNeedPay < 0 ? 0 : currNeedPay; } set { currNeedPay = value; } }
    }
}