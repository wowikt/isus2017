using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CMarkType : Entity
    {
        public CMarkType()
        {
            FEducationCudMarks = new HashSet<FEducationClaMark>();
            FEducationStudyingSpecialMarks = new HashSet<FEducationStudyingSpecialMark>();
            WorkYearsMarkTypes = new HashSet<WorkYearMarkType>();
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FEducationClaMark> FEducationCudMarks { get; set; }
        public ICollection<FEducationStudyingSpecialMark> FEducationStudyingSpecialMarks { get; set; }
        public ICollection<WorkYearMarkType> WorkYearsMarkTypes { get; set; }
    }
}
