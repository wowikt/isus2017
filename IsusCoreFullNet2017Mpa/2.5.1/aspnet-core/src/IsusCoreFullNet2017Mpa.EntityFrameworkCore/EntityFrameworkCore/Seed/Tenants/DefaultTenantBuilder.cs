using System.Linq;
using IsusCoreFullNet2017Mpa.Editions;
using IsusCoreFullNet2017Mpa.MultiTenancy;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly IsusCoreFullNet2017MpaDbContext _context;

        public DefaultTenantBuilder(IsusCoreFullNet2017MpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(Tenant.DefaultTenantName, Tenant.DefaultTenantName);

                var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
