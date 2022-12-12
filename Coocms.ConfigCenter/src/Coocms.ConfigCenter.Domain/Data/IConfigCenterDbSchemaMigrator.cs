using System.Threading.Tasks;

namespace Coocms.ConfigCenter.Data;

public interface IConfigCenterDbSchemaMigrator
{
    Task MigrateAsync();
}
