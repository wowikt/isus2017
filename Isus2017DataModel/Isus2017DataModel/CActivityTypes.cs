using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CActivityTypes
    {
        public CActivityTypes()
        {
            SActivities = new HashSet<SActivities>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }

        public ICollection<SActivities> SActivities { get; set; }
    }
}
