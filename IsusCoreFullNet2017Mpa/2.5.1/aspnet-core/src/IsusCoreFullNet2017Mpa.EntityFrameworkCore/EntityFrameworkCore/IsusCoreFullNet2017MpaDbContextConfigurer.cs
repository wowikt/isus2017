using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore
{
    public static class IsusCoreFullNet2017MpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IsusCoreFullNet2017MpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}