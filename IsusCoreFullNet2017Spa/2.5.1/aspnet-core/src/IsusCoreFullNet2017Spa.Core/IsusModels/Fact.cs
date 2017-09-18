using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class Fact
    {
        public Fact()
        {
            ATasks = new HashSet<ATask>();
        }

        public int Id { get; set; }
        public DateTime Dt { get; set; }
        public int ObjectId { get; set; }
        public int? ObjectIdOut { get; set; }
        public int? WorkYear { get; set; }
        public int? Tag { get; set; }

        public AObject Object { get; set; }
        public AObject ObjectIdOutNavigation { get; set; }
        public WorkYearItem WorkYearItemNavigation { get; set; }
        public FEducationCud FEducationCud { get; set; }
        public FEducationResult FEducationResult { get; set; }
        public FEducationResultFinal FEducationResultFinal { get; set; }
        public FEducationStudyingMainMark FEducationStudyingMainMark { get; set; }
        public FEducationStudyingSpecialMark FEducationStudyingSpecialMark { get; set; }
        public FEducationTeaching FEducationTeaching { get; set; }
        public FExpertStudyProgram FExpertStudyProgram { get; set; }
        public FGroupBasicSostav FGroupBasicSostav { get; set; }
        public FGroupExtra FGroupExtra { get; set; }
        public FStudyJob FStudyJob { get; set; }
        public FStudyPlan FStudyPlan { get; set; }
        public FStudyProgram FStudyProgram { get; set; }
        public FStudySchedule FStudySchedule { get; set; }
        public FWorker FWorker { get; set; }
        public FWorkerTeaching FWorkerTeaching { get; set; }
        public ICollection<ATask> ATasks { get; set; }
    }
}
