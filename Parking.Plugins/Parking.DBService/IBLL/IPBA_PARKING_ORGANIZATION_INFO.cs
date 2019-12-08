using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking.Core.Model;
using Parking.Core.Oragnization;

namespace Parking.DBService.IBLL
{
    public interface IPBA_PARKING_ORGANIZATION_INFO
    {
        List<Parking.Core.Model.PBA_PARKING_ORGANIZATION_INFO> GetTreeDeviceByIP(string IP);
        List<Equipment> GetOragnizationInfo();
    }
}