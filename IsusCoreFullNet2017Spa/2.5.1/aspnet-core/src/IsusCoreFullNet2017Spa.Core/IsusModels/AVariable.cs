using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AVariable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? ValueBit { get; set; }
        public int? ValueInt { get; set; }
        public DateTime? ValueDatetime { get; set; }
        public string ValueStr { get; set; }
        public string ValueXml { get; set; }
        public byte[] ValueBinary { get; set; }
    }
}
