namespace Parking.Core.Phone
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Security;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Xml;

    public class SendPhoneMessage
    {
        private string m_appId = null;
        private EBodyType m_bodyType = EBodyType.EType_XML;
        private bool m_isWriteLog = false;
        private string m_mainAccount = null;
        private string m_mainToken = null;
        private string m_restAddress = null;
        private string m_restPort = null;
        private string m_subAccount = null;
        private string m_subToken = null;
        private string m_voipAccount = null;
        private string m_voipPwd = null;
        private const string softVer = "2013-12-26";

        public Dictionary<string, object> BillRecords(string date, string keywords)
        {
            Dictionary<string, object> dictionary6;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (date == null)
            {
                throw new ArgumentNullException("date");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/BillRecords?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("BillRecords url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><BillRecords>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<date>").Append(date).Append("</date>");
                    if (keywords != null)
                    {
                        builder.Append("<keywords>").Append(keywords).Append("</keywords>");
                    }
                    builder.Append("</BillRecords>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"date\":\"").Append(date).Append("\"");
                    if (keywords != null)
                    {
                        builder.Append(",\"keywords\":\"").Append(keywords).Append("\"");
                    }
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("BillRecords requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("BillRecords responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                        dictionary4.Add("statusCode", "0");
                        dictionary4.Add("statusMsg", "成功");
                        dictionary4.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary4;
                        Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else
                                {
                                    dictionary3.Add(node.Name, node.InnerText);
                                }
                            }
                        }
                        else
                        {
                            dictionary2.Clear();
                            dictionary2["resposeBody"] = xml;
                        }
                        if (dictionary3.Count > 0)
                        {
                            dictionary2["data"] = dictionary3;
                        }
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                    dictionary5.Add("statusCode", 0x29fe2);
                    dictionary5.Add("statusMsg", "无返回");
                    dictionary5.Add("data", null);
                    dictionary6 = dictionary5;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary6;
        }

        public bool CertificateValidationResult(object obj, X509Certificate cer, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }

        public Dictionary<string, object> CreateSubAccount(string friendlyName)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (friendlyName == null)
            {
                throw new ArgumentNullException("friendlyName");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/SubAccounts?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("CreateSubAccount url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<friendlyName>").Append(friendlyName).Append("</friendlyName>");
                    builder.Append("</SubAccount>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"friendlyName\":\"").Append(friendlyName).Append("\"");
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("CreateSubAccount requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("CreateSubAccount responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "SubAccount")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        public void enabeLog(bool enable)
        {
            this.m_isWriteLog = enable;
        }

        public static string getDictionaryData(Dictionary<string, object> data)
        {
            string str = null;
            foreach (KeyValuePair<string, object> pair in data)
            {
                if ((pair.Value != null) && (pair.Value.GetType() == typeof(Dictionary<string, object>)))
                {
                    str = str + pair.Key.ToString() + "={";
                    str = str + getDictionaryData((Dictionary<string, object>) pair.Value);
                    str = str + "};";
                }
                else
                {
                    string str3 = str;
                    str = str3 + pair.Key.ToString() + "=" + ((pair.Value == null) ? "null" : pair.Value.ToString()) + ";";
                }
            }
            return str;
        }

        public string GetLogPath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            return (Path.GetDirectoryName(codeBase.Substring(8, codeBase.Length - 8)) + @"\log.txt");
        }

        public Dictionary<string, object> GetSubAccounts(uint startNo, uint offset)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if ((offset < 1) || (offset > 100))
            {
                throw new ArgumentOutOfRangeException("offset超出范围");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/GetSubAccounts?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("GetSubAccounts url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<startNo>").Append(startNo).Append("</startNo>");
                    builder.Append("<offset>").Append(offset).Append("</offset>");
                    builder.Append("</SubAccount>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"startNo\":\"").Append(startNo).Append("\"");
                    builder.Append(",\"offset\":\"").Append(offset).Append("\"");
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("GetSubAccounts requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("GetSubAccounts responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                        List<object> list = new List<object>();
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "totalCount")
                                {
                                    dictionary3.Add(node.Name, node.InnerText);
                                }
                                else if (node.Name == "SubAccount")
                                {
                                    Dictionary<string, object> item = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        item.Add(node2.Name, node2.InnerText);
                                    }
                                    list.Add(item);
                                }
                            }
                        }
                        else
                        {
                            dictionary2.Clear();
                            dictionary2["resposeBody"] = xml;
                        }
                        if (dictionary3.Count > 0)
                        {
                            if (list.Count > 0)
                            {
                                dictionary3.Add("SubAccount", list);
                            }
                            dictionary2["data"] = dictionary3;
                        }
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        public bool init(string restAddress, string restPort)
        {
            this.m_restAddress = restAddress;
            this.m_restPort = restPort;
            if ((((this.m_restAddress == null) || (this.m_restAddress.Length < 0)) || ((this.m_restPort == null) || (this.m_restPort.Length < 0))) || (Convert.ToInt32(this.m_restPort) < 0))
            {
                return false;
            }
            return true;
        }

        public Dictionary<string, object> IvrDial(string number, string userdata, string record)
        {
            Dictionary<string, object> dictionary5;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (number == null)
            {
                throw new ArgumentNullException("number");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/ivr/dial?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("IvrDial url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                request.Accept = "application/xml";
                request.ContentType = "application/xml;charset=utf-8";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                builder.Append("<?xml version='1.0' encoding='utf-8'?><Request>");
                builder.Append("<Appid>").Append(this.m_appId).Append("</Appid>");
                builder.Append("<Dial ");
                builder.Append("number=\"" + number + "\"");
                if (userdata != null)
                {
                    builder.Append(" userdata=\"" + userdata + "\"");
                }
                if ((record != null) && (record == "true"))
                {
                    builder.Append(" record=\"true\"");
                }
                builder.Append("></Dial>");
                builder.Append("</Request>");
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("IvrDial requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("IvrDial responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                        dictionary3.Add("statusCode", "0");
                        dictionary3.Add("statusMsg", "成功");
                        dictionary3.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary3;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                    dictionary4.Add("statusCode", 0x29fe2);
                    dictionary4.Add("statusMsg", "无返回");
                    dictionary4.Add("data", null);
                    dictionary5 = dictionary4;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary5;
        }

        public Dictionary<string, object> LandingCall(string to, string mediaName, string mediaTxt, string displayNum, string playTimes, int type, string respUrl)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (to == null)
            {
                throw new ArgumentNullException("to");
            }
            if ((mediaName == null) && (mediaTxt == null))
            {
                throw new ArgumentNullException("mediaName和mediaTxt同时为null");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/Calls/LandingCalls?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("LandingCall url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><LandingCall>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<to>").Append(to).Append("</to>");
                    if (mediaName != null)
                    {
                        builder.Append("<mediaName type=\"" + type + "\">").Append(mediaName).Append("</mediaName>");
                    }
                    if (mediaTxt != null)
                    {
                        builder.Append("<mediaTxt>").Append(mediaTxt).Append("</mediaTxt>");
                    }
                    if (displayNum != null)
                    {
                        builder.Append("<displayNum>").Append(displayNum).Append("</displayNum>");
                    }
                    if (playTimes != null)
                    {
                        builder.Append("<playTimes>").Append(playTimes).Append("</playTimes>");
                    }
                    if (respUrl != null)
                    {
                        builder.Append("<respUrl>").Append(respUrl).Append("</respUrl>");
                    }
                    builder.Append("</LandingCall>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"to\":\"").Append(to).Append("\"");
                    builder.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
                    if (mediaName != null)
                    {
                        builder.Append(",\"mediaName\":\"").Append(mediaName).Append("\"");
                        builder.Append(",\"mediaNameType\":\"").Append(type).Append("\"");
                    }
                    if (mediaTxt != null)
                    {
                        builder.Append(",\"mediaTxt\":\"").Append(mediaTxt).Append("\"");
                    }
                    if (displayNum != null)
                    {
                        builder.Append(",\"displayNum\":\"").Append(displayNum).Append("\"");
                    }
                    if (playTimes != null)
                    {
                        builder.Append(",\"playTimes\":\"").Append(playTimes).Append("\"");
                    }
                    if (respUrl != null)
                    {
                        builder.Append(",\"respUrl\":\"").Append(respUrl).Append("\"");
                    }
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("LandingCall requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("LandingCall responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "LandingCall")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        public static string MD5Encrypt(string source)
        {
            byte[] buffer = MD5.Create().ComputeHash(Encoding.Default.GetBytes(source));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString("X2"));
            }
            return builder.ToString();
        }

        private Dictionary<string, object> paramCheckAppId()
        {
            if (this.m_appId == null)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("statusCode", 0x29fec);
                dictionary.Add("statusMsg", "应用ID为空");
                dictionary.Add("data", null);
                return dictionary;
            }
            return null;
        }

        private Dictionary<string, object> paramCheckMainAccount()
        {
            int num = 0;
            string str = null;
            if (this.m_mainAccount == null)
            {
                num = 0x29fe6;
                str = "主帐号空";
            }
            else if (this.m_mainToken == null)
            {
                num = 0x29fe7;
                str = "主帐号令牌空";
            }
            if (num != 0)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("statusCode", num);
                dictionary.Add("statusMsg", str);
                dictionary.Add("data", null);
                return dictionary;
            }
            return null;
        }

        private Dictionary<string, object> paramCheckRest()
        {
            int num = 0;
            string str = null;
            if (this.m_restAddress == null)
            {
                num = 0x29fe4;
                str = "IP空";
            }
            else if (this.m_restPort == null)
            {
                num = 0x29fe5;
                str = "端口错误";
            }
            if (num != 0)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("statusCode", num);
                dictionary.Add("statusMsg", str);
                dictionary.Add("data", null);
                return dictionary;
            }
            return null;
        }

        private Dictionary<string, object> paramCheckSunAccount()
        {
            int num = 0;
            string str = null;
            if (this.m_subAccount == null)
            {
                num = 0x29fe8;
                str = "子帐号空";
            }
            else if (this.m_subToken == null)
            {
                num = 0x29fe9;
                str = "子帐号令牌空";
            }
            else if (this.m_voipAccount == null)
            {
                num = 0x1a3eca;
                str = "VoIP帐号空";
            }
            else if (this.m_voipPwd == null)
            {
                num = 0x29feb;
                str = "VoIP密码空";
            }
            if (num != 0)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("statusCode", num);
                dictionary.Add("statusMsg", str);
                dictionary.Add("data", null);
                return dictionary;
            }
            return null;
        }

        public Dictionary<string, object> QueryAccountInfo()
        {
            Dictionary<string, object> dictionary8;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            try
            {
                HttpWebResponse response;
                string str5;
                Dictionary<string, object> dictionary2;
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/AccountInfo?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("QueryAccountInfo url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "GET";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    using (response = request.GetResponse() as HttpWebResponse)
                    {
                        str5 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        this.WriteLog("QueryAccountInfo responseBody = " + str5);
                        if ((str5 != null) && (str5.Length > 0))
                        {
                            Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                            dictionary5.Add("statusCode", "0");
                            dictionary5.Add("statusMsg", "成功");
                            dictionary5.Add("data", null);
                            dictionary2 = dictionary5;
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(str5);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "Account")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                        dictionary6.Add("statusCode", 0x29fe2);
                        dictionary6.Add("statusMsg", "无返回");
                        dictionary6.Add("data", null);
                        return dictionary6;
                    }
                }
                request.Accept = "application/json";
                request.ContentType = "application/json;charset=utf-8";
                using (response = request.GetResponse() as HttpWebResponse)
                {
                    str5 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("QueryAccountInfo responseBody = " + str5);
                    if ((str5 != null) && (str5.Length > 0))
                    {
                        dictionary2 = new Dictionary<string, object>();
                        dictionary2["resposeBody"] = str5;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary7 = new Dictionary<string, object>();
                    dictionary7.Add("statusCode", 0x29fe2);
                    dictionary7.Add("statusMsg", "无返回");
                    dictionary7.Add("data", null);
                    dictionary8 = dictionary7;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary8;
        }

        public Dictionary<string, object> QuerySubAccount(string friendlyName)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (friendlyName == null)
            {
                throw new ArgumentNullException("friendlyName");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/QuerySubAccountByName?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("QuerySubAccount url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><SubAccount>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<friendlyName>").Append(friendlyName).Append("</friendlyName>");
                    builder.Append("</SubAccount>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"friendlyName\":\"").Append(friendlyName).Append("\"");
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("QuerySubAccount requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("QuerySubAccount responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "SubAccount")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        public Dictionary<string, object> SendTemplateSMS(string to, string templateId, string[] data)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (to == null)
            {
                throw new ArgumentNullException("to");
            }
            if (templateId == null)
            {
                throw new ArgumentNullException("templateId");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/SMS/TemplateSMS?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("SendTemplateSMS url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><TemplateSMS>");
                    builder.Append("<to>").Append(to).Append("</to>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<templateId>").Append(templateId).Append("</templateId>");
                    if ((data != null) && (data.Length > 0))
                    {
                        builder.Append("<datas>");
                        foreach (string str5 in data)
                        {
                            builder.Append("<data>").Append(str5).Append("</data>");
                        }
                        builder.Append("</datas>");
                    }
                    builder.Append("</TemplateSMS>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"to\":\"").Append(to).Append("\"");
                    builder.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"templateId\":\"").Append(templateId).Append("\"");
                    if ((data != null) && (data.Length > 0))
                    {
                        builder.Append(",\"datas\":[");
                        int num = 0;
                        foreach (string str5 in data)
                        {
                            if (num == 0)
                            {
                                builder.Append("\"" + str5 + "\"");
                            }
                            else
                            {
                                builder.Append(",\"" + str5 + "\"");
                            }
                            num++;
                        }
                        builder.Append("]");
                    }
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("SendTemplateSMS requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("SendTemplateSMS responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "TemplateSMS")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        public void setAccount(string accountSid, string accountToken)
        {
            this.m_mainAccount = accountSid;
            this.m_mainToken = accountToken;
        }

        public void setAppId(string appId)
        {
            this.m_appId = appId;
        }

        public void setCertificateValidationCallBack()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CertificateValidationResult);
        }

        public void setSubAccount(string subAccountSid, string subAccountToken, string voipAccount, string voipPassword)
        {
            this.m_subAccount = subAccountSid;
            this.m_subToken = subAccountToken;
            this.m_voipAccount = voipAccount;
            this.m_voipPwd = voipPassword;
        }

        public Dictionary<string, object> VoiceVerify(string to, string verifyCode, string displayNum, string playTimes, string respUrl)
        {
            Dictionary<string, object> dictionary7;
            Dictionary<string, object> dictionary = this.paramCheckRest();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckMainAccount();
            if (dictionary != null)
            {
                return dictionary;
            }
            dictionary = this.paramCheckAppId();
            if (dictionary != null)
            {
                return dictionary;
            }
            if (to == null)
            {
                throw new ArgumentNullException("to");
            }
            if (verifyCode == null)
            {
                throw new ArgumentNullException("verifyCode");
            }
            try
            {
                string str = DateTime.Now.ToString("yyyyMMddhhmmss");
                string str2 = MD5Encrypt(this.m_mainAccount + this.m_mainToken + str);
                string uriString = string.Format("https://{0}:{1}/{2}/Accounts/{3}/Calls/VoiceVerify?sig={4}", new object[] { this.m_restAddress, this.m_restPort, "2013-12-26", this.m_mainAccount, str2 });
                Uri requestUri = new Uri(uriString);
                this.WriteLog("VoiceVerify url = " + uriString);
                HttpWebRequest request = WebRequest.Create(requestUri) as HttpWebRequest;
                this.setCertificateValidationCallBack();
                request.Method = "POST";
                string str4 = Convert.ToBase64String(Encoding.GetEncoding("utf-8").GetBytes(this.m_mainAccount + ":" + str));
                request.Headers.Add("Authorization", str4);
                StringBuilder builder = new StringBuilder();
                if (this.m_bodyType == EBodyType.EType_XML)
                {
                    request.Accept = "application/xml";
                    request.ContentType = "application/xml;charset=utf-8";
                    builder.Append("<?xml version='1.0' encoding='utf-8'?><VoiceVerify>");
                    builder.Append("<appId>").Append(this.m_appId).Append("</appId>");
                    builder.Append("<verifyCode>").Append(verifyCode).Append("</verifyCode>");
                    builder.Append("<to>").Append(to).Append("</to>");
                    if (displayNum != null)
                    {
                        builder.Append("<displayNum>").Append(displayNum).Append("</displayNum>");
                    }
                    if (playTimes != null)
                    {
                        builder.Append("<playTimes>").Append(playTimes).Append("</playTimes>");
                    }
                    if (respUrl != null)
                    {
                        builder.Append("<respUrl>").Append(respUrl).Append("</respUrl>");
                    }
                    builder.Append("</VoiceVerify>");
                }
                else
                {
                    request.Accept = "application/json";
                    request.ContentType = "application/json;charset=utf-8";
                    builder.Append("{");
                    builder.Append("\"to\":\"").Append(to).Append("\"");
                    builder.Append(",\"appId\":\"").Append(this.m_appId).Append("\"");
                    builder.Append(",\"verifyCode\":\"").Append(verifyCode).Append("\"");
                    if (displayNum != null)
                    {
                        builder.Append(",\"displayNum\":\"").Append(displayNum).Append("\"");
                    }
                    if (playTimes != null)
                    {
                        builder.Append(",\"playTimes\":\"").Append(playTimes).Append("\"");
                    }
                    if (respUrl != null)
                    {
                        builder.Append(",\"respUrl\":\"").Append(respUrl).Append("\"");
                    }
                    builder.Append("}");
                }
                byte[] bytes = Encoding.UTF8.GetBytes(builder.ToString());
                this.WriteLog("VoiceVerify requestBody = " + builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    this.WriteLog("VoiceVerify responseBody = " + xml);
                    if ((xml != null) && (xml.Length > 0))
                    {
                        Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
                        dictionary5.Add("statusCode", "0");
                        dictionary5.Add("statusMsg", "成功");
                        dictionary5.Add("data", null);
                        Dictionary<string, object> dictionary2 = dictionary5;
                        if (this.m_bodyType == EBodyType.EType_XML)
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(xml);
                            XmlNodeList childNodes = document.SelectSingleNode("Response").ChildNodes;
                            foreach (XmlNode node in childNodes)
                            {
                                if (node.Name == "statusCode")
                                {
                                    dictionary2["statusCode"] = node.InnerText;
                                }
                                else if (node.Name == "statusMsg")
                                {
                                    dictionary2["statusMsg"] = node.InnerText;
                                }
                                else if (node.Name == "VoiceVerify")
                                {
                                    Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
                                    foreach (XmlNode node2 in node.ChildNodes)
                                    {
                                        dictionary3.Add(node2.Name, node2.InnerText);
                                    }
                                    Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
                                    dictionary4.Add(node.Name, dictionary3);
                                    dictionary2["data"] = dictionary4;
                                }
                            }
                            return dictionary2;
                        }
                        dictionary2.Clear();
                        dictionary2["resposeBody"] = xml;
                        return dictionary2;
                    }
                    Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
                    dictionary6.Add("statusCode", 0x29fe2);
                    dictionary6.Add("statusMsg", "无返回");
                    dictionary6.Add("data", null);
                    dictionary7 = dictionary6;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dictionary7;
        }

        private void WriteLog(string log)
        {
            if (this.m_isWriteLog)
            {
                FileStream stream = new FileStream(this.GetLogPath(), FileMode.Append);
                StreamWriter writer = new StreamWriter(stream, Encoding.Default);
                writer.WriteLine(DateTime.Now.ToString() + "\t" + log);
                writer.Close();
                stream.Close();
            }
        }
    }
}

