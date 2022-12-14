using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.Modularity.PlugIns;

namespace BasicProject.Web
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //原来是IOC 注册
            services.AddApplication<BaseProjectWebModule>(); //注册模块//abp 包装了一层，由BaseProjectWebModule 中的 ConfigureServices 完成同样的功能
            //services.AddApplication<BaseProjectWebModule>(option=>
            //{
            //    string curent = System.Environment.CurrentDirectory;
            //    string currentParent = Directory.GetParent(curent).ToString();

            //    option.PlugInSources.AddFolder(Path.Combine(currentParent, "Plugins"));
            //});
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //--以前是配置管道的
            app.InitializeApplication();//初始化app ，执行注册的Module 中的 ConfigureServices
            
        }
    }
}
