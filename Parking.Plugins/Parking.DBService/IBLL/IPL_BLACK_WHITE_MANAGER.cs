using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPL_BLACK_WHITE_MANAGER
    {
        /// <summary>
        ///  获取车牌号鉴权
        /// </summary>
        /// <param name="vehicle_no"></param>
        /// <returns></returns>
        int GetVEHICLE_NOType(string vehicle_no);
    }
}