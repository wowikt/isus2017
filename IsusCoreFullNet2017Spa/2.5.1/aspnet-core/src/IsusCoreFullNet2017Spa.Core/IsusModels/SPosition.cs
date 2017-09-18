using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SPosition
    {
        public SPosition()
        {
            FWorkers = new HashSet<FWorker>();
        }

        public int Id { get; set; }
        public int Parent { get; set; }
        public int? GroupIndex { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Descr { get; set; }
        public int? StavkaHours { get; set; }
        public bool? IsAbstract { get; set; }
        public bool? IsGos { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<FWorker> FWorkers { get; set; }
    }
}
