using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.Roles.Dto;

namespace IsusCoreFullNet2017Spa.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
