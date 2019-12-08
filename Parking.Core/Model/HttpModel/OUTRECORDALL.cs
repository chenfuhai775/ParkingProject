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
    public partial class OUTRECORDALL
    {

        private string _imgContent;
        private string _imgUrl;
        private OUTRECORD _outrecord;
        public string imgContent { set { _imgContent = value; } get { return _imgContent; } }
        public string imgUrl { set { _imgUrl = value; } get { return _imgUrl; } }
        public OUTRECORD outrecord { set { _outrecord = value; } get { return _outrecord; } }
        public class OUTRECORD
        {
            private string _id;
            private string _uniqueIdentifier;
            private string _vehicleNo;
            private string _carColor;
            private int? _credentialsType;
            private string _inFieldCode;
            private string _inChannelCode;
            private string _inTime;
            private string _inOperatorId;
            private string _inPartitionCode;
            private string _inEqId;
            private string _inDevId;
            private string _inParkType;
            private decimal? _inImgTrust;
            private string _inLedInfo;
            private string _outFieldCode;
            private string _outChannelCode;
            private string _outTime;
            private string _outOperatorId;
            private string _outPartitionCode;
            private string _outEqId;
            private string _outDevId;
            private string _outParkType;
            private decimal _outImgTrust;
            private string _outLedInfo;
            private decimal _chargeMoney;
            private decimal _dueMoney;
            private decimal _preMoney;
            private decimal? _overtimesfje;
            private decimal? _advanceMoney;
            private int? _payMethod;
            private int? _payPlatform;
            private object _outImg;
            /// <summary>
            ///  ID主键
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
            public int? credentialsType
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
            public decimal? inImgTrust
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
            /// <summary>
            /// 出场工作站
            /// </summary>
            public string outFieldCode
            {
                set { _outFieldCode = value; }
                get { return _outFieldCode; }
            }
            /// <summary>
            /// 出场通道
            /// </summary>
            public string outChannelCode
            {
                set { _outChannelCode = value; }
                get { return _outChannelCode; }
            }
            /// <summary>
            /// 出场时间
            /// </summary>
            public string outTime
            {
                set { _outTime = value; }
                get { return _outTime; }
            }
            /// <summary>
            /// 出场工作人员ID
            /// </summary>
            public string outOperatorId
            {
                set { _outOperatorId = value; }
                get { return _outOperatorId; }
            }
            /// <summary>
            /// 出场分区编号
            /// </summary>
            public string outPartitionCode
            {
                set { _outPartitionCode = value; }
                get { return _outPartitionCode; }
            }
            /// <summary>
            /// 出口手持设备
            /// </summary>
            public string outEqId
            {
                set { _outEqId = value; }
                get { return _outEqId; }
            }
            /// <summary>
            /// 出口设备ID
            /// </summary>
            public string outDevId
            {
                set { _outDevId = value; }
                get { return _outDevId; }
            }
            /// <summary>
            /// 出场方式
            /// </summary>
            public string outParkType
            {
                set { _outParkType = value; }
                get { return _outParkType; }
            }
            /// <summary>
            /// 出场图片可信度
            /// </summary>
            public decimal outImgTrust
            {
                set { _outImgTrust = value; }
                get { return _outImgTrust; }
            }
            /// <summary>
            /// 出场LED显示
            /// </summary>
            public string outLedInfo
            {
                set { _outLedInfo = value; }
                get { return _outLedInfo; }
            }
            /// <summary>
            /// 收费金额
            /// </summary>
            public decimal chargeMoney
            {
                set { _chargeMoney = value; }
                get { return _chargeMoney; }
            }
            /// <summary>
            /// 应收金额
            /// </summary>
            public decimal dueMoney
            {
                set { _dueMoney = value; }
                get { return _dueMoney; }
            }
            /// <summary>
            /// 优惠金额
            /// </summary>
            public decimal preMoney
            {
                set { _preMoney = value; }
                get { return _preMoney; }
            }
            /// <summary>
            /// 超时收费金额
            /// </summary>
            public decimal? overtimesfje
            {
                set { _overtimesfje = value; }
                get { return _overtimesfje; }
            }
            /// <summary>
            /// 预交金额
            /// </summary>
            public decimal? advanceMoney
            {
                set { _advanceMoney = value; }
                get { return _advanceMoney; }
            }
            /// <summary>
            /// 支付方式
            /// </summary>
            public int? payMethod
            {
                set { _payMethod = value; }
                get { return _payMethod; }
            }
            /// <summary>
            /// 支付平台
            /// </summary>
            public int? payPlatform
            {
                set { _payPlatform = value; }
                get { return _payPlatform; }
            }
            /// <summary>
            /// 出场图片
            /// </summary>
            public object outImg
            {
                set { _outImg = value; }
                get { return _outImg; }
            }
        }
    }
}