using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Parking.Core.Infrastructure.DependencyManagement;
using Parking.Core.Enum;
using Parking.Core.Interface;
using Parking.DBService.BLL;
using Parking.Core.Caching;
using Parking.DBService.IBLL;
using Parking.Drives;
using Parking.ChargeStandard;

namespace Parking.WorkBench
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, Core.Infrastructure.ITypeFinder typeFinder, Core.Configuration.ParkingConfig config)
        {
            //缓存
            builder.RegisterType<MemoryCacheManager>().As<ICacheManager>().SingleInstance();
            builder.RegisterType<CheckPointBase>().SingleInstance();
            //转换类
            builder.RegisterType<PlatRecordConvert>().Named<IRecordConvert>(enumReleaseType.PlateRecognition.ToString()).As<IRecordConvert>();
            builder.RegisterType<HandReleaseConvert>().Named<IRecordConvert>(enumReleaseType.HandRelease.ToString()).As<IRecordConvert>();
            builder.RegisterType<UnlicensedCarCovert>().Named<IRecordConvert>(enumReleaseType.UnlicensedCar.ToString()).As<IRecordConvert>();
            //通道
            builder.RegisterType<ChannelEngine>().Named<IChannel>(enumChannelType.chn_in.ToString()).As<IChannel>();
            builder.RegisterType<ChannelEngine>().Named<IChannel>(enumChannelType.chn_out.ToString()).As<IChannel>();
            builder.RegisterType<ChannelEngine>().Named<IChannel>(enumChannelType.centerPayment.ToString()).As<IChannel>();
            //收费标准
            builder.RegisterType<CHARGE_TYPE_UNIT_TIME>().Named<IChargeStandard>(enumChargeStandardType.unitTime.ToString()).As<IChargeStandard>().SingleInstance();
            builder.RegisterType<CHARGE_TYPE_TOTAL_LENGTH>().Named<IChargeStandard>(enumChargeStandardType.totalLength.ToString()).As<IChargeStandard>().SingleInstance();
            builder.RegisterType<CHARGE_TYPE_DAY_NIGHT>().Named<IChargeStandard>(enumChargeStandardType.dayNight.ToString()).As<IChargeStandard>().SingleInstance();
            builder.RegisterType<CHARGE_TYPE_CHARGE_NUMBER>().Named<IChargeStandard>(enumChargeStandardType.chargeNumber.ToString()).As<IChargeStandard>().SingleInstance();
            builder.RegisterType<CHARGE_TYPE_TIME>().Named<IChargeStandard>(enumChargeStandardType.chargeTime.ToString()).As<IChargeStandard>().SingleInstance();
            //支付方式
            builder.RegisterType<WeiXinMethod>().Named<IPayMethod>(enumPayMethod.WeChatPay.ToString()).As<IPayMethod>().SingleInstance();
            builder.RegisterType<WeiXinMethod>().Named<IPayMethod>(enumPayMethod.AliPay.ToString()).As<IPayMethod>().SingleInstance();
            //优惠打折
            builder.RegisterType<CashDiscount>().Named<IDiscount>(enumPreferentialType.CASH_TICKET.ToString()).As<IDiscount>().SingleInstance();
            builder.RegisterType<PercentageDiscount>().Named<IDiscount>(enumPreferentialType.DISCOUNT.ToString()).As<IDiscount>().SingleInstance();
            builder.RegisterType<ManualDiscount>().Named<IDiscount>(enumPreferentialType.REDUCTION.ToString()).As<IDiscount>().SingleInstance();
            //检查点
            builder.RegisterType<InStockCheck>().Named<ICheck>(enumCheckPointType.InStock.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<PlateCorrectonCheck>().Named<ICheck>(enumCheckPointType.PlateCorrection.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<ShowRecordCheck>().Named<ICheck>(enumCheckPointType.ShowRecord.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<OpenGateCheck>().Named<ICheck>(enumCheckPointType.OpenGate.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<IsInSideCheck>().Named<ICheck>(enumCheckPointType.IsInSide.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<IsOutSideCheck>().Named<ICheck>(enumCheckPointType.IsOutSide.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<ChargingCheck>().Named<ICheck>(enumCheckPointType.Charging.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<ShowChargeCheck>().Named<ICheck>(enumCheckPointType.ShowCharge.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<OutStockCheck>().Named<ICheck>(enumCheckPointType.OutStock.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<OpenInConfirmGateCheck>().Named<ICheck>(enumCheckPointType.OpenInConfirmGate.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<GenerateOrderCheck>().Named<ICheck>(enumCheckPointType.GenerateOrder.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<IsInAuthenticationCheck>().Named<ICheck>(enumCheckPointType.InAuthentication.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<IsOutAuthenticationCheck>().Named<ICheck>(enumCheckPointType.OutAuthentication.ToString()).As<ICheck>().SingleInstance();
            builder.RegisterType<SaveDiscountsCheck>().Named<ICheck>(enumCheckPointType.SaveDiscounts.ToString()).As<ICheck>().SingleInstance();
            
            //数据库
            builder.RegisterType<BAS_SYSTEM_USER>().As<IBAS_SYSTEM_USER>().SingleInstance();
            builder.RegisterType<CR_INOUT_RECODE>().As<ICR_INOUT_RECODE>().SingleInstance();
            builder.RegisterType<FN_MODEL_UI_MANAGER>().As<IFN_MODEL_UI_MANAGER>().SingleInstance();
            builder.RegisterType<FN_PLUGIN_INFO>().As<IFN_PLUGIN_INFO>().SingleInstance();
            builder.RegisterType<FN_WORKSTATION_UI_CONFIG>().As<IFN_WORKSTATION_UI_CONFIG>().SingleInstance();
            builder.RegisterType<PBA_PARKING_ORGANIZATION_INFO>().As<IPBA_PARKING_ORGANIZATION_INFO>().SingleInstance();
            builder.RegisterType<PBA_PARKING_PARAM_SETTINGS>().As<IPBA_PARKING_PARAM_SETTINGS>().SingleInstance();
            builder.RegisterType<CR_PARK_EXCHANGE>().As<ICR_PARK_EXCHANGE>().SingleInstance();
            builder.RegisterType<WF_ProcessNode>().As<IWF_ProcessNode>().SingleInstance();
            builder.RegisterType<PBA_VOICE_TEMPLATE>().As<IPBA_VOICE_TEMPLATE>().SingleInstance();
            builder.RegisterType<PBA_CHARGE_INFO>().As<IPBA_CHARGE_INFO>().SingleInstance();
            builder.RegisterType<CR_LICENSE_CORRECT_RECORD>().As<ICR_LICENSE_CORRECT_RECORD>().SingleInstance();
            builder.RegisterType<WF_FlowProcess>().As<IWF_FlowProcess>().SingleInstance();
            builder.RegisterType<CR_ORDER_RECORD_INFO>().As<ICR_ORDER_RECORD_INFO>().SingleInstance();
            builder.RegisterType<BAS_SYSTEM_DATA_DICT>().As<IBAS_SYSTEM_DATA_DICT>().SingleInstance();
            builder.RegisterType<CR_TRAFFIC_PERMIT_INFO>().As<ICR_TRAFFIC_PERMIT_INFO>().SingleInstance();
            builder.RegisterType<CR_PREFERENTIAL_PHYSICAL>().As<ICR_PREFERENTIAL_PHYSICAL>().SingleInstance();
            builder.RegisterType<PL_BLACK_WHITE_MANAGER>().As<IPL_BLACK_WHITE_MANAGER>().SingleInstance();
            builder.RegisterType<CR_INOUT_RECODE_IMG>().As<ICR_INOUT_RECODE_IMG>().SingleInstance();
            builder.RegisterType<System_DbHelper>().As<ISystem_DbHelper>().SingleInstance();
            builder.RegisterType<FN_LAYOUT_MAIN>().As<IFN_LAYOUT_MAIN>().SingleInstance();
            builder.RegisterType<FN_LAYOUT_SUBJECT>().As<IFN_LAYOUT_SUBJECT>().SingleInstance();
            builder.RegisterType<CR_INOUT_RECODE_ARCHIVE>().As<ICR_INOUT_RECODE_ARCHIVE>().SingleInstance();
            builder.RegisterType<CR_ACCESS_PERMISSION_INFO>().As<ICR_ACCESS_PERMISSION_INFO>().SingleInstance();
            builder.RegisterType<CR_CHARGES_LOG>().As<ICR_CHARGES_LOG>().SingleInstance();
            builder.RegisterType<CR_PREFERENTIAL_RECORD>().As<ICR_PREFERENTIAL_RECORD>().SingleInstance();
            builder.RegisterType<CR_ORDER_RECORD_DETAILS>().As<ICR_ORDER_RECORD_DETAILS>().SingleInstance();
            builder.RegisterType<PBA_PARKING_SPACE_MANAGER>().As<IPBA_PARKING_SPACE_MANAGER>().SingleInstance();
            builder.RegisterType<PBA_OWNER_INFO>().As<IPBA_OWNER_INFO>().SingleInstance();
            builder.RegisterType<PBA_OWNER_ORGANIZATION>().As<IPBA_OWNER_ORGANIZATION>().SingleInstance();
            builder.RegisterType<UP_SEND_MESSAGE>().As<IUP_SEND_MESSAGE>().SingleInstance();
            builder.RegisterType<PL_ACCESS_RIGHTS_MANAGERS>().As<IPL_ACCESS_RIGHTS_MANAGERS>().SingleInstance();
            builder.RegisterType<FN_MONITOR_UPDATE_INFO>().As<IFN_MONITOR_UPDATE_INFO>().SingleInstance();
            builder.RegisterType<FN_MONITOR_VERSION_INFO>().As<IFN_MONITOR_VERSION_INFO>().SingleInstance();
            //摄像头驱动,一定不是单列
            builder.RegisterType<ZSCameraManage>().Named<ICamera>(enumDeviceType.XZI.ToString()).As<ZSCameraManage>();
            builder.RegisterType<ZXIICameraManage>().Named<ICamera>(enumDeviceType.XZII.ToString()).As<ZXIICameraManage>();
            //单板驱动
            builder.RegisterType<LNKControlPanelManage>().Named<IControlPanel>(enumDeviceType.LonixControlPanelI.ToString()).As<LNKControlPanelManage>().SingleInstance();
            //显示屏驱动
            builder.RegisterType<LNKControlPanelManage>().As<ILEDScreen>().SingleInstance();
        }

        public int Order
        {
            get { return 100; }
        }
    }
}