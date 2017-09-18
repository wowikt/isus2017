using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ZwastedWorkYearsGroupsExtraItems
    {
        public int Uid { get; set; }
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public ZwastedWorkYearsGroupsExtra Extra { get; set; }
    }
}
