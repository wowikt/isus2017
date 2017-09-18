using Abp.Authorization;
using IsusCoreFullNet2017Mpa.Authorization.Roles;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using IsusCoreFullNet2017Mpa.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace IsusCoreFullNet2017Mpa.Identity
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