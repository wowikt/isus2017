using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class UsersSessions
    {
        public UsersSessions()
        {
            AObjects = new HashSet<AObjects>();
            AObjectsValidation = new HashSet<AObjectsValidation>();
        }

        public string Session { get; set; }
        public int UserId { get; set; }
        public int ActiveWorkYear { get; set; }
        public DateTime LoginTime { get; set; }

        public Users User { get; set; }
        public ICollection<AObjects> AObjects { get; set; }
        public ICollection<AObjectsValidation> AObjectsValidation { get; set; }
    }
}
