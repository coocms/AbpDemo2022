using DashboardCenter.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace DashboardCenter.Application
{
    /// <summary>
    /// 这里不能啥都不干了，需要配置Depends 依赖，
    /// 就像积木拼装，模块需要显示申明自己依赖了那些模块
    /// </summary>
    //[DependsOn(typeof(DashboardCenterApplicationContractsModule))]// 依赖某个模块
    public class DashboardCenterApplicationModule: AbpModule
    {
        /// <summary>
        /// DI 配置
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //base.ConfigureServices(context);
        }
    }
}
