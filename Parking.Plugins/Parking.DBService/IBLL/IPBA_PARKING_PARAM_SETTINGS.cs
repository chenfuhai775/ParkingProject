using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPBA_PARKING_PARAM_SETTINGS
    {
        bool Update(Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS model);
        List<Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS> GetModelList(string sqlWhere);
        Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS GetParkingParamByIP(string IP);
        Parking.Core.Model.PBA_PARKING_PARAM_SETTINGS GetVersionInfo(string organizationCode);
    }
}