using Abp.Authorization;
using Isus2017CoreSpa.Authorization.Roles;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace Isus2017CoreSpa.Authorization.Users
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
