using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CPeriodType : Entity
    {
        public CPeriodType()
        {
            FEducationResults = new HashSet<FEducationResult>();
            FStudyPlans = new HashSet<FStudyPlan>();
        }

        public string Name { get; set; }
        public string PeriodGroup { get; set; }
        public int PeriodIndex { get; set; }
        public int PeriodCount { get; set; }

        public ICollection<FEducationResult> FEducationResults { get; set; }
        public ICollection<FStudyPlan> FStudyPlans { get; set; }
    }
}
