using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationResultsFinal
    {
        public int Uid { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int Hours { get; set; }
        public int? MarkGod { get; set; }
        public int? MarkExam { get; set; }
        public int? MarkItog { get; set; }

        public SActivities Activity { get; set; }
        public Users Pupil { get; set; }
        public F U { get; set; }
    }
}
