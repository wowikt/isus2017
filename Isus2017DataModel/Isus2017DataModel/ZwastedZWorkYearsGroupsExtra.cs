using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedZWorkYearsGroupsExtra
    {
        public int Uid { get; set; }
        public int SetId { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool IsDefault { get; set; }

        public ZwastedWorkYearsGroupsExtraSets Set { get; set; }
    }
}
