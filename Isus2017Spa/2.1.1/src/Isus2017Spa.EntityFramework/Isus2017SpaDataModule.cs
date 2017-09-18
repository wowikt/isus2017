using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Isus2017Spa.EntityFramework;

namespace Isus2017Spa
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(Isus2017SpaCoreModule))]
    public class Isus2017SpaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Isus2017SpaDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
