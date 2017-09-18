using System;
using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class UserSession
    {
        public UserSession()
        {
            AObjects = new HashSet<AObject>();
            AObjectsValidation = new HashSet<AObjectValidation>();
        }

        public string Session { get; set; }
        public int UserId { get; set; }
        public int ActiveWorkYear { get; set; }
        public DateTime LoginTime { get; set; }

        public IsusUser IsusUser { get; set; }
        public ICollection<AObject> AObjects { get; set; }
        public ICollection<AObjectValidation> AObjectsValidation { get; set; }
    }
}
