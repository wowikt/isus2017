using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedWorkYearsGroupsExtra
    {
        public ZwastedWorkYearsGroupsExtra()
        {
            ZwastedWorkYearsGroupsExtraItems = new HashSet<ZwastedWorkYearsGroupsExtraItems>();
            ZwastedWorkYearsGroupsExtraSources = new HashSet<ZwastedWorkYearsGroupsExtraSources>();
        }

        public int Uid { get; set; }
        public int WorkYear { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool? IsValid { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsLocked { get; set; }

        public WorkYears WorkYearNavigation { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtraItems> ZwastedWorkYearsGroupsExtraItems { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtraSources> ZwastedWorkYearsGroupsExtraSources { get; set; }
    }
}
