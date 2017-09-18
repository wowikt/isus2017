using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectTypeJournal : Entity
    {
        public AObjectTypeJournal()
        {
            AObjectTypes = new HashSet<AObjectType>();
        }

        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public short ResetMonth { get; set; }

        public ICollection<AObjectType> AObjectTypes { get; set; }
    }
}
