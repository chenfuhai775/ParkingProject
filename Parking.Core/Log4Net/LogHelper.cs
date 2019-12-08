using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Parking.Core.Log4Net
{
    /// <summary>
    /// 日志记录类，封装log4net的ILog。主要是在此类进行自动初始化。
    /// FATAL（致命错误）、ERROR（一般错误）、WARN（警告）、INFO（一般信息）、DEBUG（调试信息）
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 获取在配置文件中的log4net配置对象
        /// </summary>
        public static ILog Log
        {
            get
            {
                return LogManager.GetLogger("log4netMainLogger");
            }
        }
        /// <summary>
        /// 初始化log4net
        /// </summary>
        static LogHelper()
        {
            InitLog4Net();
        }
        /// <summary>
        /// 初始化log4net
        /// </summary>
        public static void InitLog4Net()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}