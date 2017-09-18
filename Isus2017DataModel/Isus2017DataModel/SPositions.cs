using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SPositions
    {
        public SPositions()
        {
            FWorkers = new HashSet<FWorkers>();
        }

        public int Uid { get; set; }
        public int Parent { get; set; }
        public int? GroupIndex { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Descr { get; set; }
        public int? StavkaHours { get; set; }
        public bool? IsAbstract { get; set; }
        public bool? IsGos { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FWorkers> FWorkers { get; set; }
    }
}
