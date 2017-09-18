using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AVariables
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public bool? ValueBit { get; set; }
        public int? ValueInt { get; set; }
        public DateTime? ValueDatetime { get; set; }
        public string ValueStr { get; set; }
        public string ValueXml { get; set; }
        public byte[] ValueBinary { get; set; }
    }
}
