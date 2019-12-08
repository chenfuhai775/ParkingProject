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
    public class UnlicensedCarCovert : RecordConvertBase, IRecordConvert
    {
        public ProcessRecord ConvertRecord(DataUploadEventArgs data)
        {
            ProcessRecord recordInfo = new ProcessRecord();
            //车牌号码
            recordInfo.INOUT_RECODE.VEHICLE_NO = data.TempRecordInfo.plateNum;
            //特征码
            recordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER = data.TempRecordInfo.INOUT_RECODE.UNIQUE_IDENTIFIER;
            //是否发送短信
            recordInfo.SendSMS = data.TempRecordInfo.SendSMS;
            //手机号码
            recordInfo.Phone = data.TempRecordInfo.Phone;
            //通道编号
            recordInfo.CHN_CODE = data.TempRecordInfo.CHN_CODE;
            //通道名称
            recordInfo.CHN_NAME = data.TempRecordInfo.CHN_NAME;

            //分区信息
            var parentsList = CommHelper.GetOrgInfos(recordInfo.CHN_CODE, false);
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

            //获取操作员信息
            if (null != GlobalEnvironment.LocalUserInfo)
            {
                recordInfo.OPERATOR_ID = GlobalEnvironment.LocalUserInfo.USER_ID;
                recordInfo.OPERATOR_NAME = GlobalEnvironment.LocalUserInfo.USER_NAME;
            }
            //车牌号码
            recordInfo.INOUT_RECODE.VEHICLE_NO = data.TempRecordInfo.plateNum;
            //入场类型
            recordInfo.PARK_TYPE = "无牌车放行";
            //刷卡时间
            recordInfo.REPORTIMG_TIME = data.TempRecordInfo.REPORTIMG_TIME;
            //出入场类型
            recordInfo.CHANNEL_TYPE = data.TempRecordInfo.CHANNEL_TYPE;
            //抓拍图片
            recordInfo.PicFullName = data.TempRecordInfo.fullPicName;
            //初始化公共信息
            base.InitBaseInfo(recordInfo);

            return recordInfo;
        }
    }
}