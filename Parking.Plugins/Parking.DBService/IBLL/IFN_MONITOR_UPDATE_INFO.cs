using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_MONITOR_UPDATE_INFO
    {
        Parking.Core.Model.FN_MONITOR_UPDATE_INFO GetByWorkStationCode(string WorkStationCode);
        bool Update(Parking.Core.Model.FN_MONITOR_UPDATE_INFO model);
    }
}
