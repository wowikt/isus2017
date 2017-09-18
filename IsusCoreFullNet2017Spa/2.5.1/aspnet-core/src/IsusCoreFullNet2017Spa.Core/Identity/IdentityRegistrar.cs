using IsusCoreFullNet2017Spa.Authorization;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.Editions;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.Extensions.DependencyInjection;

namespace IsusCoreFullNet2017Spa.Identity
{
    public static class IdentityRegistrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddLogging();

            services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddDefaultTokenProviders();
        }
    }
}
