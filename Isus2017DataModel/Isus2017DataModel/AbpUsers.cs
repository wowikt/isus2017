using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class AbpUsers
    {
        public AbpUsers()
        {
            AbpPermissions = new HashSet<AbpPermissions>();
            AbpRolesCreatorUser = new HashSet<AbpRoles>();
            AbpRolesDeleterUser = new HashSet<AbpRoles>();
            AbpRolesLastModifierUser = new HashSet<AbpRoles>();
            AbpSettings = new HashSet<AbpSettings>();
            AbpTenantsCreatorUser = new HashSet<AbpTenants>();
            AbpTenantsDeleterUser = new HashSet<AbpTenants>();
            AbpTenantsLastModifierUser = new HashSet<AbpTenants>();
            AbpUserLogins = new HashSet<AbpUserLogins>();
            AbpUserRoles = new HashSet<AbpUserRoles>();
            InverseCreatorUser = new HashSet<AbpUsers>();
            InverseDeleterUser = new HashSet<AbpUsers>();
            InverseLastModifierUser = new HashSet<AbpUsers>();
        }

        public long Id { get; set; }
        public int? TenantId { get; set; }
        public string AuthenticationSource { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string EmailConfirmationCode { get; set; }
        public string PasswordResetCode { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool IsActive { get; set; }
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
        public ICollection<AbpRoles> AbpRolesCreatorUser { get; set; }
        public ICollection<AbpRoles> AbpRolesDeleterUser { get; set; }
        public ICollection<AbpRoles> AbpRolesLastModifierUser { get; set; }
        public ICollection<AbpSettings> AbpSettings { get; set; }
        public ICollection<AbpTenants> AbpTenantsCreatorUser { get; set; }
        public ICollection<AbpTenants> AbpTenantsDeleterUser { get; set; }
        public ICollection<AbpTenants> AbpTenantsLastModifierUser { get; set; }
        public ICollection<AbpUserLogins> AbpUserLogins { get; set; }
        public ICollection<AbpUserRoles> AbpUserRoles { get; set; }
        public ICollection<AbpUsers> InverseCreatorUser { get; set; }
        public ICollection<AbpUsers> InverseDeleterUser { get; set; }
        public ICollection<AbpUsers> InverseLastModifierUser { get; set; }
    }
}
