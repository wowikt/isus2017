using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectTypesJournals
    {
        public AObjectTypesJournals()
        {
            AObjectTypes = new HashSet<AObjectTypes>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public short ResetMonth { get; set; }

        public ICollection<AObjectTypes> AObjectTypes { get; set; }
    }
}
