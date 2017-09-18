using System.Threading.Tasks;
using Abp.Application.Services;
using Isus2017Spa.Configuration.Dto;

namespace Isus2017Spa.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}