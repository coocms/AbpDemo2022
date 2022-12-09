using BasicProject.Application.Contracts;
using BasicProject.Application.Contracts.Users;
using BasicProject.Application.Users;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace BasicProject.Application
{
    [DependsOn(typeof(BasicProjectApplicationContractsModule))]
    public class BasicProjectApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($" {MethodInfo.GetCurrentMethod()!.Name} Called ");
            Console.BackgroundColor = ConsoleColor.Black;

            //配置options
            base.Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers
                .Create(typeof(BasicProjectApplicationModule).Assembly);
            });

            //context.Services.AddSingleton<IUserAppService, UserAppService>();//这才是模块化的做法
        }
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            //程序初始化， 等同Startup 里面的Configure
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($" {MethodInfo.GetCurrentMethod()!.Name} Called ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($" {MethodInfo.GetCurrentMethod()!.Name} Called ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

}