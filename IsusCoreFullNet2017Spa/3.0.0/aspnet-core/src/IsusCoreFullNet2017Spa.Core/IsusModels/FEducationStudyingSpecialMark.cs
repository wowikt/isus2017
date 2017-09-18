using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationStudyingSpecialMark : Entity<long>
    {
        public DateTime EduDate { get; set; }
        public int LessonVolume { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public SActivity Activity { get; set; }
        public CMarkType Marktype { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact Fact { get; set; }
    }
}
