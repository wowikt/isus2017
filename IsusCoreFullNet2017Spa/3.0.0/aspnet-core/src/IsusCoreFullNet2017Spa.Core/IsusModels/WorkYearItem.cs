using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearItem
    {
        public WorkYearItem()
        {
            AObjects = new HashSet<AObject>();
            F = new HashSet<Fact>();
            WorkYearsGroupsBasic = new HashSet<WorkYearGroupBasic>();
            WorkYearsMarkTypes = new HashSet<WorkYearMarkType>();
            IsusUsers = new HashSet<IsusUser>();
        }

        public int WorkYear { get; set; }
        public bool? IsActive { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int GradeMin { get; set; }
        public int GradeMax { get; set; }

        public ICollection<AObject> AObjects { get; set; }
        public ICollection<Fact> F { get; set; }
        public ICollection<WorkYearGroupBasic> WorkYearsGroupsBasic { get; set; }
        public ICollection<WorkYearMarkType> WorkYearsMarkTypes { get; set; }
        public ICollection<IsusUser> IsusUsers { get; set; }
    }
}
