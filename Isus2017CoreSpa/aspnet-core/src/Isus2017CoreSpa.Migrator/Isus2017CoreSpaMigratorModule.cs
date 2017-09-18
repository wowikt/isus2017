using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Isus2017CoreSpa.Configuration;
using Isus2017CoreSpa.EntityFrameworkCore;
using Isus2017CoreSpa.Migrator.DependencyInjection;

namespace Isus2017CoreSpa.Migrator
{
    [DependsOn(typeof(Isus2017CoreSpaEntityFrameworkModule))]
    public class Isus2017CoreSpaMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Isus2017CoreSpaMigratorModule(Isus2017CoreSpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Isus2017CoreSpaMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Isus2017CoreSpaConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(Isus2017CoreSpaMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}