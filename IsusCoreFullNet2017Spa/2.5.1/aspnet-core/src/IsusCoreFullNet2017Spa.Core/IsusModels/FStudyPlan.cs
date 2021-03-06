﻿using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyPlan
    {
        public FStudyPlan()
        {
            FEducationResults = new HashSet<FEducationResult>();
            FStudyPlansContent = new HashSet<FStudyPlanContent>();
            FStudyPlansNagruzka = new HashSet<FStudyPlanNagruzka>();
            FStudyPlansRecepients = new HashSet<FStudyPlanRecepient>();
        }

        public int Id { get; set; }
        public int? PeriodId { get; set; }
        public DateTime PlanStart { get; set; }
        public DateTime PlanEnd { get; set; }
        public bool ShortWeek { get; set; }
        public int WeekCount { get; set; }
        public int LessonLength { get; set; }

        public CPeriodType Period { get; set; }
        public Fact U { get; set; }
        public ICollection<FEducationResult> FEducationResults { get; set; }
        public ICollection<FStudyPlanContent> FStudyPlansContent { get; set; }
        public ICollection<FStudyPlanNagruzka> FStudyPlansNagruzka { get; set; }
        public ICollection<FStudyPlanRecepient> FStudyPlansRecepients { get; set; }
    }
}
