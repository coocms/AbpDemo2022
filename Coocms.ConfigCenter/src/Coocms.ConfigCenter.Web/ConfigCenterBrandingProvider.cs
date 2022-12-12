using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Coocms.ConfigCenter.Web;

[Dependency(ReplaceServices = true)]
public class ConfigCenterBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ConfigCenter";
}
