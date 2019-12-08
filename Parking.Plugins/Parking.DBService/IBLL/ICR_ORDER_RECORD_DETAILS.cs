using System.Collections.Generic;
using Parking.Core.Record;
namespace Parking.DBService.IBLL
{
    public interface ICR_ORDER_RECORD_DETAILS
    {
        /// <summary>
        /// 删|?除y订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        bool DeleteByOrderCode(string OrderCode);
        /// <summary>
        /// 添?¨a加¨?信?息?é
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model);
        /// <summary>
        /// 删|?除y记?录?
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        bool Delete(string ID);
        /// <summary>
        /// 获?取¨?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> GetOrdersByInOutCode(string InOutCode);
        /// <summary>
        /// 获?取¨?详¨o细?订?单ì￡¤
        /// </summary>
        /// <param name="OrderCode"></param>
        /// <returns></returns>
        List<Parking.Core.Model.CR_ORDER_RECORD_DETAILS> GetDetailsByOrder(string OrderCode);
        /// <summary>
        /// 更¨1新?数oy据Y
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Update(Parking.Core.Model.CR_ORDER_RECORD_DETAILS model);
        /// <summary>
        /// 获?取¨?单ì￡¤个?订?单ì￡¤详¨o细?
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <returns></returns>
        Parking.Core.Model.CR_ORDER_RECORD_DETAILS GetOrderDetailsInfo(ProcessRecord recordInfo);
    }
}