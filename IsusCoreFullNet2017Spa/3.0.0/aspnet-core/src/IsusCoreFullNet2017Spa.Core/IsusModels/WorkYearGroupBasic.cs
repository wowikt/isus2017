using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class WorkYearGroupBasic : Entity
    {
        public WorkYearGroupBasic()
        {
        }

        public int WorkYear { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public int Grade { get; set; }
        public bool IsDeleted { get; set; }

        public WorkYearItem WorkYearItemNavigation { get; set; }
    }
}
