using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Isus2017CoreSpa.Configuration.Dto;

namespace Isus2017CoreSpa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Isus2017CoreSpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
