using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IsusCore2017Mpa.Configuration.Dto;

namespace IsusCore2017Mpa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IsusCore2017MpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
