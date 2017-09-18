using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedWorkYearsGroupsExtraSetsSources
    {
        public int Uid { get; set; }
        public int SetId { get; set; }
        public int BasicgroupId { get; set; }

        public WorkYearsGroupsBasic Basicgroup { get; set; }
        public ZwastedWorkYearsGroupsExtraSets Set { get; set; }
    }
}
