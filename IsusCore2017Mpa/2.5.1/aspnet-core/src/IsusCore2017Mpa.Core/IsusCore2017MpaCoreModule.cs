using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using IsusCore2017Mpa.Localization;
using Abp.Zero.Configuration;
using IsusCore2017Mpa.MultiTenancy;
using IsusCore2017Mpa.Authorization.Roles;
using IsusCore2017Mpa.Authorization.Users;
using IsusCore2017Mpa.Configuration;
using IsusCore2017Mpa.Timing;

namespace IsusCore2017Mpa
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class IsusCore2017MpaCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            IsusCore2017MpaLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = IsusCore2017MpaConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCore2017MpaCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}