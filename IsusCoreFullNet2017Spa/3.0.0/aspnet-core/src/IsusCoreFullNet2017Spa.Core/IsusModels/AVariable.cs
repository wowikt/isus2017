using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AVariable : Entity
    {
        public string Name { get; set; }
        public bool? ValueBit { get; set; }
        public int? ValueInt { get; set; }
        public DateTime? ValueDatetime { get; set; }
        public string ValueStr { get; set; }
        public string ValueXml { get; set; }
        public byte[] ValueBinary { get; set; }
    }
}
