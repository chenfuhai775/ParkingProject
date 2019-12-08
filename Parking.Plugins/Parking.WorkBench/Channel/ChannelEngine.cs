using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.Model;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.Record;
using Parking.DBService.IBLL;

namespace Parking.WorkBench
{
    public class ChannelEngine : IChannel
    {
        public static Dictionary<string, AutoResetEvent> dicChargeInfo = new Dictionary<string, AutoResetEvent>();
        /// <summary>
        /// 执行节点
        /// </summary>
        /// <param name="recordInfo"></param>
        public void Process(ProcessRecord recordInfo)
        {
            try
            {
                WF_ProcessNode tempNode = null;
                var flow = EngineContext.Current.Resolve<IWF_ProcessNode>();
                enumFlowType flowType = enumFlowType.In;
                if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_in)
                    flowType = enumFlowType.In;
                else if (recordInfo.CHANNEL_TYPE == enumChannelType.chn_out)
                    flowType = enumFlowType.Out;
                else
                    flowType = enumFlowType.Center;
                var flowList = flow.GetNodesByWFType(flowType);

                if (flowList.Count > 0)
                {
                    if (!dicChargeInfo.ContainsKey(recordInfo.INOUT_RECODE.VEHICLE_NO))
                    {
                        dicChargeInfo.Add(recordInfo.INOUT_RECODE.VEHICLE_NO, new AutoResetEvent(false));
                        while (true)
                        {
                            tempNode = tempNode ?? flowList.First<WF_ProcessNode>(x => x.PN_Flag);
                            if (!string.IsNullOrEmpty(tempNode.NodeCode) && null != tempNode && tempNode.PN_Flag)
                            {
                                ICheck checkPoint = EngineContext.Current.Resolve<ICheck>(tempNode.NodeCode);
                                checkPoint.Process(recordInfo);
                                checkPoint.SaveCheckPointFlowingWater(tempNode, recordInfo, recordInfo.CheckPointResult);
                                if (recordInfo.CheckPointResult)
                                {
                                    if (!string.IsNullOrEmpty(tempNode.NextNode))
                                    {
                                        //////////////////执行下一节点//////////////////
                                        var nextNode = flowList.Where(x => x.ID == tempNode.NextNode).FirstOrDefault();
                                        if (null != nextNode)
                                        {
                                            if (nextNode.PN_Flag)
                                                checkPoint = EngineContext.Current.Resolve<ICheck>(nextNode.NodeCode);
                                            tempNode = nextNode;
                                        }
                                        else
                                            LogHelper.Log.Error("下一节点为空");
                                    }
                                    else
                                        break;
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(tempNode.JumpNode))
                                    {
                                        //////////////////执行跳转节点//////////////////
                                        var jumpNode = flowList.Where(x => x.ID == tempNode.JumpNode).FirstOrDefault();
                                        if (null != jumpNode)
                                        {
                                            if (jumpNode.PN_Flag)
                                                checkPoint = EngineContext.Current.Resolve<ICheck>(jumpNode.NodeCode);
                                            tempNode = jumpNode;
                                        }
                                        else
                                            LogHelper.Log.Error("跳转节点为空");
                                    }
                                    else
                                        break;
                                }
                            }
                            else
                            {
                                var nextNode = flowList.Where(x => x.ID == tempNode.NextNode).FirstOrDefault();
                                if (null != nextNode)
                                    tempNode = nextNode;
                                else
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (dicChargeInfo.ContainsKey(recordInfo.INOUT_RECODE.VEHICLE_NO))
                    dicChargeInfo.Remove(recordInfo.INOUT_RECODE.VEHICLE_NO);
                LogHelper.Log.Error(ex.StackTrace);
            }
            finally {
                if (dicChargeInfo.ContainsKey(recordInfo.INOUT_RECODE.VEHICLE_NO))
                    dicChargeInfo.Remove(recordInfo.INOUT_RECODE.VEHICLE_NO);
            }
        }

        /// <summary>
        /// 阻塞线程
        /// </summary>
        /// <param name="recordInfo"></param>
        public static void ProcessSet(ProcessRecord recordInfo)
        {
            if (dicChargeInfo.ContainsKey(recordInfo.INOUT_RECODE.VEHICLE_NO))
            {
                var autoResetevent = ChannelEngine.dicChargeInfo.Where(x => x.Key == recordInfo.INOUT_RECODE.VEHICLE_NO).FirstOrDefault();
                var temp = autoResetevent.Value as AutoResetEvent;
                temp.Set();
            }
        }
    }
}