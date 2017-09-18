using Abp.Authorization;
using IsusCore2017Mpa.Authorization.Roles;
using IsusCore2017Mpa.Authorization.Users;
using IsusCore2017Mpa.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace IsusCore2017Mpa.Identity
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