using System.Threading.Tasks;
using IsusCore2017Mpa.Configuration.Dto;

namespace IsusCore2017Mpa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}