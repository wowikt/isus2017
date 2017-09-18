using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using IsusCoreFullNet2017Mpa.Configuration;
using IsusCoreFullNet2017Mpa.EntityFrameworkCore;
using IsusCoreFullNet2017Mpa.Migrator.DependencyInjection;

namespace IsusCoreFullNet2017Mpa.Migrator
{
    [DependsOn(typeof(IsusCoreFullNet2017MpaEntityFrameworkModule))]
    public class IsusCoreFullNet2017MpaMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCoreFullNet2017MpaMigratorModule(IsusCoreFullNet2017MpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(IsusCoreFullNet2017MpaMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                IsusCoreFullNet2017MpaConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017MpaMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}