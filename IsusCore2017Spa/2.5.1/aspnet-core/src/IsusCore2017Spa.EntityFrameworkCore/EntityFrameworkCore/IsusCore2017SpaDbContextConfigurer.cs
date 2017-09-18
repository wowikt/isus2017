using Microsoft.EntityFrameworkCore;

namespace IsusCore2017Spa.EntityFrameworkCore
{
    public static class IsusCore2017SpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IsusCore2017SpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}