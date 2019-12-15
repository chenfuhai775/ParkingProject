namespace Parking.Core.Enum
{
    using System;

    public enum enumOperaterType
    {
        /// <summary>
        /// 锁屏
        /// </summary>
        LockForm = 0,
        /// <summary>
        /// 退出
        /// </summary>
        Quit = 1,
        /// <summary>
        /// 手工放行入场
        /// </summary>
        HandReleaseIn = 2,
        /// <summary>
        /// 手工放行出场
        /// </summary>
        HandReleaseOut = 3,
        /// <summary>
        /// 无牌车放行入场
        /// </summary>
        UnlicensedIn = 4,
        /// <summary>
        /// 无牌车放行出场
        /// </summary>
        UnlicensedOut = 5,
        /// <summary>
        /// 显示场内车信息
        /// </summary>
        ShowInSideForm = 6,
        /// <summary>
        /// 显示收费框
        /// </summary>
        ShowCharge = 7,
        /// <summary>
        /// 显示出入场记录
        /// </summary>
        ShowRecord = 8,
        /// <summary>
        /// 显示车牌矫正
        /// </summary>
        PlateCorrection = 9,
        /// <summary>
        /// 显示确认开闸框
        /// </summary>
        OpenInConfirmGate = 10,
        /// <summary>
        /// 开闸
        /// </summary>
        OpenGate = 11,
        /// <summary>
        /// 换班开始
        /// </summary>
        ShowChangeRoleForm = 12,
        /// <summary>
        /// 显示中央缴费框
        /// </summary>
        CentralPayment = 13,
        /// <summary>
        /// 遗失卡放行
        /// </summary>
        LostCardRelease = 14,
        /// <summary>
        /// 换班完成
        /// </summary>
        ChangeRole = 15,
        /// <summary>
        /// 识别事件
        /// </summary>
        RecognitionEvent = 16,
        /// <summary>
        /// 中央缴费成功
        /// </summary>
        CentralPaySuccess = 17,
        /// <summary>
        /// 出场
        /// </summary>
        OutSuccessed = 18,
        /// <summary>
        /// 切换数据网格
        /// </summary>
        SwitchdataGrid = 19,
        /// <summary>
        /// 用户信息查询
        /// </summary>
        QueryUserIfno = 20,
        /// <summary>
        /// 显示收费信息
        /// </summary>
        ShowChargeInfo = 21,
        /// <summary>
        /// 显示车辆登记信息
        /// </summary>
        NoCarNoIn = 22,
        /// <summary>
        /// 显示车辆登记信息
        /// </summary>
        NoCarNoOut = 23,
        /// <summary>
        /// 测试
        /// </summary>
        FeePlugInTest = 100,
    }
}

