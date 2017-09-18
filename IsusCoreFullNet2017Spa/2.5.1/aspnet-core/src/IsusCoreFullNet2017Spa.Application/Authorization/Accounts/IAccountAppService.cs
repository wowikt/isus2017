using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCoreFullNet2017Spa.Authorization.Accounts.Dto;

namespace IsusCoreFullNet2017Spa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
