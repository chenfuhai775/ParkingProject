using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Model;
using System.Data;

namespace Parking.DBService.IBLL
{
    public interface IPBA_CHARGE_INFO
    {
        PBA_CHARGE_INFO getChargeInfo(string ChargeCode, ref Dictionary<string, string> Attributes);
        DataTable getChargeList();
        Parking.Core.Model.PBA_CHARGE_INFO GetModel(string CHARGE_CODE);
    }
}