using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CWorkCategories
    {
        public CWorkCategories()
        {
            FWorkersTeaching = new HashSet<FWorkersTeaching>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorkersTeaching> FWorkersTeaching { get; set; }
    }
}
