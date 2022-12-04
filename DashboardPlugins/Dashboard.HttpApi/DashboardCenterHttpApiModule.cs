using DashboardCenter.Application;
using DashboardCenter.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Dashboard.HttpApi
{
    [DependsOn(typeof(DashboardCenterApplicationModule))]
    public class DashboardCenterHttpApiModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //配置options
            base.Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers
                .Create(typeof(DashboardCenterApplicationModule).Assembly);
            });//Auto Api 暴露
        }
    }
}