using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CObjectState : Entity
    {
        public CObjectState()
        {
            AObjects = new HashSet<AObject>();
            AObjectsValidation = new HashSet<AObjectValidation>();
        }

        public string Name { get; set; }

        public ICollection<AObject> AObjects { get; set; }
        public ICollection<AObjectValidation> AObjectsValidation { get; set; }
    }
}
