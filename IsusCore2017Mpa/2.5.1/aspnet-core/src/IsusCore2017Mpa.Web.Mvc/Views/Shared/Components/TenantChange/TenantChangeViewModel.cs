using Abp.AutoMapper;
using IsusCore2017Mpa.Sessions.Dto;

namespace IsusCore2017Mpa.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}