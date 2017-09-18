using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CMarkType
    {
        public CMarkType()
        {
            FEducationCudMarks = new HashSet<FEducationCudMark>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMark>();
            WorkYearsMarkTypes = new HashSet<WorkYearMarkType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FEducationCudMark> FEducationCudMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMark> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<WorkYearMarkType> WorkYearsMarkTypes { get; set; }
    }
}
