namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FExpertStudyProgram
    {
        public int Id { get; set; }
        public int ExpertId { get; set; }
        public int ActivityId { get; set; }
        public int Grade { get; set; }
        public bool? IsActual { get; set; }

        public SActivity Activity { get; set; }
        public IsusUser Expert { get; set; }
        public Fact U { get; set; }
    }
}
