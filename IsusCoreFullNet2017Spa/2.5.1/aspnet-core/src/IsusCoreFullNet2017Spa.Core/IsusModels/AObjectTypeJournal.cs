using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectTypeJournal
    {
        public AObjectTypeJournal()
        {
            AObjectTypes = new HashSet<AObjectType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public short ResetMonth { get; set; }

        public ICollection<AObjectType> AObjectTypes { get; set; }
    }
}
