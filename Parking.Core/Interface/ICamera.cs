namespace Parking.Core.Interface
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Parking.Core.Record;

    public interface ICamera
    {
        event EventHandler<DataUploadEventArgs> OnPlate;

        void CapturePicture(string Ip, out string strPicName, string textFont = "");
        bool StartRealTimeVideo(PictureBox videoHwnd, string Ip, int port, string userName = "", string Pwd = "");
        void StopRealTimeVideo(string Ip);
    }
}

