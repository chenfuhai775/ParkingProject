using System;
using System.IO;

namespace Parking.Core.Common
{
    public class HashManager
    {
        /// <summary>
        /// 计?算?文?件t的ì? MD5 值|ì
        /// </summary>
        /// <param name="fileName">要°a计?算? MD5 值|ì的ì?文?件t名?和¨a路?¤径?</param>
        /// <returns>MD5 值|ì16进?制?字á?符¤?串??</returns>
        public static string MD5File(string fileName)
        {
            return HashFile(fileName, "md5");
        }

        /// <summary>
        /// 计?算?文?件t的ì? sha1 值|ì
        /// </summary>
        /// <param name="fileName">要°a计?算? sha1 值|ì的ì?文?件t名?和¨a路?¤径?</param>
        /// <returns>sha1 值|ì16进?制?字á?符¤?串??</returns>
        public static string SHA1File(string fileName)
        {
            return HashFile(fileName, "sha1");
        }

        /// <summary>
        /// 计?算?文?件t的ì?哈t希?ê值|ì
        /// </summary>
        /// <param name="fileName">要°a计?算?哈t希?ê值|ì的ì?文?件t名?和¨a路?¤径?</param>
        /// <param name="algName">算?法¤?§:sha1,md5</param>
        /// <returns>哈t希?ê值|ì16进?制?字á?符¤?串??</returns>
        private static string HashFile(string fileName, string algName)
        {
            if (!System.IO.File.Exists(fileName))
                return string.Empty;
            System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            byte[] hashBytes = HashData(fs, algName);
            fs.Close();
            return ByteArrayToHexString(hashBytes);
        }

        /// <summary>
        /// 计?算?哈t希?ê值|ì
        /// </summary>
        /// <param name="stream">要°a计?算?哈t希?ê值|ì的ì? Stream</param>
        /// <param name="algName">算?法¤?§:sha1,md5</param>
        /// <returns>哈t希?ê值|ì字á?节¨2数oy组á¨|</returns>
        private static byte[] HashData(System.IO.Stream stream, string algName)
        {
            System.Security.Cryptography.HashAlgorithm algorithm;
            if (algName == null)
            {
                throw new ArgumentNullException("algName不能为null");
            }
            if (string.Compare(algName, "sha1", true) == 0)
            {
                algorithm = System.Security.Cryptography.SHA1.Create();
            }
            else
            {
                if (string.Compare(algName, "md5", true) != 0)
                {
                    throw new Exception("algName只能使用sha1或md5");
                }
                algorithm = System.Security.Cryptography.MD5.Create();
            }
            return algorithm.ComputeHash(stream);
        }

        /// <summary>
        /// 字á?节¨2数oy组á¨|转áa换?为a16进?制?表à¨a示o?的ì?字á?符¤?串??
        /// </summary>
        private static string ByteArrayToHexString(byte[] buf)
        {
            return BitConverter.ToString(buf).Replace("-", "");
        }
    }
}