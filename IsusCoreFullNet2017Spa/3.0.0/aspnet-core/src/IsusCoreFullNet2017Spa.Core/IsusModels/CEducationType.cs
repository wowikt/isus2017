using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CEducationType : Entity
    {
        public CEducationType()
        {
            FWorkers = new HashSet<FWorker>();
        }

        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorker> FWorkers { get; set; }
    }
}
