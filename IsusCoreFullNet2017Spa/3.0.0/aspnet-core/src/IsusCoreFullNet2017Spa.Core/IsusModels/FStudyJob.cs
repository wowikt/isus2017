using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyJob : Entity<long>
    {
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int ActivityId { get; set; }
        public double Hours { get; set; }
        public int? BasicGroupId { get; set; }
        public int? ExtraGroupId { get; set; }
        public int TeacherId { get; set; }
        public int MetodistId { get; set; }

        public SActivity Activity { get; set; }
        public FGroupExtraItem Extragroup { get; set; }
        public IsusUser Metodist { get; set; }
        public IsusUser Teacher { get; set; }
        public Fact Fact { get; set; }
    }
}
