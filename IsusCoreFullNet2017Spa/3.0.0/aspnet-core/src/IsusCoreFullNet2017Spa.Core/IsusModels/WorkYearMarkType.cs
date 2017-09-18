using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearMarkType : Entity
    {
        public WorkYearMarkType()
        {
            WorkYearsMarkTypesValues = new HashSet<WorkYearMarkTypeValue>();
        }

        public int WorkYear { get; set; }
        public int MarkTypeId { get; set; }
        public bool? IsIntegral { get; set; }

        public CMarkType MarkType { get; set; }
        public WorkYearItem WorkYearItemNavigation { get; set; }
        public ICollection<WorkYearMarkTypeValue> WorkYearsMarkTypesValues { get; set; }
    }
}
