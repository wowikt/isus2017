using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Isus2017CoreSpa.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

