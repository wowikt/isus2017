using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationStudyingMainMark
    {
        public int Id { get; set; }
        public DateTime DtStart { get; set; }
        public int LessonLength { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public bool IsAbsent { get; set; }
        public int? MarkValue { get; set; }
        public string MarkType { get; set; }
        public int TimeLate { get; set; }

        public SActivity Activity { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
    }
}
