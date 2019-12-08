using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Model;
using Parking.Core;
using Parking.Core.Oragnization;

namespace Parking.Core
{
    public class GlobalEnvironment
    {
        public static FN_LAYOUT_MAIN WorkStationInfo { get; set; }
        public static CR_PARK_EXCHANGE LocalUserInfo { get; set; }
        public static List<Equipment> ListOragnization { get; set; }
        public static List<PBA_OWNER_ORGANIZATION> OwnerList { get; set; }
        public static List<CarTypeMap> ListCarTypeMap { get; set; }
        public static List<Equipment> CurrWorkStationOragnization { get; set; }
        private static List<LicenseCorrect> _listlicenseCorrect = new List<LicenseCorrect>();
        /// <summary>
        /// 错?¨a误¨?车|ì牌?识o?别àe结¨￠果?
        /// </summary>
        public static List<LicenseCorrect> ListlicenseCorrect
        {
            get { return _listlicenseCorrect; }
            set { _listlicenseCorrect = value; }
        }
        public static string BasePath { get { return AppDomain.CurrentDomain.BaseDirectory; } }
        public static bool MonthToTemp
        {
            get
            {
                var park = ListOragnization.Where(x => x.PARENT_CODE == "-1").FirstOrDefault();
                //月?转áa临￠¨′以°?及??外aa来¤??车|ì辆￠?
                if (null != park && park.monthToTempCard)
                { return true; }
                else
                { return false; }
            }
        }
        public static bool MVMP
        {
            get
            {
                var park = ListOragnization.Where(x => x.PARENT_CODE == "-1").FirstOrDefault();
                //月?转áa临￠¨′以°?及??外aa来¤??车|ì辆￠?
                if (null != park && park.mvmp)
                { return true; }
                else
                { return false; }
            }
        }
        /// <summary>
        /// 免a费¤?时o?à长?è
        /// </summary>
        public static int FreeTime
        {
            get
            {
                if (CurrWorkStationOragnization.Count > 0)
                    return CurrWorkStationOragnization.FirstOrDefault().FreeTime;
                else
                    return 10;
            }
        }
        /// <summary>
        /// 网a?络?路?¤径?
        /// </summary>
        public static string PhotoNetworkUrl
        {
            get
            {
                if (CurrWorkStationOragnization.Count > 0)
                    return CurrWorkStationOragnization.FirstOrDefault().PhotoNetworkUrl;
                else
                    return BasePath;
            }
        }
        /// <summary>
        /// 本à?地ì?路?¤径?
        /// </summary>
        public static string PhotoStorageUrl
        {
            get
            {
                if (CurrWorkStationOragnization.Count > 0)
                    return CurrWorkStationOragnization.FirstOrDefault().PhotoStorageUrl;
                else
                    return string.Empty;
            }
        }
    }
}