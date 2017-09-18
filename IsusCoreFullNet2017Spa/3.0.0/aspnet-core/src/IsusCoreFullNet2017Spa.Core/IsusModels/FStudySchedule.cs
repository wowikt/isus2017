using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudySchedule : Entity<long>
    {
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int ActivityId { get; set; }
        public long? TeacherId { get; set; }
        public int ClassroomId { get; set; }
        public int? BasicGroupId { get; set; }
        public int? ExtraGroupId { get; set; }
        public bool IsExclusive { get; set; }
        public bool? IsCancelled { get; set; }

        public SActivity Activity { get; set; }
        public SClassroom Classroom { get; set; }
        public FGroupExtraItem ExtraGroup { get; set; }
        public IsusUser Teacher { get; set; }
        public Fact Fact { get; set; }
    }
}
