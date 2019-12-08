using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Record;

namespace Parking.DBService.IBLL
{
    public interface ICR_ACCESS_PERMISSION_INFO
    {
        bool HasPermit(ProcessRecord recordInfo);
    }
}