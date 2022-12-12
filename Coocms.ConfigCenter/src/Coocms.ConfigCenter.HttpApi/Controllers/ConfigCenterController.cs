using Coocms.ConfigCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Coocms.ConfigCenter.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ConfigCenterController : AbpControllerBase
{
    protected ConfigCenterController()
    {
        LocalizationResource = typeof(ConfigCenterResource);
    }
}
