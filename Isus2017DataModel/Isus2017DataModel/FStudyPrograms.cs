using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyPrograms
    {
        public FStudyPrograms()
        {
            FStudyProgramsContent = new HashSet<FStudyProgramsContent>();
            FStudyProgramsRecepients = new HashSet<FStudyProgramsRecepients>();
        }

        public int Uid { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int ActivityId { get; set; }
        public double Volume { get; set; }
        public int EssayCount { get; set; }

        public SActivities Activity { get; set; }
        public F U { get; set; }
        public ICollection<FStudyProgramsContent> FStudyProgramsContent { get; set; }
        public ICollection<FStudyProgramsRecepients> FStudyProgramsRecepients { get; set; }
    }
}
