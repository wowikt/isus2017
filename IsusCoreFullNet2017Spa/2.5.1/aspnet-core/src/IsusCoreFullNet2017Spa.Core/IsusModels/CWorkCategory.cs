using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CWorkCategory
    {
        public CWorkCategory()
        {
            FWorkersTeaching = new HashSet<FWorkerTeaching>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public ICollection<FWorkerTeaching> FWorkersTeaching { get; set; }
    }
}
