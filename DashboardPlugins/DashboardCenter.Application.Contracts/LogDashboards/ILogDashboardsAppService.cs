using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace DashboardCenter.Application.Contracts.LogDashboards
{
    /// <summary>
    /// 定义服务接口
    /// </summary>
    public interface ILogDashboardsAppService:IRemoteService, ITransientDependency
    {
        public LogDto GetLogDashboardsAsync();
    }
}
