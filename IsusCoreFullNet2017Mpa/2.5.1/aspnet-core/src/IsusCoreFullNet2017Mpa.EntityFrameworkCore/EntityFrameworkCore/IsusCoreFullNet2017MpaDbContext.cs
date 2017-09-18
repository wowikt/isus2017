using Abp.Zero.EntityFrameworkCore;
using IsusCoreFullNet2017Mpa.Authorization.Roles;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using IsusCoreFullNet2017Mpa.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore
{
    public class IsusCoreFullNet2017MpaDbContext : AbpZeroDbContext<Tenant, Role, User, IsusCoreFullNet2017MpaDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public IsusCoreFullNet2017MpaDbContext(DbContextOptions<IsusCoreFullNet2017MpaDbContext> options)
            : base(options)
        {

        }
    }
}
