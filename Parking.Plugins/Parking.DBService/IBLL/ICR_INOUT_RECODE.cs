using System.Collections.Generic;
using Parking.Core.Record;
using System.Data;
using Parking.Core.Model;

namespace Parking.DBService.IBLL
{
    public interface ICR_INOUT_RECODE
    {
        bool Add(Parking.Core.Model.CR_INOUT_RECODE model);
        bool Delete(string ID);
        Parking.Core.Model.CR_INOUT_RECODE GetInSideCarNo(Parking.Core.Model.CR_INOUT_RECODE recordInfo);
        bool DelInSideRecord(string VEHICLE_NO);
        bool Update(Parking.Core.Model.CR_INOUT_RECODE model);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        Parking.Core.Model.CR_INOUT_RECODE GetModel(string ID);
        Parking.Core.Model.CR_INOUT_RECODE GetModelByVehicleNo(string VEHICLE_NO);
        Parking.Core.Model.CR_INOUT_RECODE GetModel(string Vehicle, string InTime);
        int GetPartitionCount(string IN_PARTITION_CODE, int CREDENTIALS_TYPE);
        decimal GetOneDayTotalMoney(CR_ORDER_RECORD_DETAILS recordInfo);
        decimal GetMultipleMoney(CR_ORDER_RECORD_DETAILS recordInfo);
        decimal GetExceed24HourMoney(CR_ORDER_RECORD_DETAILS recordInfo);
        decimal GetNowDayTotalMoney(CR_ORDER_RECORD_DETAILS recordInfo);
        bool VehicleExists(string VEHICLE_NO);
        List<Parking.Core.Model.CR_INOUT_RECODE> GetInOccupyRecordList(ProcessRecord recordInfo);
        List<Parking.Core.Model.CarInSideInfo> GetInSideList(string strWhere, int currPageIndex, int pageSize, out int recordCount, out int pageCount);
    }  
}