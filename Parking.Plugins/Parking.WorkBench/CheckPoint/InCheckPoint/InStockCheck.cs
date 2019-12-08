using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.DBService.IBLL;
using Parking.Core;
using Parking.Core.Record;
using Parking.Core.Common;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Core.Model;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using Parking.Core.DataProcessing;
namespace Parking.WorkBench
{
    public class InStockCheck : CheckPointBase, ICheck
    {
        public override void Process(ProcessRecord recordInfo)
        {
            recordInfo.CheckPointResult = true;
            try
            {
                //保存入场记录
                var temp = EngineContext.Current.Resolve<ICR_INOUT_RECODE>();
                var orderBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_INFO>();
                var orderDetailsBll = EngineContext.Current.Resolve<ICR_ORDER_RECORD_DETAILS>();
                string Enter = base.getCurrChannel(recordInfo).Enter;
                string Leave = base.getCurrChannel(recordInfo).Leave;
                if (string.IsNullOrEmpty(Leave))
                {
                    recordInfo.INOUT_RECODE.CURR_PARTITION_CODE = Enter;
                    //贵宾卡，直接写一条完整记录
                    if (recordInfo.authenticationType == enumAuthenticationType.SPECIAL_TYPE_VIP)
                    {
                        //贵宾卡
                        recordInfo.INOUT_RECODE.ID = Guid.NewGuid().ToString("N");
                        recordInfo.INOUT_RECODE.RECODE_STATUS = 1;
                        recordInfo.INOUT_RECODE.IN_TIME = recordInfo.REPORTIMG_TIME;
                        recordInfo.INOUT_RECODE.IN_FIELD_CODE = recordInfo.FIELD_CODE;
                        recordInfo.INOUT_RECODE.IN_PARTITION_CODE = recordInfo.PARTITION_CODE;
                        recordInfo.INOUT_RECODE.IN_CHANNEL_CODE = recordInfo.CHN_CODE;
                        recordInfo.INOUT_RECODE.IN_DEV_ID = recordInfo.DEV_CODE;
                        recordInfo.INOUT_RECODE.IN_OPERATOR_ID = recordInfo.OPERATOR_ID;
                        recordInfo.INOUT_RECODE.IN_PARK_TYPE = recordInfo.PARK_TYPE;
                        recordInfo.INOUT_RECODE.OUT_TIME = recordInfo.REPORTIMG_TIME;
                        recordInfo.INOUT_RECODE.OUT_FIELD_CODE = recordInfo.FIELD_CODE;
                        recordInfo.INOUT_RECODE.OUT_PARTITION_CODE = recordInfo.PARTITION_CODE;
                        recordInfo.INOUT_RECODE.OUT_CHANNEL_CODE = recordInfo.CHN_CODE;
                        recordInfo.INOUT_RECODE.OUT_DEV_ID = recordInfo.DEV_CODE;
                        recordInfo.INOUT_RECODE.OUT_OPERATOR_ID = recordInfo.OPERATOR_ID;
                        recordInfo.INOUT_RECODE.OUT_PARK_TYPE = recordInfo.PARK_TYPE;
                        /////////////////转移出场数据/////////////////
                        AddRecodeArchive(recordInfo);
                    }
                    else
                        ///////////////保存入场记录//////////////////
                        recordInfo.CheckPointResult = temp.Add(recordInfo.INOUT_RECODE);
                }
                //保存入场图片
                CR_INOUT_RECODE_IMG modelImg = new CR_INOUT_RECODE_IMG();
                var tempImg = EngineContext.Current.Resolve<ICR_INOUT_RECODE_IMG>();
                modelImg.ID = Guid.NewGuid().ToString("N");
                modelImg.IMG_TYPE = 0;
                modelImg.CHANNEL_CODE = recordInfo.CHN_CODE;
                modelImg.IMG_URL = recordInfo.PicFullName;
                modelImg.RECODE_ID = recordInfo.INOUT_RECODE.ID;
                modelImg.DEV_ID = recordInfo.DEV_CODE;
                modelImg.VEHICLE_NO = recordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER;
                modelImg.CREATE_TIME = DateTime.Now;
                modelImg.CHANNEL_TYPE = recordInfo.CHANNEL_TYPE == enumChannelType.chn_in ? "I" : "E";
                modelImg.ISSEND = 0;
                tempImg.Add(modelImg);
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
                recordInfo.CheckPointResult = false;
            }
        }
    }
}