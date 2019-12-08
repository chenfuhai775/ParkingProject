using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IBAS_SYSTEM_USER
    {
        Parking.Core.Model.BAS_SYSTEM_USER Login(string userName, string Pwd);
        Parking.Core.Model.BAS_SYSTEM_USER GetModel(string ID);
    }
}