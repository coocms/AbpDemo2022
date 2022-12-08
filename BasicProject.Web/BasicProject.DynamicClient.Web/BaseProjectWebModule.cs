using BasicProject.Application;
using BasicProject.Application.Contracts;
using BasicProject.DynamicClient.HttpApi.Client;

using DashboardCenter.Application.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace BasicProject.DynamicClient.Web
{
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]//通过特性来申明依赖，会在程序启动过程中，先加载这个类，执行其初始化方法
    [DependsOn(typeof(BasicProjectApplicationModule))]
    [DependsOn(typeof(BasicProjectApplicationContractsModule))]

    [DependsOn(typeof(DashboardCenterApplicationContractsModule))]
    [DependsOn(typeof(BasicProjectDynamicClientHttpApiClientModule))]
    public class BaseProjectWebModule:AbpModule
    {
        /// <summary>
        /// 代替StartUp 中 ConfigureServices
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureSwaggerServices(context.Services);

            //配置options
            base.Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers
                .Create(typeof(BasicProjectApplicationModule).Assembly);

            });

        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "BasicProject API");
            });
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private void ConfigureSwaggerServices(IServiceCollection services)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "BasicProject API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                }
            );
        }
    }
}
