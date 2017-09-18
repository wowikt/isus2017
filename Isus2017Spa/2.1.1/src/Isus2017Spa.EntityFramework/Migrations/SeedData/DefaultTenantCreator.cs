using System.Linq;
using Isus2017Spa.EntityFramework;
using Isus2017Spa.MultiTenancy;

namespace Isus2017Spa.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Isus2017SpaDbContext _context;

        public DefaultTenantCreator(Isus2017SpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
