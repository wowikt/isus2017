using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectValidation
    {
        public AObjectValidation()
        {
            AObjectsValidationResults = new HashSet<AObjectValidationResult>();
        }

        public int Id { get; set; }
        public string Session { get; set; }
        public int ObjectId { get; set; }
        public int ObjectStateId { get; set; }
        public bool? IsValid { get; set; }

        public CObjectState ObjectState { get; set; }
        public UserSession SessionNavigation { get; set; }
        public ICollection<AObjectValidationResult> AObjectsValidationResults { get; set; }
    }
}
