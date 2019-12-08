using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Oragnization;
using Parking.Core.Interface;
using Parking.Core.Common;
using Parking.Core.Infrastructure;
using Parking.DBService.IBLL;

namespace Parking.WorkBench
{
    public class PlatRecordConvert : RecordConvertBase, IRecordConvert
    {
        public ProcessRecord ConvertRecord(DataUploadEventArgs data)
        {
            ProcessRecord recordInfo = new ProcessRecord();
            var temp = EngineContext.Current.Resolve<IPBA_PARKING_PARAM_SETTINGS>();
            //获取当前设备设置参数信息
            var model = temp.GetParkingParamByIP(data.TempRecordInfo.ip);
            if (null != model)
            {
                //获取当前设备组织信息
                var oragani = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.OrganizationInfo.ORGANIZATION_CODE == model.ORGANIZATION_CODE).FirstOrDefault();
                if (null != oragani)
                {
                    //设备信息
                    recordInfo.DEV_NAME = oragani.OrganizationInfo.ORGANIZATION_NAME;
                    recordInfo.DEV_CODE = oragani.OrganizationInfo.ORGANIZATION_CODE;

                    //分区信息
                    var parentsList = CommHelper.GetOrgInfos(recordInfo.DEV_CODE, false);
                    var par = parentsList.Where(x => x.channelType == enumChannelType.par).LastOrDefault();
                    if (null != par)
                    {
                        recordInfo.PARTITION_CODE = par.ORGANIZATION_CODE;
                        recordInfo.PARTITION_NAME = par.OrganizationInfo.ORGANIZATION_NAME;
                    }
                    //获取工作站信息
                    var wsn = parentsList.Where(x => x.channelType == enumChannelType.wsn).LastOrDefault();
                    if (null != wsn)
                    {
                        recordInfo.FIELD_NAME = wsn.OrganizationInfo.ORGANIZATION_NAME;
                        recordInfo.FIELD_CODE = wsn.OrganizationInfo.ORGANIZATION_CODE;
                    }
                    //获取岗亭信息
                    var chn = parentsList.Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).FirstOrDefault();
                    if (null != chn)
                    {
                        Channel tempChannel = chn as Channel;
                        //组织编码
                        recordInfo.CHN_CODE = chn.OrganizationInfo.ORGANIZATION_CODE;
                        //组织名称
                        recordInfo.CHN_NAME = chn.OrganizationInfo.ORGANIZATION_NAME;
                        //出入口类型
                        recordInfo.CHANNEL_TYPE = chn.channelType;
                    }
                    //获取操作员信息
                    if (null != GlobalEnvironment.LocalUserInfo)
                    {
                        recordInfo.OPERATOR_ID = GlobalEnvironment.LocalUserInfo.USER_ID;
                        recordInfo.OPERATOR_NAME = GlobalEnvironment.LocalUserInfo.USER_NAME;
                    }
                }
            }
            recordInfo.INOUT_RECODE.VEHICLE_TYPE = (int)recordInfo.CarType;
            //车牌号码
            recordInfo.INOUT_RECODE.VEHICLE_NO = data.TempRecordInfo.plateNum;
            //车辆身份唯一标识
            recordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER = data.TempRecordInfo.specialCode;
            //车牌颜色
            recordInfo.INOUT_RECODE.CAR_COLOR = data.TempRecordInfo.PlateColorStr.ToString();
            //入场类型
            recordInfo.PARK_TYPE = "车牌识别";
            //上报时间
            recordInfo.REPORTIMG_TIME = DateTime.Parse(data.TempRecordInfo.picCapTime);
            //抓拍图片
            recordInfo.PicFullName = data.TempRecordInfo.fullPicName;
            //初始化公共信息
            base.InitBaseInfo(recordInfo);

            return recordInfo;
        }
    }
}