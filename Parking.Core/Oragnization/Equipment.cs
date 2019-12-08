namespace Parking.Core.Oragnization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class Equipment : Channel
    {
        #region __基本属性__
        /// <summary>
        /// 设|¨¨备à?编à¨¤号?
        /// </summary>
        public int deviceNumber
        {
            get
            {
                if (Attributes.ContainsKey("DEVICENUMBER") && !string.IsNullOrEmpty(Attributes["DEVICENUMBER"].ToString()))
                {
                    return Convert.ToInt32(Attributes["DEVICENUMBER"].ToString());
                }
                else
                    return 0;
            }
        }
        /// <summary>
        /// 设|¨¨备à?Id
        /// </summary>
        public string deviceid { get; set; }
        /// <summary>
        /// 是o?否¤?主??识o?别àe
        /// </summary>
        public bool autoRecognition
        {
            get
            {
                if (Attributes.ContainsKey("AUTORECOGNITION") && !string.IsNullOrEmpty(Attributes["AUTORECOGNITION"].ToString()))
                {
                    return Attributes["AUTORECOGNITION"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 登ì?录?名?
        /// </summary>
        public string loginName
        {
            get
            {
                if (Attributes.ContainsKey("LOGINNAME") && !string.IsNullOrEmpty(Attributes["LOGINNAME"].ToString()))
                {
                    return Attributes["LOGINNAME"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 密¨1码?
        /// </summary>
        public string loginPsw
        {
            get
            {
                if (Attributes.ContainsKey("LOGINPSW") && !string.IsNullOrEmpty(Attributes["LOGINPSW"].ToString()))
                {
                    return Attributes["LOGINPSW"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 显?示o?屏¨￠信?息?é
        /// </summary>
        public List<LedInfoMap> LedInfos
        {
            get
            {
                List<LedInfoMap> list = new List<LedInfoMap>();
                foreach (var temp in Attributes.Keys)
                {
                    if (temp.Contains("NORMAL"))
                    {
                        LedInfoMap subsection = new LedInfoMap();
                        subsection = Newtonsoft.Json.JsonConvert.DeserializeObject<LedInfoMap>(Attributes[temp]);
                        list.Add(subsection);
                    }
                }
                return list;
            }
        }

        public bool Online { get; set; }
        #endregion

        #region ___设备实时上报信息___
        private List<RecognitioResult> _listRecognitioResult = new List<RecognitioResult>();
        /// <summary>
        /// 当ì?à前??设|¨¨备à?一°?定?§时o?à间?范¤?围?ì内¨2识o?别àe到ì?的ì?车|ì牌?
        /// </summary>
        public List<RecognitioResult> ListRecognitioResult
        {
            get { return _listRecognitioResult; }
            set { _listRecognitioResult = value; }
        }
        /// <summary>
        /// 当ì?à前??设|¨¨备à?识o?别àe的ì?正y确¨?¤数oy据Y
        /// </summary>
        public RecognitioResult CurrRecognitioData
        {
            get
            {
                return ListRecognitioResult.OrderByDescending(x => x.Count).FirstOrDefault();
            }
        }
        #endregion

        #region ___车牌识别统计信息___
        /// <summary>
        /// 识o?别àe错?¨a误¨?次??数oy(被à?车|ì牌?矫?正y)
        /// </summary>
        public int ErrorCount { get; set; }
        private List<LicenseCorrect> _listlicenseCorrect = new List<LicenseCorrect>();
        /// <summary>
        /// 错?¨a误¨?车|ì牌?识o?别àe结¨￠果?
        /// </summary>
        public List<LicenseCorrect> ListlicenseCorrect
        {
            get { return _listlicenseCorrect; }
            set { _listlicenseCorrect = value; }
        }
        /// <summary>
        /// 最á?后¨?识o?别àe车|ì牌?
        /// </summary>
        public string lastCarNo { get; set; }
        #endregion
    }
}