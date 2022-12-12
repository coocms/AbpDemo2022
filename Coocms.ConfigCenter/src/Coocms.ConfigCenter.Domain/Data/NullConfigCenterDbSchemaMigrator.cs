using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Coocms.ConfigCenter.Data;

/* This is used if database provider does't define
 * IConfigCenterDbSchemaMigrator implementation.
 */
public class NullConfigCenterDbSchemaMigrator : IConfigCenterDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
