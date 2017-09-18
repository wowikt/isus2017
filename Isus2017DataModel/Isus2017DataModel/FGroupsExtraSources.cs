using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FGroupsExtraSources
    {
        public int Uid { get; set; }
        public int FactId { get; set; }
        public int BasicgroupId { get; set; }

        public FGroupsExtra Fact { get; set; }
    }
}
