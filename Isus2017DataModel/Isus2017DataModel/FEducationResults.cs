using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationResults
    {
        public int Uid { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int Hours { get; set; }
        public int MarkMain { get; set; }
        public int? PlanId { get; set; }

        public SActivities Activity { get; set; }
        public CPeriodTypes Period { get; set; }
        public FStudyPlans Plan { get; set; }
        public Users Pupil { get; set; }
        public F U { get; set; }
    }
}
