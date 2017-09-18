using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SOrganizations
    {
        public SOrganizations()
        {
            AObjects = new HashSet<AObjects>();
        }

        public int Uid { get; set; }
        public string SpravName { get; set; }
        public string Data { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<AObjects> AObjects { get; set; }
    }
}
