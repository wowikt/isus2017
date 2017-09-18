using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Isus2017Spa.MultiTenancy;

namespace Isus2017Spa.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}