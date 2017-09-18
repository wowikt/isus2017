using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CDivisions
    {
        public CDivisions()
        {
            AObjectTypes = new HashSet<AObjectTypes>();
        }

        public int Uid { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }

        public ICollection<AObjectTypes> AObjectTypes { get; set; }
    }
}
