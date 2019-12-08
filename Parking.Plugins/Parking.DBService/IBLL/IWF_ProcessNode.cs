using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.Core.Enum;

namespace Parking.DBService.IBLL
{
    public interface IWF_ProcessNode
    {
        List<Parking.Core.Model.WF_ProcessNode> GetNodesByWFType(enumFlowType flowType);
    }
}