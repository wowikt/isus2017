using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationStudyingMainMarks
    {
        public int Uid { get; set; }
        public DateTime DtStart { get; set; }
        public int LessonLength { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public bool IsAbsent { get; set; }
        public int? MarkValue { get; set; }
        public string MarkType { get; set; }
        public int TimeLate { get; set; }

        public SActivities Activity { get; set; }
        public Users Pupil { get; set; }
        public F U { get; set; }
    }
}
