using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationStudyingSpecialMarks
    {
        public int Uid { get; set; }
        public DateTime EduDate { get; set; }
        public int LessonVolume { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public SActivities Activity { get; set; }
        public CMarkTypes Marktype { get; set; }
        public Users Pupil { get; set; }
        public F U { get; set; }
    }
}
