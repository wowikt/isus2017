using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationResult
    {
        public int Id { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int Hours { get; set; }
        public int MarkMain { get; set; }
        public int? PlanId { get; set; }

        public SActivity Activity { get; set; }
        public CPeriodType Period { get; set; }
        public FStudyPlan Plan { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
    }
}
