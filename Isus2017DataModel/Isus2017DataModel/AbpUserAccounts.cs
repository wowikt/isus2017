﻿using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpUserAccounts
    {
        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public long? UserLinkId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastLoginTime { get; set; }
    }
}
