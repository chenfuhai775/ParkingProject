using System.Data;

namespace Parking.DBService.IBLL
{
    public interface ICR_INOUT_RECODE_IMG
    {
        bool Add(Parking.Core.Model.CR_INOUT_RECODE_IMG model);
        Parking.Core.Model.CR_INOUT_RECODE_IMG GetModel(string ID);
        DataSet GetList(string strWhere);
        bool Update(Parking.Core.Model.CR_INOUT_RECODE_IMG model);
    }
}