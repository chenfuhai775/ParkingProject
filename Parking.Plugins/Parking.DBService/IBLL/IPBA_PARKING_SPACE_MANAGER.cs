using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPBA_PARKING_SPACE_MANAGER
    {
        bool Update(Parking.Core.Model.PBA_PARKING_SPACE_MANAGER model);
        void UpdateStatus(string SPACE_CODE, int STATUS, string INOUT_RECORD_ID = "");
        Parking.Core.Model.PBA_PARKING_SPACE_MANAGER GetModelByINOUTID(string INOUT_RECORD_ID);
        bool IsSurplus(string VEHICLENO);
    }
}