using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CEducationTypes
    {
        public CEducationTypes()
        {
            FWorkers = new HashSet<FWorkers>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorkers> FWorkers { get; set; }
    }
}
