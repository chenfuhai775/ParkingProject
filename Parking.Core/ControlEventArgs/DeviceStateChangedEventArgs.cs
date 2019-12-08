namespace Parking.Core.ControlEventArgs
{
    using System;

    public class DeviceStateChangedEventArgs : EventArgs
    {
        private string iP = string.Empty;
        private int state = 0;

        public DeviceStateChangedEventArgs(int _state, string ip)
        {
            this.state = _state;
            this.iP = ip;
        }

        public string IP
        {
            get
            {
                return this.iP;
            }
            set
            {
                this.iP = value;
            }
        }

        public int State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }
    }
}

