using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FEducationCudMarks
    {
        public int Uid { get; set; }
        public int FactId { get; set; }
        public int MarktypeId { get; set; }
        public int MarkValue { get; set; }

        public FEducationCud Fact { get; set; }
        public CMarkTypes Marktype { get; set; }
    }
}
