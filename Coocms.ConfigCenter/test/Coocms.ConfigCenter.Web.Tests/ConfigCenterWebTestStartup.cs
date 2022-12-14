using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Coocms.ConfigCenter;

public class ConfigCenterWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ConfigCenterWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
