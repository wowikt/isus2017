namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationResultFinal
    {
        public int Id { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int Hours { get; set; }
        public int? MarkGod { get; set; }
        public int? MarkExam { get; set; }
        public int? MarkItog { get; set; }

        public SActivity Activity { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
    }
}
