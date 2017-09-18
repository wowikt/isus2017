using System.Threading.Tasks;
using Abp.Application.Services;
using Isus2017CoreSpa.Authorization.Accounts.Dto;

namespace Isus2017CoreSpa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
