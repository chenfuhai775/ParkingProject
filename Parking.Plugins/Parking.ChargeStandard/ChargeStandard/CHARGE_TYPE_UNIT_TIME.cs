namespace Parking.ChargeStandard
{
    using Parking.Core.ChargeStandard;
    using Parking.Core.Interface;
    using Parking.Core.Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CHARGE_TYPE_UNIT_TIME : BaseCharge, IChargeStandard
    {
        public string VEHICLE_NO { get; set; }
        public string StrMessageInfo { get; set; }

        #region __属性__
        /// <summary>
        /// 每?日¨?封¤a顶￡¤金e额?
        /// </summary>
        public int dailyCapMoney
        {
            get
            {
                if (Attributes.ContainsKey("A_dailyCapMoney") && !string.IsNullOrEmpty(Attributes["A_dailyCapMoney"].ToString()))
                    return Convert.ToInt32(Attributes["A_dailyCapMoney"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 收o?费¤?时o?à段? 0-全¨?天?¨? 1-分¤?时o?à
        /// </summary>
        public int billableHoursGroup
        {
            get
            {
                if (Attributes.ContainsKey("A_billableHoursGroup") && !string.IsNullOrEmpty(Attributes["A_billableHoursGroup"].ToString()))
                    return Convert.ToInt32(Attributes["A_billableHoursGroup"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 间?隔?收o?费¤?金e额?
        /// </summary>
        public decimal intervalChargingMoney
        {
            get
            {
                if (Attributes.ContainsKey("A_intervalChargingMoney") && !string.IsNullOrEmpty(Attributes["A_intervalChargingMoney"].ToString()))
                    return Convert.ToDecimal(Attributes["A_intervalChargingMoney"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 首o?á段?收o?费¤?金e额?
        /// </summary>
        public decimal firstChargeMoney
        {
            get
            {
                if (Attributes.ContainsKey("A_firstChargeMoney") && !string.IsNullOrEmpty(Attributes["A_firstChargeMoney"].ToString()))
                    return Convert.ToDecimal(Attributes["A_firstChargeMoney"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 间?隔?收o?费¤?时o?à长?è
        /// </summary>
        public int intervalChargingTime
        {
            get
            {
                if (Attributes.ContainsKey("A_intervalChargingTime") && !string.IsNullOrEmpty(Attributes["A_intervalChargingTime"].ToString()))
                    return Convert.ToInt32(Attributes["A_intervalChargingTime"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 免a费¤?停a?ê车|ì时o?à长?è
        /// </summary>
        public int freeTime
        {
            get
            {
                if (Attributes.ContainsKey("A_freeTime") && !string.IsNullOrEmpty(Attributes["A_freeTime"].ToString()))
                    return Convert.ToInt32(Attributes["A_freeTime"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 每?日¨?封¤a顶￡¤时o?à间?(分¤?钟¨?)
        /// </summary>
        public int dailyCapTime
        {
            get
            {
                if (Attributes.ContainsKey("A_dailyCapTime") && !string.IsNullOrEmpty(Attributes["A_dailyCapTime"].ToString()))
                    return Convert.ToInt32(Attributes["A_dailyCapTime"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 首o?á段?收o?费¤?时o?à长?è
        /// </summary>
        public int firstTime
        {
            get
            {
                if (Attributes.ContainsKey("A_firstTime") && !string.IsNullOrEmpty(Attributes["A_firstTime"].ToString()))
                    return Convert.ToInt32(Attributes["A_firstTime"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 按???次??计?费¤?分¤?割?方¤?式o?
        /// </summary>
        public string cumulativeWay
        {
            get
            {
                if (Attributes.ContainsKey("A_cumulativeWay") && !string.IsNullOrEmpty(Attributes["A_cumulativeWay"].ToString()))
                    return Attributes["A_cumulativeWay"].ToString();
                else
                    return "";
            }
        }
        /// <summary>
        /// 按???次??计?费¤?累¤?计?方¤?式o?
        /// </summary>
        public int cumulativeType
        {
            get
            {
                if (Attributes.ContainsKey("A_cumulativeType") && !string.IsNullOrEmpty(Attributes["A_cumulativeType"].ToString()))
                    return Convert.ToInt32(Attributes["A_cumulativeType"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 按???次??计?费¤?累¤?计?方¤?式o?(0-累¤?计?，ê?1-不?累¤?计?)
        /// </summary>
        public bool freeOvertimeBiling
        {
            get
            {
                if (Attributes.ContainsKey("A_freeOvertimeBiling") && !string.IsNullOrEmpty(Attributes["A_freeOvertimeBiling"].ToString()))
                {
                    if ("0" == Attributes["A_freeOvertimeBiling"].ToString())
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
        }
        /// <summary>
        /// 满¨2时o?à时o?à长?è(分¤?钟¨?)
        /// </summary>
        public int thresholdTime
        {
            get
            {
                if (Attributes.ContainsKey("A_thresholdTime") && !string.IsNullOrEmpty(Attributes["A_thresholdTime"].ToString()))
                    return Convert.ToInt32(Attributes["A_thresholdTime"].ToString());
                else
                    return 0;
            }
        }
        /// <summary>
        /// 满¨2时o?à封¤a顶￡¤金e额?
        /// </summary>
        public decimal thresholdMoney
        {
            get
            {
                if (Attributes.ContainsKey("A_thresholdMoney") && !string.IsNullOrEmpty(Attributes["A_thresholdMoney"].ToString()))
                    return Convert.ToDecimal(Attributes["A_thresholdMoney"].ToString());
                else
                    return 0;
            }
        }
        #endregion

        #region __分段收费标准__
        /// <summary>
        /// 分段收费标准
        /// </summary>
        public List<SubsectionUnitTime> Subsections
        {
            get
            {
                List<SubsectionUnitTime> list = new List<SubsectionUnitTime>();
                foreach (var temp in Attributes.Keys)
                {
                    if (temp.Contains("array"))
                    {
                        SubsectionUnitTime subsection = new SubsectionUnitTime();
                        subsection = Newtonsoft.Json.JsonConvert.DeserializeObject<SubsectionUnitTime>(Attributes[temp]);
                        list.Add(subsection);
                    }
                }
                return list;
            }
        }
        #endregion

        #region __计费__
        public override decimal Charge(CR_ORDER_RECORD_DETAILS OrderDetails, int time = 0)
        {
            base.ListChargeInfo.Clear();
            this.VEHICLE_NO = OrderDetails.VEHICLE_NO;
            base.ListChargeInfo.Add(VEHICLE_NO);
            OrderDetails.IN_TIME = OrderDetails.IN_TIME.AddMinutes(time);
            Dictionary<DateTime, DateTime> dicSubsection = new Dictionary<DateTime, DateTime>();
            //减?去¨￡¤免a费¤?时o?à间?
            double totalMin = (OrderDetails.OUT_TIME - OrderDetails.IN_TIME).TotalMinutes - freeTime;
            int totalTime = Convert.ToInt32((OrderDetails.OUT_TIME - OrderDetails.IN_TIME).TotalMinutes);
            base.ListChargeInfo.Add("入¨?场?时o?à间?:" + OrderDetails.IN_TIME.ToString("yyyy-MM-dd HH:mm:ss") + "出?场?时o?à间?:" + OrderDetails.OUT_TIME.ToString("yyyy-MM-dd HH:mm:ss") + ",总á¨1时o?à长?è" + (totalTime < 0 ? 0 : totalTime) + "分¤?钟¨?");
            if (totalMin <= 0)
                return 0;
            DateTime IN_TIME = OrderDetails.IN_TIME;
            DateTime OUT_TIME = OrderDetails.OUT_TIME;

            if (!freeOvertimeBiling)
            {
                IN_TIME = IN_TIME.AddMinutes(freeTime);
                base.ListChargeInfo.Add("减?免a免a费¤?停a?ê车|ì时o?à长?è" + freeTime + "分¤?钟¨?");
            }
            if ("A" == cumulativeWay)
            {
                //总á¨1段?数oy
                int totalDay = Convert.ToDateTime(OUT_TIME.ToShortDateString()).Subtract(Convert.ToDateTime(IN_TIME.ToShortDateString())).Days + 1;
                for (int i = 0; i < totalDay; i++)
                {
                    DateTime dtStart = i == 0 ? IN_TIME : Convert.ToDateTime(IN_TIME.ToShortDateString()).AddDays(i);
                    DateTime dtEnd = Convert.ToDateTime(IN_TIME.ToShortDateString()).AddDays(i + 1).AddSeconds(-1);
                    dtEnd = dtEnd > OUT_TIME ? OUT_TIME : dtEnd;
                    dicSubsection.Add(dtStart, dtEnd);
                }
            }
            else
            {
                //总á¨1段?数oy
                double totalDay = OUT_TIME.Subtract(Convert.ToDateTime(IN_TIME)).TotalHours / 24;
                for (double i = 0; i < totalDay; i++)
                {
                    DateTime dtStart = i == 0 ? IN_TIME : Convert.ToDateTime(IN_TIME).AddHours(24 * i);
                    DateTime dtEnd = Convert.ToDateTime(IN_TIME).AddHours(24 * (i + 1)).AddSeconds(-1);
                    dtEnd = dtEnd > OUT_TIME ? OUT_TIME : dtEnd;
                    dicSubsection.Add(dtStart, dtEnd);
                }
            }

            //总á¨1金e额?
            decimal totalMoney = 0;
            bool isFirst = true;
            //按???天?¨?遍à¨|历¤¨2
            foreach (var temp in dicSubsection)
            {
                TimeSpan ts = temp.Value - temp.Key;
                //总á¨1分¤?钟¨?数oy
                double totalMinDay = ts.TotalMinutes;
                if (totalMinDay > 0)
                {
                    totalMoney += GetMoney(temp.Key, temp.Value, isFirst);
                    isFirst = false;
                }
            }
            base.ListChargeInfo.Add("本à?次??实o|ì缴¨|总á¨1金e额?" + totalMoney + "元a");
            return totalMoney;
        }

        private decimal GetMoney(DateTime startTime, DateTime endTime, bool isFirst)
        {
            base.TotalMoney = (cumulativeType == 0) ? base.GetTotalMoney(this.VEHICLE_NO, startTime, endTime, ("A" == cumulativeWay)) : 0;
            long TotalTime = 0;
            DateTime dtTemp = startTime;
            decimal dcMoney = 0;
            //首o?á时o?à段?收o?费¤?
            if (isFirst)
            {
                StrMessageInfo = "首o?á时o?à段?{0}分¤?钟¨?,收o?费¤?{1}元a";
                base.ListChargeInfo.Add(string.Format(StrMessageInfo, firstTime, firstChargeMoney));
                dtTemp = startTime.AddMinutes(firstTime);
                dcMoney += firstChargeMoney;
                TotalTime += firstTime;
            }
            StrMessageInfo = "{0}---{1}，ê?时o?à长?è{2}分¤?钟¨?,收o?费¤?{3}元a";
            while (dtTemp < endTime)
            {
                //启?用??封¤a顶￡¤时o?à间?,取¨?封¤a顶￡¤时o?à间?数oy
                if (dailyCapTime > 0)
                {
                    if (dailyCapTime <= TotalTime)
                    {
                        StrMessageInfo = "超?过y封¤a顶￡¤时o?à间?{0}分¤?钟¨?";
                        base.ListChargeInfo.Add(string.Format(StrMessageInfo, dailyCapTime));
                        break;
                    }
                }
                int totalDay = Convert.ToDateTime(DateTime.Now.ToShortDateString()).Subtract(Convert.ToDateTime(startTime.ToShortDateString())).Days;
                var temp = Subsections.Where(x => x.beginTime <= startTime.AddDays(totalDay) && x.endTime >= startTime.AddDays(totalDay)).FirstOrDefault();
                if (null != temp)
                {
                    base.ListChargeInfo.Add(string.Format(StrMessageInfo, temp.beginTime.ToString("yyyy-MM-dd HH:mm:ss"), temp.endTime.ToString("yyyy-MM-dd HH:mm:ss"), temp.intervalChargingTime.ToString(), temp.intervalChargingMoney));
                    dcMoney += temp.intervalChargingMoney;
                    dtTemp = dtTemp.AddMinutes(temp.intervalChargingTime);
                    TotalTime += temp.intervalChargingTime;
                }
                else
                {
                    base.ListChargeInfo.Add(string.Format(StrMessageInfo, dtTemp.ToString("yyyy-MM-dd HH:mm:ss"), dtTemp.AddMinutes(intervalChargingTime).ToString("yyyy-MM-dd HH:mm:ss"), intervalChargingTime.ToString(), intervalChargingMoney));
                    dcMoney += intervalChargingMoney;
                    dtTemp = dtTemp.AddMinutes(intervalChargingTime);
                    TotalTime += intervalChargingTime;
                }
            }
            //满¨2时o?à封¤a顶￡¤
            if (thresholdMoney > 0 && thresholdTime > 0 && TotalTime >= thresholdTime)
            {
                dcMoney = thresholdMoney;
                DateTime newStartDate = startTime.AddMinutes(thresholdTime);
                long newTotalTime = 0;
                DateTime newdtTemp = newStartDate;
                while (newdtTemp < endTime)
                {
                    //启?用??封¤a顶￡¤时o?à间?,取¨?封¤a顶￡¤时o?à间?数oy
                    if (dailyCapTime > 0)
                    {
                        if (dailyCapTime <= newTotalTime)
                            break;
                    }
                    int totalDay = Convert.ToDateTime(DateTime.Now.ToShortDateString()).Subtract(Convert.ToDateTime(newStartDate.ToShortDateString())).Days;
                    var temp = Subsections.Where(x => x.beginTime <= newStartDate.AddDays(totalDay) && x.endTime >= newStartDate.AddDays(totalDay)).FirstOrDefault();
                    if (null != temp)
                    {
                        base.ListChargeInfo.Add(string.Format(StrMessageInfo, temp.beginTime.ToString("yyyy-MM-dd HH:mm:ss"), temp.endTime.ToString("yyyy-MM-dd HH:mm:ss"), temp.intervalChargingTime.ToString(), temp.intervalChargingMoney));
                        dcMoney += temp.intervalChargingMoney;
                        newdtTemp = newdtTemp.AddMinutes(temp.intervalChargingTime);
                        newTotalTime += temp.intervalChargingTime;
                    }
                    else
                    {
                        base.ListChargeInfo.Add(string.Format(StrMessageInfo, newdtTemp.ToString("yyyy-MM-dd HH:mm:ss"), newdtTemp.AddMinutes(intervalChargingTime).ToString("yyyy-MM-dd HH:mm:ss"), intervalChargingTime.ToString(), intervalChargingMoney));
                        dcMoney += intervalChargingMoney;
                        newdtTemp = newdtTemp.AddMinutes(intervalChargingTime);
                        newTotalTime += intervalChargingTime;
                    }
                }
            }
            //启?用??封¤a顶￡¤金e额?
            if (dailyCapMoney > 0)
            {
                base.ListChargeInfo.Add("当ì?à天?¨?限T额?" + dailyCapMoney + "元a,全¨?时o?à段?内¨2已°?缴¨|费¤?金e额?" + TotalMoney + "元a,当ì?à前??产¨2生|¨2费¤?用??" + dcMoney + "元a");
                decimal NowTotal = dcMoney + TotalMoney;
                dcMoney = NowTotal > dailyCapMoney ? (dailyCapMoney - TotalMoney) : dcMoney;
                dcMoney = dcMoney > 0 ? dcMoney : 0;
            }
            base.ListChargeInfo.Add("实o|ì缴¨|金e额?" + dcMoney + "元a");
            return dcMoney;
        }
        #endregion
    }
}