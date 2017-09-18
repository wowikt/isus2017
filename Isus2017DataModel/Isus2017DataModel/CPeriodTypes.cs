using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CPeriodTypes
    {
        public CPeriodTypes()
        {
            FEducationResults = new HashSet<FEducationResults>();
            FStudyPlans = new HashSet<FStudyPlans>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string PeriodGroup { get; set; }
        public int PeriodIndex { get; set; }
        public int PeriodCount { get; set; }

        public ICollection<FEducationResults> FEducationResults { get; set; }
        public ICollection<FStudyPlans> FStudyPlans { get; set; }
    }
}
