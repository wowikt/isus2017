using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using IsusCoreFullNet2017Mpa.Localization;
using Abp.Zero.Configuration;
using IsusCoreFullNet2017Mpa.MultiTenancy;
using IsusCoreFullNet2017Mpa.Authorization.Roles;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using IsusCoreFullNet2017Mpa.Configuration;
using IsusCoreFullNet2017Mpa.Timing;

namespace IsusCoreFullNet2017Mpa
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class IsusCoreFullNet2017MpaCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            IsusCoreFullNet2017MpaLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = IsusCoreFullNet2017MpaConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017MpaCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}