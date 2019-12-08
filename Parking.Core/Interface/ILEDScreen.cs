namespace Parking.Core.Interface
{
    using System;
    using System.Runtime.InteropServices;

    public interface ILEDScreen
    {
        bool ShowLedScreen(string IP, int Port, string[] msg, int displayMode = 0, int rowIndex = 1, int fontColor = 1);
    }
}

