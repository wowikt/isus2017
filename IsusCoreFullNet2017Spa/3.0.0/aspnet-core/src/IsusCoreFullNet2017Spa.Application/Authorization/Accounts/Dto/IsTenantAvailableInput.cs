﻿using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace IsusCoreFullNet2017Spa.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

