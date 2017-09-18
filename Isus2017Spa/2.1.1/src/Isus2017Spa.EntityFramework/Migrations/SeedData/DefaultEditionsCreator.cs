using System.Linq;
using Abp.Application.Editions;
using Isus2017Spa.Editions;
using Isus2017Spa.EntityFramework;

namespace Isus2017Spa.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly Isus2017SpaDbContext _context;

        public DefaultEditionsCreator(Isus2017SpaDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}