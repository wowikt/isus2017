using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCoreFullNet2017Spa.Sessions.Dto;

namespace IsusCoreFullNet2017Spa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
