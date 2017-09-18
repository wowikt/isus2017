using Abp.Authorization;
using Isus2017CoreSpa.Authorization.Roles;
using Isus2017CoreSpa.Authorization.Users;
using Isus2017CoreSpa.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace Isus2017CoreSpa.Identity
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