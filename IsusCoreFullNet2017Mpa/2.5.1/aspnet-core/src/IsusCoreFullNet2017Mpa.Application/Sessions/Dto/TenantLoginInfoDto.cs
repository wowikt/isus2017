using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using IsusCoreFullNet2017Mpa.MultiTenancy;

namespace IsusCoreFullNet2017Mpa.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}