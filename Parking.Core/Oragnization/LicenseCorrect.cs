namespace Parking.Core.Oragnization
{
    public class LicenseCorrect
    {
        /// <summary>
        /// 矫?正y前??的ì?车|ì牌?
        /// </summary>
        public string BeforeChange_VehNo { get; set; }
        /// <summary>
        /// 矫?正y后¨?的ì?车|ì牌?
        /// </summary>
        public string AfterChange_VehNo { get; set; }
        /// <summary>
        /// 识o?别àe错?¨a误¨?次??数oy(被à?车|ì牌?矫?正y)
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 设|¨¨备à?号?
        /// </summary>
        public string DeviceID { get; set; }
    }
}

