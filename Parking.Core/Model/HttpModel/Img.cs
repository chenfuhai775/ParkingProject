using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    /// <summary>
    /// 出入场图片
    /// </summary>
    public class Img
    {
        private string _imgType;
        private string _imgUrl;
        private string _devid;
        /// <summary>
        /// 图片类型
        /// </summary>
        public string imgType
        {
            set { _imgType = value; }
            get { return _imgType; }
        }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string imgUrl
        {
            set { _imgUrl = value; }
            get { return _imgUrl; }
        }
        /// <summary>
        /// 抓拍设备ID
        /// </summary>
        public string devid
        {
            set { _devid = value; }
            get { return _devid; }
        }
    }
}