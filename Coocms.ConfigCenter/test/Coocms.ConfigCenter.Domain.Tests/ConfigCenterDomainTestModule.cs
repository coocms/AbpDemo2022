using Coocms.ConfigCenter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Coocms.ConfigCenter;

[DependsOn(
    typeof(ConfigCenterEntityFrameworkCoreTestModule)
    )]
public class ConfigCenterDomainTestModule : AbpModule
{

}
