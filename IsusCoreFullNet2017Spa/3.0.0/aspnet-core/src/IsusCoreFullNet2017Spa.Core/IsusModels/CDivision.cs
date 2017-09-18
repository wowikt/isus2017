using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CDivision : Entity
    {
        public CDivision()
        {
            AObjectTypes = new HashSet<AObjectType>();
        }

        public string Label { get; set; }
        public string Name { get; set; }

        public ICollection<AObjectType> AObjectTypes { get; set; }
    }
}
