using System.Threading.Tasks;
using Isus2017CoreSpa.Configuration.Dto;

namespace Isus2017CoreSpa.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}