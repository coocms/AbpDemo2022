using BasicProject.Application.Contracts;
using BasicProject.Application.Contracts.Users;
using BasicProject.Application.Users;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BasicProject.Application
{
    [DependsOn(typeof(BasicProjectApplicationContractsModule))]
    public class BasicProjectApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<IUserAppService, UserAppService>();//这才是模块化的做法
        }
    }
}