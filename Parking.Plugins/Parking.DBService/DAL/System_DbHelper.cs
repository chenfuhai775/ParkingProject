using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Parking.DBService.DBUtility;

namespace Parking.DBService.DAL
{
    public class System_DbHelper
    {
        public bool IsConnection()
        {
            return DbHelperSQL.IsConnect();
        }
        public bool SynchronizationLocationTime()
        {
            return DbHelperSQL.SynchronizationLocationTime();
        }
    }

}