using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationCud
    {
        public FEducationCud()
        {
            FEducationCudMarks = new HashSet<FEducationCudMarks>();
        }

        public int Uid { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int ProgOptId { get; set; }
        public string CudText { get; set; }

        public SActivities Activity { get; set; }
        public FStudyProgramsContent ProgOpt { get; set; }
        public Users Pupil { get; set; }
        public F U { get; set; }
        public ICollection<FEducationCudMarks> FEducationCudMarks { get; set; }
    }
}
