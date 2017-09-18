using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationTeaching : Entity<long>
    {
        public DateTime DtStart { get; set; }
        public int LessonLength { get; set; }
        public int ActivityId { get; set; }
        public int? BasicgroupId { get; set; }
        public int? ExtragroupId { get; set; }
        public long TeacherId { get; set; }
        public int Essay { get; set; }
        public string Topic { get; set; }
        public string Homework { get; set; }

        public SActivity Activity { get; set; }
        public FGroupExtraItem Extragroup { get; set; }
        public IsusUser Teacher { get; set; }
        public Fact Fact { get; set; }
    }
}
