using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017CoreSpa.MultiTenancy.Dto;

namespace Isus2017CoreSpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
