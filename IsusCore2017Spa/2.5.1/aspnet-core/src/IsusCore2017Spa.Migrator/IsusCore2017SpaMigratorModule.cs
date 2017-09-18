using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using IsusCore2017Spa.Configuration;
using IsusCore2017Spa.EntityFrameworkCore;
using IsusCore2017Spa.Migrator.DependencyInjection;

namespace IsusCore2017Spa.Migrator
{
    [DependsOn(typeof(IsusCore2017SpaEntityFrameworkModule))]
    public class IsusCore2017SpaMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCore2017SpaMigratorModule(IsusCore2017SpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(IsusCore2017SpaMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                IsusCore2017SpaConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCore2017SpaMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}