using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyProgram
    {
        public FStudyProgram()
        {
            FStudyProgramsContent = new HashSet<FStudyProgramContent>();
            FStudyProgramsRecepients = new HashSet<FStudyProgramRecepient>();
        }

        public int Id { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public int ActivityId { get; set; }
        public double Volume { get; set; }
        public int EssayCount { get; set; }

        public SActivity Activity { get; set; }
        public Fact U { get; set; }
        public ICollection<FStudyProgramContent> FStudyProgramsContent { get; set; }
        public ICollection<FStudyProgramRecepient> FStudyProgramsRecepients { get; set; }
    }
}
