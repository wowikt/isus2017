using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CEducationType
    {
        public CEducationType()
        {
            FWorkers = new HashSet<FWorker>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorker> FWorkers { get; set; }
    }
}
