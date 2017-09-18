﻿using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpSettings
    {
        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long? UserId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }

        public AbpUsers User { get; set; }
    }
}
