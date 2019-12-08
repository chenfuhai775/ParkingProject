using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPBA_OWNER_INFO
    {
        List<Parking.Core.Model.OwnerInfo> GetOwnerInfo(string strWhere, int currPageIndex, int pageSize, out int recordCount, out int pageCount);
        Parking.Core.Model.PBA_OWNER_INFO GetModel(string OWNER_CODE);
        bool Update(Parking.Core.Model.PBA_OWNER_INFO model);
    }
}