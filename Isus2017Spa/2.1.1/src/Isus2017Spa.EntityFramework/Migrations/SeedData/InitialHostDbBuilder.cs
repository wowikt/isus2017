using Isus2017Spa.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Isus2017Spa.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly Isus2017SpaDbContext _context;

        public InitialHostDbBuilder(Isus2017SpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
