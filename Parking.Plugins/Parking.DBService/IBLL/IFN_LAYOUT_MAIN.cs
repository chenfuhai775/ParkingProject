using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_LAYOUT_MAIN
    {
        Parking.Core.Model.FN_LAYOUT_MAIN GetLayOutByIP(string strIP);
        Parking.Core.Model.FN_LAYOUT_MAIN GetLayOutByWORKSTATION(string strIP);
    }
}