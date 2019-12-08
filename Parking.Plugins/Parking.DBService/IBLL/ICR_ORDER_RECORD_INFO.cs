using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parking.DBService.BLL;
namespace Parking.DBService.IBLL
{
    public interface ICR_ORDER_RECORD_INFO
    {
        bool Add(Parking.Core.Model.CR_ORDER_RECORD_INFO model);
        bool Update(Parking.Core.Model.CR_ORDER_RECORD_INFO model);
        List<Parking.Core.Model.CR_ORDER_RECORD_INFO> GetOrders(Parking.Core.Model.CR_INOUT_RECODE model);
        void CancelOrder(Parking.Core.Model.CR_ORDER_RECORD_INFO model);
        Parking.Core.Model.CR_ORDER_RECORD_INFO GetCurrentPartitionOrder(string CURR_PARTITION_CODE, string ID);
        Parking.Core.Model.CR_ORDER_RECORD_INFO GetModel(string ID);
        Core.Model.CR_ORDER_RECORD_INFO GetCurrentPartitionOrder(Core.Model.CR_INOUT_RECODE model);
        bool Delete(string ID);
    }
}