using System.Linq;
using IsusCoreFullNet2017Spa.Editions;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed.Tenants
{
    public class NShkolaTenantBuilder
    {
        private readonly IsusCoreFullNet2017SpaDbContext _context;

        public NShkolaTenantBuilder(IsusCoreFullNet2017SpaDbContext context)
        {
            _context = context;
        }

        public Tenant Create()
        {
            return CreateNShkolaTenant();
        }

        private Tenant CreateNShkolaTenant()
        {
            //NShkola tenant

            var nShkolaTenant = _context.Tenants.IgnoreQueryFilters()
                .FirstOrDefault(t => t.TenancyName == Tenant.NShkolaTenancyName);
            if (nShkolaTenant == null)
            {
                nShkolaTenant = new Tenant(Tenant.NShkolaTenancyName, Tenant.NShkolaName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters()
                    .FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    nShkolaTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(nShkolaTenant);
                _context.SaveChanges();
            }

            return nShkolaTenant;
        }
    }
}
