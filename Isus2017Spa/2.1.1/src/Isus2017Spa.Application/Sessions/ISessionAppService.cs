using System.Threading.Tasks;
using Abp.Application.Services;
using Isus2017Spa.Sessions.Dto;

namespace Isus2017Spa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
