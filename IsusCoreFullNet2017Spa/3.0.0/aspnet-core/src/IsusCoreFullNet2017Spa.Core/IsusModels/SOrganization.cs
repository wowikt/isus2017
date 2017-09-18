using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SOrganization : Entity
    {
        public SOrganization()
        {
            AObjects = new HashSet<AObject>();
        }

        public string SpravName { get; set; }
        public string Data { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<AObject> AObjects { get; set; }
    }
}
