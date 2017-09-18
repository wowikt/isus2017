using System.Threading.Tasks;
using Abp.Application.Services;
using Isus2017CoreSpa.Sessions.Dto;

namespace Isus2017CoreSpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
