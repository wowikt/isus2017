using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearGroupBasic
    {
        public WorkYearGroupBasic()
        {
        }

        public int Id { get; set; }
        public int WorkYear { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public int Grade { get; set; }
        public bool IsDeleted { get; set; }

        public WorkYearItem WorkYearItemNavigation { get; set; }
    }
}
