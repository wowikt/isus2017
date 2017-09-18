using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectsValidation
    {
        public AObjectsValidation()
        {
            AObjectsValidationResults = new HashSet<AObjectsValidationResults>();
        }

        public int Uid { get; set; }
        public string Session { get; set; }
        public int ObjectId { get; set; }
        public int ObjectstateId { get; set; }
        public bool? IsValid { get; set; }

        public CObjectStates Objectstate { get; set; }
        public UsersSessions SessionNavigation { get; set; }
        public ICollection<AObjectsValidationResults> AObjectsValidationResults { get; set; }
    }
}
