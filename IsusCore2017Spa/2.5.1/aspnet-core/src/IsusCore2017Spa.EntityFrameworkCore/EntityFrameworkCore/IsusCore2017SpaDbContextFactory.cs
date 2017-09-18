using IsusCore2017Spa.Configuration;
using IsusCore2017Spa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace IsusCore2017Spa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IsusCore2017SpaDbContextFactory : IDbContextFactory<IsusCore2017SpaDbContext>
    {
        public IsusCore2017SpaDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IsusCore2017SpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IsusCore2017SpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IsusCore2017SpaConsts.ConnectionStringName));
            
            return new IsusCore2017SpaDbContext(builder.Options);
        }
    }
}