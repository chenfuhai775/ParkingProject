using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class returnData
    {
        private int? _resStatus;
        private string _resRemark;
        /// <summary>
        /// 0 失败,1 成功
        /// </summary>
        public int? resStatus { set { _resStatus = value; } get { return _resStatus; } }

        public string resRemark { set { _resRemark = value; } get { return _resRemark; } }
    }
}