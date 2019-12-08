using System;
using System.Collections.Generic;
using System.Linq;
using Parking.Core;
using Parking.Core.Record;
using Parking.Core.Infrastructure;
using Parking.Core.Interface;
using Parking.DBService.IBLL;
using Parking.Core.Oragnization;
using Parking.Core.Model;
using Parking.Core.Enum;
using Parking.Core.DataProcessing;
using Parking.Core.Common;
using System.Text;
using System.Configuration;
using Parking.Core.Log4Net;
using System.Threading;

namespace Parking.WorkBench
{
    public class CheckPointBase : ICheck
    {
        public void WaitOne(ProcessRecord recordInfo)
        {
            if (ChannelEngine.dicChargeInfo.ContainsKey(recordInfo.INOUT_RECODE.VEHICLE_NO))
            {
                var autoResetevent = ChannelEngine.dicChargeInfo.Where(x => x.Key == recordInfo.INOUT_RECODE.VEHICLE_NO).FirstOrDefault();
                var temp = autoResetevent.Value as AutoResetEvent;
                temp.WaitOne();
            }
        }
        /// <summary>
        /// 执??行D流￠??程¨?
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public virtual void Process(ProcessRecord recordInfo)
        {
            recordInfo.CheckPointResult = true;
        }
        /// <summary>
        /// 触?￡¤发¤?é事o?件t
        /// </summary>
        /// <param name="operaterType"></param>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        /// <returns></returns>
        protected virtual bool TriggerEvent(enumOperaterType operaterType, ProcessRecord recordInfo, bool isWaitOne = false)
        {
            try
            {
                recordInfo.OPERATER_TYPE = operaterType;
                ThreadMessageTransact.Instance.triggerEvent(recordInfo, isWaitOne);
            }
            catch { return false; }
            return true;
        }
        /// <summary>
        /// 保à?ê存??节¨2点ì?执??行D记?录?
        /// </summary>
        /// <param name="node"></param>
        /// <param name="recordInfo"></param>
        /// <param name="result"></param>
        public virtual void SaveCheckPointFlowingWater(WF_ProcessNode node, ProcessRecord recordInfo, bool result)
        {
            var temp = EngineContext.Current.Resolve<IWF_FlowProcess>();
            Parking.Core.Model.WF_FlowProcess model = new Parking.Core.Model.WF_FlowProcess();
            model.ID = Guid.NewGuid().ToString("N");
            model.CarNo = recordInfo.INOUT_RECODE.VEHICLE_NO;
            model.FlowCode = node.FlowID;
            model.NodeCode = node.ID;
            model.Result = result;
            model.ExecutionTime = DateTime.Now;
            model.Remark = node.NodeName;
            model.RecordID = recordInfo.INOUT_RECODE.ID;
            temp.Add(model);
        }
        /// <summary>
        /// 获?取¨?当ì?à前??通a?§道ì¨¤
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        protected Equipment getCurrChannel(ProcessRecord recordInfo)
        {
            if (null == recordInfo.CHN_CODE)
                return null;
            return GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == recordInfo.CHN_CODE).FirstOrDefault();
        }
        /// <summary>
        /// 获?取¨?当ì?à前??车|ì场?信?息?é
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        protected Equipment getCurrParkInfo()
        {
            return GlobalEnvironment.ListOragnization.Where(x => x.PARENT_CODE == "-1").FirstOrDefault();
        }
        /// <summary>
        /// 播￡¤报à?§语??音°?
        /// </summary>
        /// <param name="recordInfo"></param>
        public void Sound(ProcessRecord recordInfo)
        {
            /////////////////////////播￡¤报à?§语??音°?////////////////////////////
            var voiceBllTemp = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
            List<string> strArr = new List<string>();
            var voiceModel = voiceBllTemp.GetModelByType((int)enumTemplateType.MODEL_TYPE_VOICE, (int)recordInfo.SpeechType);
            if (null != voiceModel)
            {
                strArr.Add(CommHelper.VoiceContent(voiceModel.CUSTOM_MODEL, recordInfo));
                Parking.Core.Common.CommHelper.Sound(recordInfo, strArr.ToArray());
            }
        }
        /// <summary>
        /// 播￡¤报à?§语??音°?
        /// </summary>
        /// <param name="recordInfo"></param>
        public void ShowLED(ProcessRecord recordInfo)
        {
            /////////////////////////显?示o?LED信?息?é////////////////////////////
            LogHelper.Log.Info("发¤?é送¨aLED显?示o?屏¨￠命¨1令￠?:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            var TempLate = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
            List<string> strArr = new List<string>();
            var childrenList = CommHelper.GetOrgInfos(recordInfo.CHN_CODE).Where(x => x.productLine == enumProductLine.DisplayScreen).ToList();
            foreach (var temp in childrenList)
            {
                foreach (var info in temp.LedInfos.OrderBy(x => x.serialNo))
                {
                    StringBuilder strSB = new StringBuilder();
                    if (!string.IsNullOrEmpty(info.displayContent))
                    {
                        string[] strArrSerialNo = info.displayContent.Split(',');
                        foreach (string s in strArrSerialNo)
                        {
                            int SeriNo = Convert.ToInt32(s);
                            if (SeriNo != 9)
                            {
                                var strTemp = TempLate.GetModelByType((int)enumTemplateType.MODEL_TYPE_DISPLAY, SeriNo);
                                if (null != strTemp)
                                    strSB.Append(CommHelper.LedContent(strTemp.CUSTOM_MODEL, recordInfo, SeriNo));
                            }
                        }
                        strArr.Add(strSB.ToString());
                        Parking.Core.Common.CommHelper.ShowLED(temp, strArr.ToArray(), info);
                        strArr.Clear();
                    }
                }
            }
        }
        /// <summary>
        /// 发¤?é送¨a余?¨¤位?信?息?é
        /// </summary>
        public void ShowMoreThanInfo(ProcessRecord recordInfo)
        {
            LogHelper.Log.Info("发¤?é送¨a余?¨¤位?显?示o?屏¨￠命¨1令￠?:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            var TempLate = EngineContext.Current.Resolve<IPBA_VOICE_TEMPLATE>();
            List<string> strArr = new List<string>();
            var childrenList = CommHelper.GetOrgInfos(recordInfo.CHN_CODE).Where(x => x.productLine == enumProductLine.DisplayScreen).ToList();
            childrenList = CommHelper.GetOrgInfos(recordInfo.INOUT_RECODE.IN_CHANNEL_CODE).Where(x => x.productLine == enumProductLine.DisplayScreen).ToList();
            foreach (var temp in childrenList)
            {
                foreach (var info in temp.LedInfos.OrderBy(x => x.serialNo))
                {
                    StringBuilder strSB = new StringBuilder();
                    string[] strArrSerialNo = info.displayContent.Split(',');
                    if (!string.IsNullOrEmpty(info.displayContent))
                    {
                        foreach (string s in strArrSerialNo)
                        {
                            int SeriNo = Convert.ToInt32(s);
                            if (SeriNo == 9)
                            {
                                var strTemp = TempLate.GetModelByType((int)enumTemplateType.MODEL_TYPE_DISPLAY, SeriNo);
                                if (null != strTemp)
                                    strSB.Append(CommHelper.LedContent(strTemp.CUSTOM_MODEL, recordInfo, SeriNo));
                            }
                        }
                        strArr.Add(strSB.ToString());
                        Parking.Core.Common.CommHelper.ShowLED(temp, strArr.ToArray(), info);
                        strArr.Clear();
                    }
                }
            }
        }
        /// <summary>
        /// 是o?否¤?有?D权¨?§限T
        /// </summary>
        /// <returns></returns>
        public bool HasPermit(ProcessRecord recordInfo)
        {
            var TempLate = EngineContext.Current.Resolve<ICR_ACCESS_PERMISSION_INFO>();
            return TempLate.HasPermit(recordInfo);
        }

        /// <summary>
        /// 插?入¨?出?场?数oy据Y
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        public bool AddRecodeArchive(ProcessRecord recordInfo)
        {
            var temArchive = EngineContext.Current.Resolve<ICR_INOUT_RECODE_ARCHIVE>();
            CR_INOUT_RECODE_ARCHIVE model = new CR_INOUT_RECODE_ARCHIVE();
            model.ID = recordInfo.INOUT_RECODE.ID;
            model.UNIQUE_IDENTIFIER = recordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER;
            model.VEHICLE_NO = recordInfo.INOUT_RECODE.VEHICLE_NO;
            model.CAR_COLOR = recordInfo.INOUT_RECODE.CAR_COLOR;
            model.CAR_EC_NO = recordInfo.INOUT_RECODE.CAR_EC_NO;
            model.IN_FIELD_CODE = recordInfo.INOUT_RECODE.IN_FIELD_CODE;
            model.IN_CHANNEL_CODE = recordInfo.INOUT_RECODE.IN_CHANNEL_CODE;
            model.IN_TIME = recordInfo.INOUT_RECODE.IN_TIME;
            model.IN_OPERATOR_ID = recordInfo.INOUT_RECODE.IN_OPERATOR_ID;
            model.IN_PARTITION_CODE = recordInfo.INOUT_RECODE.IN_PARTITION_CODE;
            model.IN_EQ_ID = recordInfo.INOUT_RECODE.IN_EQ_ID;
            model.IN_DEV_ID = recordInfo.INOUT_RECODE.IN_DEV_ID;
            model.IN_PARK_TYPE = recordInfo.INOUT_RECODE.IN_PARK_TYPE;
            model.OUT_DEV_ID = recordInfo.INOUT_RECODE.OUT_DEV_ID;
            model.OUT_PARK_TYPE = recordInfo.INOUT_RECODE.OUT_PARK_TYPE;
            model.OUT_TIME = recordInfo.INOUT_RECODE.OUT_TIME;
            model.OUT_FIELD_CODE = recordInfo.INOUT_RECODE.OUT_FIELD_CODE;
            model.OUT_CHANNEL_CODE = recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE;
            model.OUT_OPERATOR_ID = recordInfo.INOUT_RECODE.OUT_OPERATOR_ID;
            model.OUT_PARTITION_CODE = recordInfo.INOUT_RECODE.OUT_PARTITION_CODE;
            model.TOTAL_TIME = recordInfo.INOUT_RECODE.TOTAL_TIME;
            model.CHARGE_MONEY = recordInfo.INOUT_RECODE.CHARGE_MONEY;
            model.DUE_MONEY = recordInfo.INOUT_RECODE.DUE_MONEY;
            model.PRE_MONEY = recordInfo.INOUT_RECODE.PRE_MONEY;
            model.OVERTIMESFJE = recordInfo.INOUT_RECODE.OVERTIMESFJE;
            model.ADVANCE_MONEY = recordInfo.INOUT_RECODE.ADVANCE_MONEY;
            model.PAY_METHOD = recordInfo.INOUT_RECODE.PAY_METHOD;
            model.OUT_EQ_ID = recordInfo.INOUT_RECODE.OUT_EQ_ID;
            model.PAY_PLATFORM = recordInfo.INOUT_RECODE.PAY_PLATFORM;
            model.IN_IMG_TRUST = recordInfo.INOUT_RECODE.IN_IMG_TRUST;
            model.OUT_IMG_TRUST = recordInfo.INOUT_RECODE.OUT_IMG_TRUST;
            model.RECODE_STATUS = recordInfo.INOUT_RECODE.RECODE_STATUS;
            model.CREDENTIALS_TYPE = recordInfo.INOUT_RECODE.CREDENTIALS_TYPE;
            model.HAS_CORRECT = recordInfo.INOUT_RECODE.HAS_CORRECT;
            model.LOCK_FLAG = recordInfo.INOUT_RECODE.LOCK_FLAG;
            model.LOCK_TIME = recordInfo.INOUT_RECODE.LOCK_TIME;
            return temArchive.Add(model);
        }
        /// <summary>
        /// 获?取¨?节¨2假¨′日¨?信?息?é
        /// </summary>
        /// <returns></returns>
        public CalendarInfo GetWorkingDays(string dateTime)
        {
            CalendarInfo calendarInfo = new CalendarInfo();
            //获?取¨?当ì?à前??工?è作á??站?
            string url = ConfigurationManager.AppSettings["serverUrl"].ToString();
            string authCode = CommHelper.Str(6);
            string token = CommHelper.Md5(CommHelper.StringToHexString(authCode)).ToUpper();
            string data = "authCode=" + authCode + "&token=" + token + "&dateTime=" + dateTime;
            string result = CommHelper.Post(url + "/workingDaysVal.eif?", data);
            WorkingDays workDay = CommHelper.FromJsonTo<WorkingDays>(result);
            if (workDay != null)
            {
                if (workDay.resStatus == 1)
                {
                    calendarInfo = workDay.calendarInfo;
                }
                else
                {
                    LogHelper.Log.Error(workDay.resRemark);
                }
            }
            return calendarInfo;
        }
        #region ___更¨1新?所¨′有?D订?单ì￡¤信?息?é___
        /// <summary>
        /// 更¨1新?订?单ì￡¤信?息?é
        /// </summary>
        /// <param name="recordInfo"></param>
        public void UpdateAllOrders(ProcessRecord recordInfo)
        {
            var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
            var temp = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
            var orders = temp.GetOrders(recordInfo.INOUT_RECODE).ToList();
            recordInfo.INOUT_RECODE.PRE_MONEY = null != recordInfo.ListDiscount ? recordInfo.ListDiscount.Sum(x => x.PREFERENTIAL_MONEY) : 0;
            decimal perMoney = recordInfo.INOUT_RECODE.PRE_MONEY;
            string Leave = getCurrChannel(recordInfo) == null ? recordInfo.INOUT_RECODE.CURR_PARTITION_CODE : getCurrChannel(recordInfo).Leave;
            var CurrOrders = orders.Where(X => X.PARTITION_CODE == Leave).ToList();
            foreach (var order in CurrOrders)
            {
                if (null != order && !recordInfo.AutoOpenGate)
                {
                    if (order.INOUT_RECODE_ID == recordInfo.INOUT_RECODE.ID)
                    {
                        if (order.DUE_MONEY >= perMoney)
                        {
                            order.PER_MONEY = perMoney;
                            order.CHARGE_MONEY = order.DUE_MONEY - order.PER_MONEY;
                        }
                        else
                        {
                            order.PER_MONEY = order.DUE_MONEY;
                            order.CHARGE_MONEY = 0;
                        }
                        order.ALREADY_PAID = order.CHARGE_MONEY;
                        if (null != recordInfo.INOUT_RECODE.PAY_METHOD)
                            order.PAY_TYPE = recordInfo.INOUT_RECODE.PAY_METHOD;
                        order.OUT_CHANNEL_CODE = recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE;
                        order.FREE_TIME = DateTime.Now.AddMinutes(GlobalEnvironment.FreeTime);
                    }
                    order.PAY_TYPE = recordInfo.INOUT_RECODE.PAY_METHOD;
                    order.IS_PAY = true;
                    temp.Update(order);
                    var OrderDetails = orderDetailsBll.GetDetailsByOrder(order.ID);
                    if (null != OrderDetails)
                    {
                        decimal perMoneyDetail = perMoney;
                        foreach (var detail in OrderDetails)
                        {
                            if (detail.DUE_MONEY >= perMoneyDetail)
                            {
                                detail.PER_MONEY = perMoneyDetail;
                                detail.CHARGE_MONEY = detail.DUE_MONEY - perMoneyDetail;
                            }
                            else
                            {
                                detail.PER_MONEY = detail.DUE_MONEY;
                                detail.CHARGE_MONEY = 0;
                            }
                            orderDetailsBll.Update(detail);
                        }
                    }
                }
            }
            recordInfo.ListOrder = orders;
        }
        #endregion
    }
}