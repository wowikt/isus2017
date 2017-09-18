using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CDivision
    {
        public CDivision()
        {
            AObjectTypes = new HashSet<AObjectType>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }

        public ICollection<AObjectType> AObjectTypes { get; set; }
    }
}
