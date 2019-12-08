using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.DBService.IBLL
{
    public interface IFN_MODEL_UI_MANAGER
    {
        Parking.Core.Model.FN_MODEL_UI_MANAGER GetModel(string modelCode);
    }
}