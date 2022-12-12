using Coocms.ConfigCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Coocms.ConfigCenter.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ConfigCenterPageModel : AbpPageModel
{
    protected ConfigCenterPageModel()
    {
        LocalizationResourceType = typeof(ConfigCenterResource);
    }
}
