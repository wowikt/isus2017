using IsusCoreFullNet2017Spa.Configuration;
using IsusCoreFullNet2017Spa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace IsusCoreFullNet2017Spa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IsusCoreFullNet2017SpaDbContextFactory : IDbContextFactory<IsusCoreFullNet2017SpaDbContext>
    {
        public IsusCoreFullNet2017SpaDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IsusCoreFullNet2017SpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IsusCoreFullNet2017SpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IsusCoreFullNet2017SpaConsts.ConnectionStringName));
            
            return new IsusCoreFullNet2017SpaDbContext(builder.Options);
        }
    }
}