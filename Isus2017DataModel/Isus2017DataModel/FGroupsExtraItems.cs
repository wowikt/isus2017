using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FGroupsExtraItems
    {
        public FGroupsExtraItems()
        {
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FGroupsExtraSostav = new HashSet<FGroupsExtraSostav>();
            FStudyJobs = new HashSet<FStudyJobs>();
            FStudyProgramsRecepients = new HashSet<FStudyProgramsRecepients>();
            FStudySchedule = new HashSet<FStudySchedule>();
        }

        public int Uid { get; set; }
        public int FactId { get; set; }
        public string Name { get; set; }
        public int? Tag { get; set; }

        public FGroupsExtra Fact { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FGroupsExtraSostav> FGroupsExtraSostav { get; set; }
        public ICollection<FStudyJobs> FStudyJobs { get; set; }
        public ICollection<FStudyProgramsRecepients> FStudyProgramsRecepients { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
    }
}
