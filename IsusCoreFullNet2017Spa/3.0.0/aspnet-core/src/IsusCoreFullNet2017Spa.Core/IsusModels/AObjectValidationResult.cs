using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectValidationResult : Entity
    {
        public int ValidationId { get; set; }
        public string Category { get; set; }
        public string Descr { get; set; }

        public AObjectValidation Validation { get; set; }
    }
}
