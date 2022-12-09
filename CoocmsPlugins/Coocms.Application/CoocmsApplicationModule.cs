using Coocms.Application.Contracts;
using Volo.Abp.Modularity;

namespace Coocms.Application
{
    [DependsOn(typeof(CoocmsApplicationContractsModule))]
    public class CoocmsApplicationModule:AbpModule
    {

    }
}