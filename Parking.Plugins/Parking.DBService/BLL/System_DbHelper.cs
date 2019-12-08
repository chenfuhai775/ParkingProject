using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.DBService.IBLL;

namespace Parking.DBService.BLL
{
    public class System_DbHelper : ISystem_DbHelper
    {
        private readonly Parking.DBService.DAL.System_DbHelper dal = new Parking.DBService.DAL.System_DbHelper();
        public System_DbHelper()
        { }
        public bool IsConnection()
        {
            return dal.IsConnection();
        }
        public bool SynchronizationLocationTime()
        {
            return dal.SynchronizationLocationTime();
        }
    }
}