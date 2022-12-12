using Coocms.ConfigCenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Coocms.ConfigCenter.Permissions;

public class ConfigCenterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ConfigCenterPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ConfigCenterPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ConfigCenterResource>(name);
    }
}
