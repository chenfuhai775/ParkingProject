using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPL_ACCESS_RIGHTS_MANAGERS
    {
        Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS GetModelByVEHICLE_NO(string VEHICLE_NO);
    }
}
