using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectValidation : Entity
    {
        public AObjectValidation()
        {
            AObjectsValidationResults = new HashSet<AObjectValidationResult>();
        }

        public string Session { get; set; }
        public int ObjectId { get; set; }
        public int ObjectStateId { get; set; }
        public bool? IsValid { get; set; }

        public CObjectState ObjectState { get; set; }
        public UserSession SessionNavigation { get; set; }
        public ICollection<AObjectValidationResult> AObjectsValidationResults { get; set; }
    }
}
