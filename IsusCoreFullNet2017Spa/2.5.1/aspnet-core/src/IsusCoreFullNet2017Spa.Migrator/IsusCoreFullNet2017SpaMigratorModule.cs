using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using IsusCoreFullNet2017Spa.Configuration;
using IsusCoreFullNet2017Spa.EntityFrameworkCore;
using IsusCoreFullNet2017Spa.Migrator.DependencyInjection;

namespace IsusCoreFullNet2017Spa.Migrator
{
    [DependsOn(typeof(IsusCoreFullNet2017SpaEntityFrameworkModule))]
    public class IsusCoreFullNet2017SpaMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public IsusCoreFullNet2017SpaMigratorModule(IsusCoreFullNet2017SpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(IsusCoreFullNet2017SpaMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                IsusCoreFullNet2017SpaConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017SpaMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}