using System.Threading.Tasks;
using Abp.Configuration;
using Abp.UI;
using Abp.Zero.Configuration;
using IsusCoreFullNet2017Spa.Authorization.Accounts.Dto;
using IsusCoreFullNet2017Spa.Authorization.IsusUsers;
using IsusCoreFullNet2017Spa.Authorization.Users;

namespace IsusCoreFullNet2017Spa.Authorization.Accounts
{
    public class AccountAppService : IsusCoreFullNet2017SpaAppServiceBase, IAccountAppService
    {
        private readonly UserRegistrationManager _userRegistrationManager;
        private readonly IsusUserManager _isusUserManager;

        public AccountAppService(UserRegistrationManager userRegistrationManager, IsusUserManager isusUserManager)
        {
            _userRegistrationManager = userRegistrationManager;
            _isusUserManager = isusUserManager;
        }

        public async Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input)
        {
            var tenant = await TenantManager.FindByTenancyNameAsync(input.TenancyName);
            if (tenant == null)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.NotFound);
            }

            if (!tenant.IsActive)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.InActive);
            }

            return new IsTenantAvailableOutput(TenantAvailabilityState.Available, tenant.Id);
        }

        public async Task<RegisterOutput> Register(RegisterInput input)
        {
            var isusUser = await _isusUserManager.FindUser(input.UserName);

            if (isusUser == null)
            {
                throw new UserFriendlyException(L("IsusUser.CantFind", input.UserName));
            }

            if (!_isusUserManager.TryUserLogin(isusUser, input.Password))
            {
                throw new UserFriendlyException(L("IsusUser.WrongPassword"));
            }

            var user = await _isusUserManager.CreateUserForIsusUserAsync(isusUser, input.Password);

            return new RegisterOutput
            {
                CanLogin = user.IsActive && user.IsEmailConfirmed,
            };
        }
    }
}