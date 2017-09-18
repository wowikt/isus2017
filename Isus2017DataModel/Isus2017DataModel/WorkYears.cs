using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class WorkYears
    {
        public WorkYears()
        {
            AObjects = new HashSet<AObjects>();
            F = new HashSet<F>();
            WorkYearsGroupsBasic = new HashSet<WorkYearsGroupsBasic>();
            WorkYearsMarkTypes = new HashSet<WorkYearsMarkTypes>();
            ZwastedWorkYearsGroupsExtra = new HashSet<ZwastedWorkYearsGroupsExtra>();
            ZwastedWorkYearsGroupsExtraSets = new HashSet<ZwastedWorkYearsGroupsExtraSets>();
        }

        public int WorkYear { get; set; }
        public bool? IsActive { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int GradeMin { get; set; }
        public int GradeMax { get; set; }

        public ICollection<AObjects> AObjects { get; set; }
        public ICollection<F> F { get; set; }
        public ICollection<WorkYearsGroupsBasic> WorkYearsGroupsBasic { get; set; }
        public ICollection<WorkYearsMarkTypes> WorkYearsMarkTypes { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtra> ZwastedWorkYearsGroupsExtra { get; set; }
        public ICollection<ZwastedWorkYearsGroupsExtraSets> ZwastedWorkYearsGroupsExtraSets { get; set; }
    }
}
