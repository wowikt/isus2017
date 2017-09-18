using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyProgramContent : Entity
    {
        public FStudyProgramContent()
        {
            FEducationCud = new HashSet<FEducationCla>();
        }

        public long FactId { get; set; }
        public int EptId { get; set; }

        public FStudyProgram StudyProgram { get; set; }
        public SEpt Ept { get; set; }
        public ICollection<FEducationCla> FEducationCud { get; set; }
    }
}
