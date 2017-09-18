using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCore2017Mpa.Sessions.Dto;

namespace IsusCore2017Mpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
