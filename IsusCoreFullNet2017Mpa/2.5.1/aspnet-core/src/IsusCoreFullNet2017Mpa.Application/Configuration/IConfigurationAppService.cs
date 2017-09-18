using System.Threading.Tasks;
using IsusCoreFullNet2017Mpa.Configuration.Dto;

namespace IsusCoreFullNet2017Mpa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}