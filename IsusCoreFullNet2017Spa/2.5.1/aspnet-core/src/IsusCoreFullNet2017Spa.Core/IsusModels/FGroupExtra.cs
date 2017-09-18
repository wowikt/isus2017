using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtra
    {
        public FGroupExtra()
        {
            FGroupsExtraItems = new HashSet<FGroupExtraItem>();
            FGroupsExtraSources = new HashSet<FGroupExtraSource>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public Fact U { get; set; }
        public ICollection<FGroupExtraItem> FGroupsExtraItems { get; set; }
        public ICollection<FGroupExtraSource> FGroupsExtraSources { get; set; }
    }
}
