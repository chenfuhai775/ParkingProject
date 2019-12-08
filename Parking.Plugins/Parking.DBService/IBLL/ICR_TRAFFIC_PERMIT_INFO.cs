using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking.Core.Model;

namespace Parking.DBService.IBLL
{
    public interface ICR_TRAFFIC_PERMIT_INFO
    {
        List<IssueInfo> GetIssueInfo(string strWhere);
        List<IssueInfo> GetLostIssueInfo(string strWhere);
    }
}