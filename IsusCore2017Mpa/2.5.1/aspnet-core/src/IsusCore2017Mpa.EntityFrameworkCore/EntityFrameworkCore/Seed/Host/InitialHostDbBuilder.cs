namespace IsusCore2017Mpa.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly IsusCore2017MpaDbContext _context;

        public InitialHostDbBuilder(IsusCore2017MpaDbContext context)
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
