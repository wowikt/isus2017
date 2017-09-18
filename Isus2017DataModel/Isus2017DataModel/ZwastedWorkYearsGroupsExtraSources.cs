using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedWorkYearsGroupsExtraSources
    {
        public int Uid { get; set; }
        public int ExtraId { get; set; }
        public int BasicId { get; set; }

        public ZwastedWorkYearsGroupsExtra Extra { get; set; }
    }
}
