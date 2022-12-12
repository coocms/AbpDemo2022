using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Coocms.ConfigCenter.Data;
using Volo.Abp.DependencyInjection;

namespace Coocms.ConfigCenter.EntityFrameworkCore;

public class EntityFrameworkCoreConfigCenterDbSchemaMigrator
    : IConfigCenterDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreConfigCenterDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ConfigCenterDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ConfigCenterDbContext>()
            .Database
            .MigrateAsync();
    }
}
