using System;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Configuration.Startup;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Abp.Zero.EntityFrameworkCore;
using IsusCoreFullNet2017Spa.EntityFrameworkCore;
using IsusCoreFullNet2017Spa.Tests.DependencyInjection;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace IsusCoreFullNet2017Spa.Tests
{
    [DependsOn(
        typeof(IsusCoreFullNet2017SpaApplicationModule),
        typeof(IsusCoreFullNet2017SpaEntityFrameworkModule),
        typeof(AbpTestBaseModule)
        )]
    public class IsusCoreFullNet2017SpaTestModule : AbpModule
    {
        public IsusCoreFullNet2017SpaTestModule(IsusCoreFullNet2017SpaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        }

        public override void PreInitialize()
        {
            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);

            //Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<AbpZeroDbMigrator<IsusCoreFullNet2017SpaDbContext>>();

            Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }
    }
}