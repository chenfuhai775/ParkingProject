using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IBAS_SYSTEM_DATA_DICT
    {
        bool Add(Parking.Core.Model.BAS_SYSTEM_DATA_DICT model);
        bool Update(Parking.Core.Model.BAS_SYSTEM_DATA_DICT model);
        bool Delete(string ID);
        List<Parking.Core.Model.BAS_SYSTEM_DATA_DICT> GetListByParentModelKey(string ModelKey);
    }
}