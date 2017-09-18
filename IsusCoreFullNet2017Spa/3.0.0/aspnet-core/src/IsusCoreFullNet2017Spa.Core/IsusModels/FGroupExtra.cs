using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtra : Entity<long>
    {
        public FGroupExtra()
        {
            FGroupsExtraItems = new HashSet<FGroupExtraItem>();
            FGroupsExtraSources = new HashSet<FGroupExtraSource>();
        }

        public string Name { get; set; }
        public string Descr { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public Fact Fact { get; set; }
        public ICollection<FGroupExtraItem> FGroupsExtraItems { get; set; }
        public ICollection<FGroupExtraSource> FGroupsExtraSources { get; set; }
    }
}
