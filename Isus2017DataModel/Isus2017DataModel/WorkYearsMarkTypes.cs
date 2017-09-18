using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class WorkYearsMarkTypes
    {
        public WorkYearsMarkTypes()
        {
            WorkYearsMarkTypesValues = new HashSet<WorkYearsMarkTypesValues>();
        }

        public int Uid { get; set; }
        public int WorkYear { get; set; }
        public int MarktypeId { get; set; }
        public bool? IsIntegral { get; set; }

        public CMarkTypes Marktype { get; set; }
        public WorkYears WorkYearNavigation { get; set; }
        public ICollection<WorkYearsMarkTypesValues> WorkYearsMarkTypesValues { get; set; }
    }
}
