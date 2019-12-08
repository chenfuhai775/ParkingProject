using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_LAYOUT_SUBJECT
    {
        List<Parking.Core.Model.FN_LAYOUT_SUBJECT> GetPlugins(string WorkStationID, string PluginName = "1");
    }
}