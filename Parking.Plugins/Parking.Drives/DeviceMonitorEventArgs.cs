namespace Parking.Drives
{
    using System;

    public class DeviceMonitorEventArgs : EventArgs
    {
        private string iP;
        private bool isPressed;
        private int state;

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

        public bool IsPressed
        {
            get
            {
                return this.isPressed;
            }
            set
            {
                this.isPressed = value;
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

