using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearMarkType
    {
        public WorkYearMarkType()
        {
            WorkYearsMarkTypesValues = new HashSet<WorkYearMarkTypeValue>();
        }

        public int Id { get; set; }
        public int WorkYear { get; set; }
        public int MarkTypeId { get; set; }
        public bool? IsIntegral { get; set; }

        public CMarkType MarkType { get; set; }
        public WorkYearItem WorkYearItemNavigation { get; set; }
        public ICollection<WorkYearMarkTypeValue> WorkYearsMarkTypesValues { get; set; }
    }
}
