using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCoreFullNet2017Mpa.Sessions.Dto;

namespace IsusCoreFullNet2017Mpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
