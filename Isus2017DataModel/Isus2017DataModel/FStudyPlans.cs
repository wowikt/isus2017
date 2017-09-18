using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyPlans
    {
        public FStudyPlans()
        {
            FEducationResults = new HashSet<FEducationResults>();
            FStudyPlansContent = new HashSet<FStudyPlansContent>();
            FStudyPlansNagruzka = new HashSet<FStudyPlansNagruzka>();
            FStudyPlansRecepients = new HashSet<FStudyPlansRecepients>();
        }

        public int Uid { get; set; }
        public int? PeriodId { get; set; }
        public DateTime PlanStart { get; set; }
        public DateTime PlanEnd { get; set; }
        public bool ShortWeek { get; set; }
        public int WeekCount { get; set; }
        public int LessonLength { get; set; }

        public CPeriodTypes Period { get; set; }
        public F U { get; set; }
        public ICollection<FEducationResults> FEducationResults { get; set; }
        public ICollection<FStudyPlansContent> FStudyPlansContent { get; set; }
        public ICollection<FStudyPlansNagruzka> FStudyPlansNagruzka { get; set; }
        public ICollection<FStudyPlansRecepients> FStudyPlansRecepients { get; set; }
    }
}
