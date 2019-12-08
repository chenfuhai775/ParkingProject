namespace Parking.Drives
{
    using Parking.Core.ControlEventArgs;
    using System;
    using System.Runtime.CompilerServices;

    public delegate void StateChangedEventHandler(object sender, DeviceStateChangedEventArgs e);
}

