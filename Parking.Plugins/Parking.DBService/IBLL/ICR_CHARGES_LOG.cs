using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface ICR_CHARGES_LOG
    {
        bool Add(Parking.Core.Model.CR_CHARGES_LOG model);
        decimal GetTotalMoney(string VEHICLE_NO, DateTime InTime, DateTime OutTime, bool isDay = true);
        List<Parking.Core.Model.CR_CHARGES_LOG> GetListByInTime(string VEHICLE_NO, DateTime InTime);
        bool Update(Parking.Core.Model.CR_CHARGES_LOG model);
    }
}