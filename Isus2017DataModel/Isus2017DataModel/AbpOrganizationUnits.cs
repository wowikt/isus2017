using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpOrganizationUnits
    {
        public AbpOrganizationUnits()
        {
            InverseParent = new HashSet<AbpOrganizationUnits>();
        }

        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long? ParentId { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }

        public AbpOrganizationUnits Parent { get; set; }
        public ICollection<AbpOrganizationUnits> InverseParent { get; set; }
    }
}
