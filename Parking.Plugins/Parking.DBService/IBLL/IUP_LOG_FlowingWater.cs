using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Parking.DBService.IBLL
{
    public interface IUP_LOG_FlowingWater
    {
        bool Add(Parking.Core.Model.UP_LOG_FlowingWater model);
    }
}