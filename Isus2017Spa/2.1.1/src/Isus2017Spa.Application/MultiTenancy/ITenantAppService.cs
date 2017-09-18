using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017Spa.MultiTenancy.Dto;

namespace Isus2017Spa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
