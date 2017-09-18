using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CObjectState
    {
        public CObjectState()
        {
            AObjects = new HashSet<AObject>();
            AObjectsValidation = new HashSet<AObjectValidation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AObject> AObjects { get; set; }
        public ICollection<AObjectValidation> AObjectsValidation { get; set; }
    }
}
