using System.Linq;
using IsusCore2017Spa.Editions;
using IsusCore2017Spa.MultiTenancy;

namespace IsusCore2017Spa.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly IsusCore2017SpaDbContext _context;

        public DefaultTenantBuilder(IsusCore2017SpaDbContext context)
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
