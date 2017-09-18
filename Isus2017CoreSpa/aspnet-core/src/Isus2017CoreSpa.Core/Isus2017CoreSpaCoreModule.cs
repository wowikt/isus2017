using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Isus2017CoreSpa.Localization;
using Abp.Zero.Configuration;
using Isus2017CoreSpa.MultiTenancy;
using Isus2017CoreSpa.Authorization.Roles;
using Isus2017CoreSpa.Authorization.Users;
using Isus2017CoreSpa.Configuration;
using Isus2017CoreSpa.Timing;

namespace Isus2017CoreSpa
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Isus2017CoreSpaCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Isus2017CoreSpaLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Isus2017CoreSpaConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Isus2017CoreSpaCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}