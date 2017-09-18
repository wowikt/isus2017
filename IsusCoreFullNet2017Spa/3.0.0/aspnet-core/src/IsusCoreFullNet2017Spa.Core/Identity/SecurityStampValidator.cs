using Abp.Authorization;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace IsusCoreFullNet2017Spa.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(options, signInManager, systemClock)
        {
        }
    }
}