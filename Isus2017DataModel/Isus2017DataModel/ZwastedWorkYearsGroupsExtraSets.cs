using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedWorkYearsGroupsExtraSets
    {
        public ZwastedWorkYearsGroupsExtraSets()
        {
            ZwastedWorkYearsGroupsExtraSetsSources = new HashSet<ZwastedWorkYearsGroupsExtraSetsSources>();
            ZwastedZWorkYearsGroupsExtra = new HashSet<ZwastedZWorkYearsGroupsExtra>();
        }

        public int Uid { get; set; }
        public int WorkYear { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool IsEditable { get; set; }

        public WorkYears WorkYearNavigation { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtraSetsSources> ZwastedWorkYearsGroupsExtraSetsSources { get; set; }
        public ICollection<ZwastedZWorkYearsGroupsExtra> ZwastedZWorkYearsGroupsExtra { get; set; }
    }
}
