using Microsoft.EntityFrameworkCore;

namespace Isus2017CoreSpa.EntityFrameworkCore
{
    public static class Isus2017CoreSpaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Isus2017CoreSpaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}