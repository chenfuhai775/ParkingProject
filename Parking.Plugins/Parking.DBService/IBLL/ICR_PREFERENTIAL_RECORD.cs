using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Model;

namespace Parking.DBService.IBLL
{
    public interface ICR_PREFERENTIAL_RECORD
    {
        bool Add(Parking.Core.Model.CR_PREFERENTIAL_RECORD model);
        List<Parking.Core.Model.CR_PREFERENTIAL_RECORD> GetListByInOutRecordCode(string InOutRecordCode);
    }
}