using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FWorkerTeaching : Entity<long>
    {
        public long TeacherId { get; set; }
        public int ActivityId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public SActivity Activity { get; set; }
        public CWorkCategory Category { get; set; }
        public IsusUser Teacher { get; set; }
        public Fact Fact { get; set; }
    }
}
