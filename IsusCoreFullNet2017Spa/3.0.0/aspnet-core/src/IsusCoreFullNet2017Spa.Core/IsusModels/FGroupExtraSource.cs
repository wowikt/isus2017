using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class FGroupExtraSource : Entity
    {
        public long FactId { get; set; }
        public int BasicGroupId { get; set; }

        public FGroupExtra GroupExtra { get; set; }
    }
}
