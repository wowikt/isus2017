using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyProgramsContent
    {
        public FStudyProgramsContent()
        {
            FEducationCud = new HashSet<FEducationCud>();
        }

        public int Uid { get; set; }
        public int FactId { get; set; }
        public int OptId { get; set; }

        public FStudyPrograms Fact { get; set; }
        public SOpt Opt { get; set; }
        public ICollection<FEducationCud> FEducationCud { get; set; }
    }
}
