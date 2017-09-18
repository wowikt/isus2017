using IsusCoreFullNet2017Mpa.Configuration;
using IsusCoreFullNet2017Mpa.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IsusCoreFullNet2017MpaDbContextFactory : IDbContextFactory<IsusCoreFullNet2017MpaDbContext>
    {
        public IsusCoreFullNet2017MpaDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IsusCoreFullNet2017MpaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IsusCoreFullNet2017MpaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IsusCoreFullNet2017MpaConsts.ConnectionStringName));
            
            return new IsusCoreFullNet2017MpaDbContext(builder.Options);
        }
    }
}