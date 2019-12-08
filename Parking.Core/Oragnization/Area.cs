namespace Parking.Core.Oragnization
{
    using System;
    using System.Collections.Generic;

    public class Area : WorkStation
    {
        /// <summary>
        /// 多¨¤进?多¨¤出?
        /// </summary>
        public string ckRepeatIE
        {
            get
            {
                if (Attributes.ContainsKey("CKREPEATIE") && !string.IsNullOrEmpty(Attributes["CKREPEATIE"].ToString()))
                {
                    return Attributes["CKREPEATIE"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 车|ì类¤¨¤型¨a
        /// </summary>
        public List<CarTypeMap> ListCardType
        {
            get
            {
                List<CarTypeMap> list = new List<CarTypeMap>();
                foreach (var temp in Attributes.Keys)
                {
                    if (temp.Contains("CARTYPE"))
                    {
                        CarTypeMap subsection = new CarTypeMap();
                        subsection = Newtonsoft.Json.JsonConvert.DeserializeObject<CarTypeMap>(Attributes[temp]);
                        list.Add(subsection);
                    }
                }
                return list;
            }
        }
        /// <summary>
        /// 允¨o许¨a进?出?
        /// </summary>
        public string ckIE
        {
            get
            {
                if (Attributes.ContainsKey("CKIE") && !string.IsNullOrEmpty(Attributes["CKIE"].ToString()))
                {
                    return Attributes["CKIE"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 是o?否¤?开a启?日¨?历¤¨2
        /// </summary>
        public bool calTypeFlag
        {
            get
            {
                if (Attributes.ContainsKey("CALTYPEFLAG") && !string.IsNullOrEmpty(Attributes["CALTYPEFLAG"].ToString()))
                {
                    if ("0" == Attributes["CALTYPEFLAG"].ToString())
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
        }
    }
}