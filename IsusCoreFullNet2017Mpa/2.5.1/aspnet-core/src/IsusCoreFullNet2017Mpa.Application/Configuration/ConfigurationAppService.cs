using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IsusCoreFullNet2017Mpa.Configuration.Dto;

namespace IsusCoreFullNet2017Mpa.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IsusCoreFullNet2017MpaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
