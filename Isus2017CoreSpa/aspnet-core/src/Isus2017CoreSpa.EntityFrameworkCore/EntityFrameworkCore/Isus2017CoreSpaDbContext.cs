using Abp.Zero.EntityFrameworkCore;
using Isus2017CoreSpa.Authorization.Roles;
using Isus2017CoreSpa.Authorization.Users;
using Isus2017CoreSpa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Isus2017CoreSpa.EntityFrameworkCore
{
    public class Isus2017CoreSpaDbContext : AbpZeroDbContext<Tenant, Role, User, Isus2017CoreSpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public Isus2017CoreSpaDbContext(DbContextOptions<Isus2017CoreSpaDbContext> options)
            : base(options)
        {

        }
    }
}
