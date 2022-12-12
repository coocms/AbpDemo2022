using System;
using System.Collections.Generic;
using System.Text;
using Coocms.ConfigCenter.Localization;
using Volo.Abp.Application.Services;

namespace Coocms.ConfigCenter;

/* Inherit your application services from this class.
 */
public abstract class ConfigCenterAppService : ApplicationService
{
    protected ConfigCenterAppService()
    {
        LocalizationResource = typeof(ConfigCenterResource);
    }
}
