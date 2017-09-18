using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Isus2017Spa.Configuration.Dto;

namespace Isus2017Spa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Isus2017SpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
