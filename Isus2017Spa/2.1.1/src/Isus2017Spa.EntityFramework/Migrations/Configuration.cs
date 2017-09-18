using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Isus2017Spa.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Isus2017Spa.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Isus2017Spa.EntityFramework.Isus2017SpaDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Isus2017Spa";
        }

        protected override void Seed(Isus2017Spa.EntityFramework.Isus2017SpaDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
