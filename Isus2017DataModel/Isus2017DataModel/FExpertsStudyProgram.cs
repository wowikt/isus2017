using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FExpertsStudyProgram
    {
        public int Uid { get; set; }
        public int ExpertId { get; set; }
        public int ActivityId { get; set; }
        public int Grade { get; set; }
        public bool? IsActual { get; set; }

        public SActivities Activity { get; set; }
        public Users Expert { get; set; }
        public F U { get; set; }
    }
}
