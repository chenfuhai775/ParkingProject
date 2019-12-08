using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking.Core.Model;

namespace Parking.DBService.IBLL
{
    public interface IPBA_OWNER_ORGANIZATION
    {
        List<Parking.Core.Model.PBA_OWNER_ORGANIZATION> GetModelList(string strWhere);
    }
}