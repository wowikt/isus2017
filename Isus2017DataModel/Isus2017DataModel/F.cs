using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class F
    {
        public F()
        {
            ATasks = new HashSet<ATasks>();
        }

        public int Uid { get; set; }
        public DateTime Dt { get; set; }
        public int ObjectId { get; set; }
        public int? ObjectIdOut { get; set; }
        public int? WorkYear { get; set; }
        public int? Tag { get; set; }

        public AObjects Object { get; set; }
        public AObjects ObjectIdOutNavigation { get; set; }
        public WorkYears WorkYearNavigation { get; set; }
        public FEducationCud FEducationCud { get; set; }
        public FEducationResults FEducationResults { get; set; }
        public FEducationResultsFinal FEducationResultsFinal { get; set; }
        public FEducationStudyingMainMarks FEducationStudyingMainMarks { get; set; }
        public FEducationStudyingSpecialMarks FEducationStudyingSpecialMarks { get; set; }
        public FEducationTeaching FEducationTeaching { get; set; }
        public FExpertsStudyProgram FExpertsStudyProgram { get; set; }
        public FGroupsBasicSostav FGroupsBasicSostav { get; set; }
        public FGroupsExtra FGroupsExtra { get; set; }
        public FStudyJobs FStudyJobs { get; set; }
        public FStudyPlans FStudyPlans { get; set; }
        public FStudyPrograms FStudyPrograms { get; set; }
        public FStudySchedule FStudySchedule { get; set; }
        public FWorkers FWorkers { get; set; }
        public FWorkersTeaching FWorkersTeaching { get; set; }
        public ICollection<ATasks> ATasks { get; set; }
    }
}
