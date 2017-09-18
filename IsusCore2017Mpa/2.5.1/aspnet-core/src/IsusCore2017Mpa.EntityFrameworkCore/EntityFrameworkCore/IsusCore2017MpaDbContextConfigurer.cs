using Microsoft.EntityFrameworkCore;

namespace IsusCore2017Mpa.EntityFrameworkCore
{
    public static class IsusCore2017MpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IsusCore2017MpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}