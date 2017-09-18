namespace IsusCoreFullNet2017Spa.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly IsusCoreFullNet2017SpaDbContext _context;

        public InitialHostDbBuilder(IsusCoreFullNet2017SpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
