using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class CObjectStates
    {
        public CObjectStates()
        {
            AObjects = new HashSet<AObjects>();
            AObjectsValidation = new HashSet<AObjectsValidation>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }

        public ICollection<AObjects> AObjects { get; set; }
        public ICollection<AObjectsValidation> AObjectsValidation { get; set; }
    }
}
