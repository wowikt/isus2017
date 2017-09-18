using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Isus2017CoreSpa.EntityFrameworkCore.Seed;

namespace Isus2017CoreSpa.EntityFrameworkCore
{
    [DependsOn(
        typeof(Isus2017CoreSpaCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Isus2017CoreSpaEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }


        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Isus2017CoreSpaDbContext>(configuration =>
                {
                    Isus2017CoreSpaDbContextConfigurer.Configure(configuration.DbContextOptions, configuration.ConnectionString);
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Isus2017CoreSpaEntityFrameworkModule).GetAssembly());
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