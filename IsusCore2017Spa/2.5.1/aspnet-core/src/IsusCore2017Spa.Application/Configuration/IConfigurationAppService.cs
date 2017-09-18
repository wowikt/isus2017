using System.Threading.Tasks;
using IsusCore2017Spa.Configuration.Dto;

namespace IsusCore2017Spa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}