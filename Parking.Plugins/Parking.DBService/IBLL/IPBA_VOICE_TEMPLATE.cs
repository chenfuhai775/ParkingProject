using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IPBA_VOICE_TEMPLATE
    {
        Parking.Core.Model.PBA_VOICE_TEMPLATE GetModelByType(int MODEL_TYPE, int UNIT_TYPE);
    }
}