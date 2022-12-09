using Coocms.Application;
using Volo.Abp.Modularity;
using Volo.Abp.AspNetCore.Mvc;
namespace Coocms.HttpApi
{
    [DependsOn(typeof(CoocmsApplicationModule))]
    public class CoocmsHttpApiModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //配置options
            base.Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers
                .Create(typeof(CoocmsApplicationModule).Assembly);
            });//Auto Api 暴露
        }
    }
}