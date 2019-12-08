using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Parking.Core.Common
{
    public class ConfigHelper
    {
        /// <summary>
        /// 区域剩余车位统计时间间隔(秒)
        /// </summary>
        public static int RemainingTimeInterval
        {
            get
            {
                var remainingTimeInterval = System.Configuration.ConfigurationManager.AppSettings["RemainingTimeInterval"].ToString();
                if (!string.IsNullOrEmpty(remainingTimeInterval))
                    return Convert.ToInt32(remainingTimeInterval);
                else
                    return 1;
            }
        }
        /// <summary>
        /// 通道数据上报间间隔(秒)
        /// </summary>
        public static int ChannelDataUpLoadInterval
        {
            get
            {
                var channelDataUpLoadInterval = System.Configuration.ConfigurationManager.AppSettings["ChannelDataUpLoadInterval"].ToString();
                if (!string.IsNullOrEmpty(channelDataUpLoadInterval))
                    return Convert.ToInt32(channelDataUpLoadInterval);
                else
                    return 1;
            }
        }
        /// <summary>
        /// 车牌识别时间间隔(分钟)
        /// </summary>
        public static int CarRecognitionInterval
        {
            get
            {
                var carRecognitionInterval = System.Configuration.ConfigurationManager.AppSettings["CarRecognitionInterval"].ToString();
                if (!string.IsNullOrEmpty(carRecognitionInterval))
                    return Convert.ToInt32(carRecognitionInterval);
                else
                    return 1;
            }
        }
        /// <summary>
        /// 本地登录模式
        /// </summary>
        public static bool LoginFromLocal
        {
            get
            {
                var carRecognitionInterval = System.Configuration.ConfigurationManager.AppSettings["LoginFromLocal"].ToString();
                if (!string.IsNullOrEmpty(carRecognitionInterval) && carRecognitionInterval.ToUpper() == "TRUE")
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// 最低识别率，转化成百分比
        /// </summary>
        public static int RecognitionRate
        {
            get
            {
                var remainingTimeInterval = System.Configuration.ConfigurationManager.AppSettings["RecognitionRate"].ToString();
                if (!string.IsNullOrEmpty(remainingTimeInterval))
                    return Convert.ToInt32(remainingTimeInterval);
                else
                    return 60;
            }
        }
    }
}