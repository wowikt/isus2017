using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AObjectsEz
    {
        public int Uid { get; set; }
        public int ObjectId { get; set; }
        public DateTime EzDate { get; set; }
        public string EzSigma { get; set; }
        public string EzContent { get; set; }
        public string EzData { get; set; }

        public AObjects Object { get; set; }
    }
}
