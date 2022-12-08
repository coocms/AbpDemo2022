using DashboardCenter.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace BasicProject.DynamicClient.HttpApi.Client
{
    [DependsOn(typeof(AbpHttpClientModule))]//--动态api

    [DependsOn(typeof(DashboardCenterApplicationContractsModule))]//引用抽象


    public class BasicProjectDynamicClientHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Dashboard";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {


            context.Services.AddHttpClientProxies(
                typeof(DashboardCenterApplicationContractsModule).Assembly,
                RemoteServiceName,asDefaultServices:true
            );


        }
    }
}