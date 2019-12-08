using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_PLUGIN_INFO
    {
        List<Parking.Core.Model.FN_PLUGIN_INFO> GetListTree(string WorkStationIP);
        List<Parking.Core.Model.FN_PLUGIN_INFO> GetPlugins(string ParentID, string WorkStationIP);
    }
}