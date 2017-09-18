using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpFeatures
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? EditionId { get; set; }
        public int? TenantId { get; set; }
        public string Discriminator { get; set; }

        public AbpEditions Edition { get; set; }
    }
}
