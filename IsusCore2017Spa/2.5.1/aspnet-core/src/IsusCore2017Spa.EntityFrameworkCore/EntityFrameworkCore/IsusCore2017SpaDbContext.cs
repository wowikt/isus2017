using Abp.Zero.EntityFrameworkCore;
using IsusCore2017Spa.Authorization.Roles;
using IsusCore2017Spa.Authorization.Users;
using IsusCore2017Spa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace IsusCore2017Spa.EntityFrameworkCore
{
    public class IsusCore2017SpaDbContext : AbpZeroDbContext<Tenant, Role, User, IsusCore2017SpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public IsusCore2017SpaDbContext(DbContextOptions<IsusCore2017SpaDbContext> options)
            : base(options)
        {

        }
    }
}
