using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IsusCore2017Spa.Configuration.Dto;

namespace IsusCore2017Spa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IsusCore2017SpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
