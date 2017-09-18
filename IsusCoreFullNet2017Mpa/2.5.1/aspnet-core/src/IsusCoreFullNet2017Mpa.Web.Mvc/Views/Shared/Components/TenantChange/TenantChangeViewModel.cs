using Abp.AutoMapper;
using IsusCoreFullNet2017Mpa.Sessions.Dto;

namespace IsusCoreFullNet2017Mpa.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}