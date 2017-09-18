using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SActivities
    {
        public SActivities()
        {
            FEducationCud = new HashSet<FEducationCud>();
            FEducationResults = new HashSet<FEducationResults>();
            FEducationResultsFinal = new HashSet<FEducationResultsFinal>();
            FEducationStudyingMainMarks = new HashSet<FEducationStudyingMainMarks>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMarks>();
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FExpertsStudyProgram = new HashSet<FExpertsStudyProgram>();
            FStudyJobs = new HashSet<FStudyJobs>();
            FStudyPlansContent = new HashSet<FStudyPlansContent>();
            FStudyPrograms = new HashSet<FStudyPrograms>();
            FStudySchedule = new HashSet<FStudySchedule>();
            FWorkersTeaching = new HashSet<FWorkersTeaching>();
            SOpt = new HashSet<SOpt>();
        }

        public int Uid { get; set; }
        public int Parent { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Descr { get; set; }
        public bool? IsAbstract { get; set; }
        public bool? HasMainMarks { get; set; }
        public int HasSpecialMarks { get; set; }
        public bool? IsDeleted { get; set; }

        public CActivityTypes Type { get; set; }
        public ICollection<FEducationCud> FEducationCud { get; set; }
        public ICollection<FEducationResults> FEducationResults { get; set; }
        public ICollection<FEducationResultsFinal> FEducationResultsFinal { get; set; }
        public ICollection<FEducationStudyingMainMarks> FEducationStudyingMainMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMarks> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FExpertsStudyProgram> FExpertsStudyProgram { get; set; }
        public ICollection<FStudyJobs> FStudyJobs { get; set; }
        public ICollection<FStudyPlansContent> FStudyPlansContent { get; set; }
        public ICollection<FStudyPrograms> FStudyPrograms { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
        public ICollection<FWorkersTeaching> FWorkersTeaching { get; set; }
        public ICollection<SOpt> SOpt { get; set; }
    }
}
