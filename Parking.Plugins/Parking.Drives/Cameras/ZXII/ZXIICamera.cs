namespace Parking.Drives
{
    using Parking.Core;
    using Parking.Core.Common;
    using Parking.Core.Interface;
    using Parking.Core.Record;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class ZXIICamera : CameraBase, ICamera
    {
        private bool[] bClose = new bool[4];
        private static readonly object IsLock = new object();
        private DateTime LastUpLoad = DateTime.MinValue;
        private bool m_bExit = false;
        private ipcsdk.ICE_IPCSDK_OnPlate onPlate;
        private static Dictionary<string, int> PlateColor;
        public UpdatePlateInfo updatePlateInfo;
        public ICE_VBR_RESULT_S vbrResult = new ICE_VBR_RESULT_S();
        public ICE_VDC_PICTRUE_INFO_S vdcInfo = new ICE_VDC_PICTRUE_INFO_S();

        public event EventHandler<DataUploadEventArgs> OnPlate;

        public ZXIICamera()
        {
            ipcsdk.ICE_IPCSDK_Init();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("蓝色", 1);
            dictionary.Add("黑色", 2);
            dictionary.Add("黄色", 3);
            dictionary.Add("白色", 4);
            dictionary.Add("其他颜色类型", 5);
            PlateColor = dictionary;
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
            dictionary2.Add("京", 1);
            dictionary2.Add("沪", 2);
            dictionary2.Add("津", 3);
            dictionary2.Add("渝", 4);
            dictionary2.Add("黑", 5);
            dictionary2.Add("吉", 6);
            dictionary2.Add("辽", 7);
            dictionary2.Add("蒙", 8);
            dictionary2.Add("冀", 9);
            dictionary2.Add("鲁", 10);
            dictionary2.Add("晋", 11);
            dictionary2.Add("皖", 12);
            dictionary2.Add("苏", 13);
            dictionary2.Add("浙", 14);
            dictionary2.Add("闽", 15);
            dictionary2.Add("粤", 0x10);
            dictionary2.Add("豫", 0x11);
            dictionary2.Add("赣", 0x12);
            dictionary2.Add("湘", 0x13);
            dictionary2.Add("鄂", 20);
            dictionary2.Add("桂", 0x15);
            dictionary2.Add("琼", 0x16);
            dictionary2.Add("云", 0x17);
            dictionary2.Add("贵", 0x18);
            dictionary2.Add("川", 0x19);
            dictionary2.Add("陕", 0x1a);
            dictionary2.Add("甘", 0x1b);
            dictionary2.Add("宁", 0x1c);
            dictionary2.Add("青", 0x1d);
            dictionary2.Add("藏", 30);
            dictionary2.Add("新", 0x1f);
        }

        public void CapturePicture(string Ip, out string strPicName, string textFont = "")
        {
            strPicName = string.Empty;
            if (this.CameraObject != IntPtr.Zero)
            {
                uint num = 0;
                byte[] pcPicData = new byte[0x100000];
                uint num2 = ipcsdk.ICE_IPCSDK_Capture(this.CameraObject, pcPicData, 0x100000, ref num);
                if ((1 == num2) && (num > 0))
                {
                    if (num > 0)
                    {
                        byte[] destinationArray = new byte[num];
                        Array.Copy(pcPicData, 0, destinationArray, 0, destinationArray.Length);
                        this.storePic(destinationArray, textFont, Ip, "", false, 0, null, "", out strPicName);
                    }
                    if ((Ip + "进行了只抓拍不识别的操作") == null)
                    {
                        return;
                    }
                }
                pcPicData = null;
            }
        }

        private string getFeatureCode(float[] info)
        {
            string str = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                if (i != 0)
                {
                    str = str + " ";
                }
                str = str + info[i].ToString("0.000000");
            }
            return str;
        }

        protected virtual void OnShapeChanged(DataUploadEventArgs e)
        {
            EventHandler<DataUploadEventArgs> onPlate = this.OnPlate;
            if (onPlate != null)
            {
                onPlate(this, e);
            }
        }

        public void SDK_OnPlate(IntPtr pvParam, [In, MarshalAs(UnmanagedType.LPStr)] string pcIP, [In, MarshalAs(UnmanagedType.LPStr)] string pcNumber, [In, MarshalAs(UnmanagedType.LPStr)] string pcColor, IntPtr pcPicData, uint u32PicLen, IntPtr pcCloseUpPicData, uint u32CloseUpPicLen, short s16PlatePosLeft, short s16PlatePosTop, short s16PlatePosRight, short s16PlatePosBottom, float fPlateConfidence, uint u32VehicleColor, uint u32PlateType, uint u32VehicleDir, uint u32AlarmType, uint u32SerialNum, uint u32Reserved2, uint u32Reserved3, uint u32Reserved4)
        {
            DataUploadRecord record = new DataUploadRecord();
            try
            {
                ulong num = u32Reserved3 + u32Reserved4;
                IntPtr ptr = (IntPtr) num;
                if (ptr != IntPtr.Zero)
                {
                    this.vdcInfo = (ICE_VDC_PICTRUE_INFO_S) Marshal.PtrToStructure(ptr, typeof(ICE_VDC_PICTRUE_INFO_S));
                    if (this.vdcInfo.pstVbrResult != IntPtr.Zero)
                    {
                        this.vbrResult = (ICE_VBR_RESULT_S) Marshal.PtrToStructure(this.vdcInfo.pstVbrResult, typeof(ICE_VBR_RESULT_S));
                    }
                    record.ip = pcIP;
                    record.plateNum = pcNumber;
                    if (PlateColor.ContainsKey(pcColor))
                    {
                        record.PlateColor = PlateColor[pcColor];
                    }
                    IntPtr source = pcPicData;
                    byte[] destination = new byte[u32PicLen];
                    Marshal.Copy(source, destination, 0, destination.Length);
                    record.fullPicData = destination;
                    record.fullPicLen = (int) u32PicLen;
                    IntPtr ptr3 = pcPicData;
                    byte[] buffer2 = new byte[u32PicLen];
                    Marshal.Copy(ptr3, buffer2, 0, buffer2.Length);
                    record.smallPicData = buffer2;
                    record.smallPicLen = (int) u32CloseUpPicLen;
                    record.picCapTime = DateTime.Now.ToString();
                    record.plateConfidence = fPlateConfidence;
                    record.plateType = (int) u32PlateType;
                    if ((this.vbrResult.fResFeature != null) && (this.vbrResult.fResFeature.Length > 0))
                    {
                        record.specialCode = this.getFeatureCode(this.vbrResult.fResFeature);
                    }
                    record.carType = (int) u32VehicleColor;
                    int num2 = (int) pvParam;
                    string strPicName = string.Empty;
                    lock (IsLock)
                    {
                        if (u32PicLen > 0)
                        {
                            IntPtr ptr4 = pcPicData;
                            byte[] buffer3 = new byte[u32PicLen];
                            Marshal.Copy(ptr4, buffer3, 0, buffer3.Length);
                            this.storePic(buffer3, "", pcIP, "", false, 0, null, "", out strPicName);
                        }
                    }
                    record.fullPicName = strPicName;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                float num3 = ((record.plateConfidence - 10f) / 18f) * 100f;
                if ((num3 > ConfigHelper.RecognitionRate) && (this.LastUpLoad.AddSeconds(3.0) <= DateTime.Now))
                {
                    this.LastUpLoad = DateTime.Now;
                    DataUploadEventArgs e = new DataUploadEventArgs {
                        TempRecordInfo = record
                    };
                    this.OnShapeChanged(e);
                }
            }
        }

        public bool StartRealTimeVideo(PictureBox videoHwnd, string Ip, int Port, string userName = "admin", string Pwd = "123456")
        {
            this.onPlate = new ipcsdk.ICE_IPCSDK_OnPlate(this.SDK_OnPlate);
            IntPtr hSDK = ipcsdk.ICE_IPCSDK_OpenPreview_Passwd(Ip, Pwd, 1, 1, (uint) ((int) videoHwnd.Handle), this.onPlate, new IntPtr(0));
            ipcsdk.ICE_IPCSDK_SetPlateCallback(hSDK, this.onPlate, new IntPtr(0));
            this.CameraObject = hSDK;
            return (((int) hSDK) > 0);
        }

        public void StopRealTimeVideo(string Ip)
        {
            try
            {
                ipcsdk.ICE_IPCSDK_EndTalk(this.CameraObject);
                ipcsdk.ICE_IPCSDK_StopRecord(this.CameraObject);
                ipcsdk.ICE_IPCSDK_Close(this.CameraObject);
            }
            catch
            {
            }
        }

        private void storePic(byte[] picData, string textFont, string strIP, string strNumber, bool bIsPlate, uint nCapTime, float[] fResFuture, string strLogName, out string strPicName)
        {
            strPicName = string.Empty;
            base.getCapturePicturePath(strIP, out strPicName);
            try
            {
                using (MemoryStream stream = new MemoryStream(picData))
                {
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
                    bitmap.Save(strPicName, ImageFormat.Jpeg);
                }
            }
            catch (Exception)
            {
            }
            if (!bIsPlate && (null != fResFuture))
            {
                string path = GlobalEnvironment.BasePath + @"\vbr_record.txt";
                string str2 = "";
                for (int i = 0; i < 20; i++)
                {
                    if (i != 0)
                    {
                        str2 = str2 + " ";
                    }
                    str2 = str2 + fResFuture[i].ToString("0.000000");
                }
                try
                {
                    StreamWriter writer = new StreamWriter(path, true, Encoding.Unicode);
                    if (null != writer)
                    {
                        str2 = strPicName;
                        writer.Write(str2);
                        writer.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private IntPtr CameraObject { get; set; }

        public delegate void UpdatePlateInfo(string strIP, string strNum, string strColor, uint nVehicleColor, uint nAlarmType, short nVehiclType, uint nCapTime, int index, string strLogName);
    }
}

