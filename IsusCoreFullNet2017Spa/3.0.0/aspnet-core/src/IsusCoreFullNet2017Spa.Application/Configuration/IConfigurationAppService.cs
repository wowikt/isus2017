using System.Threading.Tasks;
using IsusCoreFullNet2017Spa.Configuration.Dto;

namespace IsusCoreFullNet2017Spa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}