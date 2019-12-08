using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.DataProcessing;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Oragnization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
using System.Net;
using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.Configuration;
using Parking.Core.Model;
using SpeechLib;

namespace Parking.Core.Common
{
    public class CommHelper
    {
        public static string GetRealIP()
        {
            string IP = string.Empty;
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties ip = adapter.GetIPProperties();
                UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                foreach (UnicastIPAddressInformation ipadd in ipCollection)
                {
                    if (ipadd.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        IP = ipadd.Address.ToString();
                        return IP;
                    }
                }
            }
            return IP;
        }
        /// <summary>
        /// 无牌车号码
        /// </summary>
        /// <param name="carNo"></param>
        /// <returns></returns>
        public static bool ValidateUnlicensedCar(string carNo)
        {
            string express = @"^\d{4}([0][1-9]|(1[0-2]))([1-9]|([012]\d)|(3[01]))(([0-1]{1}[0-9]{1})|([2]{1}[0-4]{1}))(([0-5]{1}[0-9]{1}|[6]{1}[0]{1}))((([0-5]{1}[0-9]{1}|[6]{1}[0]{1})))$";
            return Regex.IsMatch(carNo, express);
        }
        /// <summary>
        /// 无牌车号码
        /// </summary>
        /// <param name="carNo"></param>
        /// <returns></returns>
        public static bool ArmedPoliceCard(string carNo)
        {
            bool result = false;
            string express = carNo.Substring(0, 2);
            result = (express.ToUpper() == "WJ") ? true : false;
            express = carNo.Substring(carNo.Length - 1, 1);
            result = (express.ToUpper() == "警") ? true : false;
            return result;
        }
        /// <summary>
        /// 手机号码验证
        /// </summary>
        /// <param name="strPhone"></param>
        /// <returns></returns>
        public static bool ValidatePhone(string strPhone)
        {
            return Regex.IsMatch(strPhone, @"^1[358]{1}\d{9}$");
        }
        /// <summary>
        /// 车牌号码校验
        /// </summary>
        /// <param name="carNo"></param>
        /// <returns></returns>
        public static bool ValidateCarNum(string carNo)
        {
            string express = @"^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4,5}[A-Z0-9挂学警港澳]{1}$";
            return (Regex.IsMatch(carNo, express));
        }
        /// <summary>
        /// 特殊车牌,最后一个为文字
        /// </summary>
        /// <returns></returns>
        public static bool ValidateSpecialCarNum(string carNo)
        {
            string express = @"^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4,5}[挂学警港澳]$";
            return (Regex.IsMatch(carNo, express));
        }
        /// <summary>
        /// 语音设备播报语音
        /// </summary>
        /// <param name="channelCode">通道编号</param>
        /// <param name="strArr"></param>
        public static void Sound(ProcessRecord recordInfo, string[] strArr)
        {
            int soundSize = 1;
            var channelEqu = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.CHN_CODE).FirstOrDefault();
            if (null != channelEqu)
            {
                soundSize = channelEqu.Volume;
            }
            var childrenList = GetOrgInfos(recordInfo.CHN_CODE);
            if (null != childrenList && childrenList.Count > 0)
            {

                ////查找语音设备
                var voiceDevice = childrenList.Where(x => x.productLine == enumProductLine.Voice).FirstOrDefault();
                if (null != voiceDevice && !string.IsNullOrEmpty(voiceDevice.IP))
                {
                    if (voiceDevice.Online)
                    {
                        var tempControlPanel = EngineContext.Current.Resolve<IControlPanel>(voiceDevice.deviceType.ToString());
                        if (null != tempControlPanel)
                        {
                            LogHelper.Log.Info("车牌号：" + recordInfo.INOUT_RECODE.VEHICLE_NO + ";发送语音时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            tempControlPanel.Sound(voiceDevice.IP, voiceDevice.Port, strArr, soundSize);
                        }
                    }
                    else
                        LogHelper.Log.Info("语音设备【" + voiceDevice.ORGANIZATION_NAME + "】不在线!");
                }
                else  //找父节点 ----- (一般是主控板)
                {
                    var boardDevice = childrenList.Where(x => x.productLine == enumProductLine.MasterBoard).FirstOrDefault();
                    if (null != boardDevice && !string.IsNullOrEmpty(boardDevice.IP))
                    {
                        //if (boardDevice.Online)
                        //{
                        var tempControlPanel = EngineContext.Current.Resolve<IControlPanel>(boardDevice.deviceType.ToString());
                        if (null != tempControlPanel)
                        {
                            LogHelper.Log.Info("车牌号：" + recordInfo.INOUT_RECODE.VEHICLE_NO + ";发送语音时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            tempControlPanel.Sound(boardDevice.IP, boardDevice.Port, strArr, soundSize);
                        }
                        //}
                        //else
                        //    LogHelper.Log.Info("语音设备【" + boardDevice.ORGANIZATION_NAME + "】不在线!");
                    }
                }
            }
        }
        /// <summary>
        /// 道闸设备开闸
        /// </summary>
        /// <param name="channelCode"></param>
        /// <param name="strArr"></param>
        public static void OpenGate(ProcessRecord recordInfo)
        {
            var temp = CommHelper.GetOrgInfos(recordInfo.CHN_CODE, false);
            if (null != temp)
            {

                var par = temp.Where(x => x.channelType == enumChannelType.par).LastOrDefault();
                var chargMap = par.ListChargMap.Where(x => x.carType == (int)recordInfo.CarType).FirstOrDefault();
                int[] roadType = chargMap.roadGateType;
                var childrenList = GetOrgInfos(recordInfo.CHN_CODE);
                if (null != childrenList && childrenList.Count > 0)
                {
                    //查找道闸设备
                    var roadGateDevice = childrenList.Where(x => x.productLine == enumProductLine.RoadGate).FirstOrDefault();
                    if (null != roadGateDevice && !string.IsNullOrEmpty(roadGateDevice.IP))
                    {
                        //if (roadGateDevice.Online)
                        //{
                        var tempControlPanel = EngineContext.Current.Resolve<IControlPanel>(roadGateDevice.deviceType.ToString());
                        if (null != tempControlPanel)
                        {
                            LogHelper.Log.Info("道闸设备【" + roadGateDevice.ORGANIZATION_NAME + "】" + ";车牌号：" + recordInfo.INOUT_RECODE.VEHICLE_NO + ";发送开闸命令时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            tempControlPanel.OpenGate(roadGateDevice.IP, roadGateDevice.Port, roadType);
                            recordInfo.OPERATER_TYPE = enumOperaterType.OpenGate;
                            ThreadMessageTransact.Instance.triggerEvent(recordInfo, false);
                        }
                        //}
                        //else
                        //    LogHelper.Log.Info("道闸设备【" + roadGateDevice.ORGANIZATION_NAME + "】不在线!");
                    }
                    else  //找父节点 ----- (一般是主控板)
                    {
                        var boardDevice = childrenList.Where(x => x.productLine == enumProductLine.MasterBoard).FirstOrDefault();
                        if (null != boardDevice && !string.IsNullOrEmpty(boardDevice.IP))
                        {
                            //if (boardDevice.Online)
                            //{
                            var tempControlPanel = EngineContext.Current.Resolve<IControlPanel>(boardDevice.deviceType.ToString());
                            if (null != tempControlPanel)
                            {
                                LogHelper.Log.Info("道闸设备【" + boardDevice.ORGANIZATION_NAME + "】" + ";车牌号：" + recordInfo.INOUT_RECODE.VEHICLE_NO + ";发送开闸命令时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                tempControlPanel.OpenGate(boardDevice.IP, boardDevice.Port, roadType);
                                recordInfo.OPERATER_TYPE = enumOperaterType.OpenGate;
                                ThreadMessageTransact.Instance.triggerEvent(recordInfo, false);
                            }
                            //}
                            //else
                            //    LogHelper.Log.Info("道闸设备【" + boardDevice.ORGANIZATION_NAME + "】不在线!");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 道闸设备开闸
        /// </summary>
        /// <param name="channelCode"></param>
        /// <param name="strArr"></param>
        public static void ShowLED(Equipment device, string[] strArr, LedInfoMap info)
        {
            if (string.IsNullOrEmpty(device.IP))
            {
                var Org = CommHelper.GetOrgInfos(device.ORGANIZATION_CODE, false);
                device = Org.Where(x => x.deviceType == enumDeviceType.LonixControlPanelI).LastOrDefault();
            }
            if (null != device)
            {
                var tempLedScreen = EngineContext.Current.Resolve<ILEDScreen>();
                if (null != tempLedScreen)
                {
                    tempLedScreen.ShowLedScreen(device.IP, device.Port, strArr, info.displayMode, info.serialNo + 1, info.displayColor);
                }
            }
        }
        /// <summary>
        ///  语言播报信息处理
        ///  转换原则：
        ///  {0},{1},{2},{3}:车牌号,免费时间,缴费金额,停车时长
        /// </summary>
        /// <param name="fieldInfo">字段对应信息</param>
        /// <param name="content">DEFAULT_VOICE取出的对应信息</param>
        /// <param name="record">对应的记录</param>
        /// <returns></returns>
        public static string VoiceContent(string content, ProcessRecord recordInfo, bool isWindowsSound = false)
        {
            TimeSpan tsNow = new TimeSpan(recordInfo.INOUT_RECODE.IN_TIME.Ticks);
            TimeSpan tsTemp = new TimeSpan(recordInfo.INOUT_RECODE.OUT_TIME.Ticks);
            TimeSpan tsTotal = tsNow.Subtract(tsTemp).Duration();
            //停a?ê车|ì时o?à长?è
            string parkingTime = "[n2]" + tsTotal.Days + "天?¨?" + tsTotal.Hours + "小?时o?à" + tsTotal.Minutes + "分¤?" + tsTotal.Seconds + "秒?";
            Dictionary<int, string> current = new Dictionary<int, string>();
            current.Add(0, "[n1]" + recordInfo.INOUT_RECODE.VEHICLE_NO.ToString());  //车|ì牌?号?
            current.Add(1, getCarType(recordInfo));  //卡?§类¤¨¤
            if (recordInfo.SpeechType == enumSpeechType.ParkingOccupy)
                current.Add(2, "[n2]" + recordInfo.Validity.ToString());  //有?D效?ì期¨2
            else
                current.Add(2, "[n2]" + (recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_MONTH ? recordInfo.Validity.ToString() : ""));
            current.Add(3, parkingTime);  //停a?ê车|ì时o?à长?è
            current.Add(4, "[n2]" + recordInfo.INOUT_RECODE.CHARGE_MONEY.ToString());  //缴¨|费¤?金e额?
            current.Add(5, string.Empty);  //消?费¤?金e额?
            current.Add(6, recordInfo.OwnerInfo == null ? "0" : "[n2]" + recordInfo.OwnerInfo.balance.ToString());  //余?¨¤额?
            current.Add(7, recordInfo.ParkingNumber.ToString());  //余?¨¤位?
            current.Add(8, string.Empty);  //剩o?ê余?¨¤次??数oy
            current.Add(9, GlobalEnvironment.FreeTime.ToString());  //免a费¤?时o?à间?
            foreach (KeyValuePair<int, string> item in current)
                content = content.Replace("{" + item.Key + "}", item.Value);
            if (isWindowsSound)
                content = content.Replace("[n1]", "").Replace("[n2]", "");
            return content;
        }
        /// <summary>
        /// LED显示
        /// </summary>
        /// <param name="content"></param>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public static string LedContent(string content, ProcessRecord recordInfo, int Number)
        {
            int totalParking = 0;
            if (null != GlobalEnvironment.ListCarTypeMap)
            {
                var par = GlobalEnvironment.ListCarTypeMap.Where(x => x.AreaCode == recordInfo.INOUT_RECODE.CURR_PARTITION_CODE && x.carType == recordInfo.INOUT_RECODE.CREDENTIALS_TYPE).FirstOrDefault();
                if (null != par)
                    totalParking = recordInfo.CHANNEL_TYPE == enumChannelType.chn_out ? (par.parkingNumber + 1) : par.parkingNumber;
            }
            TimeSpan tsNow = new TimeSpan(recordInfo.INOUT_RECODE.IN_TIME.Ticks);
            TimeSpan tsTemp = new TimeSpan(recordInfo.INOUT_RECODE.OUT_TIME.Ticks);
            TimeSpan tsTotal = tsNow.Subtract(tsTemp).Duration();
            //停车时长
            string parkingTime = tsTotal.Days + "天" + tsTotal.Hours + "小时" + tsTotal.Minutes + "分" + tsTotal.Seconds + "秒";

            Dictionary<int, string> current = new Dictionary<int, string>();
            current.Add(0, "");  //欢迎语
            current.Add(1, "");  //欢送语
            current.Add(2, recordInfo.INOUT_RECODE.VEHICLE_NO);  //车牌信息
            current.Add(3, recordInfo.CARD_TYPE == enumCardType.CAR_TYPE_TEMP ? "临时卡" : "月卡");  //卡类
            current.Add(4, recordInfo.Validity.ToString());  //有效期
            current.Add(5, parkingTime);  //停车时长
            current.Add(6, recordInfo.INOUT_RECODE.CHARGE_MONEY.ToString());  //缴费金额
            current.Add(7, recordInfo.INOUT_RECODE.PRE_MONEY.ToString());  //优惠金额
            current.Add(8, string.Empty);  //余额
            current.Add(9, totalParking.ToString());  //余位
            current.Add(10, string.Empty);  //非法警告
            foreach (KeyValuePair<int, string> item in current)
                content = content.Replace("%s", current[Number]);
            return content;
        }
        /// <summary>
        /// 递归获取子节点
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public static List<Equipment> GetOrgInfos(string OrgCode, bool findChildren = true)
        {
            var query = from c in GlobalEnvironment.ListOragnization
                        where findChildren ? (c.PARENT_CODE == OrgCode) : (c.ORGANIZATION_CODE == OrgCode)
                        select c;
            return query.ToList().Concat(query.ToList().SelectMany(t => GetOrgInfos(findChildren ? t.ORGANIZATION_CODE : t.PARENT_CODE, findChildren))).OrderBy(x => x.ORG_LEVEL).ToList();
        }
        /// <summary>
        /// 获取工作站所有设备
        /// </summary>
        /// <param name="WORKSTATION_CODE"></param>
        /// <returns></returns>
        public static List<Equipment> GetCurrentWorkStationOrgs(string WorkStationCode)
        {
            return CommHelper.GetOrgInfos(WorkStationCode).Concat(CommHelper.GetOrgInfos(WorkStationCode, false)).OrderBy(x => x.ORG_LEVEL).ToList();
        }
        /// <summary>
        /// 方法：Json反序列化,用于接收客户端Json后生成对应的对象
        /// </summary>
        public static T FromJsonTo<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T jsonObject = (T)ser.ReadObject(ms);
            ms.Close();
            return jsonObject;
        }
        //对数据序列化，返回JSON格式 
        public static string ToJSON(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }
        /// <summary>  
        /// 指定Post地址使用Get方式获取全部字符串  
        /// </summary>  
        /// <param name="url">请求后台地址</param>  
        /// <param name="content">Post提交数据内容(utf-8编码的)</param>  
        /// <returns></returns>  
        public static string Post(string url, string content)
        {
            string result = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                #region 添加Post 参数
                byte[] data = Encoding.UTF8.GetBytes(content);
                req.ContentLength = data.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                #endregion
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取响应内容  
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// 生成随机字母与数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string Str(int Length)
        {
            char[] Pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            for (int i = 0; i < Length; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }
        /// <summary> 
        /// 基于Md5的自定义加密字符串方法：输入一个字符串，返回一个由32个字符组成的十六进制的哈希散列（字符串）。
        /// </summary>   
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的十六进制的哈希散列（字符串）</returns>
        public static string Md5(string str)
        {
            var buffer = Encoding.UTF8.GetBytes(str);
            var data = MD5.Create().ComputeHash(buffer);
            var sb = new StringBuilder();
            foreach (var t in data)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Convert Byte[] to Image
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }
        /// <summary>
        /// 将string格式转化为十六进制数据
        /// </summary      
        public static string StringToHexString(string s)
        {
            string hexOutput = string.Empty;
            char[] values = s.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                hexOutput += String.Format("{0:X}", value);
            }
            return hexOutput.ToLower();
        }
        /// <summary>
        /// Convert Image to Byte[]
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ImageToBytes(Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool Login(string userName, string pwd)
        {
            bool isLogin = false;
            try
            {
                if (!ConfigHelper.LoginFromLocal)
                {
                    string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
                    string authCode = CommHelper.Str(6);
                    string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
                    string data = "authCode=" + authCode + "&token=" + token + "&userAccount=" + userName + "&userPwd=" + pwd;
                    string result = CommHelper.Post(url + "/loginAuth.eif?", data);
                    returnUserInfo userInfo = CommHelper.FromJsonTo<returnUserInfo>(result);
                    if (userInfo.resStatus == 1)
                    {
                        if (null != userInfo.userInfo)
                        {
                            GlobalEnvironment.LocalUserInfo = new CR_PARK_EXCHANGE();
                            GlobalEnvironment.LocalUserInfo.ID = Guid.NewGuid().ToString("N");
                            GlobalEnvironment.LocalUserInfo.USER_ID = userInfo.userInfo.id;
                            GlobalEnvironment.LocalUserInfo.USER_ACCOUNT = userInfo.userInfo.userAccount;
                            GlobalEnvironment.LocalUserInfo.USER_NAME = userInfo.userInfo.userName;
                            GlobalEnvironment.LocalUserInfo.LOGIN_TIME = DateTime.Now;
                            GlobalEnvironment.LocalUserInfo.EIXT_TIME = DateTime.Now;
                            GlobalEnvironment.LocalUserInfo.EIXT_NUM = 0;
                            GlobalEnvironment.LocalUserInfo.ENTER_NUM = 0;
                            GlobalEnvironment.LocalUserInfo.DUE_MONEY = 0;
                            GlobalEnvironment.LocalUserInfo.PER_MONEY = 0;
                            GlobalEnvironment.LocalUserInfo.WORK_STATUS = 0;
                            isLogin = true;
                        }
                    }
                }
                else
                {
                    //var temp = EngineContext.Current.Resolve<IBAS_SYSTEM_USER>();
                    //var model = temp.Login(userName, pwd);
                    //if (null != model)
                    //{
                    //    GlobalEnvironment.LocalUserInfo = new CR_PARK_EXCHANGE();
                    //    GlobalEnvironment.LocalUserInfo.ID = model.ID;
                    //    GlobalEnvironment.LocalUserInfo.USER_ACCOUNT = userName;
                    //    GlobalEnvironment.LocalUserInfo.USER_NAME = model.USER_NAME;
                    //    GlobalEnvironment.LocalUserInfo.LOGIN_TIME = DateTime.Now;
                    //    GlobalEnvironment.LocalUserInfo.EIXT_NUM = 0;
                    //    GlobalEnvironment.LocalUserInfo.ENTER_NUM = 0;
                    //    isLogin = true;
                    //}

                    GlobalEnvironment.LocalUserInfo = new CR_PARK_EXCHANGE();
                    GlobalEnvironment.LocalUserInfo.ID = "afdfad";
                    GlobalEnvironment.LocalUserInfo.USER_ACCOUNT = "Admin";
                    GlobalEnvironment.LocalUserInfo.USER_NAME = "Admin";
                    GlobalEnvironment.LocalUserInfo.LOGIN_TIME = DateTime.Now;
                    GlobalEnvironment.LocalUserInfo.EIXT_NUM = 0;
                    GlobalEnvironment.LocalUserInfo.ENTER_NUM = 0;
                    isLogin = true;

                }
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
            return isLogin;
        }
        /// <summary>
        /// 获取节假日信息 
        /// </summary>
        /// <returns></returns>
        public static CalendarInfo GetWorkingDays(string dateTime)
        {
            CalendarInfo calendarInfo = null;
            //获取当前工作站
            string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
            string authCode = CommHelper.Str(6);
            string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
            string data = "authCode=" + authCode + "&token=" + token + "&dateTime=" + dateTime;
            string result = CommHelper.Post(url + "/workingDaysVal.eif?", data);
            WorkingDays workDay = CommHelper.FromJsonTo<WorkingDays>(result);
            if (workDay != null)
            {
                if (workDay.resStatus == 1)
                {
                    calendarInfo = workDay.calendarInfo;
                }
                else
                {
                    LogHelper.Log.Error(workDay.resRemark);
                }
            }
            return calendarInfo;
        }
        /// <summary>
        /// 获取节假日
        /// </summary>
        /// <param name="node"></param>
        /// <param name="recordInfo"></param>
        /// <param name="result"></param>
        public static bool getWorkingDaysVal()
        {
            try
            {
                DateTime dtCurr = DateTime.Now;
                var calendarInfo = CommHelper.GetWorkingDays(dtCurr.ToString("yyyy-MM-dd"));
                if (0 == calendarInfo.dayFlag)
                    return true;
                else
                {
                    if (dtCurr > Convert.ToDateTime(calendarInfo.beginTime) && dtCurr < Convert.ToDateTime(calendarInfo.endTime))
                        return true;
                    else
                        return false;
                }
            }
            catch { return false; }
        }
        public static void WindowsSound(string sound)
        {
            try
            {
                SpeechVoiceSpeakFlags ss = SpeechVoiceSpeakFlags.SVSFlagsAsync;
                SpVoice sp = new SpVoice();
                sp.Voice = sp.GetVoices(String.Empty, String.Empty).Item(0);
                sp.Speak(sound, ss);
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// 车|ì类¤¨¤型¨a
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public static string getCarType(ProcessRecord recordInfo)
        {
            string CardType = string.Empty;
            switch (recordInfo.CARD_TYPE)
            {
                case enumCardType.CAR_TYPE_MONTH:
                    CardType = "月卡车";
                    break;
                case enumCardType.CAR_TYPE_STORED:
                    CardType = "储值车";
                    break;
                case enumCardType.CAR_TYPE_TEMP:
                    CardType = "临时车";
                    break;
                default:
                    CardType = "临时车";
                    break;
            }
            switch (recordInfo.authenticationType)
            {
                case enumAuthenticationType.SPECIAL_TYPE_VIP:
                    CardType = "贵宾车";
                    break;
                case enumAuthenticationType.SPECIAL_TYPE_WHITE:
                    CardType = "白名单";
                    break;
                case enumAuthenticationType.SPECIAL_TYPE_BLACK:
                    CardType = "黑名单";
                    break;
                default:
                    break;
            }
            return CardType;
        }
        /// <summary>
        /// 根¨′据Y特??殊oa名?单ì￡¤类¤¨¤型¨a获?取¨?语??音°?
        /// </summary>
        public static void getSoundByauthentionType(ProcessRecord recordInfo)
        {
            switch (recordInfo.authenticationType)
            {
                case enumAuthenticationType.NORMAL:
                    break;
                case enumAuthenticationType.TempAuthorization:
                    recordInfo.SpeechType = enumSpeechType.TempAuthorizationIn; //临￠¨′时o?à授o¨2权¨?§车|ì入¨?场?
                    break;
                case enumAuthenticationType.SPECIAL_TYPE_VIP:
                    recordInfo.SpeechType = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? enumSpeechType.VIPIn : enumSpeechType.VIPOut; //贵¨?宾à?车|ì入¨?场?
                    break;
                case enumAuthenticationType.SPECIAL_TYPE_BLACK:
                    recordInfo.SpeechType = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? enumSpeechType.BlacklistCarIn : enumSpeechType.BlacklistCarOut;
                    break;
            }
        }
        /// <summary>
        /// 根¨′据Y卡?§类¤¨¤型¨a获?取¨?语??音°?
        /// </summary>
        public static void getSoundByCardType(ProcessRecord recordInfo)
        {
            switch (recordInfo.CARD_TYPE)
            {
                case enumCardType.CAR_TYPE_MONTH:
                    recordInfo.SpeechType = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? enumSpeechType.MonthCardIn : enumSpeechType.MonthCardOut;
                    break;
                case enumCardType.CAR_TYPE_TEMP:
                    recordInfo.SpeechType = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? enumSpeechType.TempCardIn : enumSpeechType.TempCardOut;
                    break;
                case enumCardType.CAR_TYPE_STORED:
                    recordInfo.SpeechType = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? enumSpeechType.StoredIn : enumSpeechType.StoredOut;
                    break;
            }
        }
        /// <summary>
        /// 是否缴纳物业费
        /// </summary>
        /// <returns></returns>
        public static PropertyExpend GetPropertyExpend(string vehicleNo)
        {
            PropertyExpend propertyExpend = null;
            try
            {
                CalendarInfo calendarInfo = new CalendarInfo();
                //获取当前工作站
                string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
                string authCode = CommHelper.Str(6);
                string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
                string data = "authCode=" + authCode + "&token=" + token + "&vehicleNo=" + vehicleNo;
                string result = CommHelper.Post(url + "/propertyExpendQuery.eif?", data);
                propertyExpend = CommHelper.FromJsonTo<PropertyExpend>(result);
            }
            catch { return null; }
            return propertyExpend;
        }
    }
}