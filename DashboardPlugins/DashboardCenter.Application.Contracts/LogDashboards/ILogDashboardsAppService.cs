using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardCenter.Application.Contracts.LogDashboards
{
    /// <summary>
    /// 定义服务接口
    /// </summary>
    public interface ILogDashboardsAppService
    {
        public LogDto GetLogDashboardsAsync();
    }
}
