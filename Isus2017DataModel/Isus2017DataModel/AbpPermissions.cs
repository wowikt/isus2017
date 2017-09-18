using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpPermissions
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsGranted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? RoleId { get; set; }
        public long? UserId { get; set; }
        public string Discriminator { get; set; }
        public int? TenantId { get; set; }

        public AbpRoles Role { get; set; }
        public AbpUsers User { get; set; }
    }
}
