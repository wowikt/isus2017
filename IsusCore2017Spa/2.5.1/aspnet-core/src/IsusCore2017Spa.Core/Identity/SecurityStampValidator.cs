using Abp.Authorization;
using IsusCore2017Spa.Authorization.Roles;
using IsusCore2017Spa.Authorization.Users;
using IsusCore2017Spa.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace IsusCore2017Spa.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}