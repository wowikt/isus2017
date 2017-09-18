using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Mpa.MultiTenancy.Dto;

namespace IsusCoreFullNet2017Mpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
