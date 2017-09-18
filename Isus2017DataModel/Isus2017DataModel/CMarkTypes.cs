using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CMarkTypes
    {
        public CMarkTypes()
        {
            FEducationCudMarks = new HashSet<FEducationCudMarks>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMarks>();
            WorkYearsMarkTypes = new HashSet<WorkYearsMarkTypes>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FEducationCudMarks> FEducationCudMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMarks> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<WorkYearsMarkTypes> WorkYearsMarkTypes { get; set; }
    }
}
