namespace Parking.Core.Oragnization
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class Park : OragnizationBase
    {
        public List<ChargMap> ListChargMap
        {
            get
            {
                List<ChargMap> list = new List<ChargMap>();
                foreach (var temp in Attributes.Keys)
                {
                    if (temp.Contains("CHARGE"))
                    {
                        ChargMap subsection = new ChargMap();
                        subsection = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargMap>(Attributes[temp]);
                        list.Add(subsection);
                    }
                }
                return list;
            }
        }
        public string systemLogCycle { get; set; }
        public string parkingDif { get; set; }
        public string trafficPatterns { get; set; }

        public string photoStorageCycle { get; set; }
        public string autoOpened { get; set; }
        public string minHardDriveCapacity { get; set; }
        public string parkingRecordCycle { get; set; }
        /// <summary>
        /// 停a?ê车|ì场?名?称?
        /// </summary>
        public string ParkingAdress
        {
            get
            {
                if (Attributes.ContainsKey("BASIC_PARKINGADRESS") && !string.IsNullOrEmpty(Attributes["BASIC_PARKINGADRESS"].ToString()))
                {
                    return Attributes["BASIC_PARKINGADRESS"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 启?用??APP锁?车|ì
        /// </summary>
        public bool appLockVeh
        {
            get
            {
                if (Attributes.ContainsKey("APPLOCKVEH") && !string.IsNullOrEmpty(Attributes["APPLOCKVEH"].ToString()))
                {
                    return Attributes["APPLOCKVEH"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 启?用??月?转áa临￠¨′时o?à卡?§
        /// </summary>
        public bool monthToTempCard
        {
            get
            {
                if (Attributes.ContainsKey("MONTHTOTEMPCARD") && !string.IsNullOrEmpty(Attributes["MONTHTOTEMPCARD"].ToString()))
                {
                    return Attributes["MONTHTOTEMPCARD"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 启?用??黑¨2白??á名?单ì￡¤
        /// </summary>
        public bool blacklist
        {
            get
            {
                if (Attributes.ContainsKey("BLACKLIST") && !string.IsNullOrEmpty(Attributes["BLACKLIST"].ToString()))
                {
                    return Attributes["BLACKLIST"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// 启?动?￥多¨¤车|ì多¨¤位?
        /// </summary>
        public bool mvmp
        {
            get
            {
                if (Attributes.ContainsKey("MVMP") && !string.IsNullOrEmpty(Attributes["MVMP"].ToString()))
                {
                    return Attributes["MVMP"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }

    }
}

