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
            //ԭ����IOC ע��
            services.AddApplication<BaseProjectWebModule>(); //ע��ģ��//abp ��װ��һ�㣬��BaseProjectWebModule �е� ConfigureServices ���ͬ���Ĺ���
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
            //--��ǰ�����ùܵ���
            app.InitializeApplication();//��ʼ��app ��ִ��ע���Module �е� ConfigureServices
            
        }
    }
}
