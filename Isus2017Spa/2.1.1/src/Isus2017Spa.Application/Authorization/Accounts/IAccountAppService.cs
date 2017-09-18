using System.Threading.Tasks;
using Abp.Application.Services;
using Isus2017Spa.Authorization.Accounts.Dto;

namespace Isus2017Spa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
