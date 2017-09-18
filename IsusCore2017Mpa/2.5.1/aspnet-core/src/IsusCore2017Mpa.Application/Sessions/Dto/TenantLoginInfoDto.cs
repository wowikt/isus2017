using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using IsusCore2017Mpa.MultiTenancy;

namespace IsusCore2017Mpa.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}