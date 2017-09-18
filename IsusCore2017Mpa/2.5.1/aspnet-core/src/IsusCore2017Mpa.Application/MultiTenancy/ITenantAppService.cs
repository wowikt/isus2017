using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCore2017Mpa.MultiTenancy.Dto;

namespace IsusCore2017Mpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
