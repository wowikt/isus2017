using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FWorker : Entity<long>
    {
        public int WorkerId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int PositionId { get; set; }
        public int WorkTypeId { get; set; }
        public int? EducationId { get; set; }
        public double? StavkaValue { get; set; }
        public double? StavkaNorma { get; set; }
        public bool? IsTeacher { get; set; }

        public CEducationType Education { get; set; }
        public SPosition Position { get; set; }
        public Fact Fact { get; set; }
        public IsusUser Worker { get; set; }
        public CWorkType Worktype { get; set; }
    }
}
