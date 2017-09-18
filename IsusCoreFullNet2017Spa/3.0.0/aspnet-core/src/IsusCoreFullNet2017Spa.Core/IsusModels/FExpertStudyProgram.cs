using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FExpertStudyProgram : Entity<long>
    {
        public long ExpertId { get; set; }
        public int ActivityId { get; set; }
        public int Grade { get; set; }
        public bool? IsActual { get; set; }

        public SActivity Activity { get; set; }
        public IsusUser Expert { get; set; }
        public Fact Fact { get; set; }
    }
}
