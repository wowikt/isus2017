using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationStudyingSpecialMark
    {
        public int Id { get; set; }
        public DateTime EduDate { get; set; }
        public int LessonVolume { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public SActivity Activity { get; set; }
        public CMarkType Marktype { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
    }
}
