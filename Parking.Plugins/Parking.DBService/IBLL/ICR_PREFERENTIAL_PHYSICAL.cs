using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking.Core.Model;

namespace Parking.DBService.IBLL
{
    public interface ICR_PREFERENTIAL_PHYSICAL
    {
        List<CRPreferentialDetails> GetPhysicalByCodeNo(string Preferentia_Ident);
        List<CRPreferentialDetails> GetPhysicalByVehicleNo(string Vehicle_No);
        bool update(string idEnt, int statues);
    }
}