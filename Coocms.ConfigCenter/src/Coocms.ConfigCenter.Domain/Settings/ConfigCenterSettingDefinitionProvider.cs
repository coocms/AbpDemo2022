using Volo.Abp.Settings;

namespace Coocms.ConfigCenter.Settings;

public class ConfigCenterSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ConfigCenterSettings.MySetting1));
    }
}
