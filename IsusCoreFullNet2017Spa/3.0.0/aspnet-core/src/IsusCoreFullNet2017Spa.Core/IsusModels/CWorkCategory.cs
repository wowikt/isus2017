using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CWorkCategory : Entity
    {
        public CWorkCategory()
        {
            FWorkersTeaching = new HashSet<FWorkerTeaching>();
        }

        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorkerTeaching> FWorkersTeaching { get; set; }
    }
}
