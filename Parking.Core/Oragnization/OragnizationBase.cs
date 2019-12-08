namespace Parking.Core.Oragnization
{
    using Parking.Core.Enum;
    using Parking.Core.Model;
    using System;
    using System.Collections.Generic;

    public class OragnizationBase
    {
        Dictionary<string, string> _attribute = new Dictionary<string, string>();
        /// <summary>
        /// 属o?性?集?￥合?
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return _attribute; }
            set { _attribute = value; }
        }
        /// <summary>
        /// 组á¨|织?￥信?息?é
        /// </summary>
        public PBA_PARKING_ORGANIZATION_INFO OrganizationInfo { get; set; }
        /// <summary>
        /// 通a?§道ì¨¤类¤¨¤型¨a
        /// </summary>
        public enumChannelType channelType
        {
            get
            {
                return (enumChannelType)System.Enum.Parse(typeof(enumChannelType), OrganizationInfo.ORGANIZATION_TYPE_CODE, false);
            }
        }
        /// <summary>
        /// 设|¨¨备à?IP地ì?址?¤
        /// </summary>
        public string IP
        {
            get
            {
                if (Attributes.ContainsKey("IP") && !string.IsNullOrEmpty(Attributes["IP"].ToString()))
                {
                    return Attributes["IP"].ToString();
                }
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 设|¨¨备à?IP地ì?址?¤
        /// </summary>
        public int Port
        {
            get
            {
                if (Attributes.ContainsKey("PORT") && !string.IsNullOrEmpty(Attributes["PORT"].ToString()))
                {
                    return Convert.ToInt32(Attributes["PORT"].ToString());
                }
                else
                    return 0;
            }
        }
        /// <summary>
        /// 设|¨¨备à?类¤¨¤型¨a
        /// </summary>
        public enumDeviceType deviceType { get; set; }
        /// <summary>
        /// 组á¨|织?￥节¨2点ì?
        /// </summary>
        public string ORGANIZATION_CODE { get; set; }
        /// <summary>
        /// 组á¨|织?￥节¨2点ì?
        /// </summary>
        public string ORGANIZATION_NAME
        {
            get { return OrganizationInfo.ORGANIZATION_NAME; }
        }
        /// <summary>
        /// 组á¨|织?￥节¨2点ì?
        /// </summary>
        public int? ORG_LEVEL
        {
            get { return OrganizationInfo.ORG_LEVEL; }
        }
        /// <summary>
        /// 组á¨|织?￥父?节¨2点ì?
        /// </summary>
        public string PARENT_CODE { get; set; }
        /// <summary>
        /// 设|¨¨备à?类¤¨¤型¨a
        /// </summary>
        public enumProductLine productLine { get; set; }
        /// <summary>
        /// 免a费¤?时o?à长?è
        /// </summary>
        public int FreeTime
        {
            get
            {
                if (Attributes.ContainsKey("RESIDENCETIME") && !string.IsNullOrEmpty(Attributes["RESIDENCETIME"].ToString()))
                    return Convert.ToInt32(Attributes["RESIDENCETIME"].ToString());
                else
                    return 10;
            }
        }
        /// <summary>
        /// 全¨?局?图a?片?路?¤径?
        /// </summary>
        public string PhotoStorageUrl
        {
            get
            {
                if (Attributes.ContainsKey("PHOTOSTORAGEURL") && !string.IsNullOrEmpty(Attributes["PHOTOSTORAGEURL"].ToString()))
                    return Attributes["PHOTOSTORAGEURL"].ToString();
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 网a?络?图a?片?上|?传??地ì?址?¤
        /// </summary>
        public string PhotoNetworkUrl
        {
            get
            {
                if (Attributes.ContainsKey("PHOTONETWORKURL") && !string.IsNullOrEmpty(Attributes["PHOTONETWORKURL"].ToString()))
                    return Attributes["PHOTONETWORKURL"].ToString();
                else
                    return string.Empty;
            }
        }
    }
}