using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.WeiXin;
using Parking.Core.Interface;

namespace Parking.WorkBench
{
    public class WeiXinMethod : BasePayMethod, IPayMethod
    {
        public override bool Pay(decimal money, string QRCode)
        {
            if (money > 0)
            {
                string result = MicroPay.Run("微信支付出场", "1", QRCode);
                Dictionary<string, string> dicResult = new Dictionary<string, string>();
                SplitResult(result, ref dicResult);
                if (dicResult.ContainsKey("RESULT_CODE"))
                {
                    if (dicResult["RESULT_CODE"] == "SUCCESS")
                        return true;
                    else
                        return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 分割数据
        /// </summary>
        public void SplitResult(string result, ref Dictionary<string, string> dicResult)
        {

            result = result.Replace("<br>", "|");
            string[] split = result.Split('|');

            foreach (var temp in split)
            {
                if (!string.IsNullOrEmpty(temp) && temp.IndexOf("=") > 0)
                {
                    string[] splitValue = temp.Split('=');
                    dicResult.Add(splitValue[0].ToUpper(), string.IsNullOrEmpty(splitValue[1]) ? "" : splitValue[1].ToUpper());
                }
            }
        }
    }
}