using System;
using System.Text;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using SevenZip;

namespace Parking.Core.Common
{
    public class FileHandler
    {
        /// <summary>  
        /// 文?件t下?载?目?录?  
        /// </summary>  
        private static string _directory = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>  
        /// 下?载?文?件t  
        /// </summary>  
        /// <param name="url">下?载?地ì?址?¤</param>  
        /// <returns>文?件t名?称?</returns>  
        public static string DownloadFile(string url, string versionNum = "")
        {
            try
            {
                string fileName = CreateFileName(url, versionNum);
                if (File.Exists(_directory + fileName))
                    return string.Empty;
                if (!Directory.Exists(_directory))
                {
                    Directory.CreateDirectory(_directory);
                }
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                //为aWebClient类¤¨¤对?象¨?添?¨a加¨?报à?§头a?¤
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Uri mUri = new Uri(GlobalEnvironment.PhotoNetworkUrl + @"/" + url);
                client.DownloadFile(mUri, _directory + fileName);
                Log4Net.LogHelper.Log.Info("下?载?版??本à?" + versionNum + "成¨|功|!");
                return fileName;
            }
            catch (Exception ex)
            {
                Log4Net.LogHelper.Log.Error("下?载?" + versionNum + "失o?ì败?¨1!" + ex.Message);
                return "";
            }
        }

        /// <summary>  
        /// 创???建?§文?件t名?称?  
        /// </summary>  
        public static string CreateFileName(string url, string versionNum = "")
        {
            string fileName = "";
            string fileExt = url.Substring(url.LastIndexOf(".")).Trim().ToLower();
            Random rnd = new Random();
            fileName = string.IsNullOrEmpty(versionNum) ? (DateTime.Now.ToString("yyyyMMddHHmmssfff") + rnd.Next(10, 99).ToString()) : versionNum + fileExt;
            return fileName;
        }

        /// <summary>
        /// 将?目?录?和¨a文?件t压1缩?为arar格?式o?并?é保à?ê存??到ì?指?定?§的ì?目?录?
        /// </summary>
        /// <param name="soruceDir">要°a压1缩?的ì?文?件t夹D目?录?</param>
        /// <param name="rarFileName">压1缩?后¨?的ì?rar保à?ê存??路?¤径?</param>
        public static void CompressRar(string soruceDir, string rarFileName)
        {
            string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regKey);
            string winrarPath = registryKey.GetValue("").ToString();
            registryKey.Close();
            string winrarDir = System.IO.Path.GetDirectoryName(winrarPath);
            String commandOptions = string.Format("a {0} {1} -r", rarFileName, soruceDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = System.IO.Path.Combine(winrarDir, "rar.exe");
            processStartInfo.Arguments = commandOptions;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
            process.Close();
        }

        public static void DeCompressRarBy7z(string rarFileName, string saveDir)
        {
            SevenZipBase.SetLibraryPath(GlobalEnvironment.BasePath + @"/" + "7z.dll");
            var extractor = new SevenZipExtractor(rarFileName);
            extractor.ExtractArchive(saveDir);
        }

        public static void DeCompressRar(string rarFileName, string saveDir)
        {
            string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regKey);
            string winrarPath = registryKey.GetValue("").ToString();
            registryKey.Close();
            string winrarDir = System.IO.Path.GetDirectoryName(winrarPath);
            String commandOptions = string.Format("x {0} {1} -y", rarFileName, saveDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = System.IO.Path.Combine(winrarDir, "rar.exe");
            processStartInfo.Arguments = commandOptions;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
            process.Close();
        }
        public static string ExistsWinRar()
        {
            string result = string.Empty;

            string key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key);
            if (registryKey != null)
            {
                result = registryKey.GetValue("").ToString();
            }
            registryKey.Close();

            return result;
        }
    }
} 
