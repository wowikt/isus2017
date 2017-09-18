using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCore2017Spa.Sessions.Dto;

namespace IsusCore2017Spa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
