using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectsValidationResults
    {
        public int Uid { get; set; }
        public int ValidationId { get; set; }
        public string Category { get; set; }
        public string Descr { get; set; }

        public AObjectsValidation Validation { get; set; }
    }
}
