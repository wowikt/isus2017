using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FEducationCla : Entity<long>
    {
        public FEducationCla()
        {
            FEducationCudMarks = new HashSet<FEducationClaMark>();
        }

        public long PupilId { get; set; }
        public int ActivityId { get; set; }
        public int ProgEptId { get; set; }
        public string CudText { get; set; }

        public SActivity Activity { get; set; }
        public FStudyProgramContent ProgOpt { get; set; }
        public IsusUser Pupil { get; set; }
        public Fact Fact { get; set; }
        public ICollection<FEducationClaMark> FEducationCudMarks { get; set; }
    }
}
