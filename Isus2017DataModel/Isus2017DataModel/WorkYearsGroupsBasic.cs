using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class WorkYearsGroupsBasic
    {
        public WorkYearsGroupsBasic()
        {
            ZwastedWorkYearsGroupsExtraSetsSources = new HashSet<ZwastedWorkYearsGroupsExtraSetsSources>();
        }

        public int Uid { get; set; }
        public int WorkYear { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public int Grade { get; set; }
        public bool IsDeleted { get; set; }

        public WorkYears WorkYearNavigation { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtraSetsSources> ZwastedWorkYearsGroupsExtraSetsSources { get; set; }
    }
}
