using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtraItem : Entity
    {
        public FGroupExtraItem()
        {
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FGroupsExtraSostav = new HashSet<FGroupExtraSostav>();
            FStudyJobs = new HashSet<FStudyJob>();
            FStudyProgramsRecepients = new HashSet<FStudyProgramRecepient>();
            FStudySchedule = new HashSet<FStudySchedule>();
        }

        public long FactId { get; set; }
        public string Name { get; set; }
        public int? Tag { get; set; }

        public FGroupExtra GroupExtra { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FGroupExtraSostav> FGroupsExtraSostav { get; set; }
        public ICollection<FStudyJob> FStudyJobs { get; set; }
        public ICollection<FStudyProgramRecepient> FStudyProgramsRecepients { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
    }
}
