using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_WORKSTATION_UI_CONFIG
    {
        Parking.Core.Model.FN_WORKSTATION_UI_CONFIG GetLayOutByIP(string IP);
    }
}