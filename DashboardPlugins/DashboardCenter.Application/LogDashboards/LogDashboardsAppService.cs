using DashboardCenter.Application.Contracts.LogDashboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace DashboardCenter.Application.LogDashboards
{
    /// <summary>
    /// 服务的具体实现
    /// </summary>
    public class LogDashboardsAppService :
        ILogDashboardsAppService,ITransientDependency,IRemoteService
    {
        public LogDto GetLogDashboardsAsync()
        {
            Console.WriteLine("GetLogDashboardsAsync");


            return new LogDto()
            {
                Id = 123,
                Description = "cooc",
                Name = "coocms"
            };
        }
    }
}
