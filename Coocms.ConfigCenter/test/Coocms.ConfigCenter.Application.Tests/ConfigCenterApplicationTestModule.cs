using Volo.Abp.Modularity;

namespace Coocms.ConfigCenter;

[DependsOn(
    typeof(ConfigCenterApplicationModule),
    typeof(ConfigCenterDomainTestModule)
    )]
public class ConfigCenterApplicationTestModule : AbpModule
{

}
