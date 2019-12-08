namespace Parking.Drives
{
    using Parking.Core.Interface;
    using Parking.Core.Record;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class ZSCamera : CameraBase, ICamera
    {
        private string IP;
        private static readonly object IsLock = new object();
        private int m_hLPRClient = 0;
        private int m_hSerialHandle = 0;
        private CVzClientSDK.VZLPRC_COMMON_NOTIFY_CALLBACK m_NotifyCB = null;
        private int m_nPlayHandle = 0;
        private CVzClientSDK.VZLPRC_PLATE_INFO_CALLBACK m_PlateResultCB = null;
        private CVzClientSDK.VZDEV_SERIAL_RECV_DATA_CALLBACK m_SerialRecvDataCB = null;

        public event EventHandler<DataUploadEventArgs> OnPlate;

        public ZSCamera()
        {
            CVzClientSDK.VzLPRClient_Setup();
            this.m_PlateResultCB = new CVzClientSDK.VZLPRC_PLATE_INFO_CALLBACK(this.OnPlateResult);
        }

        public void CapturePicture(string Ip, out string strPicName, string textFont = "")
        {
            strPicName = string.Empty;
            base.getCapturePicturePath(Ip, out strPicName);
            CVzClientSDK.VzLPRClient_GetSnapShootToJpeg2(this.m_nPlayHandle, strPicName, 0);
        }

        private void OnNotifyCallBack(int handle, IntPtr pUserData, CVzClientSDK.VZ_LPRC_COMMON_NOTIFY eNotify, string pStrDetail)
        {
        }

        private int OnPlateResult(int handle, IntPtr pUserData, IntPtr pResult, uint uNumPlates, CVzClientSDK.VZ_LPRC_RESULT_TYPE eResultType, IntPtr pImgFull, IntPtr pImgPlateClip)
        {
            DataUploadRecord record = new DataUploadRecord();
            try
            {
                CVzClientSDK.TH_PlateResult result = (CVzClientSDK.TH_PlateResult) Marshal.PtrToStructure(pResult, typeof(CVzClientSDK.TH_PlateResult));
                string str = new string(result.license);
                string str2 = new string(result.color);
                record.PlateColorStr = str2.Substring(0, str2.IndexOf('\0'));
                record.plateNum = str.Substring(0, str.IndexOf('\0'));
                record.picCapTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                record.ip = this.IP;
            }
            catch (Exception)
            {
            }
            finally
            {
                DataUploadEventArgs e = new DataUploadEventArgs {
                    TempRecordInfo = record
                };
                this.OnShapeChanged(e);
            }
            return 0;
        }

        private int OnSerialRecvDataCallback(int handle, StringBuilder pRecvDataBuffer, uint uRecvSize, IntPtr pUserData)
        {
            return 0;
        }

        protected virtual void OnShapeChanged(DataUploadEventArgs e)
        {
            EventHandler<DataUploadEventArgs> onPlate = this.OnPlate;
            if (onPlate != null)
            {
                onPlate(this, e);
            }
        }

        public bool StartRealTimeVideo(PictureBox videoHwnd, string Ip, int Port = 80, string userName = "admin", string Pwd = "admin")
        {
            int num = 0;
            num = this.Video_Connect(Ip, Port, userName, Pwd);
            return (this.Video_StartRealPlay(videoHwnd, Ip) == 0);
        }

        public void StopRealTimeVideo(string Ip)
        {
            CVzClientSDK.VzLPRClient_CloseByIP(Ip);
        }

        public int Video_Connect(string Ip, int Port, string userName, string Pwd)
        {
            try
            {
                this.IP = Ip;
                this.m_NotifyCB = new CVzClientSDK.VZLPRC_COMMON_NOTIFY_CALLBACK(this.OnNotifyCallBack);
                CVzClientSDK.VZLPRClient_SetCommonNotifyCallBack(this.m_NotifyCB, IntPtr.Zero);
                this.m_hLPRClient = CVzClientSDK.VzLPRClient_Open(this.IP, (ushort) Port, userName, Pwd);
                if (this.m_hLPRClient == 0)
                {
                    return 0;
                }
                int bEnableImage = 1;
                CVzClientSDK.VzLPRClient_SetPlateInfoCallBack(this.m_hLPRClient, this.m_PlateResultCB, IntPtr.Zero, bEnableImage);
                this.m_SerialRecvDataCB = new CVzClientSDK.VZDEV_SERIAL_RECV_DATA_CALLBACK(this.OnSerialRecvDataCallback);
                this.m_hSerialHandle = CVzClientSDK.VzLPRClient_SerialStart(this.m_hLPRClient, 0, this.m_SerialRecvDataCB, IntPtr.Zero);
            }
            catch (Exception)
            {
            }
            return 0;
        }

        public int Video_StartRealPlay(PictureBox videoHwnd, string IP)
        {
            if (this.m_hLPRClient > 0)
            {
                this.m_nPlayHandle = CVzClientSDK.VzLPRClient_StartRealPlay(this.m_hLPRClient, videoHwnd.Handle);
            }
            else
            {
                return -1;
            }
            return 0;
        }

        private string _imageSnapPath { get; set; }

        private byte[] bImage { get; set; }
    }
}

