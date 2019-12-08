using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    /// <summary>
    /// 将需要生成CODE的规则添加在这里
    /// </summary>
    [Serializable]
    public class INRECORDALL
    {

        private string _imgContent;
        private string _imgUrl;
        private INRECORD _inreord;
        public string imgContent { set { _imgContent = value; } get { return _imgContent; } }
        public string imgUrl { set { _imgUrl = value; } get { return _imgUrl; } }
        public INRECORD inreord { set { _inreord = value; } get { return _inreord; } }
        public class INRECORD
        {
            private string _id;
            private string _uniqueIdentifier;
            private string _vehicleNo;
            private string _carColor;
            private int _credentialsType;
            private string _inFieldCode;
            private string _inChannelCode;
            private string _inTime;
            private string _inOperatorId;
            private string _inPartitionCode;
            private string _inEqId;
            private string _inDevId;
            private string _inParkType;
            private decimal _inImgTrust;
            private string _inLedInfo;
            private object _inImg;
            /// <summary>
            /// ID主键
            /// </summary>
            public string id
            {
                set { _id = value; }
                get { return _id; }
            }
            /// <summary>
            /// 通行证唯一标识
            /// </summary>
            public string uniqueIdentifier
            {
                set { _uniqueIdentifier = value; }
                get { return _uniqueIdentifier; }
            }
            /// <summary>
            /// 车牌号
            /// </summary>
            public string vehicleNo
            {
                set { _vehicleNo = value; }
                get { return _vehicleNo; }
            }
            /// <summary>
            /// 车牌颜色
            /// </summary>
            public string carColor
            {
                set { _carColor = value; }
                get { return _carColor; }
            }
            /// <summary>
            /// 凭证类型
            /// </summary>
            public int credentialsType
            {
                set { _credentialsType = value; }
                get { return _credentialsType; }
            }
            /// <summary>
            /// 入场工作站
            /// </summary>
            public string inFieldCode
            {
                set { _inFieldCode = value; }
                get { return _inFieldCode; }
            }
            /// <summary>
            /// 入场通道
            /// </summary>
            public string inChannelCode
            {
                set { _inChannelCode = value; }
                get { return _inChannelCode; }
            }
            /// <summary>
            /// 入场时间
            /// </summary>
            public string inTime
            {
                set { _inTime = value; }
                get { return _inTime; }
            }
            /// <summary>
            /// 入场工作人员ID
            /// </summary>
            public string inOperatorId
            {
                set { _inOperatorId = value; }
                get { return _inOperatorId; }
            }
            /// <summary>
            /// 入场分区编号
            /// </summary>
            public string inPartitionCode
            {
                set { _inPartitionCode = value; }
                get { return _inPartitionCode; }
            }
            /// <summary>
            /// 入口手持设备
            /// </summary>
            public string inEqId
            {
                set { _inEqId = value; }
                get { return _inEqId; }
            }
            /// <summary>
            /// 入口设备ID
            /// </summary>
            public string inDevId
            {
                set { _inDevId = value; }
                get { return _inDevId; }
            }
            /// <summary>
            /// 入场方式
            /// </summary>
            public string inParkType
            {
                set { _inParkType = value; }
                get { return _inParkType; }
            }
            /// <summary>
            /// 入场图片可信度
            /// </summary>
            public decimal inImgTrust
            {
                set { _inImgTrust = value; }
                get { return _inImgTrust; }
            }
            /// <summary>
            /// 入场LED显示
            /// </summary>
            public string inLedInfo
            {
                set { _inLedInfo = value; }
                get { return _inLedInfo; }
            }
            public object inImg
            {
                set { _inImg = value; }
                get { return _inImg; }
            }
        }
    }
}