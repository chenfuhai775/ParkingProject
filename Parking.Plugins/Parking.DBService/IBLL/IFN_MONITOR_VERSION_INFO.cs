using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_MONITOR_VERSION_INFO
    {
        Parking.Core.Model.FN_MONITOR_VERSION_INFO GetByVersion(string Version);
    }
}
