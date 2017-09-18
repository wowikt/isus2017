using Isus2017CoreSpa.Configuration;
using Isus2017CoreSpa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Isus2017CoreSpa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Isus2017CoreSpaDbContextFactory : IDbContextFactory<Isus2017CoreSpaDbContext>
    {
        public Isus2017CoreSpaDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<Isus2017CoreSpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Isus2017CoreSpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Isus2017CoreSpaConsts.ConnectionStringName));
            
            return new Isus2017CoreSpaDbContext(builder.Options);
        }
    }
}