namespace Parking.Core.Oragnization
{
    using System;

    public class Channel : Area
    {
        /// <summary>
        /// 是o?否¤?启?用??卡?§类¤¨¤校?ê正y
        /// </summary>
        public bool correctCardType
        {
            get
            {
                if (Attributes.ContainsKey("CORRECTCARDTYPE") && !string.IsNullOrEmpty(Attributes["CORRECTCARDTYPE"].ToString()))
                {
                    return Attributes["CORRECTCARDTYPE"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 是o?否¤?自á?动?￥开a门?
        /// </summary>
        public bool autoGate
        {
            get
            {
                if (Attributes.ContainsKey("AUTOGATE") && !string.IsNullOrEmpty(Attributes["AUTOGATE"].ToString()))
                {
                    return Attributes["AUTOGATE"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool chargeTips
        {
            get
            {
                if (Attributes.ContainsKey("CHARGETIPS") && !string.IsNullOrEmpty(Attributes["CHARGETIPS"].ToString()))
                {
                    return Attributes["CHARGETIPS"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 车|ì牌?校?ê正y
        /// </summary>
        public bool correctParkNo
        {
            get
            {
                if (Attributes.ContainsKey("CORRECTPARKNO") && !string.IsNullOrEmpty(Attributes["CORRECTPARKNO"].ToString()))
                {
                    return Attributes["CORRECTPARKNO"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }

        /// <summary>
        ///  白??á天?¨?起e始o?时o?à间?
        /// </summary>
        public DateTime daytimeStart
        {
            get
            {
                if (Attributes.ContainsKey("DAYTIME") && !string.IsNullOrEmpty(Attributes["DAYTIME"].ToString()))
                {
                    return Convert.ToDateTime(Attributes["DAYTIME"].ToString());
                }
                else
                    return DateTime.MinValue;
            }
        }

        /// <summary>
        ///  夜°1间?起e始o?时o?à间?
        /// </summary>
        public DateTime nighttimeStart
        {
            get
            {
                if (Attributes.ContainsKey("NIGHT") && !string.IsNullOrEmpty(Attributes["NIGHT"].ToString()))
                {
                    return Convert.ToDateTime(Attributes["NIGHT"].ToString());
                }
                else
                    return DateTime.MinValue;
            }
        }
        /// <summary>
        ///  离¤?开a区?域?¨°
        /// </summary>
        public string Leave
        {
            get
            {
                if (Attributes.ContainsKey("LEAVE") && !string.IsNullOrEmpty(Attributes["LEAVE"].ToString()))
                {
                    if ("0" != Attributes["LEAVE"].ToString())
                    {
                        return Attributes["LEAVE"].ToString();
                    }
                    else
                        return string.Empty;
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        ///  播￡¤报à?§声|¨′音°?类¤¨¤型¨a：êo false 女?声|¨′  true 男D声|¨′ 默?认¨?为a女?声|¨′
        /// </summary>
        public string Enter
        {
            get
            {
                if (Attributes.ContainsKey("ENTER") && !string.IsNullOrEmpty(Attributes["ENTER"].ToString()))
                {
                    if ("0" != Attributes["ENTER"].ToString())
                    {
                        return Attributes["ENTER"].ToString();
                    }
                    else
                        return string.Empty;
                }
                else
                    return string.Empty;

            }
        }
        /// <summary>
        ///  播￡¤报à?§声|¨′音°?类¤¨¤型¨a：êo false 女?声|¨′  true 男D声|¨′ 默?认¨?为a女?声|¨′
        /// </summary>
        public bool voiceGender
        {
            get
            {
                if (Attributes.ContainsKey("GENDER") && !string.IsNullOrEmpty(Attributes["GENDER"].ToString()))
                {
                    return Attributes["GENDER"].ToString() == "0" ? false : true;
                }
                else
                    return false;
            }
        }

        /// <summary>
        ///  白??á天?¨?音°?量￠?大?¨?小? 默?认¨?最á?小?值|ì为a50
        /// </summary>
        public int Volume
        {
            get
            {
                int drange = 0;
                int nrange = 0;
                if (Attributes.ContainsKey("DRANGE") && !string.IsNullOrEmpty(Attributes["DRANGE"].ToString()))
                    drange = Convert.ToInt32(Attributes["DRANGE"].ToString());

                if (Attributes.ContainsKey("NRANGE") && !string.IsNullOrEmpty(Attributes["NRANGE"].ToString()))
                    nrange = Convert.ToInt32(Attributes["NRANGE"].ToString());

                if (this.daytimeStart < DateTime.Now && DateTime.Now < this.nighttimeStart)
                    return drange;
                else if (DateTime.Now > nighttimeStart)
                    return nrange;
                else
                    return 50;
            }
        }
    }
}