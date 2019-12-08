using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface ISystem_DbHelper
    {
        bool IsConnection();
        bool SynchronizationLocationTime();
    }
}