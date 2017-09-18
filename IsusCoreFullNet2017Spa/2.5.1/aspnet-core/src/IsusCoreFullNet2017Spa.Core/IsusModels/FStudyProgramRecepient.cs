namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyProgramRecepient
    {
        public int Id { get; set; }
        public int FactId { get; set; }
        public int? BasicGroupId { get; set; }
        public int? ExtraGroupId { get; set; }

        public FGroupExtraItem ExtraGroup { get; set; }
        public FStudyProgram Fact { get; set; }
    }
}
