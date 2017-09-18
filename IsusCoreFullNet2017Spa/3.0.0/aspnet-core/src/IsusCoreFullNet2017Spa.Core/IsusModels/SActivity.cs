using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SActivity : Entity
    {
        public SActivity()
        {
            FEducationCud = new HashSet<FEducationCla>();
            FEducationResults = new HashSet<FEducationResult>();
            FEducationResultsFinal = new HashSet<FEducationResultFinal>();
            FEducationStudyingMainMarks = new HashSet<FEducationStudyingMainMark>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMark>();
            FEducationTeaching = new HashSet<FEducationTeaching>();
            FExpertsStudyProgram = new HashSet<FExpertStudyProgram>();
            FStudyJobs = new HashSet<FStudyJob>();
            FStudyPlansContent = new HashSet<FStudyPlanContent>();
            FStudyPrograms = new HashSet<FStudyProgram>();
            FStudySchedule = new HashSet<FStudySchedule>();
            FWorkersTeaching = new HashSet<FWorkerTeaching>();
            SEpt = new HashSet<SEpt>();
        }

        public int Parent { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Descr { get; set; }
        public bool? IsAbstract { get; set; }
        public bool? HasMainMarks { get; set; }
        public int HasSpecialMarks { get; set; }
        public bool? IsDeleted { get; set; }

        public CActivityType Type { get; set; }
        public ICollection<FEducationCla> FEducationCud { get; set; }
        public ICollection<FEducationResult> FEducationResults { get; set; }
        public ICollection<FEducationResultFinal> FEducationResultsFinal { get; set; }
        public ICollection<FEducationStudyingMainMark> FEducationStudyingMainMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMark> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<FEducationTeaching> FEducationTeaching { get; set; }
        public ICollection<FExpertStudyProgram> FExpertsStudyProgram { get; set; }
        public ICollection<FStudyJob> FStudyJobs { get; set; }
        public ICollection<FStudyPlanContent> FStudyPlansContent { get; set; }
        public ICollection<FStudyProgram> FStudyPrograms { get; set; }
        public ICollection<FStudySchedule> FStudySchedule { get; set; }
        public ICollection<FWorkerTeaching> FWorkersTeaching { get; set; }
        public ICollection<SEpt> SEpt { get; set; }
    }
}
