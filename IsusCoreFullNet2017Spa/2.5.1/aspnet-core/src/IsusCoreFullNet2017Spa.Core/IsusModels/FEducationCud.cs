using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationCud
    {
        public FEducationCud()
        {
            FEducationCudMarks = new HashSet<FEducationCudMark>();
        }

        public int Id { get; set; }
        public int PupilId { get; set; }
        public int ActivityId { get; set; }
        public int ProgOptId { get; set; }
        public string CudText { get; set; }

        public SActivity Activity { get; set; }
        public FStudyProgramContent ProgOpt { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact U { get; set; }
        public ICollection<FEducationCudMark> FEducationCudMarks { get; set; }
    }
}
