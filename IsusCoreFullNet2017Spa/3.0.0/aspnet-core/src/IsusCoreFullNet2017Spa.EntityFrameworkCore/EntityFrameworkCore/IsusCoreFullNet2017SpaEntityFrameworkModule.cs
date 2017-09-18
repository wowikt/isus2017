using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore
{
    [DependsOn(
        typeof(IsusCoreFullNet2017SpaCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class IsusCoreFullNet2017SpaEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<IsusCoreFullNet2017SpaDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        IsusCoreFullNet2017SpaDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        IsusCoreFullNet2017SpaDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IsusCoreFullNet2017SpaEntityFrameworkModule).GetAssembly());
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