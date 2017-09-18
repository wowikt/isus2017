using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCore2017Spa.MultiTenancy.Dto;

namespace IsusCore2017Spa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
