using Abp.Authorization;
using IsusCore2017Spa.Authorization.Roles;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace IsusCore2017Spa.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(
            UserManager userManager,
            RoleManager roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(
                  userManager,
                  roleManager,
                  optionsAccessor)
        {
        }
    }
}
