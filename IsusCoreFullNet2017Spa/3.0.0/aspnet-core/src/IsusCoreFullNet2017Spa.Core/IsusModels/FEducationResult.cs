using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationResult : Entity<long>
    {
        public long PupilId { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int Hours { get; set; }
        public int MarkMain { get; set; }
        public long? PlanId { get; set; }

        public SActivity Activity { get; set; }
        public CPeriodType Period { get; set; }
        public FStudyPlan Plan { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact Fact { get; set; }
    }
}
