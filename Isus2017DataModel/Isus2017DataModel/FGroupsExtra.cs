using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FGroupsExtra
    {
        public FGroupsExtra()
        {
            FGroupsExtraItems = new HashSet<FGroupsExtraItems>();
            FGroupsExtraSources = new HashSet<FGroupsExtraSources>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public F U { get; set; }
        public ICollection<FGroupsExtraItems> FGroupsExtraItems { get; set; }
        public ICollection<FGroupsExtraSources> FGroupsExtraSources { get; set; }
    }
}
