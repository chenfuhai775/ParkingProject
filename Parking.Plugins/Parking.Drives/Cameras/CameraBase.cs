namespace Parking.Drives
{
    using Parking.Core;
    using Parking.Core.Common;
    using Parking.Core.Enum;
    using Parking.Core.Oragnization;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class CameraBase
    {
        public void getCapturePicturePath(string strIP, out string strPicName)
        {
            strPicName = string.Empty;
            Equipment equipment = (from x in GlobalEnvironment.CurrWorkStationOragnization
                where x.IP == strIP
                select x).FirstOrDefault<Equipment>();
            List<Equipment> orgInfos = CommHelper.GetOrgInfos(equipment.ORGANIZATION_CODE, false);
            Equipment equipment2 = (from x in orgInfos
                where x.channelType == enumChannelType.wsn
                select x).LastOrDefault<Equipment>();
            Equipment equipment3 = (from x in orgInfos
                where (x.channelType == enumChannelType.chn_in) || (x.channelType == enumChannelType.chn_out)
                select x).LastOrDefault<Equipment>();
            if (null != equipment)
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                string path = string.Concat(new object[] { DateTime.Now.Year, @"\", DateTime.Now.Month, @"\", DateTime.Now.Day, @"\", equipment2.ORGANIZATION_CODE, @"\", equipment3.ORGANIZATION_CODE });
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string str2 = string.Empty;
                if (equipment3.channelType == enumChannelType.chn_in)
                {
                    str2 = "I0";
                }
                else
                {
                    str2 = "E0";
                }
                strPicName = path + @"\" + DateTime.Now.ToString("yyyyMMdd") + str2 + DateTime.Now.ToString("HHmmss");
                strPicName = strPicName + ".jpg";
                if (File.Exists(strPicName))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        strPicName = path + @"\" + DateTime.Now.ToString("yyyyMMdd") + str2 + DateTime.Now.ToString("HHmmss");
                        strPicName = strPicName + "_" + i.ToString() + ".jpg";
                        if (!File.Exists(strPicName))
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void SaveCapturePicture(byte[] picData, string strIP, string textFont, out string strPicName)
        {
            strPicName = string.Empty;
            this.getCapturePicturePath(strIP, out strPicName);
            using (MemoryStream stream = new MemoryStream(picData))
            {
                string filename = GlobalEnvironment.BasePath + @"抓拍\" + strPicName;
                Image image = Image.FromStream(stream);
                int width = image.Width;
                int height = image.Height;
                Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format64bppArgb);
                bitmap.SetResolution(72f, 72f);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.InterpolationMode = InterpolationMode.High;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel);
                Font font = new Font("arial", 20f, FontStyle.Regular);
                StringFormat format = new StringFormat {
                    Alignment = StringAlignment.Near
                };
                SolidBrush brush = new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff, 0));
                if (!string.IsNullOrEmpty(textFont))
                {
                    graphics.DrawString(textFont, font, brush, new PointF(10f, 10f), format);
                }
                bitmap.Save(filename, ImageFormat.Jpeg);
            }
        }
    }
}

