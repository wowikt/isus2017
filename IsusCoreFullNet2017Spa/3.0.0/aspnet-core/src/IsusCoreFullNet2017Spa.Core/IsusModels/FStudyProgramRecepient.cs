using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyProgramRecepient : Entity
    {
        public long FactId { get; set; }
        public int? BasicGroupId { get; set; }
        public int? ExtraGroupId { get; set; }

        public FGroupExtraItem ExtraGroup { get; set; }
        public FStudyProgram StudyProgram { get; set; }
    }
}
