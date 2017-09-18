using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using IsusCore2017Mpa.Configuration;
using IsusCore2017Mpa.EntityFrameworkCore;
using IsusCore2017Mpa.Migrator.DependencyInjection;

namespace IsusCore2017Mpa.Migrator
{
    [DependsOn(typeof(IsusCore2017MpaEntityFrameworkModule))]
    public class IsusCore2017MpaMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCore2017MpaMigratorModule(IsusCore2017MpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(IsusCore2017MpaMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                IsusCore2017MpaConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(IsusCore2017MpaMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}