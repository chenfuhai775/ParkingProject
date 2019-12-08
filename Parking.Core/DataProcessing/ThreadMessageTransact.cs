using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using Parking.Core.Infrastructure;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.Oragnization;
using Parking.Core.Interface;
using Parking.Core.Caching;
using Parking.Core.Common;
using Parking.Core.Model;
using System.ComponentModel;
using System.Configuration;


namespace Parking.Core.DataProcessing
{
     public class ThreadMessageTransact
    {
        #region __属性__
        private Thread threadAcceptData;
        private Thread threadInRecordData;
        private Thread threadOutRecordData;
        private object AcceptDataQueLock = new object();
        public AutoResetEvent AcceptDataEvent = new AutoResetEvent(true);
        private object AcceptInRecordDataQueLock = new object();
        private object AcceptOutRecordDataQueLock = new object();
        /// <summary>
        /// 可以走流程的正式数据
        /// </summary>
        Queue<ProcessRecord> AcceptDataQue = new Queue<ProcessRecord>();

        private Thread threadMiddData;
        private object MiddDataQueLock = new object();
        public AutoResetEvent MiddDataEvent = new AutoResetEvent(false);
        /// <summary>
        /// 各种设备上报的中间数据
        /// </summary>
        Queue<DataUploadEventArgs> MiddDataQue = new Queue<DataUploadEventArgs>();

        /// <summary>
        /// 流程运行中触发的事件代理
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="isWaitOne"></param>
        public delegate void OnMessageBroadcastEventHandler(ProcessRecord msg, bool isWaitOne);
        public event OnMessageBroadcastEventHandler OnMessageBroadcast;
        public delegate void ProcessDelegate(IChannel channel, ProcessRecord record);
        private static object channelLock = new object();
        public Action<ProcessRecord> OnPlate;
        public static Dictionary<string, DateTime> dicCache = new Dictionary<string, DateTime>();

        public AutoResetEvent InRedodeEvent = new AutoResetEvent(false);
        Queue<INRECORDALL> InRedodeQue = new Queue<INRECORDALL>();
        public AutoResetEvent OutRedodeEvent = new AutoResetEvent(false);
        Queue<OUTRECORDALL> OutRedodeQue = new Queue<OUTRECORDALL>();
        #endregion

        #region __启动线程__
        /// <summary>
        /// 启动数据监控线程
        /// </summary>
        public void Start()
        {
            ThreadHelper.StartBgThread(ref threadAcceptData, new ParameterizedThreadStart(AcceptDataWork), null, true);
            ThreadHelper.StartBgThread(ref threadMiddData, new ParameterizedThreadStart(MiddDataWork), null, true);
            ThreadHelper.StartBgThread(ref threadInRecordData, new ParameterizedThreadStart(AcceptInRecord), null, true);
            ThreadHelper.StartBgThread(ref threadOutRecordData, new ParameterizedThreadStart(AcceptOutRecord), null, true);
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerAsync();
        }
        #endregion

        #region ___数据处理线程___
        /// <summary>
        /// 处理队列中的正式数据
        /// </summary>
        /// <param name="state"></param>
        public void AcceptDataWork(object state)
        {
            while (true)
            {
                try
                {
                    AcceptDataEvent.WaitOne(1);
                    while (AcceptDataQue.Count > 0)
                    {
                        ProcessRecord msg = null;
                        lock (AcceptDataQueLock)
                        {
                            if (AcceptDataQue.Count > 0)
                            {
                                msg = AcceptDataQue.Dequeue();
                            }
                        }
                        if (msg != null)
                        {
                            var channel = EngineContext.Current.Resolve<IChannel>(msg.CHANNEL_TYPE.ToString());
                            if (null != channel)
                            {
                                ///////////////////////补抓图片//////////////////////////////////
                                if (string.IsNullOrEmpty(msg.PicFullName))
                                {
                                    var channelList = CommHelper.GetOrgInfos(msg.CHN_CODE);
                                    var cameraDevice = channelList.Where(x => x.productLine == enumProductLine.IdentificationCamera && x.autoRecognition).FirstOrDefault();
                                    if (null != cameraDevice)
                                    {
                                        var cameraSDK = EngineContext.Current.Resolve<ICamera>(cameraDevice.deviceType.ToString());
                                        if (null != cameraSDK)
                                        {
                                            string strPicName = string.Empty;
                                            cameraSDK.CapturePicture(cameraDevice.IP, out strPicName);
                                            msg.PicFullName = strPicName;
                                        }
                                    }
                                }
                                ///////////////////////开始流程//////////////////////////////////
                                ProcessDelegate dl = new ProcessDelegate(RunProcess);
                                dl.BeginInvoke(channel, msg, null, null);
                                if (null != OnPlate)
                                    OnPlate(msg);
                            }
                        }
                    }
                    AcceptDataEvent.Reset();
                }
                catch (Exception ex)
                {
                    AcceptDataEvent.Reset();
                    LogHelper.Log.Error(ex.Message, ex.InnerException);
                }
            }
        }
        /// <summary>
        ///  处理入场队列中的数据
        /// </summary>
        public void AcceptInRecord(object state)
        {
            while (true)
            {
                try
                {
                    InRedodeEvent.WaitOne(100);
                    while (InRedodeQue.Count > 0)
                    {
                        InRedodeEvent.WaitOne(100);
                        INRECORDALL recordAll = null;
                        lock (AcceptInRecordDataQueLock)
                        {
                            if (InRedodeQue.Count > 0)
                            {
                                recordAll = InRedodeQue.First();
                            }
                        }
                        try
                        {
                            if (null != recordAll)
                            {
                                string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
                                string authCode = CommHelper.Str(6);
                                string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
                                string imgData = "imgContent=" + recordAll.imgContent + "&imgUrl=" + recordAll.imgUrl + "&authCode=" + authCode + "&token=" + token + ""; ;
                                string imgResult = CommHelper.Post(url + "/inOutImg.eif", imgData);
                                returnData returnResult = CommHelper.FromJsonTo<returnData>(imgResult);
                                LogHelper.Log.Info("车牌号:" + recordAll.inreord.vehicleNo + ";返回状态:" + returnResult.resStatus + ";返回信息：" + returnResult.resRemark);
                                if (null != returnResult)
                                {
                                    if (returnResult.resStatus == 1)
                                    {
                                        LogHelper.Log.Info("通道:" + recordAll.inreord.inChannelCode + "入场图片上传成功");
                                        string data = Common.CommHelper.ToJSON(recordAll.inreord).Replace("\\", "");
                                        data = "inRecord=" + data.Remove((data.IndexOf('[') - 1), 1);
                                        data = data.Remove((data.IndexOf(']') + 1), 1) + "&authCode=" + authCode + "&token=" + token;
                                        string inResult = CommHelper.Post(url + "/inRecord.eif", data);
                                        returnData returnInrecord = CommHelper.FromJsonTo<returnData>(inResult);
                                        if (returnInrecord.resStatus == 1)
                                        {
                                            LogHelper.Log.Info("通道:" + recordAll.inreord.inChannelCode + "入场记录上传成功");
                                            InRedodeQue.Dequeue();
                                        }
                                        else
                                        {
                                            LogHelper.Log.Info("通道:" + recordAll.inreord.inChannelCode + "入场记录上传失败");
                                        }
                                    }
                                    else
                                    {
                                        LogHelper.Log.Info("通道:" + recordAll.inreord.inChannelCode + "入场图片上传失败");
                                    }
                                }
                                else
                                {
                                    LogHelper.Log.Error(returnResult.resRemark);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Log.Error(ex.Message);
                            AcceptDataEvent.Reset();
                        }
                    }
                    AcceptDataEvent.Reset();
                }
                catch (Exception ex)
                {
                    LogHelper.Log.Error(ex.Message);
                    AcceptDataEvent.Reset();
                }
            }
        }
        /// <summary>
        ///  处理出场队列中的数据
        /// </summary>
        public void AcceptOutRecord(object state)
        {
            while (true)
            {
                try
                {
                    OutRedodeEvent.WaitOne(100);
                    while (OutRedodeQue.Count > 0)
                    {
                        OutRedodeEvent.WaitOne(100);
                        OUTRECORDALL recordAll = null;
                        lock (AcceptOutRecordDataQueLock)
                        {
                            if (OutRedodeQue.Count > 0)
                            {
                                recordAll = OutRedodeQue.First();
                            }
                        }
                        try
                        {
                            if (null != recordAll)
                            {
                                string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
                                string authCode = CommHelper.Str(6);
                                string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
                                string imgData = "imgContent=" + recordAll.imgContent + "&imgUrl=" + recordAll.imgUrl + "&authCode=" + authCode + "&token=" + token + ""; ;
                                string imgResult = CommHelper.Post(url + "/inOutImg.eif", imgData);
                                returnData returnResult = CommHelper.FromJsonTo<returnData>(imgResult);
                                LogHelper.Log.Info("车牌号:" + recordAll.outrecord.vehicleNo + ";返回状态:" + returnResult.resStatus+";返回信息："+ returnResult.resRemark);
                                if (null != returnResult)
                                {
                                    if (returnResult.resStatus == 1)
                                    {
                                        LogHelper.Log.Info("通道:" + recordAll.outrecord.outChannelCode + "出场图片上传成功");
                                        string data = Common.CommHelper.ToJSON(recordAll.outrecord).Replace("\\", "");
                                        data = "inOutRecord=" + data.Remove((data.IndexOf('[') - 1), 1);
                                        data = data.Remove((data.IndexOf(']') + 1), 1) + "&authCode=" + authCode + "&token=" + token;
                                        string inResult = CommHelper.Post(url + "/inOutRecord.eif", data);
                                        returnData returnInrecord = CommHelper.FromJsonTo<returnData>(inResult);
                                        if (returnInrecord.resStatus == 1)
                                        {
                                            LogHelper.Log.Info("通道:" + recordAll.outrecord.outChannelCode + "出场记录上传成功");
                                            OutRedodeQue.Dequeue();        
                                        }
                                        else
                                        {
                                            LogHelper.Log.Info("通道:" + recordAll.outrecord.outChannelCode + "出场记录上传失败");
                                        }
                                    }
                                    else
                                    {
                                        LogHelper.Log.Info("通道:" + recordAll.outrecord.outChannelCode + "出场图片上传失败");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Log.Error(ex.Message);
                            AcceptDataEvent.Reset();
                        }
                    }
                    AcceptDataEvent.Reset();
                }
                catch (Exception ex)
                {
                    LogHelper.Log.Error(ex.Message);
                    AcceptDataEvent.Reset();
                }
            }
        }
        /// <summary>
        /// 处理队列中的数据
        /// </summary>
        /// <param name="state"></param>
        public void MiddDataWork(object state)
        {
            while (true)
            {
                try
                {
                    MiddDataEvent.WaitOne();
                    while (MiddDataQue.Count > 0)
                    {
                        DataUploadEventArgs args = null;
                        lock (MiddDataQueLock)
                        {
                            if (MiddDataQue.Count > 0)
                            {
                                args = MiddDataQue.Dequeue();
                            }
                        }
                        if (null != args)
                        {
                            var converter = EngineContext.Current.Resolve<IRecordConvert>(args.releaseType.ToString());
                            if (null != converter)
                            {
                                ProcessRecord recordinfo = converter.ConvertRecord(args);
                                if (null != recordinfo)
                                    AcceptFormalData(recordinfo);
                            }
                            else
                            {

                            }
                        }
                    }
                    MiddDataEvent.Reset();
                }
                catch (Exception ex)
                {
                    MiddDataEvent.Reset();
                    LogHelper.Log.Error(ex.Message, ex.InnerException);
                }
            }
        }
        /// <summary>
        /// 往队列中添加临时数据
        /// </summary>
        /// <param name="acceptBytes"></param>
        public void AcceptMiddData(DataUploadEventArgs args)
        {
            if (CommHelper.ValidateCarNum(args.TempRecordInfo.plateNum))
            {
                lock (MiddDataQue)
                    MiddDataQue.Enqueue(args);
                MiddDataEvent.Set();
                var Porg = GlobalEnvironment.ListOragnization.Where(x => x.IP == args.TempRecordInfo.ip).FirstOrDefault();
                string OrgCode = Porg == null ? string.Empty : Porg.PARENT_CODE;
                LogHelper.Log.Info("收到通道【" + OrgCode + "】上的设备【" + args.TempRecordInfo.ip + "】上传识别的正确车牌【" + args.TempRecordInfo.plateNum + "】，在" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            }
        }
        /// <summary>
        /// 往入场记录队列中添加数据
        /// </summary>
        /// <param name="record"></param>
        public void AddInRecord(INRECORDALL record)
        {
            lock (InRedodeQue)
                InRedodeQue.Enqueue(record);
        }
// <summary>
        /// 往出场记录队列中添加数据
        /// </summary>
        /// <param name="record"></param>
        public void AddOutRecord(OUTRECORDALL record)
        {
            lock (OutRedodeQue)
                OutRedodeQue.Enqueue(record);
        }
        /// <summary>
        /// 往队列中添加正式数据
        /// </summary>
        /// <param name="acceptBytes"></param>
        public void AcceptFormalData(ProcessRecord acceptBytes)
        {
            lock (AcceptDataQue)
            {
                AcceptDataQue.Enqueue(acceptBytes);
            }
        }
        /// <summary>
        /// 正式数据流程运行中，异步获取出入口流程对象并运行
        /// </summary>
        /// <param name="recordInfo"></param>
        private void RunProcess(IChannel channel, ProcessRecord recordInfo)
        {
            channel.Process(recordInfo);
        }
        #endregion

        #region ___服务总线事件___
        /// <summary>
        /// 流程过程中触发事件
        /// </summary>
        /// <param name="recordinfo">过程数据</param>
        /// <param name="isWaitOne">是否模态窗口</param>
        public void triggerEvent(ProcessRecord recordinfo, bool isWaitOne)
        {
            if (null != OnMessageBroadcast)
            {
                OnMessageBroadcast(recordinfo, isWaitOne);
            }
        }
        #endregion

        #region __各设备上报中间数据__
        /// <summary>
        /// 上报中间数据，缓存一段时间
        /// </summary>
        /// <param name="e"></param>
        public void AddRecognitioMiddData(DataUploadEventArgs e)
        {
            lock (channelLock)
            {
                //通过IP找到设备信息
                var recognitioEqu = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.IP == e.TempRecordInfo.ip).FirstOrDefault();
                var channels = CommHelper.GetOrgInfos(recognitioEqu.ORGANIZATION_CODE, false);
                if (null != channels)
                {
                    var currChannel = channels.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                    //没加定时器,则加上定时器
                    if (!dicCache.ContainsKey(currChannel.ORGANIZATION_CODE))
                    {
                        dicCache.Add(currChannel.ORGANIZATION_CODE, DateTime.Now);
                        LogHelper.Log.Info("【" + currChannel.ORGANIZATION_NAME + "】上的相机【" + e.TempRecordInfo.ip + "】识别到车牌【" + e.TempRecordInfo.plateNum + "】，在" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                }

                if (null != recognitioEqu)
                {
                    var tempCarNo = recognitioEqu.ListRecognitioResult.Where(x => x.CarNo == e.TempRecordInfo.plateNum).FirstOrDefault();
                    if (null != tempCarNo)
                        tempCarNo.Count += 1;
                    else
                    {
                        RecognitioResult rResult = new RecognitioResult();
                        rResult.CarNo = e.TempRecordInfo.plateNum;
                        rResult.Count = 1;
                        rResult.args = e;
                        recognitioEqu.ListRecognitioResult.Add(rResult);
                    }
                    triggerEvent(new ProcessRecord() { OPERATER_TYPE = enumOperaterType.RecognitionEvent, IP = e.TempRecordInfo.ip }, false);
                }
            }
        }
        /// <summary>
        /// 获取中间数据
        /// </summary>
        public void bgw_DoWork(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    List<Equipment> listResult = new List<Equipment>();
                    var listEquipment = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.channelType == enumChannelType.equ && x.ListRecognitioResult.Count > 0).ToList();
                    //遍历有数据上传的所有设备
                    foreach (var temp in listEquipment)
                    {
                        var channels = CommHelper.GetOrgInfos(temp.ORGANIZATION_CODE, false);
                        if (null != channels)
                        {
                            var currChannel = channels.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                            if (dicCache.ContainsKey(currChannel.ORGANIZATION_CODE))
                            {
                                DateTime dtOld = dicCache[currChannel.ORGANIZATION_CODE];
                                if (DateTime.Now.AddSeconds(-ConfigHelper.ChannelDataUpLoadInterval) >= dtOld)
                                {
                                    //查找通道
                                    var tempResult = listResult.Where(x => x.PARENT_CODE == temp.PARENT_CODE).FirstOrDefault();
                                    if (null == tempResult)
                                    {
                                        //如果当前出入口有数据
                                        if (temp.ListRecognitioResult.Count > 0)
                                            listResult.Add(temp);
                                    }
                                    else
                                    {
                                        if (temp.CurrRecognitioData.CarNo != tempResult.CurrRecognitioData.CarNo)
                                        {
                                            //对于同一个通道同时有两个以上设备上报数据，比较两种设备的识别率,保留识别率高的设备上传的数据
                                            if (temp.ErrorCount < tempResult.ErrorCount)
                                            {
                                                listResult.Remove(tempResult);
                                                listResult.Add(temp);
                                            }
                                        }
                                    }
                                    LogHelper.Log.Info("从【" + currChannel.ORGANIZATION_NAME + "】上获取正确车牌【" + temp.CurrRecognitioData.CarNo + "】，在" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    dicCache.Remove(currChannel.ORGANIZATION_CODE);
                                }
                            }
                        }
                    }
                    lock (channelLock)
                    {
                        var cache = EngineContext.Current.Resolve<ICacheManager>();
                        foreach (var temp in listResult)
                        {
                            var channels = CommHelper.GetOrgInfos(temp.ORGANIZATION_CODE, false);
                            if (null != channels && null != temp.CurrRecognitioData && temp.CurrRecognitioData.Count > 0)
                            {
                                var currChannel = channels.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                                if (!cache.IsSet(temp.CurrRecognitioData.CarNo + currChannel.ORGANIZATION_CODE))
                                {
                                    AcceptMiddData(temp.CurrRecognitioData.args);
                                    temp.lastCarNo = temp.CurrRecognitioData.CarNo;
                                    cache.Set(temp.CurrRecognitioData.CarNo + currChannel.ORGANIZATION_CODE, temp.IP, ConfigHelper.CarRecognitionInterval);
                                    LogHelper.Log.Info("【" + currChannel.ORGANIZATION_NAME + "】缓存车牌【" + temp.CurrRecognitioData.CarNo + "】，在" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                }
                                else
                                    LogHelper.Log.Info("【" + currChannel.ORGANIZATION_NAME + "】上的车辆【" + temp.CurrRecognitioData.CarNo + "】在【" + ConfigHelper.CarRecognitionInterval + "】分钟内不允许重复入场");
                                GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.ORGANIZATION_CODE == temp.ORGANIZATION_CODE).FirstOrDefault().ListRecognitioResult.Clear();
                            }
                        }
                        listResult.Clear();
                    }
                    Thread.Sleep(100);
                }
                catch (Exception ex) { LogHelper.Log.Error(ex.Message, ex.InnerException); }
            }
        }
        #endregion

        #region __单列对象__
        private static ThreadMessageTransact _instance;
        public static ThreadMessageTransact Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new ThreadMessageTransact();
                return _instance;
            }
        }
        #endregion
    }
 }