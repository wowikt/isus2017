using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.MultiTenancy.Dto;

namespace IsusCoreFullNet2017Spa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
