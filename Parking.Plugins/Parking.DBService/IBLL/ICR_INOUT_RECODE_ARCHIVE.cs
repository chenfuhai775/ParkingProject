using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking.Core.Record;

namespace Parking.DBService.IBLL
{
    public interface ICR_INOUT_RECODE_ARCHIVE
    {
        bool Add(Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model);
        bool Delete(string ID);
        bool Update(Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE model);
        Parking.Core.Model.CR_INOUT_RECODE_ARCHIVE GetModel(string ID);
        int GetInOutCount(Parking.Core.Model.PL_ACCESS_RIGHTS_MANAGERS model);
    }
}