using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Parking.DBService.IBLL
{
    public interface ICR_PARK_EXCHANGE
    {
        bool Add(Parking.Core.Model.CR_PARK_EXCHANGE model);
        Parking.Core.Model.CR_PARK_EXCHANGE GetModelByAccount(string USER_ACCOUNT, string WORKSTATION_NO);
        bool Update(Parking.Core.Model.CR_PARK_EXCHANGE model);
        DataSet GetList(string strWhere);
    }
}