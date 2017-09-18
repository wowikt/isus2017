using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FWorkerTeaching
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ActivityId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

        public SActivity Activity { get; set; }
        public CWorkCategory Category { get; set; }
        public IsusUser Teacher { get; set; }
        public Fact U { get; set; }
    }
}
