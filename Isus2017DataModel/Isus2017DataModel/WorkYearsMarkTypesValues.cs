using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class WorkYearsMarkTypesValues
    {
        public int Uid { get; set; }
        public int WorkyearMarktypeId { get; set; }
        public string ValueStr { get; set; }
        public int ValueInt { get; set; }
        public bool? IsDefault { get; set; }

        public WorkYearsMarkTypes WorkyearMarktype { get; set; }
    }
}
