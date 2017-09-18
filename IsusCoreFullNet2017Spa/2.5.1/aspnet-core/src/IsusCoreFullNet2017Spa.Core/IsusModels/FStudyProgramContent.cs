using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FStudyProgramContent
    {
        public FStudyProgramContent()
        {
            FEducationCud = new HashSet<FEducationCud>();
        }

        public int Id { get; set; }
        public int FactId { get; set; }
        public int OptId { get; set; }

        public FStudyProgram Fact { get; set; }
        public SOpt Opt { get; set; }
        public ICollection<FEducationCud> FEducationCud { get; set; }
    }
}
