using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IWF_FlowProcess
    {
        bool Add(Parking.Core.Model.WF_FlowProcess model);
    }
}