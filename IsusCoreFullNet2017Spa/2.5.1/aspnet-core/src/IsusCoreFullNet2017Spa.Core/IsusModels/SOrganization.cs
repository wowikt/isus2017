using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SOrganization
    {
        public SOrganization()
        {
            AObjects = new HashSet<AObject>();
        }

        public int Id { get; set; }
        public string SpravName { get; set; }
        public string Data { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<AObject> AObjects { get; set; }
    }
}
