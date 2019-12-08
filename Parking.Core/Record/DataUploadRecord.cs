namespace Parking.Core.Record
{
    using System;

    public class DataUploadRecord : ProcessRecord
    {
        private int _carType = 0;
        private byte[] _fullPicData;
        private int _fullPicLen = 0;
        private string _fullpicname = string.Empty;
        private string _ip = string.Empty;
        private string _picCapTime = string.Empty;
        private int _plateColor = 0;
        private string _plateColorStr = string.Empty;
        private float _plateConfidence = 0f;
        private string _plateNum = string.Empty;
        private int _plateType = 0;
        private byte[] _smallPicData;
        private int _smallPicLen = 0;
        private string _specialCode = string.Empty;

        public int carType
        {
            get
            {
                return this._carType;
            }
            set
            {
                this._carType = value;
            }
        }

        public byte[] fullPicData
        {
            get
            {
                return this._fullPicData;
            }
            set
            {
                this._fullPicData = value;
            }
        }

        public int fullPicLen
        {
            get
            {
                return this._fullPicLen;
            }
            set
            {
                this._fullPicLen = value;
            }
        }

        public string fullPicName
        {
            get
            {
                return this._fullpicname;
            }
            set
            {
                this._fullpicname = value;
            }
        }

        public string ip
        {
            get
            {
                return this._ip;
            }
            set
            {
                this._ip = value;
            }
        }

        public string picCapTime
        {
            get
            {
                return this._picCapTime;
            }
            set
            {
                this._picCapTime = value;
            }
        }

        public int PlateColor
        {
            get
            {
                return this._plateColor;
            }
            set
            {
                this._plateColor = value;
            }
        }

        public string PlateColorStr
        {
            get
            {
                return this._plateColorStr;
            }
            set
            {
                this._plateColorStr = value;
            }
        }

        public float plateConfidence
        {
            get
            {
                return this._plateConfidence;
            }
            set
            {
                this._plateConfidence = value;
            }
        }

        public string plateNum
        {
            get
            {
                return this._plateNum;
            }
            set
            {
                this._plateNum = value;
            }
        }

        public int plateType
        {
            get
            {
                return this._plateType;
            }
            set
            {
                this._plateType = value;
            }
        }

        public byte[] smallPicData
        {
            get
            {
                return this._smallPicData;
            }
            set
            {
                this._smallPicData = value;
            }
        }

        public int smallPicLen
        {
            get
            {
                return this._smallPicLen;
            }
            set
            {
                this._smallPicLen = value;
            }
        }

        public string specialCode
        {
            get
            {
                return this._specialCode;
            }
            set
            {
                this._specialCode = value;
            }
        }
    }
}

