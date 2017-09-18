using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Isus2017Spa.EntityFramework;

namespace Isus2017Spa.Migrator
{
    [DependsOn(typeof(Isus2017SpaDataModule))]
    public class Isus2017SpaMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<Isus2017SpaDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}