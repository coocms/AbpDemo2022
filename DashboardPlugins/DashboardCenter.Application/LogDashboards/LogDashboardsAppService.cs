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
    //[RemoteService(IsEnabled = false)]//不暴露服务
    //[RemoteService(IsMetadataEnabled = false)] //不暴露给swagger
    public class LogDashboardsAppService :
        ILogDashboardsAppService
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
