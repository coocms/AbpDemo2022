using Coocms.ConfigCenter.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Coocms.ConfigCenter.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ConfigCenterEntityFrameworkCoreModule),
    typeof(ConfigCenterApplicationContractsModule)
    )]
public class ConfigCenterDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
