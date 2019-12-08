namespace Parking.Drives
{
    using Parking.Core.Interface;
    using Parking.Core.Record;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public class ZXIICameraManage : ICamera
    {
        private static Dictionary<string, ZXIICamera> dicCamera = new Dictionary<string, ZXIICamera>();

        public event EventHandler<DataUploadEventArgs> OnPlate;

        public void camera_OnPlate(object sender, DataUploadEventArgs e)
        {
            if (null != this.OnPlate)
            {
                this.OnPlate(this, e);
            }
        }

        public void CapturePicture(string Ip, out string strPicName, string textFont = "")
        {
            Func<KeyValuePair<string, ZXIICamera>, bool> predicate = null;
            strPicName = string.Empty;
            if (dicCamera.ContainsKey(Ip))
            {
                if (predicate == null)
                {
                    predicate = x => x.Key == Ip;
                }
                dicCamera.Where<KeyValuePair<string, ZXIICamera>>(predicate).FirstOrDefault<KeyValuePair<string, ZXIICamera>>().Value.CapturePicture(Ip, out strPicName, textFont);
            }
        }

        public bool StartRealTimeVideo(PictureBox videoHwnd, string Ip, int Port, string userName = "admin", string Pwd = "123456")
        {
            Func<KeyValuePair<string, ZXIICamera>, bool> predicate = null;
            bool flag = false;
            if (!dicCamera.ContainsKey(Ip))
            {
                ZXIICamera camera = new ZXIICamera();
                flag = camera.StartRealTimeVideo(videoHwnd, Ip, Port, userName, Pwd);
                dicCamera.Add(Ip, camera);
                camera.OnPlate += new EventHandler<DataUploadEventArgs>(this.camera_OnPlate);
                return flag;
            }
            if (predicate == null)
            {
                predicate = x => x.Key == Ip;
            }
            return dicCamera.Where<KeyValuePair<string, ZXIICamera>>(predicate).FirstOrDefault<KeyValuePair<string, ZXIICamera>>().Value.StartRealTimeVideo(videoHwnd, Ip, Port, userName, Pwd);
        }

        public void StopRealTimeVideo(string Ip)
        {
            Func<KeyValuePair<string, ZXIICamera>, bool> predicate = null;
            if (dicCamera.ContainsKey(Ip))
            {
                if (predicate == null)
                {
                    predicate = x => x.Key == Ip;
                }
                dicCamera.Where<KeyValuePair<string, ZXIICamera>>(predicate).FirstOrDefault<KeyValuePair<string, ZXIICamera>>().Value.StopRealTimeVideo(Ip);
            }
        }
    }
}

