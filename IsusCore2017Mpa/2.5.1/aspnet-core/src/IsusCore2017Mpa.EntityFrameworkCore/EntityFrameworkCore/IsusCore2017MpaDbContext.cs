using Abp.Zero.EntityFrameworkCore;
using IsusCore2017Mpa.Authorization.Roles;
using IsusCore2017Mpa.Authorization.Users;
using IsusCore2017Mpa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace IsusCore2017Mpa.EntityFrameworkCore
{
    public class IsusCore2017MpaDbContext : AbpZeroDbContext<Tenant, Role, User, IsusCore2017MpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public IsusCore2017MpaDbContext(DbContextOptions<IsusCore2017MpaDbContext> options)
            : base(options)
        {

        }
    }
}
