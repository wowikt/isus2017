using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore
{
    public static class IsusCoreFullNet2017SpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IsusCoreFullNet2017SpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IsusCoreFullNet2017SpaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}