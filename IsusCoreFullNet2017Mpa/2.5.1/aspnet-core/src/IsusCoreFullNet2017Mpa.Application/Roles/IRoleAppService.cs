using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Mpa.Roles.Dto;

namespace IsusCoreFullNet2017Mpa.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
