using IsusCore2017Mpa.Configuration;
using IsusCore2017Mpa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace IsusCore2017Mpa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IsusCore2017MpaDbContextFactory : IDbContextFactory<IsusCore2017MpaDbContext>
    {
        public IsusCore2017MpaDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IsusCore2017MpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IsusCore2017MpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IsusCore2017MpaConsts.ConnectionStringName));
            
            return new IsusCore2017MpaDbContext(builder.Options);
        }
    }
}