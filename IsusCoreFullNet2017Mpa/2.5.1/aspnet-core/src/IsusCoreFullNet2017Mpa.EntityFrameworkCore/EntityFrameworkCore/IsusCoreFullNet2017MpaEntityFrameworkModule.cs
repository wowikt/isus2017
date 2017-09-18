using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using IsusCoreFullNet2017Mpa.EntityFrameworkCore.Seed;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore
{
    [DependsOn(
        typeof(IsusCoreFullNet2017MpaCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class IsusCoreFullNet2017MpaEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }


        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<IsusCoreFullNet2017MpaDbContext>(configuration =>
                {
                    IsusCoreFullNet2017MpaDbContextConfigurer.Configure(configuration.DbContextOptions, configuration.ConnectionString);
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017MpaEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}