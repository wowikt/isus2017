﻿using IsusCoreFullNet2017Mpa.Authorization;
using IsusCoreFullNet2017Mpa.Authorization.Roles;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using IsusCoreFullNet2017Mpa.Editions;
using IsusCoreFullNet2017Mpa.MultiTenancy;
using Microsoft.Extensions.DependencyInjection;

namespace IsusCoreFullNet2017Mpa.Identity
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
