namespace Parking.Core.Interface
{
    using System;
    using Parking.Core.ControlEventArgs;
    using System.Runtime.InteropServices;

    public interface IControlPanel
    {
        event EventHandler<DeviceStateChangedEventArgs> OnDeviceStateChanged;

        bool Initialize(string IP, int Port, string userName = "", string Pwd = "");
        bool OpenGate(string IP, int Port, int[] gateNumber);
        bool Sound(string IP, int Port, string[] msg, int soundSize, int sex = 0, int displayMode = 0, int rowIndex = 1);
    }
}

