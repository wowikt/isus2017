using Abp.AutoMapper;
using Isus2017Spa.Sessions.Dto;

namespace Isus2017Spa.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}