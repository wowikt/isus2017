using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpRoles
    {
        public AbpRoles()
        {
            AbpPermissions = new HashSet<AbpPermissions>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }

        public AbpUsers CreatorUser { get; set; }
        public AbpUsers DeleterUser { get; set; }
        public AbpUsers LastModifierUser { get; set; }
        public ICollection<AbpPermissions> AbpPermissions { get; set; }
    }
}
